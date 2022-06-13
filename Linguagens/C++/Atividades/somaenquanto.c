#include <stdio.h>

int isZero = 1;
int numeroDigitado;
int numerosSomados;

int main(){

    printf("Digite o primeiro numero\n");
    scanf("%d",&numeroDigitado);
    while (isZero == 1)
    {
        if(numeroDigitado == 0){
            isZero = 0;
            printf("%d", numerosSomados);
        }
        else{
            numerosSomados += numeroDigitado;
            printf("Digite o outro numero\n");
            scanf("%d",&numeroDigitado);
        }
    }
    
}