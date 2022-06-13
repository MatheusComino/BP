#include <bits/stdc++.h>

using namespace std;

int main(){

    float N, X, i, dentro, fora;

    cout<<"Quantos numeros voce vai digitar?"<<endl;
    cin>>N;

    for (int i = 0; i < N; i++)
    {
        cout<<"Digite um numero: "<<endl;
        cin>>X;

        if (X >= 10 && X <= 20){
            dentro += 1;
        }
        else{
            fora += 1;
        }
    }
    
    cout<<"dentro: "<< dentro<<endl;
    cout<<"fora: "<< fora<<endl;
}