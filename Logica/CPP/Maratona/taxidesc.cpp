#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

    cout<<fixed<<setprecision(2);

    int bandeira;
    float bandeiraKm1 = 1.80;
    float bandeiraKm2 = 2.30;
    float kmRodada;
    float taxaminima = 3.50;
    string desconto;
    cout<< "Digite o numero da bandeira <1 ou 2>: ";
    cin>> bandeira;

    cout<< "Digite a kilometragem rodada: ";
    cin>> kmRodada;

    cout<< "O Taxi oferece um desconto <1 - SIM ou 2 - NAO>: ";
    cin>> desconto;
    
    if(bandeira == 1 && kmRodada > 1 && desconto == "SIM"){
        cout<<"Valor da corrida é R$ "<< (bandeiraKm1 * kmRodada) * 0.7;

    }
    
    else if(bandeira == 1 && kmRodada > 1 && desconto == "NAO"){
        cout<<"Valor da corrida é R$ "<< bandeiraKm1 * kmRodada;
    }
    else if(bandeira == 1 && kmRodada <= 1){
        cout<<"Valor da corrida é R$ "<< taxaminima; 

    }
    else if(bandeira == 2 && kmRodada > 1 && desconto == "SIM" ){
        cout<<"Valor da corrida é R$ "<< (bandeiraKm2 * kmRodada) * 0.7; 
    } 
    
    else if(bandeira == 2 && kmRodada > 1 && desconto == "NAO" ){
        cout<<"Valor da corrida é R$ "<< bandeiraKm2 * kmRodada; 
    } 
    else{
        cout<<"Valor da corrida é R$ "<< taxaminima;
    }

}
