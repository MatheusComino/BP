#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

float base1,base2;
float altura1, altura2;

int main(){
    
    cout<<"Digite a base do primeiro retangulo em cm: "<<endl;
    cin>>base1;
    cout<<"Digite a altura do primeiro retangulo em cm: "<<endl;
    cin>>altura1;
    cout<<"Digite a base do segundo retangulo em cm: "<<endl;
    cin>>base2;
    cout<<"Digite a base do segundo retangulo em cm: "<<endl;
    cin>>altura2;

    cout<<fixed<<setprecision(2);
    cout<<"A area do primeiro retangulo: "<<base1*altura1<<endl;
    cout<<"A area do segundo retangulo: "<<base2*altura2<<endl;

    if (base1*altura1 < base2+altura2){
        cout<<"A area do primeiro retangulo é maior"<<endl;
    }
    else{
        cout<<"A area do segundo retangulo é maior"<<endl;
    }
}