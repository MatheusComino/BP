#include <stdio.h>
#include <string.h>

void limpar_entrada(){
    char c;
    while ((c = getchar()) != '/n' && c != EOF){

    }
}

void ler_texto(char *buffer, int length){
    fgets (buffer, length, stdin);
    strtok (buffer, "\n");
}

char nome1[20], nome2[20];
double salario1, salario2;
int idade1, idade2;
char sexo1, sexo2;

int main(){
    printf("Escreva o nome da primeira pessoa?\n");
    ler_texto(nome1, 50);
    printf("Escreva o salario da primeira pessoa?\n");
    scanf("%lf", &salario1);
    printf("Escreva o idade da primeira pessoa?\n");
    scanf("%d", &idade1);
    printf("Escreva o sexo (F/M) da primeira pessoa?\n");
    scanf(" %c", &sexo1);

    printf("Escreva o nome da segunda pessoa?\n");
    limpar_entrada();
    ler_texto(nome2,50);
    scanf("%s", &nome2);
    printf("Escreva o salario da segunda pessoa?\n");
    scanf("%lf", &salario2);
    printf("Escreva o idade da segunda pessoa?\n");
    scanf("%d", &idade2);
    printf("Escreva o sexo (F/M) da segunda pessoa?\n");
    limpar_entrada();
    scanf(" %c", &sexo2);

    printf("Nome 1: %s\n", nome1);
    printf("Salario 1: %.2lf\n", salario1);
    printf("Idade 1: %d\n", idade1);
    printf("Sexo 1: %c\n", sexo1);

    printf("\n");

    printf("Nome 2: %s\n", nome2);
    printf("Salario 2: %.2lf\n", salario2);
    printf("Idade 2: %d\n", idade2);
    printf("Sexo 2: %c\n", sexo2);
    
}