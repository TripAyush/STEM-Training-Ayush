"""
In this program, we are using variables & functions defined
in PYTHON LIBRARY mymodule.py
"""

print("1-way to import")
print("-"*20)
# ----------------------

import my_module
# - import will create BLANK object 'mymodule'
# - import will execute mymodule.py
# - import will keep all the objects in 'mymodule' object,
#   which created during mymodule.py execution
# - in this case, 'mymodule' object will be having 2 objects
#   1) location 2) employee
print("location : ", my_module.location)
func_result = my_module.employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("2nd-way to import")
print("-"*20)
# ----------------------

import my_module as mm

print("location : ", mm.location)
func_result = mm.employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("3rd-way to import")
print("-"*20)
# ----------------------

from my_module import location, employee

print("location : ", location)
func_result = employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("4th-way to import")
print("-"*20)
# ----------------------

from my_module import location as lc, employee as em

print("location : ", lc)
func_result = em(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("5th-way to import")
print("-"*20)
# ----------------------

from my_module import *

print("location : ", location)
func_result = employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################


# ----------------------
# PACKAGES
# ----------------------
# - We can organize modules in folders/sub folders
# - these folders called PACKAGES
# - We can directly import from the PACKAGE
# ----------------------

print("1-way to import")
print("-"*20)
# ----------------------

import packages.google.mymodule

print("location : ", packages.google.mymodule.location)
func_result = packages.google.mymodule.employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("2nd-way to import")
print("-"*20)
# ----------------------

import packages.google.mymodule as mm

print("location : ", mm.location)
func_result = mm.employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("3rd-way to import")
print("-"*20)
# ----------------------

from packages.google.mymodule import location, employee

print("location : ", location)
func_result = employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################

print("4th-way to import")
print("-"*20)
# ----------------------

from packages.google.mymodule import location as lc, employee as em

print("location : ", lc)
func_result = em(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################


print("5th-way to import")
print("-"*20)
# ----------------------

from packages.google.mymodule import *

print("location : ", location)
func_result = employee(name='emp-1', company="XYZ company",pre_comp_1="my_prev_comp")
print("func_result : ", func_result)

print("#"*40, end="\n\n")
#########################