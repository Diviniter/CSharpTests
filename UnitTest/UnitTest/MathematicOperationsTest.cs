using ClassLibrary;
using NFluent;
using Xunit;

namespace UnitTest
{
    public class MathematicOperationsTest
    {
        [Fact]
        public void Should_AdditionNumber()
        {
            //Init
            var one = 1;
            var two = 2;
            var three = 3;

            //Action
            var result = MathematicOperations.Addition(one, two);

            //Check
            Check.That(result).IsEqualTo(three);
        }
    }
}
