#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

    int numero1;
    int numero2;
    int numero3;
    
    cout<<"Voce devera digitar tres numeros inteiros diferentes: "<<endl;
    cout<<"Digite o primeiro numero :";
    cin>>numero1;
    cout<<"Digite o segundo numero :";
    cin>>numero2;
    cout<<"Digite o terceiro numero :";
    cin>>numero3;
    
    if(numero3 > numero2 && numero2 > numero1){
        cout<< "Na order crescente os numeros sao: "<< numero1 <<" "<< numero2 << " "<<  numero3; 
    }
     else if(numero3 > numero1 && numero1 > numero2){
        cout<< "Na order crescente os numeros sao: "<< numero2 <<" "<< numero1 << " "<<  numero3; 
    }
     else if(numero2 > numero1 && numero1 > numero3){
        cout<< "Na order crescente os numeros sao: "<< numero3 <<" "<< numero1 << " "<<  numero2; 
    }
     else if(numero2 > numero3 && numero3> numero1){
        cout<< "Na order crescente os numeros sao: "<< numero1 <<" "<< numero3 << " "<<  numero2; 
    }
     else if(numero1 > numero2 && numero2 > numero3){
        cout<< "Na order crescente os numeros sao: "<< numero3 <<" "<< numero2 << " "<<  numero1; 
    }
     else {
        cout<< "Na order crescente os numeros sao: "<< numero2 <<" "<< numero3 << " "<<  numero1; 
    }
}
