#include <iostream>
#include <cmath>
using namespace std;

int main () {
	setlocale (LC_CTYPE, "ukr");
	float x, y, r1, r2;
	cout << "����i�� ���������� ����� �� �����i��i� i ����i��i� ���i��� �i����\n";
	cin >> x >> y >> r1 >> r2;
	float r = sqrt (x*x+y*y);
	if (r>=r1 && r<=r2)
		cout << "��������";
	else
		cout << "�� ��������";
}

