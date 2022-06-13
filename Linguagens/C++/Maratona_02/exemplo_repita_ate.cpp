#include <bits/stdc++.h>

using namespace std;

int main(){

    float C, F; 
    string resp;

    do
    {
        cout<<"Digite a temperatura em Celsius: "<<endl;
        cin>>C;

        F = 9.0 * C / 5.0 + 32.0;
        cout<<"Equivalente em Fahrenheit: "<<F<<endl;
        cout<<"Deseja repetir (s/n)? "<<endl;
        cin>>resp;
    } while (resp == "n");
}