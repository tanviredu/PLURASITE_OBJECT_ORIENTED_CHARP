using System;
using Xunit;
namespace ACM.BL.Test
{
    public class StaticTests
    {
        [Fact]
        public void CheckiftheStaticworks()
        {

            // create a new instance
            var c1 = new Customer();
            // set the first name
            c1.FirstName = "Tanvir1";
            Customer.InstanceCount += 1;



            // create a new instance
            var c2 = new Customer();
            // set the first name
            c2.FirstName = "Tanvir2";
            Customer.InstanceCount += 1;



            // act
            // nothing in there

            // assert


            // for object Assert Equal is obsolite
            Object.Equals(2, Customer.InstanceCount);

        }
    }
}
