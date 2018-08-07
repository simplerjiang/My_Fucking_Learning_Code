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

Status InitList(LinkList *list,int num); //放入num个元素，并每个随机data，前后链起,list保持为头不变
Status BeginList(LinkList *list, int num); //list会根据报数而变，不再作为头。
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
	LinkList Target,UpTarget; //Target是目标元素，UpTarget是Target上一个
	UpTarget = NULL;
	while (Flag)
	{
		if ((*list) == NULL)
		{
			return OK;
		}
		if ((*list) == (*list)->next)
		{
			printf("最后一位%d\n", (*list)->data);
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
		printf("密码被修改！新密码为：%d\n", num);
		UpTarget->next = Target->next; //将下一个连上前一个
		free(Target);
		j++;
	}
	printf("完成！共剔除%d个成员\n",j);
	return OK;
}

Status PrintList(LinkList list)
{
	LinkList Target;
	Target = list;
	int i = 0;
	printf("顺序为：\n");
	do
	{
		i++;
		printf("%d -- %d号\n",i,Target->data);
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
			(*list)->data = rand() % 1000 + 1; // 放入1000以内的正随机数。
			(*list)->next = (*list);
			Rear = (*list)->next;
		}
		else //这里用尾插法
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