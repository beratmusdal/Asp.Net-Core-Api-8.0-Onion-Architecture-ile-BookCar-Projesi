using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                BrandID = command.BrandID,
                Luggage = command.Luggage,
                Transmission = command.Transmission,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Fuel = command.Fuel,
                CoverImageUrl = command.CoverImageUrl,
            });
        }
    }
}
