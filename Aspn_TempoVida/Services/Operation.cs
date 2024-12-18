﻿namespace Aspn_TempoVida.Services;

public class Operation : IOperationTransient, 
    IOperationScoped,
    IOperationSingleton
{
    public Operation()
    {
        OperationId = Guid.NewGuid().ToString();
    }
    public string OperationId { get; }
}