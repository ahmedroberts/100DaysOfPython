# Raikage 4th Python Day
print("\nRaikage will switch two inputs.")

# There are two variables, a and b from input
a = input("What is the first input?")
b = input("What is the second input?")
# 🚨 Don't change the code above ☝️
####################################
# Write your code below this line 👇

print("\na was entered as: " + a)
print("b was entered as: " + b)
print("~~ presto change o ~ switcheroo ~~\n")

a = str(a)
b = str(b)
c = a
a = b
b = c

# 🚨 Don't change the code below 👇
print("a: " + a)
print("b: " + b)