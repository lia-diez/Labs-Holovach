import math

x = float(input("x:"))
y = float(input("y:"))
r1 = float(input("r1:"))
r2 = float(input("r2:"))
r = math.sqrt(x*x+y*y)
if (r>=r1 and r<=r2):
	print("Належить")
else:
	print("Не належить")
end = input("")