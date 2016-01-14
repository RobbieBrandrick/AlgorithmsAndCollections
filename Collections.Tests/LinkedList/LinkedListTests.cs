using Collections.LinkedList;
using System;
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
                Assert.Equal(1, sut.Count);

                sut.PushFront(2);
                Assert.Equal(1, sut.Back());
                Assert.Equal(2, sut.Front());
                Assert.Equal(2, sut.Count);

                sut.PushBack(3);
                Assert.Equal(3, sut.Back());
                Assert.Equal(2, sut.Front());
                Assert.Equal(3, sut.Count);

                sut.RemoveFront();
                Assert.Equal(3, sut.Back());
                Assert.Equal(1, sut.Front());
                Assert.Equal(2, sut.Count);
            }

            [Fact]
            public void MustRemoveFromFrontkWhenOnlyOneItemIsInList()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushBack(1);
                Assert.Equal(1, sut.Back());
                Assert.Equal(1, sut.Front());
                Assert.Equal(1, sut.Count);

                sut.RemoveFront();
                Assert.Equal(0, sut.Count);
                Assert.Throws<InvalidOperationException>(() => sut.Front());
                Assert.Throws<InvalidOperationException>(() => sut.Back());

            }

            [Fact]
            public void MustThrowWhenNoElementsExist()
            {
                var sut = new LinkedList<bool>();

                var exception = Assert.Throws<InvalidOperationException>(() => sut.RemoveFront());
                Assert.Equal("There are no elements to remove", exception.Message);
            }
        }

        public class RemoveBack
        {
            [Fact]
            public void MustRemoveFromBack()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushBack(1);
                Assert.Equal(1, sut.Back());
                Assert.Equal(1, sut.Front());
                Assert.Equal(1, sut.Count);

                sut.PushFront(2);
                Assert.Equal(1, sut.Back());
                Assert.Equal(2, sut.Front());
                Assert.Equal(2, sut.Count);

                sut.PushBack(3);
                Assert.Equal(3, sut.Back());
                Assert.Equal(2, sut.Front());
                Assert.Equal(3, sut.Count);

                sut.RemoveBack();
                Assert.Equal(1, sut.Back());
                Assert.Equal(2, sut.Front());
                Assert.Equal(2, sut.Count);

            }

            [Fact]
            public void MustRemoveFromBackWhenOnlyOneItemIsInList()
            {

                LinkedList<int> sut = new LinkedList<int>();

                sut.PushBack(1);
                Assert.Equal(1, sut.Back());
                Assert.Equal(1, sut.Front());
                Assert.Equal(1, sut.Count);

                sut.RemoveBack();
                Assert.Equal(0, sut.Count);
                Assert.Throws<InvalidOperationException>(() => sut.Front());
                Assert.Throws<InvalidOperationException>(() => sut.Back());

            }

            [Fact]
            public void MustThrowWhenNoElementsExist()
            {
                var sut = new LinkedList<bool>();

                var exception = Assert.Throws<InvalidOperationException>(() => sut.RemoveBack());
                Assert.Equal("There are no elements to remove", exception.Message);
            }
        }

        public class Count
        {
            [Fact]
            public void MustIncrementCountForEveryPush()
            {

                var sut = new LinkedList<string>();
                var expectedCount = 100;

                for (int i = 0; i < expectedCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        sut.PushFront("foo");
                    }
                    else
                    {
                        sut.PushBack("bar");
                    }
                }

                Assert.Equal(expectedCount, sut.Count);

            }
        }

        [Fact]
        public void MustPushBackAndPushFront()
        {

            LinkedList<int> sut = new LinkedList<int>();

            sut.PushBack(1);
            Assert.Equal(1, sut.Back());
            Assert.Equal(1, sut.Front());
            Assert.Equal(1, sut.Count);

            sut.PushFront(2);
            Assert.Equal(1, sut.Back());
            Assert.Equal(2, sut.Front());
            Assert.Equal(2, sut.Count);

            sut.PushBack(3);
            Assert.Equal(3, sut.Back());
            Assert.Equal(2, sut.Front());
            Assert.Equal(3, sut.Count);

        }

    }
}
