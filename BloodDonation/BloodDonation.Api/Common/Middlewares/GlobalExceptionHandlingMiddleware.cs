
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BloodDonation.Api.Common.Middlewares
{
    /// <summary>
    /// Middleware for handling unhandled exceptions globally in the application. 
    /// It intercepts exceptions during request processing, logs relevant error details, 
    /// and returns a standardized error response using the <see cref="ProblemDetails"/> format.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="GlobalExceptionHandling"/> middleware.
    /// </remarks>
    /// <param name="next">The next delegate in the request pipeline.</param>
    public class GlobalExceptionHandlingMiddleware(RequestDelegate next)
    {
        private readonly RequestDelegate _next = next ?? throw new ArgumentNullException(nameof(next));

        /// <summary>
        /// Middleware invocation method that handles exceptions occurring during request processing.
        /// If an exception is thrown, it constructs a structured error response with relevant details.
        /// </summary>
        /// <param name="context">The HTTP context of the current request.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Proceed with the next middleware in the pipeline.
                await _next(context);
            }
            catch (Exception ex)
            {
                // Handle unhandled exceptions and respond with a structured error message.
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// Handles exceptions by constructing a structured error response using <see cref="ProblemDetails"/>.
        /// </summary>
        /// <param name="context">The HTTP context of the request.</param>
        /// <param name="exception">The caught exception.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        private async static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Set the response status code to Internal Server Error (500).
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // Create an instance of ProblemDetails to structure the error information.
            ProblemDetails problemDetails = new()
            {
                // The HTTP status code indicating that an internal server error occurred.
                Status = (int)HttpStatusCode.InternalServerError,

                // A brief, human-readable title for the error.
                Title = exception.Message,

                // A detailed description of the error to help the client understand the issue.
                Detail = "An internal server error has occurred. Please try again later.",

                // A URI that provides further details about the error type (e.g., HTTP status code).
                Type = "https://httpstatuses.com/500", // URI for the status code definition.

                // The URI of the request path that caused the error, helping with debugging.
                Instance = context.Request.Path,

                // Additional custom information about the error, which may be useful for tracing and debugging.
                Extensions =
                {
                    // TraceId is a unique identifier for the request, useful for tracking the flow of the request.
                    { "traceId", context.TraceIdentifier },

                    // The timestamp in UTC when the error occurred.
                    { "timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ") }, // Timestamp of the error.
                }
            };

            // Write the ProblemDetails object as a JSON response, which is returned to the client.
            await context.Response.WriteAsJsonAsync(problemDetails);
        }
    }
}
