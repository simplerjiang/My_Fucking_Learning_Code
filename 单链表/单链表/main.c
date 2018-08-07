#include <stdio.h>
#include <stdlib.h>
typedef struct Node
{
	int data;
	struct Node *next;
}Node, *p, *LinkList;


void InitList(LinkList * head) //��ʼ������
{
	*head = (LinkList *)malloc(sizeof(Node));
	(*head)->next = NULL;
}

void AddList(LinkList * head, int data) //ͷ�巨,ʱ��������ÿ����Ӷ���O(1)
{
	LinkList p;
	p = (LinkList)malloc(sizeof(Node));
	p->data = data;
	p->next = (*head)->next;
	(*head)->next = p;
}

void AddListTail(LinkList *head, int data) //β�巨����ʱ��������ÿ����Ӷ���O(n)
{
	LinkList p,a;
	a = *head;
	p = (LinkList)malloc(sizeof(Node));
	p->data = data;
	while (a->next != NULL)
	{
		a = a->next;
	}
	a->next = p;
	p->next = NULL;
}

LinkList GetListByIndex(LinkList head, int index) //����indexֵ����Linklist��index��0��ͷ�����򷵻�NULL
{
	LinkList p;
	int i;
	p = head->next;
	for (i = 0; i < index && p != NULL; i++)
	{
		p = p->next;
	}
	return p;

}

LinkList GetListByData(LinkList head, int data) //�������ݷ���LinkList�����򷵻�NULL
{
	LinkList p, n;
	p = head->next;
	while (p->next != NULL || p->data == data)
	{
		p = p->next;
	}
	if (p->data == data)
	{
		return p;
	}
	else
	{
		return NULL;
	}
}

void ClearList(LinkList *head)
{
	LinkList p;
	while ((*head)->next != NULL)
	{
		p = (*head)->next;
		free(*head);
		(*head) = p;
	}
	free(*head);
	(*head) = NULL;
}

int main(void)
{
	int i;
	LinkList head,lkEmpty;
	InitList(&head);
	for (i = 0; i < 10; i++)
	{
		AddListTail(&head, i);
	}
	for (i = 0; i < 10; i++)
	{
		lkEmpty = GetListByIndex(head, i);
		printf("%d", lkEmpty->data);
	}
	lkEmpty = GetListByIndex(head, 5);
	printf("%d", lkEmpty->data);
	ClearList(&head);
	getchar();
	return 0;
}



