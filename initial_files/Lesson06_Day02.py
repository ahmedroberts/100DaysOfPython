'''
height = input("What is your height? : ")
weight = input("What is your weight? : ")

weight_as_int = int(weight)
height_as_float = float(weight)

bmi = (weight_as_int * 703) / (height_as_float ** 2)
bmi = round(bmi, 1)

print("Your BMI is : ", bmi)
'''

# 1st input: enter height in meters e.g: 1.65
height = input()
# 2nd input: enter weight in kilograms e.g: 72
weight = input()
# 🚨 Don't change the code above 👆

# Write your code below this line 👇
weight_as_int = int(weight)
height_as_float = float(height)

# print(weight_as_int, height_as_float)

bmi = (weight_as_int) / (height_as_float ** 2)
bmi = int(bmi)