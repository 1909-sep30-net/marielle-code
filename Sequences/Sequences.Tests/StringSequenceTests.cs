using Sequences.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sequences.Tests
{
    public class StringSequenceTests
    {
        [Theory]
        [InlineData("abc")]
        [InlineData ("")]
        [InlineData(null)]
        public void AddShouldAdd(string item)
        {
            var seq = new StringSequence();
            seq.Add(item);
            Assert.Equal(expected: item,actual: seq[0]);
        }

        [Fact]
        public void AddshouldAddInConsistentOrder()
        {
            var seq = new StringSequence();
            seq.Add("abc");
            seq.Add("def");
            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);
        }

        [Fact]
        public void AccessOutOfBoundsShouldThrow()
        {
            var seq = new StringSequence();
            var x = seq[0];
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => { var x = seq[0]; });
        }
        [Fact]

        public void ShortestShouldReturnShortestString()
        {
            var seq = new StringSequence();
            seq.Add("a");
            seq.Add("b");
            seq.Add("c");
            Assert.Equal("a", seq.Shortest(seq));
        }
    }
}
