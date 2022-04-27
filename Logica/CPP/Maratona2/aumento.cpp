#include <bits/stdc++.h>

using namespace std;

int main(){

    float codigo, alcool, gasolina, diesel;

    cout<<"Informe um codigo (1, 2, 3) ou 4 para parar: "<<endl;
    cin>>codigo;

    while (codigo != 4)
    {
        if (codigo == 1){
            alcool = alcool + 1;
        }
        else if(codigo == 2){
            gasolina = gasolina + 1;
        }
        else if(codigo == 3){
            diesel = diesel + 1;
        }

        cout<<"Informe um codigo (1, 2, 3) ou 4 para parar: "<<endl;
        cin>>codigo;
    }
    
    cout<<"MUITO OBRIGADO"<<endl;
    cout<<"Alcool: "<< alcool<<endl;
    cout<<"Gasolina: "<< gasolina<<endl;
    cout<<"Diesel: "<< diesel<<endl;
}