"""
Functions Without Args

Functions: While coding if we want to rewrite same code more than one time
then instead of rewriting same code OR copy/paste, we can keep that code
in a block and execute that block whenever you want
"""

print("Without using function")
print("-"*20)
# ---------------------

a = 10
b = 20
c = a + b
print("c : ", c)

a = 10
b = 20
c = a + b
print("c : ", c)

a = 10
b = 20
c = a + b
print("c : ", c)


print("#"*40, end="\n\n")
#######################

print("Using function")
print("-"*20)
# ---------------------


def my_func():
    a = 10
    b = 20
    c = a + b
    print("c : ", c)


my_func()
my_func()
my_func()

print("#"*40, end="\n\n")
#######################

print("Just another function")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)

employee()
employee()
employee()
employee()

print("#"*40, end="\n\n")
#######################