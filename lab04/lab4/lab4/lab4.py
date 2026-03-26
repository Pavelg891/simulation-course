import random

N = 100_000



class MCG:
    def __init__(self, seed):
        self.M = 2**63
        self.beta = 2**32 + 3
        self.x = seed  

    def next(self):
        self.x = (self.beta * self.x) % self.M
        return self.x / self.M


def mean(arr):
    return sum(arr) / len(arr)

def variance(arr, m):
    return sum((x - m) ** 2 for x in arr) / len(arr)

def autocorrelation(arr, lag=1):
    n = len(arr)
    m = mean(arr)

    num = sum((arr[i] - m) * (arr[i + lag] - m) for i in range(n - lag))
    den = sum((x - m) ** 2 for x in arr)

    return num / den

mcg = MCG(5)
arr1 = [mcg.next() for _ in range(N)]          
arr2 = [random.random() for _ in range(N)]     


mean1 = mean(arr1)
var1 = variance(arr1, mean1)
r = autocorrelation(arr1)

mean2 = mean(arr2)
var2 = variance(arr2, mean2)


theoretical_mean = 0.5
theoretical_var = 1/12


print("MCG:")
print("Среднее: ", mean1)
print("Дисперсия: ",var1)
print("Автокорреляция: ", r)


print("random.random:")
print("Среднее: ", mean2)
print("Дисперсия:", var2)

print("Теоретические значения: ")
print("Среднее: ",theoretical_mean)
print("Дисперсия: ", theoretical_var)