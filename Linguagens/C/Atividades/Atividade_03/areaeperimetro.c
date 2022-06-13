#include <stdio.h>

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    int lados;

    printf("Digite o lado do quadrado em cm: ");
    scanf("%d", &lados);

    printf("A area do quadrado e: %d\nO perimentro do quadrado e: %d",lados * lados, lados * 4);

}