#include <iostream>
#include <ctime>
#include <cstdlib>
#include <string>
#include <conio.h>

using namespace std;

struct Stats{
	int dice[3];
	int special;
	int value;
};

int roll(){
   return (rand()%6) + 1;
}
//Function that rolls 3 dice
Stats roll(Stats P){
	int chance = (rand()%100)+1;
    if (chance > 5){
	for (int i = 0; i < 3 ; i++){
		P.dice[i] = roll();
		cout << P.dice[i] << " ";
		P.special = 1;
		}
	}
	else/* 5% chance to get pisser */{
		P.special = -2;
		cout << "P I S S E R\n";
	}
	return P;
}
//checks for special rolls
int specials (Stats P){
   if (P.dice[0] + P.dice[1] + P.dice[2] == 3){
		cout << "Snake eyes :O\n";
		return P.special = 4;
    }
    else if (P.special == -2){
	    //pisser
	    return P.special = -2;
	}
   else if (P.dice[1] == P.dice[2] && P.dice[1] == P.dice[0] && P.dice[2] == P.dice[0]){
		cout << "A triple :O\n";
		return P.special = 3;
	}
	else if ((P.dice[0] + P.dice[1] + P.dice[2] == 15) && (P.dice[0] == 4 || P.dice[1] == 4 || P.dice[2] == 4)){
		cout << "A four five six!\n";
		return P.special = 2;
	}
	else if ((P.dice[0] == 1 || P.dice[1] == 1 || P.dice[2] == 1)&& (P.dice[0] == 2 || P.dice[1] == 2 || P.dice[2] == 2) && (P.dice[0] == 3 || P.dice[1] == 3 || P.dice[2] == 3)){
		cout << "A one two three!\n";
		return P.special = 0;
	}
	else if (P.dice[0] != P.dice[1] && P.dice[2] != P.dice[1] && P.dice[0] != P.dice[2]){
		cout << "A bust!\n";
		return P.special = -1;
	}
	else {
		//normal roll
		return P.special = 1;
	}
	
}
//checks for the odd one out
int diceValue(Stats P){
 if (P.special == 1){
	if (P.dice[0] == P.dice[1] && P.dice[2] != P.dice[1]  && P.dice[2] != P.dice[0]){
		cout << "\nValue of " << P.dice[2] << endl;
		return P.dice[2];
	}
	else if (P.dice[0] == P.dice[2] && P.dice[1] != P.dice[2] && P.dice[1] != P.dice[0]){
		cout << "\nValue of " << P.dice[1] << endl;
		return P.dice[1];
	}
	else if (P.dice[1] == P.dice[2] && P.dice[0] != P.dice[1] && P.dice[0] != P.dice[2]){
		cout << "\nValue of " << P.dice[0] << endl;
		return P.dice[0];
	} 
 }
 else if (P.special == -1 || P.special == -2) {
	return 0; //No dice value when bust/pisser
 }     	
}

Stats rollAttempts(Stats P){
	for (int i = 0 ; i < 3 ; i++){
	  		P = roll(P);//rolls dice
	  		P.special = specials(P);//checks for specials
            P.value = diceValue(P);//checks for the odd one out(if there is)
            if (P.value > 0 || P.special == -2 )/*If it's a pisser/special/normal roll, it will stop*/{
            	break;
			}
		    if (i < 2){
            cout << "rolls again..." << endl;
        }
	}
	return P;
}

int wager(int bet, int perica){
	while (bet < 100 || bet > perica){
		cout << "Enter a proper amount:";
		cin >> bet;
	}
	return bet;
}

string higherRoll (Stats me, Stats dealer, int bet, int perica, string winner){
     if ((dealer.special == -1 && me.special == -1) || (dealer.special == 0 && me.special == 0)){
     	winner = "player";
	 }
	 else if (dealer.special == -2){
	 	winner = "player";
	 }
	 else if (dealer.special == -1 && me.special == -2){
	 	winner = "draw";
	 }
	 else if (dealer.special == 0 && me.special == -2){
	 	winner = "draw";
	 }
	 else if (dealer.special > me.special){
	 	winner = "dealer";
	 }
	 else if (dealer.special < me.special){
	 	winner = "player";
	 }
	 else if(dealer.special == me.special){
	 	winner = "draw";
	 }
if (dealer.special == 1 && me.special == 1){
     if (dealer.value > me.value){
     	winner = "dealer";
	 }
	 else if (dealer.value < me.value){
	 	winner = "player";
	 }
	 else{
	 	winner = "draw";
	 	}
  }
  return winner;
}
  
int payout(Stats me, Stats dealer, int bet, int perica){
	string winner;
	winner = higherRoll(me, dealer, bet, perica, winner);
	if (winner == "dealer"){
		if (me.special == 0){/*Player got a 123*/
			perica -= bet * 2;
			cout << "You lost " << bet * 2 << " Perica :/ \n";
		}else{
			perica -= bet;
			cout << "You lost " << bet << " Perica :/ \n";
		}
	}
	else if (winner == "player"){
		if (me.special == 4){/*Snake Eyes*/
			cout << "You gain " << bet * 5 << " Perica!\n";
			perica += bet * 5;
		}
		else if (me.special == 3){/*Triple*/
			cout << "You gain " << bet * 3 << " Perica!\n";
			perica += bet * 3;
		}
		else if (me.special == 2){/*456*/
			cout << "You gain " << bet * 2 << " Perica!\n";
			perica += bet * 2;
		}
		else{/*dealer got a pisser/bust/123*/
		    cout << "You gain " << bet << " Perica!\n";
			perica += bet;
		}
	}
	else if(winner == "draw"){
		cout << "It is a draw!\n";
	}
return perica;
}

void ending(int perica){
 if (perica >= 500000 ){
 	cout << "\nYOU GOT THE BEST ENDING!!\n";
 }
 else if (perica >= 90000 ){
 	cout << "\nYOU GOT THE GOOD ENDING!\n";
}
 else if (perica < 90000 && perica > 0){
 	cout << "\nYou got the meh ending..\n";
 }
 else if (perica == 0){
 	cout << "\nYou got the bad ending...\n";
 }
 else{
 	cout << "\nYou got the WORST ending...\n";
 }
}
int main(){
	srand(time(NULL));
	system("color F0");
	Stats me;
	Stats dealer;
	int perica = 90000;
	int bet;
	cout << "~~Ola! Welcome to Underground Chinchirorin~~\n\n";
    
	for (int c = 1 ; c < 11 && perica > 100 ; c++){
	  cout << "+++Match #" << c << "+++\n\n";
	  cout << "You now have " << perica << " Perica!\n\n";
	  cout << "Place your bet!\n:";
	  cin >> bet;
	  bet = wager(bet, perica);
	  cout << "==The dealer rolls!==\n";
	  cout << endl;
	  dealer = rollAttempts(dealer);
      if (dealer.special != -2)/*will skip player roll if dealer got a pisser*/{
	  cout << "\n==Your turn to roll!==\nPress any key to continue...\n";
	  getch();
	  me = rollAttempts(me);
	  cout << endl;
  }
  perica = payout(me, dealer, bet ,perica);
  }
  ending(perica);
}

