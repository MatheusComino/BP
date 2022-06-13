#include <stdio.h>

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    int numero1;
    int numero2;

    printf("Digite o numero 1: ");
    scanf("%d", &numero1);
    printf("Digite o numero 2: ");
    scanf("%d", &numero2);

    printf("A soma %d + %d = %d\nA subtração %d - %d = %d\nO produto %d x %d = %d\nA divisão %d : %d = %d\nA media entre %d e %d = %.2f\n",numero1,numero2,numero1 + numero2,numero1,numero2, numero1 - numero2,numero1,numero2, numero1 * numero2,numero1,numero2, numero1 / numero2,numero1,numero2, (numero1 + numero2) / 2.0f);

}