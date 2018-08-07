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
	printf("list1初始化完毕，所有data加起来为：%d\n",CountList(list1));
	
	if (InitList(&list2)) return ERROR;
	printf("list2初始化完毕，所有data加起来为：%d\n",CountList(list2));

	if (AddList(&list1, &list2)) return ERROR;
	printf("合并完成！");

	printf("最后计算结果为：%d\n", CountList(list2));

	getchar();
	return OK;
}
Status PrintList(LinkList list)
{
	LinkList Target;
	Target = list;
	printf("顺序为： ");
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

Status AddList(LinkList *list1, LinkList *list2) //传入两个链表的都是尾节点
{
	LinkList p;
	p = (*list1)->next; //将list1的头节点传入替换对象中
	(*list1)->next = (*list2)->next; //将list1的尾部next接上list2的头
	(*list2)->next = p; //再将list2的尾部next接上list1的头。 
	//最后list2->next 就是开头了！
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
		New->next = (*list)->next; //将头节点放入New节点中
		(*list)->next = New; //再将上一个节点（*list)的next改为New
		(*list) = New; //(*list) 一直为伪结点，而(*list)->next 其实就是头节点
	}
	return OK;
}