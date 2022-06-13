#include <stdio.h>
#include <string.h>
#include <stdlib.h>

char palavrasecreta[20];

int main(){
    FILE* f;
    f = fopen("teste.txt", "r");

    int qtddepalavras;
    fscanf(f, "%d", &qtddepalavras);
    printf("%d", qtddepalavras);

     for (int i = 0; i < qtddepalavras; i++)
    {
        fscanf(f,"%s", palavrasecreta);
        printf("%s\n\n", palavrasecreta);
    }
   
    fclose(f);

}