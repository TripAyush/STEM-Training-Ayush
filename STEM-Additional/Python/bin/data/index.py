# This can be used for multiple line comments
# This is 1st multi line comment
# This 1st multi line comment will be used for providing description about the program
# This 1st multi line comment also called as 'DOCUMENTATION STRING' or 'DOC STRING'

# About Python
# ------------------------------
# - It is Object Oriented Programming Language
# - open source
# - platform independent
# - easy learn
# - interpreted language
# - more and more libraries
# - Popularity : https://www.tiobe.com/tiobe-index/
# ------------------------------

# ------------------------------
# To write program
# ------------------------------
# OPTION - 1 : You can use any editor like notepad, vi editor etc
# OPTION - 2 : We can make use of any IDE
# - We can use IDE called IDLE which is part of python installated
# - We can use IDE called pycharm
#  - We can use IDE called notebook
#  - We can use IDE called spyder
#  - We can use IDE called vs code


# Core data types : Some of the options are avaible to store the data, which we can make use of it

# 1. Numbers : We have option to store numbers like int, float etc
#                     But we don't know how?
#                     IMMUTABLE

# 2. Strings : We have option to store collection of characters like name, emailid, address etc
#                     But we don't know how?
#                     IMMUTABLE
#                     - Automatically index no will be assigned to each character

# 3. List : We have option to store collection of values like list of names, list of emailids, list of addresses etc
#                     But we don't know how?
#                     - MUTABLE : After creating the list, throught the program, we can modify/alter like
#                         (We add elements / We can remove elements / We can update elements)
#                     - Automatically index no will be assigned to each value

# 4. Tuple : We have option to store collection of values like list of names, list of emailids, list of addresses etc
#                     But we don't know how?
#                     - IMMUTABLE: After creating the tuple, throught the program, we CAN'T modify/alter like
#                         (We CAN'T add elements / We CAN'T remove elements / We CAN'T update elements)
#                     - Automatically index no will be assigned to each value

# 5. Dictionary : We have option to store collection of values like list of names, list of emailids, list of addresses etc
#                     But we don't know how?
#                     - MUTABLE : After creating the list, throught the program, we can modify/alter like
#                         (We add elements / We can remove elements / We can update elements)
#                     - We got option to provide our own index to each value. alse called as KEY/VALUE pair

# 6. Set : We have option to store collection of values like list of names, list of emailids, list of addresses etc
#                     But we don't know how?
#                     - MUTABLE : After creating the list, throught the program, we can modify/alter like
#                         (We add elements / We can remove elements / We can update elements)
#                     - It keeps UNIQUE values, it removes duplicates
#                     - No Index
#                     - No key
#                     - Un-Ordered
#                     - We can store only IMMUTABLE objects

# 7. frozenset : IMMUTABLE set



print("Numbers PART - 1")
print("-"*20)
print("#"*40, end="\n\n")

# internally it will create object of predefined class or builtin class 'int' and store the values inside that object
a = 10
b = int(10) # same as b = 10

print(a,b)




# About print function
print("print function PART - 1")
print("-"*20)

a = 100
b = 200
c = 300
d = 400

print(a, b, c, d) # Default value of sep="SPACE". Each value will get print with SPACE separated
print(a, b, c, d, sep=",") # Each value will get printed with COMMA separated
print(a, b, c, d, sep="XYZ") # Each value will get printed with XYZ separated 

print("#"*40, end="\n\n")

print("print function PART - 2")
print("-"*20)

a = 100
b = 200
c = 300
d = 400

print(a, b, c, d) # Default end="\n". After printing all the values, put \n
print(a, b, c, d, end=".") # After printing all the values, put .
print(a, b, c, d, end="XYZ") # After printing all the values, put XYZ
print(a, b, c, d) # Default end="\n". After printing all the values, put \n

# Finally we can pass 4 arguments to print
# 1) sep 2) end 3) file 4) flush
# 3) file & 4) fulsh will be discussed during file operations

print("#"*40, end="\n\n")

