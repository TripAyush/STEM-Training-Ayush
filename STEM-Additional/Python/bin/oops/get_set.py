"""
How to store the values & How to get the values
"""

class Employee:
    pass # Empty Class

e1 = Employee()

# How to store the values
# store value in object -1
Employee.company_name = "XYZ Company"
# store value in object -2
e1.name = "emp-1"

# How to get the values
print("get company_name : ", Employee.company_name)
print("get emp-1 name : ", e1.name)

# Others : How to check what variables inside any objects
print("How many variables inside 'Employee' object: ", vars(Employee))
print("How many variables inside 'e1' object: ", vars(e1))

"""
2nd way to store values & get values
"""

class Employee:
    def add_name(self, n):
        self.name = n

    def view_name(self):
        return self.name

    @classmethod
    def add_company_name(cls, cn):
        cls.company_name = cn

    @classmethod
    def view_company_name(cls):
        return cls.company_name


e1 = Employee()
e2 = Employee()

# -------------------
# Store Value
# -------------------
Employee.add_company_name('XYZ Company')
# add_company_name(Employee, 'XYZ Company')
# cls=Employee object reference, cn='XYZ Company'

e1.add_name("emp-1")
# add_name(e1, "emp-1")
# self=e1 object reference, name=emp-1

e2.add_name("emp-2") # add_name(e2, "emp-2")
# self=e2 object reference, name=emp-2
# -------------------


# -------------------
# Print the Value
# -------------------
print("Company Name : ", Employee.view_company_name())
# view_company_name(Employee), cls='Employee', return Employee.name

print("e1 name : ", e1.view_name())
# view_name(e1), self=e1, return e1.name

print("e2 name : ", e2.view_name())
# view_name(e2), self=e2, return e2.name
# Self is to hold current object reference
# -------------------

"""
3rd way to store values & get values
"""
# At the time of object creation, we are stroing the values

class Employee:

    company_name = "XYZ Company" # This will get stored inside CLASS OBJECT

    def __init__(self, n):
        self.name = n # This will get stored, in each instance object

    def view_name(self):
        return self.name

    @classmethod
    def view_company_name(cls):
        return cls.company_name


# -----------------
# Get the values from CLASS OBJECT
# -----------------
print("access company_name using CLASS OBJECT: ", Employee.company_name)
print("access company_name using CLASS METHOD: ", Employee.view_company_name())
# -----------------

# -----------------
# Store the values in INSTANCE OBJECT
# -----------------
e1 = Employee('emp-1')
# __init__(e1, 'emp-1')
    # self=e1
    # e1.name=emp-1

e2 = Employee('emp-2')
# __init__(e2, 'emp-2')
    # self=e2
    # e2.name=emp-2
# -----------------

# -----------------
# Get the values from INSTANCE OBJECT
# -----------------
print("Employee name using INSTANCE VARIABLE : ", e1.name)
print("Employee name using INSTANCE METHOD : ", e1.view_name())
# -----------------