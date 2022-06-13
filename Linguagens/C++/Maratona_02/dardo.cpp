#include <bits/stdc++.h>

using namespace std;

int main(){

    float d1, d2, d3, maior;

    cout<<"Digite a primeira distancias: "<<endl;
    cin>>d1;
    cout<<"Digite a segunda distancias: "<<endl;
    cin>>d2;
    cout<<"Digite a terceira distancias: "<<endl;
    cin>>d3;

    if (d1 > d2 && d1 > d3){
        maior = d1;
    }
    else if(d2 > d3){
        maior = d2;
    }
    else{
        maior = d3;
    }

    cout<<"MAIOR DISTANCIA = "<<maior<<endl;
}