﻿namespace Application.Contracts.Driving.SignalR.Dtos;

public record SendMessageRequest
{
    public required Guid ConversationId { get; init; }
    
    public required string Message { get; init; }
}