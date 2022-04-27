#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){
    double salario1, salario2;
    string nome1, nome2;
    int idade1, idade2;
    char sexo1, sexo2;

    cout<<"Escreva o nome da primeira pessoa?"<<endl;
    cin>>nome1;
    cout<<"Escreva o idade da primeira pessoa?"<<endl;
    cin>>idade1;
    cout<<"Escreva o salario da primeira pessoa?"<<endl;
    cin>>salario1;
    cout<<"Escreva o sexo da primeira pessoa?"<<endl;
    cin>>sexo1;

    cout<<"Escreva o nome da segunda pessoa?"<<endl;
    cin>>nome2;
    cout<<"Escreva o idade da segunda pessoa?"<<endl;
    cin>>idade2;
    cout<<"Escreva o salario da segunda pessoa?"<<endl;
    cin>>salario2;
    cout<<"Escreva o sexo da segunda pessoa?"<<endl;
    cin>>sexo2;

    cout<<"Nome Primeira pessoa: "<< nome1<<endl;
    cout<<"idade Primeira pessoa: "<< idade1<<endl;
    cout<<"salario Primeira pessoa: "<< salario1<<endl;
    cout<<"sexo Primeira pessoa: "<< sexo1<<endl<<endl;

    cout<<"Nome Seguda pessoa: "<< nome2<<endl;
    cout<<"idade Seguda pessoa: "<< idade2<<endl;
    cout<<"salario Seguda pessoa: "<< salario2<<endl;
    cout<<"sexo Seguda pessoa: "<< sexo2<<endl;
}