from random import randint
import math

def SumOfDigits(a, b, c):
    sum = FirstDigit(a) + FirstDigit(b) + FirstDigit(c)
    return int(sum)

def FirstDigit(n):
    quan = int(math.floor(math.log10(n + 0.5)))
    digit = n / 10**quan
    return digit

def RandNum():
    numb = int(randint (1, 10000))
    return numb

a = RandNum();
b = RandNum();
c = RandNum();
print("Numbers are", a, b, c)
sum = SumOfDigits(a, b, c)
print("The sum of first digits of numbers is", sum)

a = input()