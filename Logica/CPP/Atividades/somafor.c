#include <stdio.h>

int quantidadeDeRepetiacoes;
int somaDoNumeros;
int numeroDigitado;
int i;

int main(){
    printf("Quantos numeros serao digitados?");
    scanf("%d", &quantidadeDeRepetiacoes);
    // for (int i = 0; i < quantidadeDeRepetiacoes; i++)
    // {
    //     printf("Digite um numero: ");
    //     scanf("%d", &numeroDigitado);
    //     somaDoNumeros += numeroDigitado;
    // }
    

    while (i < quantidadeDeRepetiacoes)
    {
        i++;
        printf("Digite um numero: ");
        scanf("%d", &numeroDigitado);
        somaDoNumeros += numeroDigitado;
    }
    printf("SOMA = %d", somaDoNumeros);
}