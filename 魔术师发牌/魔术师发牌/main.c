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

Status InitList(LinkList *list); //创建13个空的data循环列表
Status IntoList(LinkList list); //放入牌
Status PrintList(LinkList list); // 读出目前的数
Status SendList(LinkList *list); // 出牌
Status ListLength(LinkList *list);


Status main(void)
{
	LinkList list = NULL;
	InitList(&list);
	if (IntoList(&list) == ERROR) printf("错误\n");
	PrintList(list);
	getchar();
	return OK;
}

Status PrintList(LinkList list)
{
	LinkList Target = list;
	printf("开始打印：");
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
		New->next = (*list)->next; //头插法
		(*list)->next = New;
		New->data = NULL;
	}
	return OK;
}
Status IntoList(LinkList *list)
{
	LinkList p = (*list);
	int i, j,k; //i用于计算目前发到哪张牌,j用于记步数
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


