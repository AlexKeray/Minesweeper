#include <iostream>

using namespace std;









int main() {

    const int MAX_PASSWORD_LENGTH = 30;

    char password[MAX_PASSWORD_LENGTH + 1];

    cout << "Въведи парола до " << MAX_PASSWORD_LENGTH << " символа: ";

    cin >> password;



    int password_length = strlen(password);

    if (password_length > MAX_PASSWORD_LENGTH) {

        cout << "грешна парола" << endl;

        return 1;

    }



    char c;

    cout << "въведи знак: ";

    cin >> c;

    while (c != '*') {

        for (int i = 0; i < password_length; ++i) {

            if (password[i] == c) {

                password[i] = '*';

            }

        }

        cout << "парола " << password << std::endl;

        cout << "въведи знак ";

        cin >> c;

    }



    return 0;

}