using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage ="Enter a monthly investment")]
        [Range(1,500, ErrorMessage ="Please enter a monthly investment between 1 & 500")]
        public decimal? MonthlyInvestment { get;set; }

        [Required(ErrorMessage ="Enter a yearly interest rate")]
        [Range(1.0,10.0, ErrorMessage ="Yealy rate must be between 1 & 10")]
        public decimal? YearlyInterestRate { get;set; }

        [Required(ErrorMessage ="Please enter a number of years")]
        [Range(1,50, ErrorMessage ="Enter years")]
        public int? Years { get; set; }

        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureVal = 0;

            for (int i = 0; i < months; i++)
            {
                futureVal = (futureVal + MonthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureVal;
        }

    }
}
