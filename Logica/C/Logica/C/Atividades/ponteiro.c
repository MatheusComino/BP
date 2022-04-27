#include<stdio.h>

int x = 10;
int *ponteiro = &x;
int y = 20;



int main(){
    *ponteiro = y;

    printf("%d %d\n", x,y);
}