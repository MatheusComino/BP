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

    int bandeira;
    float km;

    printf("Digite o numero da bandeira (1 ou 2): ");
    scanf("%d", &bandeira);

    printf("Digite a kliometragem rodada: ");
    scanf("%f", &km);

    if(bandeira == 1){
        printf("Valor da corrida: %.2f", km * 1.80);
    } else {
        printf("Valor da corrida: %.2f", km * 2.30);
    }


}
