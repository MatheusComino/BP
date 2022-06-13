#include <bits/stdc++.h>

using namespace std;

int main(){

    int x,y;

    cout<<"Digite dois numeros inteiros: "<<endl;
    cin>>x;
    cin>>y;

    if(x % y == 0 || y % x == 0){
        cout<<"Sao multiplos"<<endl;
    }  
    else{
        cout<<"Nao sao multiplos"<<endl;
    }
}