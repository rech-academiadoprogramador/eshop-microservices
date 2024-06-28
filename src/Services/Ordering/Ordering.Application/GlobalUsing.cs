﻿global using BuildingBlocks.CQRS;
global using BuildingBlocks.Behaviors;
global using BuildingBlocks.Pagination;


global using Ordering.Application.Data;
global using Ordering.Application.Dtos;
global using Ordering.Application.Exceptions;
global using Ordering.Application.Extensions;

global using Ordering.Domain.Events;
global using Ordering.Domain.Models;
global using Ordering.Domain.ValueObjects;

global using FluentValidation;
global using MediatR;

global using System.Reflection;

global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.EntityFrameworkCore;

global using MassTransit;

global using BuildingBlocks.Messaging.Events;