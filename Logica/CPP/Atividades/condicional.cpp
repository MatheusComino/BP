#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main(){
    int hora;
    int horavalidade = 1;

    while (horavalidade == 1)
    {
        cout<<"Digite uma hora do dia: "<<endl;
        cin>>hora;
        if (hora <12){
            cout<<"Bom dia!"<<endl;
            
        }
        else if(hora >= 12 && hora < 18){
            cout<<"Boa tarde!"<<endl;
            
        }
        else if(hora < 24){
            cout<<"Boa noite!"<<endl;
            
        }
        else{
            cout<<"Hora Invalida"<<endl;
            horavalidade = 0;

        }
    }
    
    
    
}