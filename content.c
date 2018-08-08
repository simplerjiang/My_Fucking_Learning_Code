#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX 1024


struct Person
{
    char name[40];
    char phone[40];

    struct  Person *next;
};

struct Person *pool = NULL;
int count;

void addPerson(struct Person **head)
{
    struct Person *temp;
    struct Person *new1;
    char name[40];
    char phone[40];

    printf("请输入联系人：");
    scanf("%s",name);
    printf("请输入电话号：");
    scanf("%s",phone);

    //如果内存池非空，则直接从里面获取空间。
    if (pool != NULL)
    {
        new1 = pool;
        pool = pool->next;
        count--;
    }
    else // 如果内存池为空，调用malloc;
    {
        new1 = (struct Person *) malloc(sizeof(struct Person));
    }
    strcpy(new1->name,name);
    strcpy(new1->phone,phone);
    temp = *head;  //不管它是null还是不是null
    (*head) = new1;
    new1->next = temp; // 都是直接放入，如果null，就null
    printf("输入完毕！\n");
}

void findPerson(struct Person *head)
{
    struct Person *current;
    char name[40];
    printf("请输入联系人：");
    scanf("%s",name);

    current = head;
    while (current != NULL && strcmp(current->name,name))
    {
        current = current->next;
    }
    if (current==NULL)
    {
        printf("未找到！");
        return ;
    }
    else if (!strcmp(current->name,name))
    {
        printf("联系人：%s\n",current->name);
        printf("电话号：%s\n",current->phone);
        return ;
    }
}



void changePerson(struct Person *head)
{
    struct Person *temp;
    char name[40];
    char phone[40];
    printf("请输入联系人：");
    scanf("%s",name);
    printf("请输入电话号：");
    scanf("%s",phone);

    temp = head;
    while (temp != NULL && strcmp(temp->name,name))
    {
        temp = temp->next;
    }
    if (temp == NULL)
    {
        printf("未找到！");
        return ;
    }
    else if (!strcmp(temp->name,name))
    {
        strcpy(temp->phone,phone);
        printf("修改完毕！\n");
        return ;
    }
}

void delPerson(struct Person **head)
{
    char name[40];
    printf("请输入联系人：");
    scanf("%s",name);
    struct Person *temp;
    struct Person *p = NULL;
    struct Person *c;
    temp = *head;
    while (temp != NULL && strcmp(temp->name,name))
    {
        p = temp;
        temp = temp->next;
    }
    if (temp == NULL)
    {
        printf("未找到！");
        return ;
    }
    else if (!strcmp(temp->name,name))
    {
        if (p == NULL) // 这个说明，这个匹配出来的值没有上一个数
        {
            *head = temp->next;
            printf("修改完毕！\n");
        }
        else
        {
            p->next = temp->next;
            printf("修改完毕！\n");
        }
        if (count < MAX) // 如果有空位就放进去
        {
            temp->next = pool;
            pool = temp;
            count++;
        }
        else //如果没空位，就free
        {
            free(temp);
        }
    }
}

void displayPerson(struct Person *head)
{
    struct  Person *temp;
    temp = head;
    while (temp != NULL)
    {
        printf("联系人：%s ",temp->name);
        printf("电话：%s",temp->phone);
        putchar('\n');
        temp = temp->next;
    }
}
void freePerson(struct Person *head)
{
    struct Person *temp;
    while (pool != NULL)
    {
        temp = pool;
        pool = pool->next;
        free(temp);
    }
    while (head!=NULL)
    {
        temp = head;
        free(head);
        head = temp->next;
    }
    printf("已退出!");
    exit(0);

}
int main(void)
{
    struct Person *head = NULL;
    int flag; //接收指令
    while (1) {
        printf("++++++++++++++++++++++\n");
        printf("+++++ 手机通讯录 ++++++\n");
        printf("++++ 1、添加联系人+++++\n");
        printf("++++ 2、查找联系人+++++\n");
        printf("++++ 3、更改联系人+++++\n");
        printf("++++ 4、删除联系人+++++\n");
        printf("++++ 5、显示所有人+++++\n");
        printf("++++ 6、退出通讯录+++++\n");
        printf("请输入指令：");
        scanf("%d",&flag);
        switch (flag)
        {
            case 1: addPerson(&head); break;
            case 2: findPerson(head); break;
            case 3: changePerson(head); break;
            case 4: delPerson(&head); break;
            case 5: displayPerson(head); break;
            case 6: freePerson(head); break;
            default: printf("重新选择！");break;
        }

    }



    return 0;
}