#include <stdio.h>
#include <stdlib.h>

typedef struct Node
{
	int data;
	struct Node *next;
}Node, *LinkList;

void InitList(LinkList *list,int num);
void PrintListAsBlock(LinkList list, int num);

void main(void)
{
	int num;
	LinkList list;
	printf("请输入n:");
	scanf_s("%d", &num);
	InitList(&list, num);
	PrintListAsBlock(list, num);
	getchar();
	getchar();
}

void InitList(LinkList *list, int num)
{
	int i;
	LinkList New;
	(*list) = (LinkList)malloc(sizeof(Node));
	(*list)->data = 1;
	(*list)->next = (*list);

	for (i = 2; i <= num; i++)
	{ //尾插法,(*list)这里先做尾巴
		New = (LinkList)malloc(sizeof(Node));
		New->data = i;
		New->next = (*list)->next;
		(*list)->next = New;
		(*list) = New;
	}
	//最后弄完以后 (*list)就是指向尾巴)
	//这里再跳一个回到头部
	(*list) = (*list)->next;
}

void  PrintListAsBlock(LinkList list, int num)
{
	LinkList Flag;
	while (num)
	{
		Flag = list;
		do
		{
			printf("%d ", list->data);
			list = list->next;
		} while (Flag != list);
		list = list->next;
		num--;
		putchar('\n');
	}
}