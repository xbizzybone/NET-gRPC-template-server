global using FluentValidation;
global using FluentValidation.Results;
global using Grpc.Core;
global using Grpc.AspNetCore.Server;
global using Grpc.Core.Interceptors;
global using MemoryPack;
global using Serilog;
global using System.Text;
global using System.Text.Json;

global using gRPC.template.server.Extensions;
global using gRPC.template.server.Filters;
global using gRPC.template.server.Filters.Domain;
global using gRPC.template.server.Filters.Internal;
global using gRPC.template.server.Services;
global using gRPC.template.server.Validators;

global using gRPC.template.shared.logger;