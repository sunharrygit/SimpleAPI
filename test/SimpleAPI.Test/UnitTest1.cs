using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {


        }

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Les Harry", returnValue.Value);
        }
    }
}
