
#include <iostream>

using namespace std;

int main()
{
	int input;
	int divisible;
	bool prime;

	cout << "Enter a number! ";
	cin >> input;

	for (int i = 1; i < input - 1; i++) {
		if (input % (i + 1) == 0) {
			prime = false;
			divisible = i + 1;
			break;
		}
		else {
			prime = true;
		}
	}

	if (prime == true) cout << "Prime!\n";
	else cout << "Composite, divbisible by " << divisible << "\n";
}

