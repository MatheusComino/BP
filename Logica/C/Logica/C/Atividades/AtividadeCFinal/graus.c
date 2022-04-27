#include <stdio.h>
float celsius;

int main(){
    printf("\n");
    printf("           ESCOLA SENAI         \n");
    printf("       'Euclides Facchini'      \n");
    printf("           Votuporanga          \n");
    printf("      Matheus Henrique Comino da Silva   \n");
    printf("\n");

    printf("Digite a temperatura em °Celsius: ");
    scanf("%f", &celsius);
    printf("°F %.2f", celsius * 1.8 + (float)32);
    
}