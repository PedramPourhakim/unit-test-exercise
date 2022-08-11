using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class UnitTest2
    {
        [Theory]
        [MemberData(nameof(Users))]
        public void Add(WebApplication1.Models.
            Person person)
        {
            Assert.True(UnitTest1.A6(person));
        }
        public static TheoryData<WebApplication1.Models.
            Person> Users()
        {
                var data = new TheoryData<WebApplication1.Models.
            Person>(); 
                WebApplication1.Models.
            Person person1 = new WebApplication1.Models.Person()
            {
                FirstName = "Pedram",
                LastName = "Pourhakim",
                Age = 23
            };
                data.Add(person1);
                return data;
            }
        }

          
    }
