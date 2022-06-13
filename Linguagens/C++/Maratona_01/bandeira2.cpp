#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int bandeira;
float valorBandeira;
int kilomotragem;

int main(){
    cout<<fixed<<setprecision(2);

    cout<<"Digite o numero da bandeira <1 ou 2>: "<<endl;
    cin>>bandeira;
    if(bandeira == 1){
        valorBandeira = 1.80;
    }
    else{
        valorBandeira = 2.30;
    }

    cout<<"Digite a kilometragem rodada: "<<endl;
    cin>>kilomotragem;

    cout<<"O valor da corrida e: "<<kilomotragem * valorBandeira;
}

