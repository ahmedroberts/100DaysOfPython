Calculation_001 = 8/3

Calculation_002 = 8//3

print("Calc 001  = ", Calculation_001, "Calc 002 = ", Calculation_002)

print(round(Calculation_001, 2))

score = 0
height = 1.8
isWinning = True

# f-string
my_f_string = f"your score is {score},  your height is {height}, you are winning {isWinning}"

print(my_f_string)

# Life in Weeks

current_age = input("What is your current age?: ")

years_left = 90 - int(current_age)

weeks_left = int(years_left * 52)

print(f"You have {weeks_left} weeks left. Enjoy!")