#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int isZero = 1;
int numeroDigitado;
int numerosSomados;

int main(){

    cout<<"Digite o primeiro numero"<<endl;
    cin>>numeroDigitado;
    while (isZero == 1)
    {
        if(numeroDigitado == 0){
            isZero = 0;
            cout<<numerosSomados;
        }
        else{
            numerosSomados += numeroDigitado;
            cout<<"Digite o outro numero"<<endl;
            cin>>numeroDigitado;
        }
    }
}