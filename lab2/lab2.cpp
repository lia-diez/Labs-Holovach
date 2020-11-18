#include <iostream>
#include <cmath>
using namespace std;

int main () {
	setlocale (LC_CTYPE, "ukr");
	float x, y, r1, r2;
	cout << "Введiть координати точки та внутрiшнiй i зовнiшнiй радiуси кiльця\n";
	cin >> x >> y >> r1 >> r2;
	float r = sqrt (x*x+y*y);
	if (r>=r1 && r<=r2)
		cout << "Належить";
	else
		cout << "Не належить";
}

