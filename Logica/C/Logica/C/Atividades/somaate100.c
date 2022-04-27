#include <stdio.h>

int main(){
    int numerosSomados = 0;
    printf("0 ");
    for (int i = 0; i < 100; i++)
    {
        printf ("+ %d ",i);
        numerosSomados += i;   
    }
    //printf("100");
    printf(" = %d\n", numerosSomados);

    printf("------------------------------------\n\n");

    int contador = 0;
    while (contador < 100)
    {
        printf ("%d + ",contador);
        contador++;
    }
    printf("100");
    printf(" = %d\n\n", numerosSomados + 100);

    printf("----------------FIM----------------");
}