#include<stdio.h>

int main(){
int idade;
double salario,altura;
char genero;
char nome[50];

idade = 20;
salario = 5800.5;
altura = 1.63;
genero = 'F';
strcpy(nome, "MARIA SIlva");

printf("IDADE = %d\n", idade);
printf("SALARIO = %.2f\n", salario);
printf("ALTURA = %.2f\n", altura);
printf("GENERO = %c\n", genero);
printf("NOME = %s\n", nome);


}