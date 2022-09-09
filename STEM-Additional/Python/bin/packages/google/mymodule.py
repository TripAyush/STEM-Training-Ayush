"""
If we want to reuse any Variables, Functions & classes in some other programs
then instead of copy/paste from one program to another program,
we can keep those Variables, Functions & classes in separate file and reuse it
without copy paste.

Here we are keeping variables & functions which we need to reuse in some other program.

This file also called as MODULE or PYTHON LIBRARY
"""

location = "Europe"


def employee(*, name, company="XYZ Company", **prev_companies):
    print("Name : ", name)
    print("Company : ", company)
    print("prev_companies : ", prev_companies)
    return [name, company, prev_companies]