namespace Calculators
{
    public class SalaryCalculator
    {
        //FULLTIME
        const int hoursInAYear = 2080;
        //TIME vs hardcode -> LEAP YEAR
        //PARTTIME?
        //PER PERSON

        public decimal GetAnnualSalary(decimal hourlyWage) =>  hourlyWage*hoursInAYear;

        public decimal GetHourlyWage(decimal annualSalary) => annualSalary/hoursInAYear;


        //public decimal GetAnnualSalary(decimal hourlyWage)
        //{
        //    decimal annualSalary = hourlyWage * hoursInAYear;
        //    return annualSalary;
        //}

        //public decimal GetHourlyWage(decimal annualSalary)
        //{
        //    return annualSalary / hoursInAYear;
        //}
    }
}
