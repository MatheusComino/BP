#include <bits/stdc++.h>

using namespace std;

int main(){

    float X, Y ;

    cout<<"Digite um numero"<<endl;
    cin>>X;
    cout<<"Digite um outro numero"<<endl;
    cin>>Y;

    while (X != Y)
    {
        if (X < Y){
            cout<<"DECRESCENTE"<<endl;
        }
        else if(X > Y){
            cout<<"CRESCENTE"<<endl;
        }

        cout<<"Digite um numero"<<endl;
        cin>>X;
        cout<<"Digite um outro numero"<<endl;
        cin>>Y;
    }
}