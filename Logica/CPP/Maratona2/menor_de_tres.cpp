#include <bits/stdc++.h>

using namespace std;

int main(){

    float a, b, c, menor;

    cout<<"Primeiro Valor"<<endl;
    cin>>a;
    cout<<"Segundo Valor"<<endl;
    cin>>b;
    cout<<"Terceiro Valor"<<endl;
    cin>>c;

    if(a < b && a < c){
        menor = a; 
    }
    else{
        if(b < c){
            menor = b;
        }
        else{
            menor = c;
        }
    }

    cout<<"MENOR = "<<menor<<endl;
}