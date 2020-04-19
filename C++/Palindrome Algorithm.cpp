#include <iostream>

using namespace std;

string removeSpace(string s){
	string noSpace;
	
	for (int i = 0 ; i < s.size() ; i++){
		if (s[i] != ' '){
			noSpace += s[i];
		}
	}
	return noSpace;
}

bool isPalindrome(string s){
	bool isPalindrome = true;
	string nospace = removeSpace(s);
	for (int i = 0; i < s.size() / 2; i ++){
		if (nospace[i] != nospace[nospace.size() - 1 - i] ){
			isPalindrome = false;
		}
	}
	return isPalindrome;
}

int main(){
	string input;
	cout << "Input any string ";
	cin >> input;
	cout << endl;
	cout << "Palindrome: " << isPalindrome(input);
}
