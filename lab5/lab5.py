numb = int(input("Enter the number: "))
n = numb
while n > 9 :
	sum = int(0)
	while n > 0 :
		sum += n % 10
		n //= 10
	n = sum
print ("The digital root of the number is:", n)
a = input ("")