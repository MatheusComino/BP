#include <stdio.h>

int num[2];
int maior = 0;
int menor = 1000;
int meio;

int main(){

    printf("\n");
    printf("           ESCOLA SENAI         \n");
    printf("       'Euclides Facchini'      \n");
    printf("           Votuporanga          \n");
    printf("      Matheus Henrique Comino da Silva   \n");
    printf("\n");
    
    for (int i = 0; i < 3; i++)
    {
        printf("Você deveria digitar tres numeros inteiros diferentes: ");
        scanf("%d", &num[i]);
        meio = num[i];
    }

    for (int i = 0; i < 3; i++)
    {

        if(num[i] > maior){
            maior = num[i];
        }
        if(num[i] < menor){
            menor = num[i];
        }

        for (int j = 0; j < 3; j++)
        {
            if(num[j] < maior && num[j] > menor){
            meio = num[j];
            }
        }
    }
    printf("%d %d %d", menor, meio, maior);
}