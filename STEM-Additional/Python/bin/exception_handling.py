"""
Exceptions handling
"""

print("Without handling exceptions")
print("-"*20)
# --------------------

a = 10
b = 0
# result = a/b # Program will terminate here abruptly
# print("result : ", result)

print("#"*40, end="\n\n")
######################

print("Using try-except")
print("-"*20)
# --------------------
try:
    a = 10
    b = 0
    result = a/b # Program will NOT terminate here, instead control will goto except block
    print("result : ", result)
except:
    print("Some error in try")

print("#"*40, end="\n\n")
######################

# --------------------
# One more problem in above example
# --------------------
# - for any type of error, control will come to except block
# - In except we will not be able to decide what type of error occrred
#   to provide logic to solve that error
# --------------------

# --------------------
# - For all exceptions, we have classes
#   it can be builtin/user defined
# - super class for all exception classes are 'Exception'
# - We can use class name in 'except' block
# --------------------

print("try-except with class names")
print("-"*20)
# --------------------
try:
    a = 10
    b = 0
    result = a/b
    print("result : ", result)
except ZeroDivisionError: # 1 way to mention class name
    print("It is ZDE")
except NameError as ne: # 2nd way to mention class name where we are capturing error object
    print("It is NameError and ne is : ", ne)
except (KeyError, IOError):
    print("It can KE or IE")

print("#"*40, end="\n\n")
######################

print("try-except-else")
print("-"*20)
# --------------------

try:
    a = 10
    b = 10
    result = a/b
    print("result : ", result)
except ZeroDivisionError:
    print("It is ZDE")
else:
    print("In Else")

# if try success then execute 'else' & skip 'except'
# if try failed then execute 'except' & 'else'


print("#"*40, end="\n\n")
######################

print("try-except-else-finally")
print("-"*20)
# --------------------

try:
    a = 10
    b = 10
    result = a/b
    print("result : ", result)
except ZeroDivisionError:
    print("It is ZDE")
else:
    print("In Else")
finally:
    print("In finally block")

# if try success/Failed, Finally will execute
# if except success/Failed, Finally will execute
# if else success/Failed, Finally will execute

print("#"*40, end="\n\n")
######################

print("assert")
print("-"*20)
# --------------------

try:
    a = 10
    b = 0
    assert b !=0
    # if condition fails then throw AssertionError
    # It will always throw AssertionError
    result = a/b
    print("result : ", result)
except AssertionError:
    print("It is from assert")


print("#"*40, end="\n\n")
######################

print("raise")
print("-"*20)
# --------------------

try:
    a = 10
    b = 0
    if b == 0:
        raise ZeroDivisionError

    result = a/b
    print("result : ", result)
except:
    print("It is from raise")

print("#"*40, end="\n\n")
######################

print("Custom Exception Class - 1")
print("-"*20)
# --------------------
# minimum requirement is it should be subclass of 'Exception'

class MyError(Exception):
    pass

try:
    a = 10
    b = 0
    if b == 0:
        raise MyError

    result = a/b
    print("result : ", result)
except MyError:
    print("It is from MyError")

print("#"*40, end="\n\n")
######################


print("Custom Exception Class - 2")
print("-"*20)
# --------------------
# minimum requirement is it should be subclass of 'Exception'\
# Requirement: while raising exception, pass some message

class MyError(Exception):
    def __init__(self, m):
        self.error_message=m
    def __str__(self):
        return self.error_message

try:
    a = 10
    b = 0
    if b == 0:
        raise MyError("Here b is 0 so got error")

    result = a/b
    print("result : ", result)
except MyError as me:
    #print("It is from MyError & me is : ", me.error_message)
    print("It is from MyError & me is : ", me)
    # print will execute __str__ internally before printing values,
    # if __str__ returns some value then that value will get printed

print("#"*40, end="\n\n")
######################