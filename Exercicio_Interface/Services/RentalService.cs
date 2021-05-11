using Exercicio_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService; //Serviço de imposto

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {   //Calculo da duração do aluguel do carro 
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {   //Calculo do valor do aluguel por horas (até 12 horas)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //arredondamento para cima (Math.Ceiling)
            }
            else
            {
                //Calculo do valor do aluguel por dia (acima de 12 horas)
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            /*Calculo do serviço de imposto*/
            double tax = _taxService.Tax(basicPayment);

            /*Instanciando o invoice e associar com o carRental*/
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
