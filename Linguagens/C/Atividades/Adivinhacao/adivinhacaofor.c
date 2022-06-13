#include <stdio.h>
#define NUMERO_DE_TENTATIVAS 5

int main(){

    printf("***************************************\n");
    printf("Bem vindo a nosso jogo de Adivinhação\n");
    printf("***************************************\n");

    int numeroscreto = 42;
    int chute;
    
    for (int i = 0; i < NUMERO_DE_TENTATIVAS; i++)
    {
        printf("qual e o seu chute? ");
        scanf("%d", &chute);
        printf("Seu chute foi o número %d\n", chute);

        int acertou = (chute == numeroscreto);
        int maior = (chute > numeroscreto);
        int menor = (chute < numeroscreto);

        if(chute < 0){
            printf("Você digitou um numero invalido\n");
            i--;

            continue;
        }
        else if (acertou){
        printf("Parabens, você acertou!");
        printf("Jogue de novo, você é um bom jogador!\n");
        break; 
        }
        else if (maior){
        printf("tentativa: %d de %d\n", i + 1, NUMERO_DE_TENTATIVAS);
        printf("Seu numero secreto é maior que seu chute\n");
        }
        else {
        printf("tentativa: %d de %d\n", i + 1, NUMERO_DE_TENTATIVAS);
        printf("Seu numero secreto é menor que seu chute\n");
        }
    }
}
