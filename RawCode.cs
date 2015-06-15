using System;
using NUnit.Framework;

namespace StringCalculatorTest
{
    class HighlyDivisibleTriangularNumber
    {
        public int FindSumOfFirstFiveDivisors(int limit)
        {
            int number = 0;
            int i = 1;

            while (NumberOfDivisors(number) < limit)
            {
                number += i;
                i++;
            }

            return number;
        }

        public int NumberOfDivisors(int limit)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(limit);

            for (int i = 1; i <= sqrt; i++)
            {
                if (limit % i == 0)
                {
                    nod += 2;
                }
            }
            //Correction if the number is a perfect square
            if (sqrt * sqrt == limit)
            {
                nod--;
            }

            return nod;
        }
    }

    [TestFixture]
    class HighlyDivisibleTriangularNumberTest
    {
        [Test]
        public void ShouldFindSumOfFirstFiveDivisors()
        {
            //arrange
            var DivTriNumber = new HighlyDivisibleTriangularNumber();
            
            //act
            var result = DivTriNumber.FindSumOfFirstFiveDivisors(501);
            
            //assert
            Assert.That(result, Is.EqualTo(76576500));
        }

        //[Test]
        //public void ShouldFindNumberOfDivisors()
        //{
        //    //arrange
        //    var DivTriNumber = new HighlyDivisibleTriangularNumber();
            
        //    //act
        //    var result = DivTriNumber.NumberOfDivisors(501);
            
        //    //assert
        //    Assert.That(result, Is.EqualTo(28));
        //}
    }
}
