
# 2. Strings : We have option to store collection of characters like name, emailid, address etc
#                     But we don't know how? IMMUTABLE Automatically index no will be assigned to each character


print("Strings PART-1")
print("-"*20)

a = 'PERSON'
# internally it will create object of predefined/builtin class called 'str' and store the value 'PERSON' in it

b = str('PERSON') # same as b = 'PERSON'
print(a, b, sep="\n")

print("#"*40, end="\n\n")

print("Strings PART-2")
print("-"*20)

c = 'PERSON'
d = "PERSON'S"
e = 'PERSON\'S'
f = '''PERSON'S HEIGHT IS XYZ" (" represents inches)'''
g = """PERSON'S HEIGHT IS XYZ" (" represents inches)"""

# COMMENT
"""PERSON'S HEIGHT IS XYZ" (" represents inches)"""

print(c, d, e, f, g, sep="\n")

print("#"*40, end="\n\n")
print("Strings PART-3")
print("-"*40)

h = "C:\newfolder\test.py" # \n will get replaced with newline \t will get replaced with tab
i = r"C:\newfolder\test.py" # r-> RAW string, \n&\t will NOT get replaced
print("Value of h: ", h)
print("Value if i : ", i)
print("Convert exsiting string h to RAW string : ", repr(h))

print("#"*40, end="\n\n")
print("List of builtins")
print("-"*40)
print(dir(__builtins__))

print("#"*40, end="\n\n")

print("Strings PART-4")
print("-"*40)

x = 10
y = 20
z = x + y

my_add_string_1 = 'add of x and y is z'
my_add_string_2 = f'add of {x} and {y} is {z}'
# f-> format. It replaces {var_name} with value

print("my_add_string_1 :", my_add_string_1)
print("my_add_string_2 :", my_add_string_2)
print("#"*40, end="\n\n")



print("Strings PART-5")
print("Access each character using index number")
print("-"*40)

my_string = "WEL COME"
print("my_string : ", my_string)

# Refer 5_strings.xlsx SECTION-1
print("0th character using +ve index no: ", my_string[0])
print("0th character using -ve index no: ", my_string[-8])

print("1st character using +ve index no: ", my_string[1])
print("1st character using -ve index no: ", my_string[-7])

# print("10th character using +ve index no: ", my_string[10]) # INDEX ERROR

print("#"*40, end="\n\n")

print("Strings PART-6")
print("Slicing : Getting substrings")
print("-"*40)

my_string = "WEL COME"
print("my_string : ", my_string)

# Refer 5_strings.xlsx SECTION-2
print("substring from index 1 to 6 using +ve index no : ", my_string[1:6])
print("substring from index 1 to 6 using -ve index no : ", my_string[-7:-2])

print("substring from index 1 to END using +ve index no : ", my_string[1:])
print("substring from index 1 to END using -ve index no : ", my_string[-7:])

print("substring from index BEGINNING to 6 using +ve index no : ", my_string[:6])
print("substring from index BEGINNING to 6 using -ve index no : ", my_string[:-2])

print("substring from index BEGINNING to END : ", my_string[:])

print("#"*40, end="\n\n")


print("Strings PART-8")
print("Reverse direction ")
print("-"*40)
# ---------------------

my_string = "WEL COME"
print("my_string : ", my_string)

# Refer 5_strings.xlsx SECTION-4

print("substring from index 6 to 1 using +ve index no & step by '-1' : ", my_string[6:1:-1])
print("substring from index 6 to 1 using -ve index no & step by '-1' : ", my_string[-2:-7:-1])
# step=-1, from 6 to 1 give me every character. 1 is end index & excluded

print("substring from index 6 to 1 using +ve index no & step by '-2' : ", my_string[6:1:-2])
print("substring from index 6 to 1 using -ve index no & step by '-2' : ", my_string[-2:-7:-2])
# step=-2, from 6 to 1 give me every 2nd character. 1 is end index & excluded

print("#"*40, end="\n\n")
##################


print("Strings PART-9")
print("Methods inside str class ")
print("-"*40)
# ---------------------

my_string = "WEL COME"
print(dir(my_string))

print("#"*40, end="\n\n")
##################

print("Strings PART-10")
print("Trying few methods ")
print("-"*40)
# ---------------------

a = "   WEL        COME       "
print("a :" , a)
      
result = a.strip() # "WEL        COME" # Works only at the ENDS
print("a.strip() : ", repr(result))
# lstrip, rstrip

b = "XYXYXYWEL XY COMEXYXYXY"
print("value of b:", b)
result = b.strip('XY') # removes all XY from both ends
print("b.strip('XY') : ", result)

result = b.removeprefix('XY')
print("b.removeprefix('XY') : ", result)

print("#"*40, end="\n\n")
##################

print("Strings PART-11")
print("Trying few methods ")
print("-"*40)
# ---------------------

my_string = "WEL COME"
print("my_string : ", my_string)

result = my_string.split()
print("my_string.split() : ", result) # ['WEL' , 'COME']

result = my_string.split('E')
print("my_string.split('E') : ", result) # ['W','L COM', ''] # split will always return 2 elements

print("#"*40, end="\n\n")
##################

print("Strings PART-12")
print("Trying few methods ")
print("-"*40)
# ---------------------

my_string = "WEL COME"
print("my_string : ", my_string)

result = my_string.index('E')
print("index of 1st E : ", result) #1

result = my_string.index('E', 3) # give me index of E which is coming after 3rd index
print("index of 1st E : ", result) # 7

result = my_string.rindex('E')
print("index of last E : ", result) #7

print("#"*40, end="\n\n")
##################

print("Strings PART-13")
print("Trying few methods ")
print("-"*40)
# ---------------------

my_string = "123"
print("my_string : ", my_string)

result = my_string.isdigit()
print("my_string.isdigit() : ", result) #True

my_string = "abcsdfdsfds123"
print("my_string : ", my_string)

# check whether last 3 chars are digit
last_3_chars = my_string[-3:]

result = last_3_chars.isdigit()
print("last_3_chars.isdigit() : ", result) #True

print("#"*40, end="\n\n")
##################