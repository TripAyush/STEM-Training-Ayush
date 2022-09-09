"""
for loop : Iterate any collection
"""

print("print each char without using for loop")
print("-"*20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

print("Each Char : ", my_string[0])
print("Each Char : ", my_string[1])
print("Each Char : ", my_string[2])
print("Each Char : ", my_string[3])
print("Each Char : ", my_string[4])
print("Each Char : ", my_string[5])

print("#"*40, end="\n\n")
##################

print("print each char using for loop")
print("-"*20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

for each_char in my_string:
    print("Each Char : ", each_char)
    
print("#"*40, end="\n\n")
##################

print("print each value in list/tuple/set/any other collection")
print("-"*20)
# --------------------

my_courses = ["Java", "C", "C++"]
print("my_courses : ", my_courses)

for each_course in my_courses:
    print("each_course : ", each_course)
    
print("#"*40, end="\n\n")
##################


# 2 cases
# -------------
# case - 1 : break : how to stop loop in between
# case - 2 : continue : how to skip current iteration in between
# -------------

print("# case - 1 : break : how to stop loop in between")
print("-"*20)
# --------------------

my_courses = ["Perl", "Java-1", "C", "Java-2","C++", "Java-3"]
print("my_courses : ", my_courses)

# Requirement: Findout are there any Java course. If one course found then no
# need to verify other elements, we can end the loop

for each_course in my_courses:
    # if 'Java' in each_course:
    if each_course.startswith('Java'):
        print("Found")
        break

print("#"*40, end="\n\n")
##################

print("# case - 2 : continue : how to skip current iteration in between")
print("-"*20)
# --------------------

my_courses = ["Perl", "Java-1", "C", "Java-2","C++", "Java-3"]
print("my_courses : ", my_courses)


for each_course in my_courses:
    if not each_course.startswith("Java"):
        continue
    # Below code is applicable for only java course
    print("This Java course name is : ", each_course)
    print("This Java course is available online")
    print("This java course duration is 1 month")
    print("This is one version of java")
    print("-"*10, end="\n\n")

print("#"*40, end="\n\n")
##################


"""
while loop : Based on the condition we can execute the loop
"""

print("while example - ")
print("-"*20)
# ---------------------

a = 0

while a<10:
    print("a : ", a)
    a = a + 1

print("#"*40, end="\n\n")
######################


print("print each char using for loop")
print("-" * 20)
# --------------------

my_string = "Python"
print("my_string : ", my_string)

index_no = 0
while index_no < len(my_string):
    print("Each Char : ", my_string[index_no])
    index_no = index_no + 1


print("#" * 40, end="\n\n")
##################

# 2 cases
# -------------
# case - 1 : break : how to stop loop in between
# case - 2 : continue : how to skip current iteration in between
# -------------

print("# case - 1 : break : how to stop loop in between")
print("-"*20)
# --------------------

my_courses = ["Perl", "Java-1", "C", "Java-2","C++", "Java-3"]
print("my_courses : ", my_courses)

# Requirement: Findout are there any Java course. If one course found then no
# need to verify other elements, we can end the loop

index_no = 0
while index_no < len(my_courses):
    if my_courses[index_no].startswith('Java'):
        print("Found")
        break
    index_no = index_no + 1


print("#"*40, end="\n\n")
##################

print("# case - 2 : continue : how to skip current iteration in between")
print("-"*20)
# --------------------

my_courses = ["Perl", "Java-1", "C", "Java-2","C++", "Java-3"]
print("my_courses : ", my_courses)

index_no = 0
while index_no < len(my_courses):
    if not my_courses[index_no].startswith("Java"):
        index_no = index_no + 1
        continue
    # Below code is applicable for only java course
    print("This Java course name is : ", my_courses[index_no])
    print("This Java course is avaiable online")
    print("This java course duration is 1 month")
    print("This is one version of java")
    print("-"*10, end="\n\n")
    index_no = index_no + 1

print("#"*40, end="\n\n")
##################