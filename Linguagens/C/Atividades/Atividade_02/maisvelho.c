#include <stdio.h>

int idadePedro;
int idadeJoana;
int idadeIsmael;

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    printf("Digite a idade de Pedro: ");
    scanf("%d", &idadePedro);
    printf("Digite a idade de Ismael: ");
    scanf("%d", &idadeIsmael);
    printf("Digite a idade de Joana: ");
    scanf("%d", &idadeJoana);

    if (idadePedro > idadeJoana && idadePedro > idadeIsmael)
    {
        printf("Pedro e o mais velho dentre os tres");
    }
    else if (idadeJoana > idadePedro && idadeJoana > idadeIsmael)
    {
        printf("Joana e o mais velho dentre os tres");
    }
    else
    {
        printf("Ismael e o mais velho dentre os tres");
    }
}