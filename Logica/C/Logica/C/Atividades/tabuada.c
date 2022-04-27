#include <stdio.h>

int main(){
    int tabuada;
    printf("Qual tabuada?");
    scanf("%d",&tabuada);

    for (int i = 0; i <= 10; i++)
    {
        printf("%d x %d = %d\n",i,tabuada, tabuada * i);

    }
}