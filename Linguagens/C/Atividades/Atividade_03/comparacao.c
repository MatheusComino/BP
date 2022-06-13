#include <stdio.h>

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    int idadePedro;
    int idadeJoana;

    printf("Digite a idade de Pedro: ");
    scanf("%d", &idadePedro);
    printf("Digite a idade de joana: ");
    scanf("%d", &idadeJoana);

    if(idadeJoana == idadePedro){
        printf("As idade são iguais");
    }
    else if (idadeJoana < idadePedro){
        printf("Pedro é o mais velho");
    }
    else{
        printf("Joana é o mais velha");
    }

}