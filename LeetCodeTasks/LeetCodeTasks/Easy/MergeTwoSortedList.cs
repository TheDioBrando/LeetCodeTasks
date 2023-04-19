﻿namespace LeetCodeTasks.Easy
{
    public class SolutionMergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;

            ListNode head;
            if (list1.val < list2.val)
            {
                head = list1;
                list1 = list1.next;
            }
            else
            {
                head = list2;
                list2 = list2.next;
            }

            var temp = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                    temp = temp.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                    temp = temp.next;
                }
            }
            if (list1 != null)
                temp.next = list1;
            else if (list2 != null)
                temp.next = list2;
            return head;
        }
    }
}
