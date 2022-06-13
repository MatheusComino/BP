#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){

    cout<<fixed<<setprecision(2);
    
    float valorCelsius;
    cout<<"Digite a temperatura em °Celsius: ";
    cin>>valorCelsius;
    
    float valorF = (valorCelsius * 1.8) + 32;
    cout<<"O valor em °F e: "<<valorF;

}