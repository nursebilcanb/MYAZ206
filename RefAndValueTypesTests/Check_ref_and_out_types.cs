using System;
using ValueAndReferenceTypes;
using Xunit;

namespace RefAndValueTypesTests
{
    public class Check_ref_and_out_types
    {
        [Fact]
        public void SwapByValueTest()
        {
            //Arrange
            var valueType = new ValueAndReferenceTypes.ValueType();
            int a = 23, b = 55;

            //Act
            valueType.SwapByValue(a,b);

            //Assert
            Assert.Equal(23,a);
            Assert.Equal(55,b);
        }

        [Fact]
        public void SwapByRefTest()
        {
            //Arrange
            var refType = new ValueAndReferenceTypes.ReferenceType();
            int a = 23, b = 55;

            //Act
            refType.SwapByRef(ref a, ref b);

            //Assert
            Assert.Equal(55,a);
            Assert.Equal(23,b);
        }
    }
}
