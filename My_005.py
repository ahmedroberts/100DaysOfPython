print("\nHow many characters are in your name? : ")
nameLength = str(len(input("What is your name? : ")))
print("\nYour name has " + str(nameLength) + " characters.\n")

street_name = "Abbey Road"
print(street_name[4] + street_name[7])


a = float(123)
print(type(a))

print(70 + float(120.53))
print(str(70) + str(120.53))

print("\nWe will add the digits of a number together. ")
two_digit_number = input("Enter a two-digit number: ")
firstDigit = str(two_digit_number)[0]
secondDigit = str(two_digit_number)[1]

print(firstDigit + " + " + secondDigit + " = " + str(int(firstDigit) + int(secondDigit)) + ".\n" )

