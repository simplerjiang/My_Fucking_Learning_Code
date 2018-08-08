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
void InitList(LinkList *list); //����һ��ѭ������26����ĸ��list��ͷ�ڵ㣬ͷ�ڵ������
char GetChar(LinkList list,char text, int num); //��ȡƫ�ƺ���ַ���
void InitAndRandomCode(CodeLink *code,int num); //����һ���ض����ȵ��������
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
	printf("\n��ӡ�����У�");
	LinkList Target = text;
	do
	{
		printf("%c", Target->data);
		Target = Target->next;
	} while (Target != text);
	putchar('\n');
}

void InitFinalList(CodeLink *code, LinkList *list,LinkList *text) //����������ָ��
{
	//������ʾ���룬���ҽ��ں����ڲ��������к���������list,Ȼ����ʾ�����ȡ�ַ�������
	//�����ַ������ȣ�����������Ȼ�����������ȡƫ�ƺ�ĸ�����.
	LinkList New;
	char Input[1024];
	InitList(list);
	printf("������Ҫ���ܵ�����:");
	scanf_s("%s", &Input,1024);
	fflush(stdin); //���������
	int i = (int)strlen(Input);
	printf("���ģ�%s\n", Input);  
	InitAndRandomCode(code, i);
	PrintCodeList((*code));
	(*text) = (LinkList)malloc(sizeof(Node));
	(*text)->data = GetChar((*list), Input[0], (*code)->data);
	(*text)->next = (*text);
	for (int a = 1; a < i; a++)
	{ //β�巨��(*text)�䵱β�ڵ�
		New = (LinkList)malloc(sizeof(Node));
		(*code) = (*code)->next;
		New->data = GetChar((*list), Input[a], (*code)->data);
		New->next = (*text)->next;
		(*text)->next = New;
		(*text) = New;
	}
	(*text) = (*text)->next; //�л�ͷ�ڵ�
	PrintTextList((*text));

}

char GetChar(LinkList list, char text, int num)
{
	while (list->data != text)
	{
		list = list->next;
	}//��listָ������ͬһλ����
	for (int i = 0; i < num; i++)
	{
		list = list->next;
	}
	return list->data;
}

void PrintCodeList(CodeLink code)
{
	printf("������");
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
	{ //β�巨
		New = (LinkList)malloc(sizeof(Node));
		New->data = string[i];
		New->next = (*list)->next;
		(*list)->next = New;
		(*list) = New;
		i++;
	}
	(*list) = (*list)->next; //����ͷ�ڵ㡣
}

