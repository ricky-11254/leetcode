using System;
using System.Collections.Generic;
namespace MyNameSpace{
	public class ListNode {
	    public int val;
	    public ListNode next;
	    public ListNode(int val = 0, ListNode next = null) {
		this.val = val;
		this.next = next;
	    }
	}

	public class Solution {
	    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode dummyHead = new ListNode(0);
		ListNode current = dummyHead;
		int carry = 0;

		while (l1 != null || l2 != null) {
		    int x = l1 != null ? l1.val : 0;
		    int y = l2 != null ? l2.val : 0;
		    int sum = carry + x + y;
		    carry = sum / 10;
		    current.next = new ListNode(sum % 10);
		    current = current.next;
		    if (l1 != null) l1 = l1.next;
		    if (l2 != null) l2 = l2.next;
		}

		if (carry > 0) {
		    current.next = new ListNode(carry);
		}

		return dummyHead.next;
	    }
	}
}
