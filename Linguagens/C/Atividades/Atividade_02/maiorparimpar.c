#include <stdio.h>

int numero1;
int numero2;

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    printf("Digite um numero inteiro: ");
    scanf("%d", &numero1);
    printf("Digite outro numero inteiro: ");
    scanf("%d", &numero2);

    if(numero1 > numero2){
        if(numero1 % 2 == 0){
            printf("O primeiro numero e maior que o segundo numero e par");
        }
        else{
            printf("O primeiro numero e maior que o segundo numero e impar");
        }
    }
    else{
        if(numero2 % 2 == 0){
            printf("O segundo numero e maior que o primeiro numero e par");
        }
        else{
            printf("O segundo numero e maior que o primeiro numero e impar");
        }
    }
}