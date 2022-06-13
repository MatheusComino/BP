#include <bits/stdc++.h>

using namespace std;

int main(){

    float glicose ;

    cout<<"Digite a medida da glicose: "<<endl;
    cin>>glicose;

    if (glicose <= 100){
        cout<<"Normal"<<endl;
    }
    else{
        if(glicose <= 140.0){
            cout<<"Elevado"<<endl;
        }
        else{
            cout<<"Diabetes"<<endl;
        }
    }
}