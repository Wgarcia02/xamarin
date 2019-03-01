#include <iostream>

using namespace std;

int main()
{
	int tam;
	cout << "dime el tamaño del vector";
	cin >> tam;
	char vector[5];
	tam = 5;
	for (int i = 0; i < tam; i++)
	{
		cin >> vector[i];

	}

	for (i = 0; i < tam; i++)
	{
		cout << vector[i] << " ";
		if (int(vector[i]) >= 65 and int(vector[i]) <= 122)
			cout << " es una letra\n";
		else
			cout << " es un número\n";
	}


}
