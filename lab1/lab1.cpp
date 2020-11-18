#include <iostream>
using namespace std;

int main () 
{
	double height, rad; //висота та радіус заданих фігур
	double cylVolume, conVolume; //об'єми циліндра та конуса
	char end;
	
	cout << "Enter height and radius of the objects \nHeight: ";
	cin >> height;
	cout << "Radius: ";
	cin >> rad;
	
	// обчислення об'ємів
	cylVolume = 3.1415*(rad*rad)*height;
	conVolume = cylVolume/3;
	
	printf("Volume of the cylinder is %.3f\n", cylVolume);
	printf("Volume of the cone is %.3f\n", conVolume);
	cin >> end;
}
