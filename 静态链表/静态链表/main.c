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
	space[MAXSIZE - 1].cur = 0; //��ǰ��̬����Ϊ�գ�����Ϊ0����������ݣ��Ͳ�Ӧ��Ϊ0
	return OK;
}
int Malloc_SLL(StaticLinkList space) //�������λ�þͷ���
{
	int i = space[0].cur;
	if (space[0].cur)
	{
		space[0].cur = space[i].cur;
	}
	else if (space[0].cur == (MAXSIZE-1))
	{
		return -1; //��ָ�������һ��Ԫ�أ�����û�пռ䣬����-1
	}
	return i; 
}

Status ListInsert(StaticLinkList space, int i, ElemType e) //i����Ҫ�����ĸ���ǰ ��e��data
{
	int j, k, l;
	k = MAXSIZE - 1;
	if (i<1 || i>ListLength(space) + 1) //����ֻ�����i�Ƿ�����ЧԪ�������ڣ�����ЧԪ�ض�һλ
	{
		return Error;
	}
	j = Malloc_SLL(space);
	if (j) //�ж��Ƿ�ɹ�����
	{
		space[j].data = e;
		for (l = 1; l < i; i++)
		{
			k = space[k].cur; //��������������α꣬�Դ˴ﵽ������iǰ����Ǹ����ķ���
			// k�����Ϊiǰ��һ��Ԫ�ص�����ֵ��
		}
		space[j].cur = space[k].cur;//��k���α��j���α꣬�Դ˴ﵽ��k�������
		space[k].cur = j;  //��k���α�ָ��j;

		return OK;
	}
	return Error;
}
void Free_SLL(StaticLinkList space, int j)
{
	int l, k;
	space[j].cur = space[0].cur; //��ñ����б��һ��
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
		k = space[k].cur; //k��Ҫɾ����Ԫ��i��ǰһ��Ԫ��
	}
	j = space[k].cur; //j����Ҫɾ��������λ��
	space[k].cur = space[j].cur;  //��Ҫɾ������i(ʵ��λ��j)���α��ǰһ��Ԫ��k���α꣬���ǽ�ǰ��Խ�
	Free_SLL(space, j); //��ɾ����Ԫ���뱸���б���������
	return OK;
}