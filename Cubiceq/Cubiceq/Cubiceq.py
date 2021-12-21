import numpy as np

print("Рівняння виду a*x^3+b*x^2+c*x+d=0")

a = int(input("Введіть значення a: "))
b = int(input("Введіть значення b: "))
c = int(input("Введіть значення c: "))
d = int(input("Введіть значення d: "))

cof = [a,b,c,d]
print("Результат: ",np.roots(cof))