using System;
using Xunit;

using LinkedList.Classes;

namespace ll_kth_from_end_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            int answer = KthFromEnd(test, 8);
        }
    }
}
