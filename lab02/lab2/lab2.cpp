#include <iostream>
#include <iomanip>

using namespace std;

double simulate(double Tl, double Tr, double L, double h, double dt, double total_time)
{
    const double rho = 8920;
    const double c = 380;
    const double lambda = 394;

    int Nx = (int)(L / h);
    int Nt = (int)(total_time / dt);

    double* T = new double[Nx + 1];
    double* T_new = new double[Nx + 1];
    double* alpha = new double[Nx + 1];
    double* beta = new double[Nx + 1];

    for (int i = 0; i <= Nx; i++)
        T[i] = 0;

    T[0] = Tl;
    T[Nx] = Tr;

    double A = lambda / (h * h);
    double C = A;
    double B = 2 * lambda / (h * h) + rho * c / dt;

    for (int n = 0; n < Nt; n++)
    {
        alpha[0] = 0;
        beta[0] = Tl;

        for (int i = 1; i < Nx; i++)
        {
            double F = -(rho * c / dt) * T[i];

            double denom = B - C * alpha[i - 1];

            alpha[i] = A / denom;
            beta[i] = (C * beta[i - 1] - F) / denom;
        }

        T_new[Nx] = Tr;

        for (int i = Nx - 1; i > 0; i--)
        {
            T_new[i] = alpha[i] * T_new[i + 1] + beta[i];
        }

        T_new[0] = Tl;

        for (int i = 0; i <= Nx; i++)
            T[i] = T_new[i];
    }

    double result = T[Nx / 2];

    delete[] T;
    delete[] T_new;
    delete[] alpha;
    delete[] beta;

    return result;
}

int main()
{
    double dt = 1;
    double h = 1;
    double L = 0.2;
    double Tl = 50;
    double Tr = 100;
    double total_time = 2;

    cout << fixed << setprecision(5);
    for (int i = 0; i < 4; i++) {
        dt = dt / 10;
        h = 1;
        for (int j = 0; j < 4; j++) {
            h = h / 10;
            double T_center = simulate(Tl, Tr, L, h, dt, total_time);
            cout << "dt = " << dt << ", " << "h = " << h << ", T = " << T_center << endl;
        }
    }
    return 0;
}
