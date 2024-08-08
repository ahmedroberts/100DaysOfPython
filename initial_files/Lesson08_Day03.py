'''
number = int(input("Please enter a number. "))

print("This is an even number.") if (number % 2 == 0) else print("This is an odd number.")
'''

print("\n\tWelcome to the Adora Rollercoaster\n")
height = int(input("What is your height in cm? : "))

if height > 120:
    print("Enjoy the ride!")
    age = int(input("What is your age? "))
    if age <= 18:
        print("Please pay $7.")
    else:
        print("Please pay $12.")
else:
    print("Sorry, maybe next time.")
    
input()
