#include <stdio.h>

void abertura(){

    printf("\n");
    printf("           ESCOLA SENAI         \n");
    printf("       'Euclides Facchini'      \n");
    printf("           Votuporanga          \n");
    printf("      Matheus Henrique Comino da Silva   \n");
    printf("\n");
}

int main(){

    abertura();

    float nota, notamaior = 0, notamenor = 10;
    int limite;
    float soma = 0;

    printf("De quantos numeros voce deseja calcular a media? ");
    scanf("%d", &limite);

    for (int i = 0; i < limite; i++){
        
        printf("-> Nota: ");
        scanf("%f", &nota);

        soma = soma + nota;

        if(nota > notamaior){
            notamaior = nota;
        }
        if(nota < notamenor){
            notamenor = nota;
        }
    
    }

    printf("Soma das notas: %.1f \n", soma);
    printf("Media das notas: %.1f \n", soma / limite);
    printf("%.1f \n", notamaior);
    printf("%.1f", notamenor);

}