# введення радіусу та висоти об'єктів

rad = float(input("Enter height and radius of the objects \nRadius: "))
height = float(input("Height: "))

# обчислення об'єму циліндра та конуса

cylVolume = rad*rad*3.1416*height
conVolume = cylVolume/3

print ("Volume of the cylinder is %.3f" % cylVolume)
print ("Volume of the cone is %.3f" % conVolume)
a = input ("")