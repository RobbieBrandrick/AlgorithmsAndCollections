using Collections.LinkedList;
using Xunit;

namespace Collections.Tests.LinkedList
{
    public class LinkedListTests
    {

        public class PushBack
        {
            [Fact]
            public void IntsMustBePushedToTheBack()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushBack(1);
                Assert.Equal(1, sut.Back());

                sut.PushBack(2);
                Assert.Equal(2, sut.Back());

                sut.PushBack(3);
                Assert.Equal(3, sut.Back());

            }

            [Fact]
            public void StringsMustBePushedToTheBack()
            {

                LinkedList<string> sut = new LinkedList<string>();

                sut.PushBack("1");
                Assert.Equal("1", sut.Back());

                sut.PushBack("2");
                Assert.Equal("2", sut.Back());

                sut.PushBack("3");
                Assert.Equal("3", sut.Back());

            }
        }

        public class PushFront
        {
            [Fact]
            public void IntsMustBePushedToTheFront()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushFront(1);
                Assert.Equal(1, sut.Front());

                sut.PushFront(2);
                Assert.Equal(2, sut.Front());

                sut.PushFront(3);
                Assert.Equal(3, sut.Front());

            }

            [Fact]
            public void StringsMustBePushedToTheFront()
            {

                LinkedList<string> sut = new LinkedList<string>();

                sut.PushFront("1");
                Assert.Equal("1", sut.Front());

                sut.PushFront("2");
                Assert.Equal("2", sut.Front());

                sut.PushFront("3");
                Assert.Equal("3", sut.Front());

            }
        }

        public class RemoveFront
        {
            [Fact]
           public void MustRemoveFromFrontLinkedList()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushBack(1);
                Assert.Equal(1, sut.Back());
                Assert.Equal(1, sut.Front());

                sut.PushFront(2);
                Assert.Equal(1, sut.Back());
                Assert.Equal(2, sut.Front());

                sut.PushBack(3);
                Assert.Equal(3, sut.Back());
                Assert.Equal(2, sut.Front());

                sut.RemoveFront();
                Assert.Equal(3, sut.Back());
                Assert.Equal(1, sut.Front());
            }
        }

        [Fact]
        public void MustPushBackAndPushFront()
        {

            LinkedList<int> sut = new LinkedList<int>();

            sut.PushBack(1);
            Assert.Equal(1, sut.Back());
            Assert.Equal(1, sut.Front());

            sut.PushFront(2);
            Assert.Equal(1, sut.Back());
            Assert.Equal(2, sut.Front());

            sut.PushBack(3);
            Assert.Equal(3, sut.Back());
            Assert.Equal(2, sut.Front());

        }

    }
}
