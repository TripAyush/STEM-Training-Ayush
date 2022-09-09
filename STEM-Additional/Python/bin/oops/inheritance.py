"""
Inheritance
"""

# Requirement: We have existing class Employee, extend that class
# to add
# 1) 2 more methods add/view tax
# 2) alter view_salary to return salary-tax


class Employee:

    def add_salary(self, n):
        self.salary = n

    def view_salary(self):
        return self.salary


class NewEmployeeClass(Employee):
    # 1) 2 more methods add/view tax
    def add_tax(self, t):
        self.tax = t
    def view_tax(self):
        return self.tax

    # 2) alter view_salary to return salary-tax
    # POLYMORPHISM, we can use same name as super class
    def view_salary(self): # This will OVERRIDE super class method
        return self.salary - self.tax

e1 = NewEmployeeClass()
e1.add_salary(20000)
e1.add_tax(2000)

print("salary : ", e1.view_salary())
print("tax: ", e1.view_tax())


"""
Multiple inheritance
"""
# Requirement: create class with below methods
# 1. add/view salary
# 2. add/view tax
# 3. add/view name


class Salary:

    def add_salary(self, n):
        self.salary = n

    def view_salary(self):
        return self.salary


class Tax:

    def add_tax(self, t):
        self.tax = t

    def view_tax(self):
        return self.tax


class Employee(Salary, Tax):
    def add_name(self, n):
        self.name = n
    def view_name(self):
        return self.name

e1 = Employee()

# Store Values
e1.add_name('emp-1')
e1.add_salary(20000)
e1.add_tax(2000)

# Print Values
print("Employee Name : ", e1.view_name())
print("Employee Salary : ", e1.view_salary())
print("Employee Tax : ", e1.view_tax())