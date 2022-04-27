#include <stdio.h>

int idade = 20;
double salario = 5800.50;
double altura = 1.63;
char genero = 'F';
char nome[100] = "Maria Silva";

int main()
{
    printf("IDADE: %d\n", idade);
    printf("SALARIO: %.2f\n", salario);
    printf("ALTURA: %.2f\n", altura);
    printf("GENERO: %c\n", genero);
    printf("NOME: %s", nome);
}
