"""
In Python, for each operators there is a special name given.

example:for + spacial name is __add__
example:for - spacial name is __sub__

In our class, if we want to support for any operator then we need to
provide implementation to __ methods
"""

class Employee:
    def __init__(self, n):
        self.name =n
    def __add__(self, other): # self=e1, other=e2
        # return 0 # add of 2 employee object is 0
        # return "Hello"  # add of 2 employee object is Hello
        return self.name + other.name

e1 = Employee('emp-1')
e2 = Employee('emp-2')
result = e1 + e2 # e1.__add__(e2) # __add__(e1, e2)
print("result : ", result)