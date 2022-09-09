# -----------------
# How Object is created?
# -----------------
# - there is a predefined/builtin class 'object'
# - inside 'object' class, we have many methods
# - 2 methods are 1) __new__ 2) __init__
# - __new__ method will construct the object
# - __init__ method will initialize the object
# - All our classes are by default accessing all methods from 'object'
#   called INHERITANCE. Means, all classes are sub class of 'object' class
# - when we create our class object, __new__ from 'object' class will be executed
#   then __init__ method will executed
# - We can rewrite any method defined in 'object', this rewriting we call it as
#   METHOD OVERRIDING
# -----------------

"""
How to get our own objects
"""

class Employee:
    pass # Empty Class

e1 = Employee()
e2 = Employee()

# 3 objects
# 1. Employee : CLASS OBJECT
# 2. e1, e2: INSTANCE OBJECTS

print("CLASS OBJECT Employee : ", Employee)
print("INSTANCE OBJECT e1 : ", e1)
print("INSTANCE OBJECT e2 : ", e2)