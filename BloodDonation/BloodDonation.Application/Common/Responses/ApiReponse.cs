namespace BloodDonation.Application.Common.Responses
{
    /// <summary>
    /// Standard API response wrapper for returning consistent results across the application.
    /// </summary>
    /// <typeparam name="T">Type of the data being returned.</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Data returned in case of success.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Error message returned in case of failure.
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// Optional user-friendly message (Success or Failure description).
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Optional list of validation or business errors.
        /// </summary>
        public List<string>? Errors { get; set; }

        /// <summary>
        /// Creates a successful response.
        /// </summary>
        /// <param name="data">The data payload.</param>
        /// <param name="message">Optional success message.</param>
        /// <returns>A successful ApiResponse.</returns>
        public static ApiResponse<T> SuccessResponse(T data, string? message = null)
        {
            return new ApiResponse<T>
            {
                Data = data,
                Success = true,
                Message = message
            };
        }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="error">Single error message.</param>
        /// <param name="message">Optional error message.</param>
        /// <returns>An error ApiResponse.</returns>
        public static ApiResponse<T> ErrorResponse(string error, string? message = null)
        {
            return new ApiResponse<T>
            {
                Error = error,
                Success = false,
                Message = message
            };
        }

        /// <summary>
        /// Creates an error response with multiple error messages (for validation errors, etc.).
        /// </summary>
        /// <param name="errors">List of error messages.</param>
        /// <param name="message">Optional error message.</param>
        /// <returns>An error ApiResponse.</returns>
        public static ApiResponse<T> ErrorResponse(List<string> errors, string? message = null)
        {
            return new ApiResponse<T>
            {
                Errors = errors,
                Success = false,
                Message = message
            };
        }
    }
}
