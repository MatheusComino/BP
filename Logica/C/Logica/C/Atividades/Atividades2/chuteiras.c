#include <stdio.h>

int quantidadeChuteirasA;
int quantidadeChuteirasB;
int quantidadeChuteirasC;

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    printf("Digite a quantidae de chuteiras da marca A: ");
    scanf("%d", &quantidadeChuteirasA);
    printf("Digite a quantidae de chuteiras da marca B: ");
    scanf("%d", &quantidadeChuteirasB);
    printf("Digite a quantidae de chuteiras da marca C: ");
    scanf("%d", &quantidadeChuteirasC);

    printf("Existem %d chuteiras da marca A\n", quantidadeChuteirasA);
    printf("Existem %d chuteiras da marca B\n", quantidadeChuteirasB);
    printf("Existem %d chuteiras da marca C\n", quantidadeChuteirasC);
}