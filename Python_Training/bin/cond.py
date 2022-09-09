"""
conditional statement 'if': Based on the condition, we can execute the block of code
"""

'''
In some languages,
if condn{
s1
    s2
        s3
    s4
s5
}
s6

In python we wont use {} to make bock of code
instead we use INDENTATION
if condn
        s1
        s2
        s3
        s4
        s5
s6
'''
print("Only if ")
print("-"*20)
# --------------------

x = 10
if x == 10:
    print("value of x is 10")
if x > 10:
    print("Value of x is greater than 10")
if x < 10:
    print("Value of x is less than 10")

print("#"*40, end="\n\n")
##################

print("if-elif ")
print("-"*20)
# --------------------

x = 10
if x == 10:
    print("value of x is 10")
elif x > 10:
    print("Value of x is greater than 10")
elif x < 10:
    print("Value of x is less than 10")

print("#"*40, end="\n\n")
##################

print("if-elif-else ")
print("-"*20)
# --------------------

x = 10
if x == 10:
    print("value of x is 10")
elif x > 10:
    print("Value of x is greater than 10")
else:
    print("Value of x is less than 10")

print("#"*40, end="\n\n")
##################


print("if with strings ")
print("-"*20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

if (my_string != "Java") and (my_string != "C"):
    print("Not Java or C")

if "yth" in my_string:
    print("substring 'yth' found")

print("#"*40, end="\n\n")
##################

print("if with list/tuple/set/any other collections ")
print("-"*20)
# --------------------

my_courses = ["Java", "C", "C++"]
print("my_courses : ", my_courses)

if "C" in my_courses:
    print("Course C is present")

print("#"*40, end="\n\n")
##################