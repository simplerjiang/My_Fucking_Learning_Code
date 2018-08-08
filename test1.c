#include <stdio.h>
#include <stdlib.h>

struct Node
{
	int value;
	struct Node *next;
};

void insertNode(struct Node **head, int value)
{
	struct Node *previous;
	struct Node *current;
	struct Node *new;

	current = *head;
	previous = NULL;

	while (current != NULL && current->value <value)
	{
		previous = current;
		current = current->next;
	}
	new = (struct Node *)malloc(sizeof(struct Node));
	if (new == NULL)
	{
		exit(1);
	}
	new->value = value;
	new->next = current;

	if (previous == NULL)
	{
		*head = new;
	}
	else
	{
		previous->next = new;
	}
}
void printNode(struct Node *head)
{
	struct Node *current;
	current = head;
	while (current != NULL)
	{
		printf("%d", current->value);
		current=current->next;
	}
}
int main(void)
{
	struct Node *head = NULL;
	int input;

	while (1)
	{
		printf("input:");
		scanf("%d",&input);
		if (input == -1) break;
		insertNode(&head, input);
		printNode(head);
	}
	return 0;
}
