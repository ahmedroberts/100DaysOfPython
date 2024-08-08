# Even Number

print('\nCheck Evens.\n')

num_max = int(input('What number shall we stop at?: '))
for x in range(num_max + 1):
  if x % 2 == 0:
    print(f'{x:>3} is even.')
  else:
    print(f'{x:>3} is odd.')

print('\nAll done.')