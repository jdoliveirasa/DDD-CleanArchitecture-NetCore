using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VxTel.FaleMais.Domain.Entities
{
    public class ExceedingMinute
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public int OriginId { get; set; }

        [ForeignKey("OriginId")]
        public AreaCode Origin { get; set; }

        public int DestinyId { get; set; }

        [ForeignKey("DestinyId")]
        public AreaCode Destiny { get; set; }

        public int MinutePriceId { get; set; }

        public Rate MinutePrice { get; set; }

        [NotMapped]
        public decimal AmountPayable { get; set; }

        [NotMapped]
        public decimal AmountPayableWithPlan { get; set; }

        [NotMapped]
        public int TimeInMinutes { get; set; }

        [NotMapped]
        public string PlanDescription { get; set; }

        public ExceedingMinute()
        {

        }

        public void CalculateValueCall(int timeInMinutes, Plan plan)
        {
            this.TimeInMinutes = timeInMinutes;
            this.PlanDescription = plan.Description;

            this.AmountPayable = (timeInMinutes * this.MinutePrice.Price);

            var exceedingMinutes = timeInMinutes - plan.Minutes;
            if (exceedingMinutes > 0)
            {
                var amountPayable = (exceedingMinutes * this.MinutePrice.Price);
                this.AmountPayableWithPlan = (amountPayable / 10) + amountPayable;
            }
            else
            {
                this.AmountPayableWithPlan = 0;
            }
        }
    }
}