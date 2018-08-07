#include <stdlib.h>
#include <stdio.h>

typedef struct Node
{
	char data;
	struct Node *prior;
	struct Node *next;
}Node, *LinkList;

char ABC[] = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
void InitList(LinkList *list);
void NextList(LinkList *list, int num);
void UpList(LinkList *list, int num);
void PrintListDouble(LinkList list);
void main(void)
{
	LinkList list;
	InitList(&list);
	PrintListDouble(list);
	UpList(&list, 5);
	PrintListDouble(list);
	NextList(&list, 10);
	PrintListDouble(list);
	getchar();
}

void NextList(LinkList *list, int num)
{
	int i;
	for ( i = 0; i < num; i++)
	{
		(*list) = (*list)->next;
	}
}

void UpList(LinkList *list, int num)
{
	int i;
	for ( i = 0; i < num; i++)
	{
		(*list) = (*list)->prior;
	}
}

void PrintListDouble(LinkList list)
{
	LinkList Target = list;
	printf("正循环:");
	do
	{
		printf("%c  ", Target->data);
		Target = Target->next;
	} while (Target != list);
	putchar('\n');
	printf("反循环:");
	Target = Target->prior;
	list = list->prior;
	do
	{


		printf("%c  ", Target->data);
		Target = Target->prior;
	} while (Target != list);
	putchar('\n');


}

void InitList(LinkList *list)
{
	int i = 1;
	LinkList New;
	(*list) = (LinkList)malloc(sizeof(Node));
	(*list)->data = ABC[0];
	(*list)->next = (*list);
	(*list)->prior = (*list);
	while (i < 26)
	{ //尾插法,(*list)暂时充当尾部
		New = (LinkList)malloc(sizeof(Node));
		New->data = ABC[i];
		New->next = (*list)->next;
		(*list)->next->prior = New;
		(*list)->next = New;
		New->prior = (*list);
		(*list) = New;
		i++;
	}
	(*list) = (*list)->next; //跳回头节点
}