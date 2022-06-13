#include <bits/stdc++.h>

using namespace std;

int main(){

    string nome1, nome2;
    float idade1, idade2, media;


    cout<<"Dados da primeira pessoa: "<<endl;
    cout<<"Nome: "<<endl;
    cin>>nome1;
    cout<<"Idade: "<<endl;
    cin>>idade1;

    cout<<"Dados da segunda pessoa: "<<endl;
    cout<<"Nome: "<<endl;
    cin>>nome2;
    cout<<"Idade: "<<endl;
    cin>>idade2;

    media = (idade1 + idade2) / 2;

    cout<<"A idade media de "<< nome1<< " e "<<nome2<< " eh de "<< media <<" anos"<<endl;
}