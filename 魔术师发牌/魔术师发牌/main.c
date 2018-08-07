#include <stdio.h>
#include <stdlib.h>

#define ERROR 1
#define OK 0

typedef int ElemTpye;
typedef int Status;

typedef struct Node
{
	ElemTpye data;
	struct Node *next;
}Node, *LinkList;

Status InitList(LinkList *list); //����13���յ�dataѭ���б�
Status IntoList(LinkList list); //������
Status PrintList(LinkList list); // ����Ŀǰ����
Status SendList(LinkList *list); // ����
Status ListLength(LinkList *list);


Status main(void)
{
	LinkList list = NULL;
	InitList(&list);
	if (IntoList(&list) == ERROR) printf("����\n");
	PrintList(list);
	getchar();
	return OK;
}

Status PrintList(LinkList list)
{
	LinkList Target = list;
	printf("��ʼ��ӡ��");
	do
	{
		printf("%d  ",Target->data);
		Target = Target->next;
	} while (Target != list);
	putchar('\n');
	return OK;
}

Status InitList(LinkList *list)
{
	int i;
	LinkList New;
	(*list) = (LinkList)malloc(sizeof(Node));
	(*list)->data = NULL;
	(*list)->next = (*list);
	for (i = 0; i < 12; i++)
	{
		New = (LinkList)malloc(sizeof(Node));
		New->next = (*list)->next; //ͷ�巨
		(*list)->next = New;
		New->data = NULL;
	}
	return OK;
}
Status IntoList(LinkList *list)
{
	LinkList p = (*list);
	int i, j,k; //i���ڼ���Ŀǰ����������,j���ڼǲ���
	i = 1;
	j = 0;
	while (1)
	{
		if (i == 1)
		{
			p->data = i;
			i++;
			continue;
		}
		for (k = 0; k < i;)
		{
			p = p->next;
			if (p->data == NULL)
			{
				k++;
			}
		}
		if (p->data != NULL) return ERROR;
		p->data = i;
		if (i == 13)
		{
			break;
		}
		i++;
	}
	return OK;
}


