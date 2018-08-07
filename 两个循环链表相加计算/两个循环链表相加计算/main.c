#include <stdio.h>
#include <stdlib.h>
#define OK 0
#define ERROR 1
typedef int ElemTpye;
typedef int Status;
typedef struct Node
{
	ElemTpye data;
	struct Node *next;
}Node, *LinkList;

Status InitList(LinkList *list);
Status AddList(LinkList *list1, LinkList *list2);
ElemTpye CountList(LinkList list);
Status PrintList(LinkList list);

Status main(void)
{
	LinkList list1, list2;
	list1 = NULL;
	list2 = NULL;
	if (InitList(&list1)) return ERROR;
	printf("list1��ʼ����ϣ�����data������Ϊ��%d\n",CountList(list1));
	
	if (InitList(&list2)) return ERROR;
	printf("list2��ʼ����ϣ�����data������Ϊ��%d\n",CountList(list2));

	if (AddList(&list1, &list2)) return ERROR;
	printf("�ϲ���ɣ�");

	printf("��������Ϊ��%d\n", CountList(list2));

	getchar();
	return OK;
}
Status PrintList(LinkList list)
{
	LinkList Target;
	Target = list;
	printf("˳��Ϊ�� ");
	do
	{
		printf("%d  ", Target->data);
		Target = Target->next;
	} while (Target != list);
	putchar('\n');
	return OK;
}


ElemTpye CountList(LinkList list)
{
	LinkList Target;
	Target = list;
	ElemTpye count = 0;
	do
	{
		count += Target->data;
		Target = Target->next;
	} while (Target != list);
	return count;
}

Status AddList(LinkList *list1, LinkList *list2) //������������Ķ���β�ڵ�
{
	LinkList p;
	p = (*list1)->next; //��list1��ͷ�ڵ㴫���滻������
	(*list1)->next = (*list2)->next; //��list1��β��next����list2��ͷ
	(*list2)->next = p; //�ٽ�list2��β��next����list1��ͷ�� 
	//���list2->next ���ǿ�ͷ�ˣ�
	return OK;
}



Status InitList(LinkList *list)
{
	if ((*list) != NULL) return ERROR;
	int i;
	LinkList New;
	(*list) = (LinkList)malloc(sizeof(Node));
	(*list)->data = rand() % 100 + 1;
	(*list)->next = (*list);
	for (i = 0; i < 50; i++)
	{
		New = (LinkList)malloc(sizeof(Node));
		New->data = rand() % 100 + 1;
		New->next = (*list)->next; //��ͷ�ڵ����New�ڵ���
		(*list)->next = New; //�ٽ���һ���ڵ㣨*list)��next��ΪNew
		(*list) = New; //(*list) һֱΪα��㣬��(*list)->next ��ʵ����ͷ�ڵ�
	}
	return OK;
}