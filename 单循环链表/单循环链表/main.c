#include <stdio.h>
#include <stdlib.h>
#define OK 0
#define ERROR 1

typedef int Elemtpye;
typedef int Status;
typedef struct Node
{
	Elemtpye data;
	struct Node * next;
} Node,*LinkList;

Status DelList(LinkList *list);
Status InList(LinkList *list, int *e); //����������ʼ����Ҳ��������β�巨��
Status PrintList(LinkList list);

Status main(void)
{
	int e = 1;
	int i;
	LinkList list=NULL;
	for (i = 0; i < 41; i++) //��ֵÿһ������
	{
		InList(&list, &e);
	}
	PrintList(list);
	while (!DelList(&list));
	PrintList(list);
	getchar();
}



Status PrintList(LinkList list)
{
	LinkList target;
	target = list;
	printf("˳��Ϊ;");
	do
	{
		printf("%d������ ", target->data);
		target = target->next;
	} while (target != list);
	return OK;
}
Status DelList(LinkList *list)
{
	LinkList Target;
	if ((*list) == NULL) return ERROR;
	if ((*list)->next->next->next == (*list))
	{
		Target = (*list)->next->next;
		(*list)->next->next = (*list);
		printf("%d��������ɱ\n", Target->data);
		free(Target);
		return ERROR;
	}
	Target = (*list)->next->next;
	printf("%d��������ɱ\n",Target->data);
	(*list)->next->next = Target->next;
	(*list) = Target->next;
	free(Target);
	return OK;
}

Status InList(LinkList *list,int *e) //����������ʼ����Ҳ��������β�巨��
{
	LinkList Target,Data;
	if ((*list) == NULL)
	{
		(*list) = (LinkList)malloc(sizeof(Node));
		if (!(*list))
		{
			return ERROR;
		}
		(*list)->data = (*e);
		(*e)++;
		(*list)->next = (*list);
	}
	else
	{
		Data = (LinkList)malloc(sizeof(Node));
		if (!Data)
		{
			return ERROR;
		}
		for (Target = (*list); Target->next != (*list); Target = Target->next); //�ҵ����һλ
		Data->next = Target->next;
		Target->next = Data;
		Data->data = (*e);
		(*e)++;
	}
	return OK;
}