#include <bits/stdc++.h>

using namespace std;

int main(){

    float nota1, nota2, notaFinal;

    cout<<"Digite a primeira nota: "<<endl;
    cin>>nota1;
    cout<<"Digite a segunda nota:"<<endl;
    cin>>nota2;

    notaFinal = nota1 + nota2;

    cout<<"NOTA FINAL = "<<notaFinal<<endl;
    
    if(notaFinal <60){
        cout<<"REPROVADO"<<endl;
    }
}