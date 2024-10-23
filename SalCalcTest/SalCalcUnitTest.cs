using Calculators;

namespace SalCalcTest
{
    /// <summary>
    /// To get hourly, divide annual salary by 2080
    /// $100,006.40 / 2080 = $48.08 hr
    /// To get annual, multiply hourly by 2080
    /// $48.08 * 2080 = $100,006.40
    /// </summary>
    [TestClass]
    public class SalCalcUnitTest
    {
        //Arrange - Class Scope Test Data, Class Refs & Objects
        SalaryCalculator salCalc = new SalaryCalculator();

        //[Setup]

        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arrange
            //Arrange objects and set the values that are needed to run - Expected
            //SalaryCalculator salCalc = new SalaryCalculator();
            decimal expectedAnnualSalary = 104000;

            //Access Act
            //Invoke our method or functionality on our objects - Actual
            //Add breakpoint in MSTestTools for step into logic
            decimal actualAnnualSalary = salCalc.GetAnnualSalary(50); //50

            //Assert
            //Check the values we got back are expected
            // we assert by  verifying the actions of these methods behaved
            // as expected.
            //(Expected Value, Actual Value)
            Assert.AreEqual(expectedAnnualSalary, actualAnnualSalary);


        }

        [TestMethod]
        public void HourlyWageTest()
        {
            //Arrange
            //SalaryCalculator salCalc = new SalaryCalculator();
            decimal expectedHourlyWage = 25;
            decimal expectedAnnualSalary = salCalc.GetAnnualSalary(expectedHourlyWage); //HARD CODE OR FUNCTION IS CORRECT

            //Act
            decimal actualHourlyWage = salCalc.GetHourlyWage(expectedAnnualSalary);

            //Assert
            Assert.AreEqual(expectedHourlyWage, actualHourlyWage);
        }
    }
}