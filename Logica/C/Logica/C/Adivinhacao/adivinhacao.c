#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    printf("          P  /_\\  P                              \n");
    printf("         /_\\_|_|_/_\\                             \n");
    printf("     n_n | ||. .|| | n_n         Bem vindo ao    \n");
    printf("     |_|_|nnnn nnnn|_|_|     Jogo de Adivinhação!\n");
    printf("    |     |  |_|  |     |                        \n");
    printf("    |     |  |_|  |     |                        \n");
    printf("    |_____| ' _ ' |_____|                        \n");
    printf("          \\__|_|__/                              \n");

    int segundos = time(0);
    srand(segundos);

    int numeroscreto = rand() % 100;
    int chute;
    double pontos = 1000;
    int numerotentativas = 5;

    int dificuldade;
    
    for (int i = 1; i <= numerotentativas; i++)
    {
        if (i == 1){
            printf("%d", numeroscreto);
            printf("qual é o nivel de dificuldade? (1,2,3)");
            scanf("%d", &dificuldade);

            /*if(dificuldade == 1){
                numerotentativas = 20;
            }
            else if (dificuldade == 2){
                numerotentativas = 15;
            }
            else{
                numerotentativas = 6;
            }*/

            switch (dificuldade)
            {
            case 1:
                numerotentativas = 20;
                break;
            case 2:
                numerotentativas = 15;
                break;
            default:
                numerotentativas = 6;
                break;
            }
            
        }
        printf("%d", numeroscreto);
        printf("qual e o seu chute? ");
        scanf("%d", &chute);
        printf("Seu chute foi o n�mero %d\n", chute);

        int acertou = (chute == numeroscreto);
        int maior = (chute > numeroscreto);
        int menor = (chute < numeroscreto);

        if(chute < 0){
        printf("Voc� digitou um numero invalido\n");
        }
        else if (acertou){
        printf("Parabens, voc� acertou na tentativa: %d\n", i);
        printf("Jogue de novo, voc� � um bom jogador!\n");
        printf("PONTOS TOTAIS: %.2f", pontos);

        printf("             OOOOOOOOOOO               \n");
        printf("         OOOOOOOOOOOOOOOOOOO           \n");
        printf("      OOOOOO  OOOOOOOOO  OOOOOO        \n");
        printf("    OOOOOO      OOOOO      OOOOOO     \n");
        printf("  OOOOOOOO  #   OOOOO  #   OOOOOOOO    \n");
        printf(" OOOOOOOOOO    OOOOOOO    OOOOOOOOOO   \n");
        printf("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  \n");
        printf("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  \n");
        printf("OOOO  OOOOOOOOOOOOOOOOOOOOOOOOO  OOOO  \n");
        printf(" OOOO  OOOOOOOOOOOOOOOOOOOOOOO  OOOO   \n");
        printf("  OOOO   OOOOOOOOOOOOOOOOOOOO  OOOO    \n");
        printf("    OOOOO   OOOOOOOOOOOOOOO   OOOO     \n");
        printf("      OOOOOO   OOOOOOOOO   OOOOOO      \n");
        printf("         OOOOOO         OOOOOO         \n");
        printf("             OOOOOOOOOOOO\n");

        break; 
        }
        else{
            printf("       \\|/ ____ \\|/       \n");
            printf("        @~/ ,. \\~@         \n");
            printf("       /_( \\__/ )_\\       \n");
            printf("          \\__U_/\n");
        }
        
        if (maior){
        printf("Seu numero secreto � maior que seu chute\n");
        }
        else {
        printf("Seu numero secreto � menor que seu chute\n");
        }
       
        pontos -= abs(chute - numeroscreto)/(double)2;
        printf("tentativa atual: %d\n", i);
        printf("Pontos Totais: %.2f\n", pontos);

        if(i == numerotentativas){
            i = 0;
            pontos = 1000;
        }
        
    }
}
