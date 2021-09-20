using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodeNote.API.SeedWork
{
    public class BaseAPIController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public BaseAPIController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            
        }

        public Task<TResponse> SendQuery<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            return _mediator.Send(request, cancellationToken);
        }

        public Task<TResponse> SendCommand<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            
            return _mediator.Send(request, cancellationToken);
        }


    }
}
