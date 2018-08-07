#include <stdio.h>
#include <stdlib.h>

#define OK 0
#define ERROR 1

typedef int DataType;
typedef int Status;


typedef struct Node
{
	DataType data;
	struct Node *next;
}Node, *LinkList;

Status InitList(LinkList *list,int num); //����num��Ԫ�أ���ÿ�����data��ǰ������,list����Ϊͷ����
Status BeginList(LinkList *list, int num); //list����ݱ������䣬������Ϊͷ��
Status PrintList(LinkList list);  

Status main(void)
{
	LinkList list;
	list = NULL;
	InitList(&list, 100);
	PrintList(list);
	BeginList(&list, rand() % 1000 + 1);
	getchar();
	return OK;
}

Status BeginList(LinkList *list, int num)
{
	int i,Flag,j;
	Flag = 1;
	j = 0;
	LinkList Target,UpTarget; //Target��Ŀ��Ԫ�أ�UpTarget��Target��һ��
	UpTarget = NULL;
	while (Flag)
	{
		if ((*list) == NULL)
		{
			return OK;
		}
		if ((*list) == (*list)->next)
		{
			printf("���һλ%d\n", (*list)->data);
			free(*list);
			j++;
			(*list) = NULL;
			Flag = 0;
			continue;
		}
		for (i = 1; i < num; i++)
		{
			UpTarget = (*list);
			(*list) = (*list)->next;
		}
		Target = (*list);
		(*list) = (*list)->next;
		num = Target->data;
		printf("���뱻�޸ģ�������Ϊ��%d\n", num);
		UpTarget->next = Target->next; //����һ������ǰһ��
		free(Target);
		j++;
	}
	printf("��ɣ����޳�%d����Ա\n",j);
	return OK;
}

Status PrintList(LinkList list)
{
	LinkList Target;
	Target = list;
	int i = 0;
	printf("˳��Ϊ��\n");
	do
	{
		i++;
		printf("%d -- %d��\n",i,Target->data);
		Target = Target->next;
	} while (Target != list);
	putchar('\n');
	return OK;
}


Status InitList(LinkList *list, int num)
{
	LinkList New;
	LinkList Rear = NULL;
	(*list) = NULL;
	int i;
	for (i = 0; i < num; i++)
	{
		if ((*list) == NULL)
		{
			(*list) = (LinkList)malloc(sizeof(Node));
			if (!list) return ERROR;
			(*list)->data = rand() % 1000 + 1; // ����1000���ڵ����������
			(*list)->next = (*list);
			Rear = (*list)->next;
		}
		else //������β�巨
		{
			if (!Rear)
			{
				return ERROR;
			}
			New = (LinkList)malloc(sizeof(Node));
			if (!New) return ERROR;
			New->data = rand() % 1000 + 1;
			New->next = Rear->next;
			Rear->next = New;
			Rear = New;
		}
	}
	return OK;
}