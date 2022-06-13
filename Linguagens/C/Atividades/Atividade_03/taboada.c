#include<stdio.h>

int main(){
    
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    int taboada;
    printf("Qual é a taboa?");
    scanf("%d",&taboada);
    for (int i = 0; i <= 10; i++)
    {
        printf("%d x %d = %d\n",taboada, i, i * taboada);
    }
    
}