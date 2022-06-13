#include <bits/stdc++.h>

using namespace std;

int main(){

    float X, Y ;

    cout<<"Valor de X:  "<<endl;
    cin>>X;
    cout<<"Valor de Y:  "<<endl;
    cin>>Y;

    if (X > 0 && Y > 0){
        cout<<"Q1"<<endl;
    }
    else{
        if (X < 0 && Y > 0){
            cout<<"Q2"<<endl;
        }
        else{
            if (X < 0 && Y < 0){
                cout<<"Q3"<<endl;
            }
            else{
                if (X > 0 && Y < 0){
                    cout<<"Q4"<<endl;
                }
                else{
                    if (X == 0 && Y == 0){
                        cout<<"Origem"<<endl;
                    }
                    else{
                        if (X == 0){
                            cout<<"Eixo Y"<<endl;
                        }
                        else{
                            cout<<"Eixo X"<<endl;
                        }   
                    }
                }
            }    
        }
    }
}