using LeetCodeProblems;
using LeetCodeProblems.Array101;
using LeetCodeProblems.LinkedList;

Problem13 problem = new Problem13();

problem.RomanToInt("MCMXIV");

MaxConsecutiveOnes max = new MaxConsecutiveOnes();

int[] nums = new int[11] { 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1 };

max.FindMax(nums);

FindNumbersWithEvenNumberOfDigits find = new FindNumbersWithEvenNumberOfDigits();

int[] nums2 = new int[] { 12, 345, 2, 6, 7896 };

find.FindNumbers(nums2);
find.FindNumbersWithLinq(nums2);

SquaresOfASortedArray squares = new SquaresOfASortedArray();

int[] nums3 = new int[] { -4, -1, 0, 3, 10 };

var ads = squares.SortedSquares(nums3);

DuplicateZeros duplicateZeros = new DuplicateZeros();

//int[] nums4 = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
//int[] nums4 = new int[] { 8, 5, 0, 9, 0, 3, 4, 7 };
//int[] nums4 = new int[] { 0, 1, 7, 6, 0, 2, 0, 7 };
int[] nums4 = new int[] { 0, 0, 0, 0, 0, 0, 0 };

duplicateZeros.DupeZeros(nums4);

MyLinkedList list = new MyLinkedList();
list.AddAtHead(2);
list.DeleteAtIndex(1);
;
list.Get(0);
;

ReverseLinkedList reverse = new ReverseLinkedList();
//ListNode head = new ListNode();
//ListNode first = new ListNode();
//ListNode second = new ListNode();
//ListNode third = new ListNode();
//ListNode fourth = new ListNode();
//head.val = 1;
//head.next = first;

//first.val = 2;
//first.next = second;

//second.val = 3;
//second.next = third;

//third.val = 4;
//third.next = fourth;

//fourth.val = 5;

//reverse.ReverseList(head);

RemoveLinkedListElements removeLinkedListElements = new RemoveLinkedListElements();

ListNode head = new ListNode();
ListNode first = new ListNode();
ListNode second = new ListNode();
ListNode third = new ListNode();
ListNode fourth = new ListNode();
ListNode fifth = new ListNode();
ListNode sixth = new ListNode();
head.val = 1;
head.next = first;

first.val = 2;
first.next = second;

second.val = 6;
second.next = third;

third.val = 3;
third.next = fourth;

fourth.val = 4;
fourth.next = fifth;

fifth.val = 5;
fifth.next = sixth;

sixth.val = 6;

removeLinkedListElements.RemoveElements(head, 6);
;