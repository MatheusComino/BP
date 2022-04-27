#include <stdio.h>

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    int numero;
    printf("Digite um numero inteiro: ");
    scanf("%d", &numero);

    if (numero % 2 == 0){
        printf("O numero %d é par", numero);
    }
    else{
        printf("O numero %d é impar", numero);
    }

}