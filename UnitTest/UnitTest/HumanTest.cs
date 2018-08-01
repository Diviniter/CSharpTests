using ClassLibrary;
using NFluent;
using NSubstitute;
using System;
using Xunit;

namespace UnitTest
{
    public class HumanTest
    {
        [Fact]
        public void Should_WriteSentence_When_HumanSaySentence()
        {
            //Init
            var outputWriter = Substitute.For<OutputWriter>();
            var human = new Human(outputWriter);

            //Action
            human.Say("hello");

            //Check
            outputWriter.Received().Write("hello");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Should_ThrowArgumentException_When_HumanSayNothing(string invalidHumanSentence)
        {
            //Init
            var outputWriter = Substitute.For<OutputWriter>();
            var human = new Human(outputWriter);

            //Action
            Action action = () => human.Say(invalidHumanSentence);

            //Check
            Check.ThatCode(action).Throws<ArgumentException>().WithMessage("The message can't be empty");
        }
    }
}
