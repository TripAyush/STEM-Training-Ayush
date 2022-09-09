"""
for loop : Iterate any collection
"""

print("print each char without using for loop")
print("-"*20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

print("Each Char : ", my_string[0])
print("Each Char : ", my_string[1])
print("Each Char : ", my_string[2])
print("Each Char : ", my_string[3])
print("Each Char : ", my_string[4])
print("Each Char : ", my_string[5])

print("#"*40, end="\n\n")
##################

print("print each char using for loop")
print("-"*20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

for each_char in my_string:
    print("Each Char : ", each_char)
    
print("#"*40, end="\n\n")
##################

print("print each value in list/tuple/set/any other collection")
print("-"*20)
# --------------------

my_courses = ["Java", "C", "C++"]
print("my_courses : ", my_courses)

for each_course in my_courses:
    print("each_course : ", each_course)
    
print("#"*40, end="\n\n")
##################