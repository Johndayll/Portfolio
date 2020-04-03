
#include <iostream>
#include <vector>
#include <string>

using namespace std;

class GameMove {
protected:
	int player;
public:
	virtual void ask_move(int) = 0;
};

class ConnectMove : public GameMove {
private:
	int column;
public:
	void ask_move(int p) {
		player = p;
		cout << "Aye player " << p << " what column you wanna dig this? \n>>";
		cin >> column;
		column--;
	}
	int c() {
		return column;
	}
	int p() {
		return player;
	}

};

class GameBoard {
public:
	virtual void print_board() = 0;
	virtual int check_winner() = 0;
	virtual void take_turn(GameMove*) = 0;
};

class ConnectBoard : public GameBoard {
private:
	int rows, columns;
	vector<vector<int>> connect4_board;
public:
	ConnectBoard() {
		rows = 6;
		columns = 7;
		vector<int> col(rows, 0);
		connect4_board = vector<vector<int> >(columns, col);
	}
	bool isfullcol(int c) {		
		return (connect4_board[c][0] != 0);		
	}

	bool fullBoard(vector<vector<int>> board) {
		
	}
	void print_board() {
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				if (connect4_board[j][i] == 0) {
					cout << " . ";
				}
				else if (connect4_board[j][i] == 1) {
					cout << " 1 ";
				}
				else
					cout << " 2 ";
			}
			cout << endl;
		}
	}

	int check_winner(){
		if (horizontal(connect4_board, 1) ||
			vertical(connect4_board, 1) ||
			diagUp(connect4_board, 1) || diagDown(connect4_board, 1)) {
			return 1;
		}
		else if (horizontal(connect4_board, 2) ||
			vertical(connect4_board, 2) ||
			diagUp(connect4_board, 2) || diagDown(connect4_board, 2)) {
			return 2;
		}
		else return 0;
	}
	void take_turn(ConnectMove* m) {
		if (!isfullcol(m->c())) {
			int last_empty = 0;
			while ((last_empty < rows) && (connect4_board[m->c()][last_empty] == 0)) {
				last_empty++;
			}
			last_empty--;
			connect4_board[m->c()][last_empty] = m->p();
		}
	}
	void take_turn(GameMove* m) {
		take_turn((ConnectMove*)m);
	}

	bool horizontal(const vector<vector<int>>& board, int p) {
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns - 3; j++) {
				if (board[j][i] == p && board[j + 1][i] == p && board[j + 2][i] == p && board[j + 3][i] == p) {
					return true;
				}
			}
		}
		return false;
	}
	bool vertical(const vector<vector<int>>& board, int p) {
		for (int i = 0; i < rows - 3; i++) {
			for (int j = 0; j < columns; j++) {
				if (board[j][i] == p && board[j][i + 1] == p && board[j][i + 2] == p && board[j][i + 3] == p) {
					return true;
				}
			}
		}
		return false;
	}
	bool diagUp(const vector<vector<int>>& board, int p) {
		for (int i = 0; i < rows - 3; i++) {
			for (int j = 0; j < columns - 3; j++) {
				if (board[j + 3][i] == p && board[j + 2][i + 1] == p && board[j + 1][i + 2] == p && board[j][i + 3] == p) {
					return true;
				}
			}
		}
		return false;
	}
	bool diagDown(const vector<vector<int>>& board, int p) {
		for (int i = 0; i < rows - 3; i++) {
			for (int j = 0; j < columns - 3; j++) {
				if (board[j][i] == p && board[j + 1][i + 1] == p && board[j + 2][i + 2] == p && board[j + 3][i + 3] == p) {
					return true;
				}
			}
		}
		return false;
	}
};

class ReversiMove : public GameMove {
private:
	int column, row;
public:
	void ask_move(int p) {
		player = p;
		cout << "Aye player " << p << " what column yall digging at?\n>>";
		cin >> column;
		column--;
		cout << "What Row yall digging at?\n>>";
		cin >> row;
		row--;
	}

	int c() {
		return column;
	}
	int r() {
		return row;
	}
	int p() {
		return player;
	}
};


class ReversiBoard : public GameBoard {
private:
	int columns, rows;
	vector<vector<int> > reversiBoard;
public:
	ReversiBoard() {
		rows = 8;
		columns = 8;
		vector<int> col(rows, 0);
		reversiBoard = vector<vector<int> >(columns, col);
		reversiBoard[3][3] = 1;
		reversiBoard[4][3] = 2;
		reversiBoard[4][4] = 1;
		reversiBoard[3][4] = 2;

	}
	void print_board() {
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				if (reversiBoard[j][i] == 1) {
					cout << " W ";
				}
				else if (reversiBoard[j][i] == 2) {
					cout << " B ";
				}
				else cout << " . ";
			}

			cout << endl;
		}
	}
	int check_winner() {
		int p1 = 0, p2 = 0;
		if (fullboard(reversiBoard)) {
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < columns; j++) {
					if (reversiBoard[j][i] == 1) {
						p1++;
					}
					else if(reversiBoard[j][i] == 2) p2++;
				}
			}
		}
		if (p1 > p2) {
			return 1;
		}
		else if (p2 > p1) return 2;
		else return 0;
	}
	void up(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = row - 1; (i >= 0) && (board[column][i] == player); i--) {}
		if ((i >= 0) && (board[column][i] == board[column][row])) {
			for (i = row - 1; board[column][i] == player; i--) {
				board[column][i] = board[column][row];
			}
		}
	}

	void down(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = row + 1; (i < 8) && (board[column][i] == player); i++) {}
		if ((i < 8) && (board[column][i] == board[column][row])) {
			for (i = row + 1; board[column][i] == player; i++) {
				board[column][i] = board[column][row];
			}
		}
	}
	void left(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column - 1; (i >= 0) && (board[i][row] == player); i--) {}
		if ((i >= 0) && (board[i][row] == board[column][row])) {
			for (i = column - 1; board[i][row] == player; i--) {
				board[i][row] = board[column][row];
			}
		}
	}
	void right(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column + 1; (i < 8) && (board[i][row] == player); i++) {}
		if ((i < 8) && (board[i][row] == board[column][row])) {
			for (i = column + 1; board[i][row] == player; i++) {
				board[i][row] = board[column][row];
			}
		}
	}
	void diagdl(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0, j = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column - 1, j = row + 1; (i >= 0 && j < 8) && (board[i][j] == player); i--, j++) {}
		if (((i >= 0 && j < 8) && (board[i][j]) == board[column][row])) {
			for (i = column - 1, j = row + 1; (board[i][j] == player); i--, j++) {
				board[i][j] = board[column][row];
			}
		}	
	}
	void diagdr(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0, j = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column + 1, j = row + 1; (i < 8 && j < 8) && (board[i][j] == player); i++, j++) {}
		if (((i < 8 && j < 8) && (board[i][j]) == board[column][row])) {
			for (i = column + 1, j = row + 1; (board[i][j] == player); i++, j++) {
				board[i][j] = board[column][row];
			}
		}
	}
	void diagul(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0, j = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column - 1, j = row - 1; (i >= 0 && j >= 0) && (board[i][j] == player); i--, j--) {}
		if (((i >= 0 && j >= 0) && (board[i][j]) == board[column][row])) {
			for (i = column - 1, j = row - 1; (board[i][j] == player); i--, j--) {
				board[i][j] = board[column][row];
			}
		}
	}
	void diagur(vector<vector<int>>& board, ReversiMove* m) {
		int i = 0, j = 0;
		int column = m->c();
		int row = m->r();
		int player = 3 - board[column][row];
		for (i = column + 1, j = row - 1; (i < 8 && j >= 0) && (board[i][j] == player); i++, j--) {}
		if (((i < 8 && j >= 0) && (board[i][j]) == board[column][row])) {
			for (i = column + 1, j = row - 1; (board[i][j] == player); i++, j--) {
				board[i][j] = board[column][row];
			}
		}
	}
	void take_turn(ReversiMove* m) {
		int last_empty = 0;
		if (reversiBoard[m->c()][m->r()] == 0) {
			reversiBoard[m->c()][m->r()] = m->p();
		}
		up(reversiBoard, m);
		down(reversiBoard, m);
		left(reversiBoard, m);
		right(reversiBoard, m);
		diagdl(reversiBoard, m);
		diagdr(reversiBoard, m);
		diagul(reversiBoard, m);
		diagur(reversiBoard, m);
	}
	void take_turn(GameMove* m) {
		take_turn((ReversiMove*)m);
	}

	

	bool fullboard(const vector<vector<int>>& board) {
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				if (board[j][i] == 0) return false;
			}
		}
		return true;
	}


};

class Game{
private:
	GameBoard& board;
	GameMove* turn;
	int playerturn;
	int numturns;
protected:
	int check_winner() {
		return board.check_winner();
	}

	void declare_winner() {
		if (check_winner() == 1) cout << "Player 1 wins!!!\n";

		else cout << "Player 2 wins!!!\n";

	}

	void take_turn() {
		board.print_board();
		turn->ask_move(playerturn);
		board.take_turn(turn);
		system("CLS");
	}
public:

	void startgame() {
		numturns = 0;
		playerturn = 1;
		while (check_winner() == 0) {
			take_turn();
			if (playerturn == 1) {
				playerturn = 2;
			}
			else {
				playerturn = 1;
			}
			numturns++;
		}
		declare_winner();
	}
public:
	Game(GameBoard& b, GameMove& m) : board(b) {
		turn = &m;
	}
};

int main()
{
	int choice;
	cout << "Please pick between the two games! ";
	cout << "\n[1]Connect four";
	cout << "\n[2]Reversi\n>>";
	cin >> choice;
	if (choice == 1) {
		ConnectBoard b;
		ConnectMove m;
		Game connectFour(b, m);
		connectFour.startgame();
	}
	else {
		ReversiBoard b;
		ReversiMove m;
		Game connectFour(b, m);
		connectFour.startgame();
	}

}
