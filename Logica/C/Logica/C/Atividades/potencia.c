#include <stdio.h>

void potencia(int a, int b){
    int potencia = a^b;
    printf("%d",potencia);
}

int mains(){
    potencia(1,10);
}