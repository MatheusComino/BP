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

    int base;
    int altura;

    int base2;
    int altura2;

    printf("Digite a base do primeiro retangulo em cm: ");
    scanf("%d", &base);
    printf("Digite a altura do primeiro retangulo em cm: ");
    scanf("%d", &altura);
    printf("Digite a base do segundo retangulo em cm: ");
    scanf("%d", &base2);
    printf("Digite a altura do segundo retangulo em cm: ");
    scanf("%d", &altura2);

    double area = base * altura;
    double area2 = base2 * altura2;

    printf("Area do primeiro retangulo: %.2f\n", area);
    printf("Area do segundo retangulo %.2f\n", area2);

    if(area > area2){
        printf("A area do primeiro retangulo e maior.");
    }
    else if(area2 > area) {
        printf("A area do segundo retangulo e maior.");
    }
    else{
        printf("As areas dos retangulos sao iguais.");
    }

}