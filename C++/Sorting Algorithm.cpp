#include <iostream>

using namespace std;

int main(){   
	int temp;
	int n = 3;
	int dices[n] = {6,5,4};
	for(int i = 0; i < n ; i++){
		for(int j = i + 1 ; j < n ; j++)
			if(dices[i]>dices[j]){
				temp = dices[i];
				dices[i] = dices[j];
				dices[j] = temp;
			}
		}
	
	for(int i = 0; i < n; i++){
		cout << dices[i] << " ";
	}
	}
	
