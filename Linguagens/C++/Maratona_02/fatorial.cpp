#include <bits/stdc++.h>

using namespace std;

int main(){

    int N, fat;

    cout<<"Digite o valor de N: ";
    cin>>N;

    fat = 1;

    for (int i = 1; i <= N; i++)
    {
        fat = fat * i;
    }

    cout<<"FATORIAL = "<<fat;
}