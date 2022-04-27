#include <stdio.h>

void abertura(int multiplicador){
    printf("Tabuada do: \n");
}

int main(){
    int multiplicador = 0;

    abertura(multiplicador);

    for (int i = 0; i < 10; i++)
    {
        int resultado = multiplicador * i;
        printf("%d x %d = %d", i, multiplicador, resultado);
    }
    

}