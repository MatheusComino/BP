#include <stdio.h>

int numero1;
int numero2;

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    printf("Voce devera digitar dois numeros inteiros diferentes:\n ");
    printf("Digite o primeiro numero: ");
    scanf("%d", &numero1);
    printf("Digite o segundo numero:");
    scanf("%d", &numero2);

    if(numero1 > numero2){
        printf("A diferença do maior pelo menor numero e: %d", numero1 - numero2);
    }
    else{
        printf("A diferença do maior pelo menor numero e: %d", numero2 - numero1);
    }
}