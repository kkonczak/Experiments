namespace IndexOfLibrary.UnitTests
{
    public class UnitTest1
    {
        private readonly int[] Elements = new[] { 1, 5, 33, 434, 2, 7, 8, 4, 67767 };
        private const int SearchingValue = 33;
        private readonly int CorrectIndex;

        public UnitTest1()
        {
            CorrectIndex = Array.IndexOf(Elements, SearchingValue);
        }

        [Fact]
        public void ForEachIndexOf_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForEachIndexOf(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOf_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOf(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithCompare_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithCompare(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithSpan_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithSpan(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithSpanAndOneLengthCalling_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithSpanAndOneLengthCalling(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithMemory_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithMemory(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithPointer_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithPointer(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithPointerAndDecrement_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithPointerAndDecrement(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);

        }

        [Fact]
        public void ForIndexOfWithPointerAndBinaryOperator_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithPointerAndBinaryOperator(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);
        }

        [Fact]
        public void FForIndexOfWithSseAndOneLengthCalling_Should_ReturnCorrectResult()
        {
            // Act
            var result = IndexOfLibrary.ForIndexOfWithSseAndOneLengthCalling(Elements, SearchingValue);

            // Assert
            Assert.Equal(CorrectIndex, result);
        }
    }
}