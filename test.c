#include <stdio.h>
#include <math.h>

int main()
{
        unsigned long long sum = 0;
        unsigned long long temp;
        unsigned long long weight;
        int i;

        for (i=0; i < 64; i++)
        {
                temp = pow(2, i);
                sum = sum + temp;
        }

        weight = sum / 25000;

        printf("�ằ��Ӧ�ø��������%llu�����ӣ�\n", sum);
        printf("���ÿ25000������Ϊ1kg����ôӦ�ø�%llu�������ӣ�\n", weight);

        return 0;
}