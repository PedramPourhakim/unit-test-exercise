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
            Assert.NotNull(A3());
            Assert.NotEqual(false,A3());
        }   
        [Fact] 
        public void Test3()
        {
            Assert.NotNull(A3());
        }
        public bool A3()
        {
            return true;
        }
    }
}
