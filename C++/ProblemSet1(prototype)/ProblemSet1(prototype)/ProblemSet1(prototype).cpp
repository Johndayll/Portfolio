
#include <iostream>
#include <cmath>
using namespace std;


int main()
{
	float hourIn, hourOut, minuteIn, minuteOut;
	float timeIn, timeOut, hourSpent, minuteSpent;

	cout << R"(
======================================================
 _    _       ______                       _      _ 
| |  | |      |  _  \                     | |    | |
| |  | |  ___ | | | |  ___   _ __    __ _ | |  __| |
| |/\| | / __|| | | | / _ \ | '_ \  / _` || | / _` |
\  /\  /| (__ | |/ / | (_) || | | || (_| || || (_| |
 \/  \/  \___||___/   \___/ |_| |_| \__,_||_| \__,_|                                                                                                      		
)" << endl;

	cout << "======================================================\n";
	cout << "Enter the hour in ";
	cin >> hourIn;
	cout << "Enter the minute in ";
	cin >> minuteIn;
	cout << "======================================================\n";
	cout << "======================================================\n";
	cout << "Enter the hour out ";
	cin >> hourOut;
	cout << "Enter the minute out ";
	cin >> minuteOut;
	cout << "======================================================\n";

	if (hourIn <= 8 && minuteIn <= 30) {
		if (hourOut > 17 && minuteOut >= 0) {
			cout << R"(
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
              YOU DONE DID OVERTIME!
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        )" << endl;
		}
		else if (hourOut == 17 && minuteOut == 0) {
			cout << R"(
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
               YOU WENT HOME ON TIME!
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        )" << endl;
		}
			
	}
	else {
		cout << R"(
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
               AN EARLY DISMISSAL...        
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        )" << endl;
	}

}



