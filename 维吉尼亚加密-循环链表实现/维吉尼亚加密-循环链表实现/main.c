#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Node
{
	char data;
	struct Node *next;
}Node, *LinkList;

typedef struct CipherCode
{
	int data;
	struct CipherCode *next;
}CipherCode, *CodeLink;

char string[] = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',' ' };
void InitList(LinkList *list); //创建一个循环链表，26个字母，list是头节点，头节点带数据
char GetChar(LinkList list,char text, int num); //获取偏移后的字符。
void InitAndRandomCode(CodeLink *code,int num); //返回一个特定长度的随机数组
void PrintTextList(LinkList text);
void InitFinalList(CodeLink *code, LinkList *list, LinkList *text);
void PrintCodeList(CodeLink code);

void main(void)
{
	LinkList list, text;
	CodeLink code;
	InitFinalList(&code, &list, &text);
	getchar();
	getchar();
}


void PrintTextList(LinkList text)
{
	printf("\n打印密文中：");
	LinkList Target = text;
	do
	{
		printf("%c", Target->data);
		Target = Target->next;
	} while (Target != text);
	putchar('\n');
}

void InitFinalList(CodeLink *code, LinkList *list,LinkList *text) //传入两个空指针
{
	//这里提示输入，并且将在函数内部调用所有函数，生成list,然后提示输入获取字符串，再
	//计算字符串长度，生成密链，然后根据密链获取偏移后的各个数.
	LinkList New;
	char Input[1024];
	InitList(list);
	printf("请输入要加密的内容:");
	scanf_s("%s", &Input,1024);
	fflush(stdin); //清楚缓冲区
	int i = (int)strlen(Input);
	printf("明文：%s\n", Input);  
	InitAndRandomCode(code, i);
	PrintCodeList((*code));
	(*text) = (LinkList)malloc(sizeof(Node));
	(*text)->data = GetChar((*list), Input[0], (*code)->data);
	(*text)->next = (*text);
	for (int a = 1; a < i; a++)
	{ //尾插法，(*text)充当尾节点
		New = (LinkList)malloc(sizeof(Node));
		(*code) = (*code)->next;
		New->data = GetChar((*list), Input[a], (*code)->data);
		New->next = (*text)->next;
		(*text)->next = New;
		(*text) = New;
	}
	(*text) = (*text)->next; //切回头节点
	PrintTextList((*text));

}

char GetChar(LinkList list, char text, int num)
{
	while (list->data != text)
	{
		list = list->next;
	}//将list指针跳到同一位置上
	for (int i = 0; i < num; i++)
	{
		list = list->next;
	}
	return list->data;
}

void PrintCodeList(CodeLink code)
{
	printf("密链：");
	CodeLink Target = code;
	do
	{
		printf("%d,", Target->data);
		Target = Target->next;
	} while (Target != code);
	putchar('\n');
}
void InitAndRandomCode(CodeLink *code,int num)
{
	CodeLink New;
	int i;
	(*code) = (CodeLink)malloc(sizeof(CipherCode));
	(*code)->data = rand() % 10;
	(*code)->next = (*code);
	for ( i = 0; i < num; i++)
	{
		New = (CodeLink)malloc(sizeof(CipherCode));
		New->data = rand() % 10;
		New->next = (*code)->next;
		(*code)->next = New;
		(*code) = New;
	}
	(*code) = (*code)->next;
}

void InitList(LinkList *list) 
{
	int i = 1;
	LinkList New;
	(*list) = (LinkList)malloc(sizeof(Node));
	(*list)->data = string[0];
	(*list)->next = (*list);
	while (i < 27)
	{ //尾插法
		New = (LinkList)malloc(sizeof(Node));
		New->data = string[i];
		New->next = (*list)->next;
		(*list)->next = New;
		(*list) = New;
		i++;
	}
	(*list) = (*list)->next; //跳回头节点。
}

