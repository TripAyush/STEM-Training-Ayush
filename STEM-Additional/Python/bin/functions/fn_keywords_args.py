"""
2nd way, we can pass in KEY=VALUE form
"""

print("1. Function with KEYWORD ARGUMENTS")
print("-"*20)
# ---------------------


# name, company are called KEYWORD arguments
def employee(*, name, company): # pass the values in any order
    print("Name : ", name)
    print("Company : ", company)
    return [name, company] # Step-1

received_value = employee(name="emp-1", company='XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-2", company='XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-3", company='MNC Company') # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("2. Function with DEFAULT VALUE KEYWORD ARGUMENTS")
print("-"*20)
# ---------------------


# name, company are called KEYWORD arguments
def employee(*, name, company="XYZ Company"): # pass the values in any order
    print("Name : ", name)
    print("Company : ", company)
    return [name, company] # Step-1

received_value = employee(name="emp-1") # company will malke use of default value
print("received_value : ", received_value)

received_value = employee(name="emp-2", company='XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-3", company='MNC Company') # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("3. Function with VARIABLE KEYWORD ARGUMENTS")
print("-"*20)
# ---------------------


# prev_companies are called VARIABLE KEYWORD arguments
def employee(*, name, company="XYZ Company", **prev_companies):
    print("Name : ", name)
    print("Company : ", company)
    print("prev_companies : ", prev_companies)
    return [name, company, prev_companies] # Step-1

received_value = employee(name="emp-1") # company will malke use of default value
print("received_value : ", received_value)

received_value = employee(name="emp-2", company='XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-3", company='MNC Company') # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-3", company='MNC Company', prev_1="my_prev_comp_1") # Step-2
print("received_value : ", received_value)

received_value = employee(name="emp-3", company='MNC Company', prev_1="my_prev_comp_1", prev_2="my_prev_comp_2", prev_3="my_prev_comp_3") # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################