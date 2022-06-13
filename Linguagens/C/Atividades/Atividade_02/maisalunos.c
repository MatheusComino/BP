#include <stdio.h>

int quantidadeAlunos;
int quantidadeAlunas;

int main(){
    printf("Matheus Henrique Comino da Silva\n");
    printf("Escola Senai Euclides Facchini Votuporanga\n");

    printf("Digite a quantidade de alunos: ");
    scanf("%d", &quantidadeAlunos);
    printf("Digite a quantidade de alunas: ");
    scanf("%d", &quantidadeAlunas);

    if(quantidadeAlunos > quantidadeAlunas){
        printf("Existem mais alunos do que alunas.");
    }
    else{
        printf("Existem mais alunas do que alunos");
    }
}