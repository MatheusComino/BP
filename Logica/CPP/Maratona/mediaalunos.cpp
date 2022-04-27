#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

    cout<<fixed<<setprecision(2);
    int notasQauntidade = 10;
    float notas;
    float notasTotal;
    float notaMaior = 0;
    float notaMenor = 100;
    
    for(int i = 1; i <= notasQauntidade; i++){
        cout<< "Digite a "<< i <<"ª nota: ";
        cin>>notas;
        notasTotal =notasTotal + notas;
        
        if(notas > notaMaior){
             notaMaior = notas;
        }
        if(notas < notaMenor){
            notaMenor = notas;
        }
    }
    float mediaNotas = notasTotal / 10;
    
    cout<< "A soma das notas e: "<<notasTotal<<endl;
    cout<<"A media das notas fornecidas e: "<<mediaNotas<<endl;
    cout<<"A maior nota a: "<<notaMaior<<endl;
    cout<<"A menor nota e: "<<notaMenor<<endl;
    
    
}
