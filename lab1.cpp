#include <iostream>
using namespace std;

int main () 
{
	double height, rad; //������ �� ����� ������� �����
	double cylVolume, conVolume; //��'��� ������� �� ������
	char end;
	
	cout << "Enter height and radius of the objects \nHeight: ";
	cin >> height;
	cout << "Radius: ";
	cin >> rad;
	
	// ���������� ��'���
	cylVolume = 3.1415*(rad*rad)*height;
	conVolume = cylVolume/3;
	
	printf("Volume of the cylinder is %.3f\n", cylVolume);
	printf("Volume of the cone is %.3f\n", conVolume);
	cin >> end;
}
