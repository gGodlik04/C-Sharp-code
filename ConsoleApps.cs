/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    cout.precision(3);
    cout << fixed;
    double z = 0, x = 0, a = 0, b = 0;
    cin >> x >> a >> b;
    z = log(pow(tan(x / a - x / b), 2)) + exp(a);
    cout << z << endl;
}

*/

/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    cout.precision(3);
    cout << fixed;
    double z = 0, x = 0, a = 0;
    cin >> x >> a;
    z = (log(cos(x))) / (a * pow(sin(x), 2)) + sqrt(a * (tan(x)));
    cout << z << endl;
}

*/

/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    cout.precision(3);
    cout << fixed;
    double y = 0, x = 0, a = 0, b = 0;
    cin >> a >> b >> x;
    sqrt(a - b) < x ? y = a * pow(x, 2) + b * log(fabs(2 * x)) : y = sqrt(a + sin(2 * x)) - exp(abs(3 * x));
    cout << y << endl;
}

*/

/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	cout.precision(3);
	cout << fixed;
	double x = 0, a = 0, b = 0;
	cin >> a >> b >> x;
	if (pow(x, 2) - pow(b, 2) < 3)
		cout << exp(2 * atan(a) + 3 * atan(b));
	else if (pow(x, 2) - pow(b, 2) == 3)
		cout << (abs(x - b) / (1 + 2 * x) - exp(2 * (x - b)) + pow(sin(x), 2));
	else
		cout << log(pow(x, 2) + pow(b, 2)) + sin(a);
}

*/

/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	cout.precision(3);
	cout << fixed;
	double x = 0.2, A = 0, P = 0;
	cin >> A;
	while (x < 7.4)
	{
		P = (sqrt(A) * cos(5 * x)) / (3 + 2 * sin(5 * x)) - atan(sin(A));
		x = x + 0.8;
		cout << P << endl;
	}
}

*/

/*
Вычисление ф-ии

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	cout.precision(3);
	cout << fixed;
	double x = 0.3, A = 0, H = 0;
	cin >> A;
	do
	{
		H = (sin(A - pow(x, 2)) - sqrt(pow(A, 2) + pow(x, 2))) / (pow(A, 2) * sqrt(x));
		cout << H << endl;
		x = x + 0.2;
	} while (x < 1.9);
}
*/
