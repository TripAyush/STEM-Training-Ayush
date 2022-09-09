"""
add method to compute average of 2 salaries:
If we pass 2 nos then it should return average of 2 nos
"""

class Employee:

    def add_salary(self, n):
        self.salary = n

    def view_salary(self):
        return self.salary

    # OPTION - 1
    # We dont need to reference to cls object
    # THIS WILL NOT WORK
    #
    # @classmethod
    # def compute_avg_salary(cls, sal1, sal2):
    #     return (sal1 + sal2)/2


    # OPTION -2 : WONT WORK
    # def compute_avg_salary(self, sal1, sal2):
    #     return (sal1 + sal2) / 2

    # OPTION-3
    @staticmethod
    def compute_avg_salary(sal1, sal2):
        return (sal1 + sal2)/2


e1 = Employee()
e2 = Employee()

e1.add_salary(20000)
e2.add_salary(22000)

print("e1 salary : ", e1.view_salary())
print("e2 salary : ", e2.view_salary())

s1 = e1.view_salary()
s2 = e2.view_salary()
avg = Employee.compute_avg_salary(s1, s2)
print("Avg salary : ", avg)