'''
Ahmed Omar Roberts
The 9th Raikage
100 Days of Code - Python Exercises
Interactive coding exercises for students enrolled on the 100 Days of Code - The Complete Python Pro Bootcamp.

https://app.auditorium.ai/courses/eelyNMYJKXeNJAbjssSEQz0m88XvnhX6
'''
###################### - Day 1 - ######################

# Lesson 001 - Printing
print("Day 1 - Python Print Function")
print("The function is declared like this:")
print("print('what to print')")

# Lesson 002 - Debugging
# Fix the code below 👇
print("Day 1 - String Manipulation")
print("String Concatenation is done with the \"+\" sign.")
print("e.g. print(\"Hello \" + \"world\")")
print("New lines can be created with a backslash and n.")

# Lesson 003 - Input Function
# Provide any name in the input pane below.
# That value can be accessed using the input() function.
# Don't put anything inside the input() function!
#userName = input("What's your name?")
userName = input()
print(str(len(userName)))

# Lesson 004 - Variables
# There are two variables, a and b from input
a = input()
b = input()
# 🚨 Don't change the code above ☝️
####################################
# Write your code below this line 👇

a = str(a)
b = str(b)
c = a
a = b
b = c


# 🚨 Don't change the code below 👇
print("a: " + a)
print("b: " + b)
