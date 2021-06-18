using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharpCore.Test
{
    // "1" => 1: OK
    // "1,2" => 3: OK
    // "1, 2\n3" => 6: OK
    // "" => 0: OK
    // "//;\n1;2,3\n4" => 10
    public class StringCalculatorTest
    {
        [Fact]
        public void EmptyStringShouldReturnZero()
        {
            Add("").Should().Be(0);
        }

        [Fact]
        public void SingleNumberReturnsInputNumber()
        {
            Add("1").Should().Be(1);
        }

        [Fact]
        public void TwoNumbersAreSummedUp()
        {
            Add("1,2").Should().Be(3);
        }

        [Fact]
        public void MultipleNumbersAreSummedUpWithDefaultDelimiters()
        {
            Add("1, 2\n3").Should().Be(6);
        }

        [Fact]
        public void MultipleNumbersAreSummedUpWithAdditionalDelimiters()
        {
            Add("//;\n1;2,3\n4").Should().Be(10);
        }

        private int Add(string input)
        {
            var delimiters = new List<char> { ',', '\n' };

            if (HasDelimiter(input))
            {
                delimiters.Add(input[2]);
            }

            return input
                .Split(delimiters.ToArray())
                .Sum(ParseNumber);
        }

        private bool HasDelimiter(string input)
        {
            return input.StartsWith("//");
        }

        private int ParseNumber(string number)
        {
            return int.TryParse(number, out var result) ? result : 0;
        }
    }
}