using System;
using WebApplication1.Controllers;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        //private readonly TestController testController;
        //public UnitTest1(TestController testController)
        //{
        //    this.testController = testController;   
        //}
        [Fact] 
        public void Test1()
        {
            Assert.True(A3());
        } 
        [Fact] 
        public void Test2()
        {
            int id = 10;
            Assert.NotEqual(0,A4(id));
        }   
        [Fact] 
        public void Test3()
        {
            Assert.NotNull(A5());
        }   
        [Theory] 
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void Test4(int id)
        {
            Assert.NotEqual(0,A4(id));
        }
        public bool A3()
        {
            return true;
        }
        public int A4(int id)
        {
            return 1;
        }
        public string A5()
        {
            return "Hello World";
        }

        public double sum(double d1, double d2) => d1 + d2;

        [Theory]
        [InlineData(6,8)]
        [InlineData(9,1)]
        [InlineData(10,23)]
        [InlineData(43,14)]
        public void TestSum(double p1,double p2)
        {
            Assert.Equal((p1 + p2), sum(p1, p2));
        }
        public static bool A6(WebApplication1.Models.Person person)
        {
            return true;
        }

    }
}
