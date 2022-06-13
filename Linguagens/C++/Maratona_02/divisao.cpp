#include <bits/stdc++.h>

using namespace std;

int main(){

    float N, i, x, y, divisao  ;

    cout<<"Quantos casos voce vai digitar? "<<endl;
    cin>>N;

    for (int i = 0; i < N; i++)
    {
        cout<<"Entre com o numerador: "<<endl;
        cin>>x;
        cout<<"Entre com o denominador: "<<endl;
        cin>>y;

        if(y == 0){
            cout<<"DIVISAO IMPOSSIVEL"<<endl;  
        }
        else{
            divisao = x / y;
            cout<<"DIVISAO = "<<divisao<<endl;  
        }
    }
}