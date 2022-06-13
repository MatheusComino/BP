#include <bits/stdc++.h>

using namespace std;

int main(){

    float quantidade, valorPago;
    int codigo;

    cout<<"Codigo do produto comprado: "<<endl;
    cin>>codigo;
    cout<<"Quantidade comprada: "<<endl;
    cin>>quantidade;

    switch (codigo)
    {
    case 1:
        valorPago = 5.0 * quantidade;
        break;
    case 2:
        valorPago = 3.5 * quantidade;
        break;
    case 3:
        valorPago = 4.8 * quantidade;
        break;
    case 4:
        valorPago = 8.9 * quantidade;
        break;
    case 5:
        valorPago = 7.32 * quantidade;
        break;
    default:
        break;
    }

    cout<<"Valor a pagar: R$ "<<valorPago<<endl;
}