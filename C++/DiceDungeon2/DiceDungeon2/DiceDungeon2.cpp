// DiceDungeon2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <cstdlib>
#include <algorithm>
#include <ctime>
#include <tuple>

using namespace std;

void draw(string type) {
	if (type == "Lion") {
		cout << R"(
======================================================================
            oo88888888boo
            `""88888888888bo
                ""888; `"Y888o
                   Y88;    "Y88.
                    "88.     `88b.    ,
                     `Yb      `888.   :8b
                       Yb    , `888.   88b
                        Y.    ` `"88.  Y8"8.
                         Y. `. b ``8b  :8 Y8.
           ,oooooooo      Yo :.`b`b`8;  8  8b
    ,ood8P""""""""88888oo  8b Y.:b:b:8;,8 ,:8.
,od88888bo  ` ,o.   """888o`8b`8 Y.8.88d8 : 8;
"""""""""""8oo`,. 'oo.   ""888b8b:8db8888 d :8 :;
          d8888boP , "Y88o. ""Y8888888888 8 d8.88
        o""""888888o``o'"88bood8888888888:8,;8888
      o"    ""8888888o."88888888" oooo `888d888:8
     d'    ,o8888888P88od88P""' ,d8888; Y888888:8
   ,8'     ood88888,dP"88       :888888 :88888;d;
   8'  ,o88""8888`8P   `"       888888P  8888d;8;
  d;,o8P" ,d888'oP'             "8888"    d88888boo
  8,88'  ,8888'88                 `' ,o8; "" Y88888888oooo.
 :88'   ,8888'dP,88o    :;          d88P    oooo88d888888888bo.
 `"    ,8888;,;:88888.  d8.        :8P'   ""'          :8888888888ooo
      ,88888 8,88. :88; 88;     ood"                    88888888888P"Y;
     oP d88;d;d888od"Y8  8;     ""                      :8P""Y88PYb8 :
    :P'd888`8'8b  ""Y88. 8'                             `"   `8"  YP 8
   ,P .:Y8Pd8,8Y88o.  :;                                     `"  o8 d;
  ,8'','8888;:8o   """Y8           ooood88888oooo.       o         dP
  8P  ,d88'8;:8"888oooo8;       ,o888888888888888888boo  `Y8oo.   dP
 :8bd88888 8':8ooo.  ""Yb     odP""          """888888888bo8P""'o8"
 """""8888 8 :8888888o. 8oooo888oooooooooo.       Y8888888888oo8"
     d8888 Y :bo     `""""888P"""         ""Ybo.    `"8888888""
    ,8`Y88.: :8"Y88oooooooo88.                `Ybo     Y8"
    dP'd88;:; 8o        `""Y8b                  `"b.   dP
    88`8:8;:; 88888booooood888.                   `8.  8'
   :8P:'Y88:b 8P            `8b                    `8d8'
   88 ',88888 Y8888ooooooP""""Yb                    `"
  ,8; o8888bY;8Yb '         ooo88b
  :8o8":;888'8;88bo,od8` '`'`'  Ybo
  d8"  d;888bP;o'`        ,.:o:'`"P o
  "'   8'8888d8b,;odP8;dP'`    o:;`'8 :o       '
       8 :8P8'88o`8P''    ooo'   ,oo" d8.dboo
      ,8 :`d88b,88od8888P"'   oo""  ,'" dP"88888
      :P  88888;8b 888;   oo8"'   ,P' ,8' d'88"8
      d;,dY88888.Y. Y8888""    odP' ,d" ,d'dP ,P
      8bP' Y8Y888d8o `Y8;  ood8P' ,dP  o8':P  :;
     ,P"   :8YY;88b"b  Y8888P"  o'"  o8P ,P   8  -hrr-
           `8d:`888b`bo `8b  ,o8"  ,dP' ,P   :;
            8;:dP88888Yb  Y888;   d8;  ,P    8
            8;:8 :8888b88. `Y8boo8P'  ,P    :;
            8b8' `88:;Y88"b. `Y888   ,P     8
            88'   Y88':88b."8o `"8b.oP     8'
            "'    :8Y :88888o"8o  :88o.  ,8'
                   8: 88;8Y88b88bod8"Y8oo8P
                   8.d':b8`8:P`"8888o. :8P
                   88'  Yd 88'   `"88888"
                  :8'   `8 dP       """'
                  `'     8o8
                         88'
======================================================================
        )" << endl;
	}
	else if (type == "Boar") {
		cout << R"(
============================================
              _,-""""-..__
         |`,-'_. `  ` ``  `--'""".
         ;  ,'  | ``  ` `  ` ```  `.
       ,-'   ..-' ` ` `` `  `` `  ` |==.
     ,'    ^    `  `    `` `  ` `.  ;   \
    `}_,-^-   _ .  ` \ `  ` __ `   ;    #
       `"---"' `-`. ` \---""`.`.  `;
                  \\` ;       ; `. `,
                   ||`;      / / | |
                  //_;`    ,_;' ,_;"
============================================
        )" << endl;
	}
	else if (type == "Spider") {
		cout << R"(
================================
        /\  .-"""-.  /\
       //\\/  ,,,  \//\\
       |/\| ,;;;;;, |/\|
       //\\\;-"""-;///\\
      //  \/   .   \/  \\
     (| ,-_| \ | / |_-, |)
       //`__\.-.-./__`\\
      // /.-(() ())-.\ \\
     (\ |)   '---'   (| /)
      ` (|           |) `
        \)           (/
================================
        )" << endl;
	}
	else if (type == "Wolf") {
		cout << R"(
=====================================
                          ,     ,
                          |\---/|
                         /  , , |
                    __.-'|  / \ /
           __ ___.-'        ._O|
        .-'  '        :      _/
       / ,    .        .     |
      :  ;    :        :   _/
      |  |   .'     __:   /
      |  :   /'----'| \  |
      \  |\  |      | /| |
       '.'| /       || \ |
       | /|.'       '.l \\_
       || ||             '-'
       '-''-'
=====================================
        )" << endl;
	}
	else if (type == "Elephant") {
		cout << R"(
=====================================================
              ___.-~"~-._   __....__
            .'    `    \ ~"~        ``-.
           /` _      )  `\              `\
          /`  a)    /     |               `\
         :`        /      |                 \
    <`-._|`  .-.  (      /   .            `;\\
     `-. `--'_.'-.;\___/'   .      .       | \\
  _     /:--`     |        /     /        .'  \\
 ("\   /`/        |       '     '         /    :`;
 `\'\_/`/         .\     /`~`=-.:        /     ``
   `._.'          /`\    |      `\      /(
                 /  /\   |        `Y   /  \
                J  /  Y  |         |  /`\  \
               /  |   |  |         |  |  |  |
              "---"  /___|        /___|  /__|
=====================================================
        )" << endl;
	}
	else if (type == "Slime") {
		cout << R"(
==================================
         , - ~ ~ ~ - ,
     , '               ' ,
   ,    !           !      ,
  ,                         ,
 ,               @@     @@   ,
 , !             @@     @@   ,
 ,        !                  ,
  ,                         ,
   ,                    !  ,
     ,       !          , '
       ' - , _ _ _ ,  '
==================================
        )" << endl;
	}
}

int main() {
	string input;
	cout << "Whaddya want?";
	cin >> input;
	draw(input);
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
