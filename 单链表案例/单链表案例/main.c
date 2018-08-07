#include <stdio.h>
#include <stdlib.h>
#define ERROR 1;
#define OK 0;
typedef int ElemType; //data��������
typedef int Status;  //״̬����



typedef struct Node
{
	ElemType data;
	struct Node *next;
}Node, *LinkList;

Status InitList(LinkList *L);
Status GetMidNode(LinkList L, ElemType *e); //e����Ҫ�����
Status AddListHead(LinkList *L,ElemType e); //ͷ�巨
Status AddListTail(LinkList *R,ElemType e); //β�巨
Status DeleteList(LinkList L, int Index); //Index��0��ʼ����
Status ClearList(LinkList *L);
Status PrintList(LinkList L);


Status main(void)
{
	int i;
	LinkList List,R;
	InitList(&List);
	R = List;
	for (i = 0; i < 20; i++)
	{
		AddListTail(&R, rand() % 100 + 1);
	}
	PrintList(List);
	GetMidNode(List, &i);
	printf("%d\n", i);
	DeleteList(List, 9);
	PrintList(List);
	GetMidNode(List, &i);
	printf("%d\n", i);
	ClearList(&List);
	getchar();
	return OK;
}

Status InitList(LinkList *L)
{
	(*L) = (LinkList)malloc(sizeof(Node)); //����ͷ�ڵ�
	if ((*L) == NULL)
	{
		return ERROR;
	}
	(*L)->next = NULL;
}

Status GetMidNode(LinkList L, ElemType * e)
{
	LinkList Search, Mid;
	Mid = Search = L;
	while (Search->next != NULL)
	{
		if (Search->next->next != NULL)
		{
			Search = Search->next->next;
			Mid = Mid->next;
		}
		else
		{
			Search = Search->next;
		}
	}
	*e = Mid->data;
	return OK;
}

Status AddListHead(LinkList *L, ElemType e)
{
	LinkList New;
	New = (LinkList)malloc(sizeof(Node));
	if (New == NULL)
	{
		return ERROR;
	}
	New->data = e;
	New->next = (*L)->next;
	(*L)->next = New;
	return OK;
}

Status AddListTail(LinkList *R, ElemType e)
{
	LinkList New;
	New = (LinkList)malloc(sizeof(Node));
	if (New == NULL)
	{
		return ERROR;
	}
	New->data = e;
	New->next = NULL;
	(*R)->next = New;
	*R = New;
}

Status DeleteList(LinkList L, int Index)
{
	if (Index < 0)
	{
		return ERROR;
	}
	LinkList list = L->next; //��һ��Ԫ��
	int i;
	for (i = 0; i < Index; i++)
	{
		L = L->next; //�����list����һ��Ԫ��
		list = list->next; //������һ��
	}
	L->next = list->next;
	free(list);
	return OK;
}

Status ClearList(LinkList * L)
{
	LinkList BackOut;
	while ((*L)->next!=NULL)
	{
		BackOut = (*L);
		(*L) = (*L)->next;
		free(BackOut);
	}
	free(*L);
	return OK;
}

Status PrintList(LinkList L)
{
	L = L->next;
	while (L != NULL)
	{
		printf("%d ", L->data);
		L = L->next;
	}
	putchar('\n');
	return OK;
}

