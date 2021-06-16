using NUnit.Framework;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.UnitTestDefault
{
    public class NUnitTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(20, "FaleMais 30 (30 minutos)", 30, 1.90, 0.00, 38.00)]
        [TestCase(80, "FaleMais 60 (60 minutos)", 60, 1.70, 37.40, 136.00)]
        [TestCase(200, "FaleMais 120 (120 minutos)", 120, 1.90, 167.20, 380.00)]
        public void CalculaValorDaChamada_TempoEmMinutos_ResultadoIgual(int inTimeInMinutes, string inPlanDescription, int inPlanMinutes,
            decimal inMinutePrice, decimal outAmountPayableWithPlan, decimal outAmountPayable)
        {
            Plan plan = new Plan();
            plan.Description = inPlanDescription;
            plan.Minutes = inPlanMinutes;

            Rate rate = new Rate();
            rate.Price = inMinutePrice;
            ExceedingMinute exceedingMinute = new ExceedingMinute();

            exceedingMinute.MinutePrice = rate;
            exceedingMinute.CalculateValueCall(inTimeInMinutes, plan);

            Assert.AreEqual(exceedingMinute.AmountPayableWithPlan, outAmountPayableWithPlan);
            Assert.AreEqual(exceedingMinute.AmountPayable, outAmountPayable);
        }

        [Test]
        [TestCase(120, "FaleMais 30 (30 minutos)", 30, 1.90, 0.00, 38.00)]
        [TestCase(97, "FaleMais 60 (60 minutos)", 60, 1.70, 37.40, 136.00)]
        [TestCase(170, "FaleMais 120 (120 minutos)", 120, 1.90, 167.20, 380.00)]
        public void CalculaValorDaChamada_TempoEmMinutos_ResultadoNaoIgual(int inTimeInMinutes, string inPlanDescription, int inPlanMinutes,
            decimal inMinutePrice, decimal outAmountPayableWithPlan, decimal outAmountPayable)
        {
            Plan plan = new Plan();
            plan.Description = inPlanDescription;
            plan.Minutes = inPlanMinutes;

            Rate rate = new Rate();
            rate.Price = inMinutePrice;
            ExceedingMinute exceedingMinute = new ExceedingMinute();

            exceedingMinute.MinutePrice = rate;
            exceedingMinute.CalculateValueCall(inTimeInMinutes, plan);

            Assert.AreNotEqual(exceedingMinute.AmountPayableWithPlan, outAmountPayableWithPlan);
            Assert.AreNotEqual(exceedingMinute.AmountPayable, outAmountPayable);
        }
    }
}