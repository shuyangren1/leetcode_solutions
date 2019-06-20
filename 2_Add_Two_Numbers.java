// Leetcode problem # 2, Add Two Numbers


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode root = new ListNode(0);
        ListNode current = root;
        int remainder = 0;
        while (l1 != null && l2 != null){
            ListNode r2 = new ListNode(l1.val + l2.val + remainder);
            remainder = checkRemainder(r2);
            current.next = r2;
            current = current.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 != null){
            l2 = l1;
        }
        while (l2 != null){
            ListNode r2 = new ListNode(l2.val + remainder);
            remainder = checkRemainder(r2);
            current.next = r2;
            current = current.next;
            l2 = l2.next;
        }
        if (remainder == 1){
            ListNode r2 = new ListNode(1);
            current.next = r2;
        }
        return root.next;
    }
    
    public int checkRemainder(ListNode l){
        if (l.val >= 10){
            l.val -= 10;
            return 1;
        }
        return 0;
    }
}