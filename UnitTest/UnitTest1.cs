using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Playground
{
    [TestClass]
    public class SortAlgorithmTest
    {
        // IsSorted Method Test
        [TestMethod]
        public void IsSorted_ArrayIsSorted_ReturnTrue()
        {
            // Setup
            var sortAlgorithm = new SortAlgorithm();
            var bacon = new string[] { "A", "B", "C", "D" };

            // Operate
            var result = sortAlgorithm.IsSorted(bacon);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSorted_ArrayIsNotSorted_ReturnFalse()
        {
            // Setup
            var sortAlgorithm = new SortAlgorithm();
            var bacon = new string[] { "B", "A", "D", "C" };

            // Operate
            var result = sortAlgorithm.IsSorted(bacon);

            // Assert
            Assert.IsFalse(result);
        }


        // Compare Method Test
        [TestMethod]
        public void Compare_XLessThanY_ReturnTrue()
        {
            var sortAlgorithm = new SortAlgorithm();
            var bacon = new string[] { "A", "B" };

            var result = sortAlgorithm.Compare(bacon[0], bacon[1]);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Compare_XLessThanY_ReturnFalse()
        {
            var sortAlgorithm = new SortAlgorithm();
            var bacon = new string[] { "B", "A" };

            var result = sortAlgorithm.Compare(bacon[0], bacon[1]);

            Assert.IsFalse(result);
        }

        
        // Exchange Method Test
        [TestMethod]
        public void Exchange_ReturnTrue()
        {
            var sortAlgorithm = new SortAlgorithm();
            var bacon = new string[] { "B", "A" };

            sortAlgorithm.Exchange(bacon, 0, 1);

            Assert.IsTrue(bacon[0] == "A");
            Assert.IsTrue(bacon[1] == "B");
        }
    }
}
