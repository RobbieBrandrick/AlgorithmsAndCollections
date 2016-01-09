using Xunit;

namespace Collections.Tests
{
    public class NodeTests
    {

        [Fact]
        public void ValueMustBeStored()
        {
            var value1 = 7;
            var node1 = new Node<int>() { Value = value1 };

            Assert.Equal(value1, node1.Value);

            var value2 = "test";
            var node2 = new Node<string>() { Value = value2 };

            Assert.Equal(value2, node2.Value);
        }

        [Fact]
        public void NextMustBeSet()
        {
            var value1 = 7;
            var value2 = 33;
            var node1 = new Node<int>() { Value = value1 };
            var node2 = new Node<int>() { Value = value2 };

            node1.Next = node2;

            Assert.Equal(node2, node1.Next);

        }

    }
}

//Watch usings. Did not need to include system
//Watch auto initializer. Did no include semi colon
//Watch generics. Did not include generic parameter in NOde classes;
//M is decimal and d is double
//Node was not contiguous 