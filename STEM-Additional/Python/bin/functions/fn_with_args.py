"""
In this section,
Case -2 : How to pass values to variables present inside the function

2 ways to pass values
    1st way, we can pass only VALUES
    2nd way, we can pass in KEY=VALUE form

In this section,
1st way, we can pass only VALUES
"""


print("1. Function with POSITIONAL ARGUMENTS")
print("-"*20)
# ---------------------


# name, company are called POSITIONAL arguments
def employee(name, company): # pass the values in same order
    print("Name : ", name)
    print("Company : ", company)
    return [name, company] # Step-1

received_value = employee("emp-1", 'XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee("emp-2", 'XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee("emp-3", 'MNC Company') # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("2. Function with DEFAULT VALUE POSITIONAL ARGUMENTS")
print("-"*20)
# ---------------------


# name, company are called POSITIONAL arguments
def employee(name, company="XYZ Company"): # pass the values in same order
    print("Name : ", name)
    print("Company : ", company)
    return [name, company] # Step-1

received_value = employee("emp-1") # company will malke use of default value
print("received_value : ", received_value)

received_value = employee("emp-2", 'XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee("emp-3", 'MNC Company') # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("3. Function with VARIABLE POSITIONAL ARGUMENTS")
print("-"*20)
# ---------------------


# prev_companies are called VARIABLE POSITIONAL arguments
def employee(name, company="XYZ Company", *prev_companies): # pass the values in same order
    print("Name : ", name)
    print("Company : ", company)
    print("prev_companies : ", prev_companies)
    return [name, company, prev_companies] # Step-1

received_value = employee("emp-1") # company will make use of default value
print("received_value : ", received_value)

received_value = employee("emp-2", 'XYZ Company') # Step-2
print("received_value : ", received_value)

received_value = employee("emp-3", 'MNC Company') # Step-2
print("received_value : ", received_value)

received_value = employee("emp-3", 'MNC Company', "my_prev_comp_1") # Step-2
print("received_value : ", received_value)

received_value = employee("emp-3", 'MNC Company', "my_prev_comp_1", "my_prev_comp_2", "my_prev_comp_3") # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################