"""
2 Cases
Case -1 : How to access variables outside the function
Case -2 : How to pass values to variables present inside the function

In this section, we will discuss about,
Case -1 : How to access variables outside the function
"""

print("Function with 1 return value")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return name # Step-1

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with more than 1 return value-Tuple")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return name, company # Step-1

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with more than 1 return value-List")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return [name, company] # Step-1

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with more than 1 return value-Dictionary")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return {"name": name, "company": company} # Step-1

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with no value in return - None")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return # Step-1

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with no return statement- None")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################

print("Function with expression in return")
print("-"*20)
# ---------------------

def employee():
    name = "emp-1"
    company = "XYZ Company"
    print("Name : ", name)
    print("Company : ", company)
    return (10+20)/(10-20) # Step-1 # return the result

received_value = employee() # Step-2
print("received_value : ", received_value)

print("#"*40, end="\n\n")
#######################