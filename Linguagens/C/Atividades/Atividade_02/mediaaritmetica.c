#include <stdio.h>

int numero1;
int numero2;
double media;
int main(){
    printf("De quantos numeros voce deseja calcular a media: ");
    scanf("%d", &numero1);

    for (int i = 0; i < numero1; i++)
    {
        printf("Digite um dos numero: ");
        scanf("%d", &numero2);
        media = media + numero2;
    }

    printf("A media dos numeros fonercidos e: %.1f", media / numero1);
    
}