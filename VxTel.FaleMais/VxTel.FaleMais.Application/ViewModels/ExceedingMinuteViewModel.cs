using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Application.ViewModels
{
    public class ExceedingMinuteViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int OriginId { get; set; }

        public AreaCode Origin { get; set; }

        public int DestinyId { get; set; }

        public AreaCode Destiny { get; set; }

        public int MinutePriceId { get; set; }

        public Rate MinutePrice { get; set; }

        public decimal AmountPayable { get; set; }

        public decimal AmountPayableWithPlan { get; set; }

        public int TimeInMinutes { get; set; }

        public string PlanDescription { get; set; }
    }
}