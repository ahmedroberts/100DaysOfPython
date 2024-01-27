height = input("What is your height? : ")
weight = input("What is your weight? : ")

weight_as_int = int(weight)
height_as_float = float(weight)

bmi = (weight_as_int * 703) / (height_as_float ** 2)
bmi = round(bmi, 1)

print("Your BMI is : ", bmi)

