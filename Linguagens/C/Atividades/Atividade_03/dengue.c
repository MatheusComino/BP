#include <stdio.h>

int main(){
    
    int casosSupeitos;
    int casosConfirmados;
    int mortes;
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");


    printf("Preencha com as seguintes infomações sobre a Dengue em Votuporanga?\n");
    printf("Quantos casos supeitos?");
    scanf("%d", &casosSupeitos);
    printf("Quantos casos Confirmados?");
    scanf("%d", &casosConfirmados);
    printf("Quantos Mortes?");
    scanf("%d", &mortes);

    printf("Informações sobre a dengue em Votuporanga?\n");
    printf("Casos Supeitos: %d\nCasos Confirmados: %d\nMortes: %d\n\nTotal de Dados: %d", casosSupeitos, casosConfirmados, mortes, casosSupeitos + casosConfirmados + mortes);

}