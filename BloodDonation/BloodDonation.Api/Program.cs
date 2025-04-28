using BloodDonation.Api.Common.Extensions.Application;
using BloodDonation.Api.Common.Extensions.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPresentationServices();

var app = builder.Build();

app.UsePresentationServices();
