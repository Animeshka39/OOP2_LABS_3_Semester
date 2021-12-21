import math

print("Введіть коефіцієнти a, b, c.")
print("ax^2+bx-c=0")
while (True):

    a = float(input("a:="))
    b = float(input("b:="))
    c = float(input("c:="))

    d = b ** 2 - 4 * a * c

    print("Дискримінант D =", d)
 
    if d > 0:
        x1 = (-b + math.sqrt(d)) / (2 * a)
        x2 = (-b - math.sqrt(d)) / (2 * a)
        print("x1 =" , x1)
        print("x2 =" , x1)
    elif d == 0:
        x = -b / (2 * a)
        print("x =" ,x)
    else:
        print("Корнів немає")

    z = int(input("Почати знову? 1-Так, 2-Ні "))
    if (z == 2):
        break
