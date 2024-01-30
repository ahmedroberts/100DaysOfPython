'''
Ahmed's Tip Calculator
Monday, January 29th, 2024
https://replit.com/@ahmedroberts/100Daystip-calculator#main.py
'''

print("Welcome to the tip calculator.")
bill_total = float(input("What was the total bill? "))
tip_percentage = float(input("What percentage tip would you like to give?\n 10, 12, or 15? "))
number_of_people = int(input("How many people to split the bill? "))

tip_at = 1 + (tip_percentage * .01)
#print("Tip At :", tip_at)

#print(f"Bill: {bill_total}, Tip: {tip_percentage}, People: {number_of_people}.")
each_owes = (bill_total / number_of_people) * tip_at
# The Format Rounds inside the f-string
FORMAT_2DP = "{:.2f}"
#print(f"\nEach owes: ${FORMAT_2DP.format(each_owes)}")
print(f"Each person should pay: ${FORMAT_2DP.format(each_owes)}")