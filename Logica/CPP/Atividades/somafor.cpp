#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int quantidadeDeRepetiacoes;
int somaDoNumeros;
int numeroDigitado;
int i;

int main(){
    cout<<"Quantos numeros serao digitados?";
    cin>>quantidadeDeRepetiacoes;
    for (int i = 0; i < quantidadeDeRepetiacoes; i++)
    {
        cout<<"Digite um numero: ";
        cin>>numeroDigitado;
        somaDoNumeros += numeroDigitado;
    }
    

    // while (i < quantidadeDeRepetiacoes)
    // {
    //     i++;
    //     cout<<"Digite um numero: ";
    //     cin>>numeroDigitado;
    //     somaDoNumeros += numeroDigitado;
    // }
    cout<<"SOMA = "<<somaDoNumeros;
}