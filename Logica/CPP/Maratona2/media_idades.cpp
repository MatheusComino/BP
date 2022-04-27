#include <bits/stdc++.h>

using namespace std;

int main(){

    float idade, soma, cont, media;

    cout<<"Digite as idades: "<<endl;
    cin>>idade;

    while (idade >= 0)
    {
        soma = soma + idade;
        cont = cont + 1;
        cout<<"Digite as idades: "<<endl;
        cin>>idade;
    }

    if (cont == 0){
        cout<<"IMPOSSIVEL CALCULAR"<<endl;
    }
    else{
        media = soma/cont;
        cout<<"MEDIA = "<<media<<endl;
    }
}