#include <bits/stdc++.h>

using namespace std;

int main(){

    float minutos, valorPago ;

    cout<<"Digite a quantidade de minutos: "<<endl;
    cin>>minutos;

    valorPago = 50;

    if (minutos > 100){
        valorPago = valorPago + 2 * (minutos - 100);
    }
    cout<<"Valor a pagar: R$ "<<valorPago<<endl;
}