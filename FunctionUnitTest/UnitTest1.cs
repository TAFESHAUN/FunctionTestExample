

namespace FunctionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculators salCacl = new Calculators();

        //HOW MANY TEST METHODS DO WE NEED
        [TestMethod]
        public void ManagerSalaryTest()
        {
            //Arrange
            decimal baseSalary = 100000;
            string choice = "manager";
            decimal expectedSalary = 120000;

            //Act
            decimal actualSalary = salCacl.CalculateSalary(baseSalary,choice);

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);

        }

        //[TestMethod]
        [TestMethod]
        public void DeveloperSalaryTest()
        {
            //Arrange
            decimal baseSalary = 100000;
            string choice = "developer";
            decimal expectedSalary = 110000;

            //Act
            decimal actualSalary = salCacl.CalculateSalary(baseSalary,choice);

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);

        }

        [TestMethod]
        public void SalesPersonSalaryTest()
        {
            //Arrange
            decimal baseSalary = 100000;
            string choice = "salesperson";
            decimal expectedSalary = 115000;

            //Act
            decimal actualSalary = salCacl.CalculateSalary(baseSalary,choice);

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void DefaultSalaryTest()
        {
            //Arrange
            decimal baseSalary = 100000;
            string choice = "default";
            decimal expectedSalary = 100000;

            //Act
            decimal actualSalary = salCacl.CalculateSalary(baseSalary,choice);

            //Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }

    }
}