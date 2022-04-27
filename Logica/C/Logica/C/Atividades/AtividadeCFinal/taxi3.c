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

    int bandeira, desconto;
    float km, valor;
    float taxaminima = 3.50;

    printf("Digite o numero da bandeira (1 ou 2): ");
    scanf("%d", &bandeira);

    printf("Digite a kliometragem rodada: ");
    scanf("%f", &km);

    if(bandeira == 1){
        valor = 1.80;
    } else {
        valor = 2.30;
    }

    float preco = km * valor;
    float calculodesconto = preco * 0.7;

    if(preco > taxaminima){

        printf("O taxi oferece desconto de 30% ? (1-sim 2-nao)");
        scanf("%d", &desconto);


        if(desconto == 1){
            printf("Valor da corrida original: %.2f \n", preco);
            printf("Valor da corrida com desconto: %.2f", calculodesconto); 
        } else {
            printf("Valor da corrida: %.2f", preco);
        }
         
    } else {
        printf("Valor da corrida: %.2f", taxaminima);
    }


}