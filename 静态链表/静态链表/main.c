#include <stdio.h>
#define MAXSIZE 1000
#define OK 0
#define Error 1

typedef int ElemType;
typedef int Status;


typedef struct
{
	ElemType data;
	int cur;
} Component, StaticLinkList[MAXSIZE];

int ListLength(StaticLinkList space)
{
	int j = 0;
	int i = space[MAXSIZE - 1].cur;
	while (i)
	{
		i = space[i].cur;
		j++;
	}
	return j;
}
Status InitList(StaticLinkList space)
{
	int i;
	for (i = 0; i < MAXSIZE - 1; i++)
	{
		space[i].cur = i + 1;
	}
	space[MAXSIZE - 1].cur = 0; //当前静态链表为空，所以为0，如果有数据，就不应该为0
	return OK;
}
int Malloc_SLL(StaticLinkList space) //如果还有位置就返回
{
	int i = space[0].cur;
	if (space[0].cur)
	{
		space[0].cur = space[i].cur;
	}
	else if (space[0].cur == (MAXSIZE-1))
	{
		return -1; //当指向了最后一个元素，代表没有空间，返回-1
	}
	return i; 
}

Status ListInsert(StaticLinkList space, int i, ElemType e) //i是需要放在哪个数前 ，e是data
{
	int j, k, l;
	k = MAXSIZE - 1;
	if (i<1 || i>ListLength(space) + 1) //这里只检测了i是否不在有效元素数组内，或有效元素多一位
	{
		return Error;
	}
	j = Malloc_SLL(space);
	if (j) //判断是否成功申请
	{
		space[j].data = e;
		for (l = 1; l < i; i++)
		{
			k = space[k].cur; //这里是逐个索引游标，以此达到往下找i前面的那个数的方法
			// k最后会成为i前面一个元素的索引值。
		}
		space[j].cur = space[k].cur;//将k的游标给j的游标，以此达到在k后面插入
		space[k].cur = j;  //将k的游标指向j;

		return OK;
	}
	return Error;
}
void Free_SLL(StaticLinkList space, int j)
{
	int l, k;
	space[j].cur = space[0].cur; //获得备用列表第一个
	space[0].cur = j;
}
Status ListDelete(StaticLinkList space, int i)
{
	int j, k;
	if (i<1 || i>ListLength(space))
	{
		return Error;
	}
	k = MAXSIZE - 1;
	for (j = 1; j <= i - 1; j++)
	{
		k = space[k].cur; //k是要删除的元素i的前一个元素
	}
	j = space[k].cur; //j就是要删除的数的位置
	space[k].cur = space[j].cur;  //将要删除的数i(实际位置j)的游标给前一个元素k的游标，就是将前后对接
	Free_SLL(space, j); //将删除的元素与备用列表链接起来
	return OK;
}