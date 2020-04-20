using System;
using Xunit;
namespace ACM.BL.Test
{
    public class validateTest
    {
        [Fact]
        public void ValidateFalseTest(){
                // this is  a test function

                var customer = new Customer{
                    // set only Email address
                    EmailAddess = "ornobtanvir.git@gmail.com"
                };

                var expected = false;

                // find the actual

                var actual = customer.validate();


                // assert

                Assert.Equal(expected,actual);
        }

        [Fact]
        public void validateTrueTest(){


                var customer2 = new Customer{
                    // set only Email address
                    EmailAddess = "ornobtanvir.git@gmail.com",
                    LastName = "Tanvir"
                };

                var expected2 = true;

                // find the actual

                var actual2 = customer2.validate();


                // assert

                Assert.Equal(expected2,actual2);
        }




        }

    }
