"""
In this section, we are discussing about,

7. frozenfrozenset : IMMUTABLE frozenset
"""

print("frozenset PART - 1")
print("-"*20)
# ----------------------

my_frozenset_1 = frozenset({10, 10, 10, "Java", "Java", "Perl"})
# internally it will create object of predefined/builtin classe 'frozenset' and store the values
# inside {}, if we provide key:val then it will become dictionary
my_frozenset_2 = frozenset({10, 10, 10, "Java", "Java", "Perl"})

print("my_frozenset_1 : ", my_frozenset_1)
print("my_frozenset_2 : ", my_frozenset_2)

my_list = list(my_frozenset_1)
print("frozenset to list : ", my_list)

print("#"*40, end="\n\n")
###################


print("frozenset PART - 2")
print("Methods inside 'frozenset' class")
print("-"*20)
# ----------------------

print(dir(my_frozenset_1))

print("#"*40, end="\n\n")
###################

print("frozenset PART - 3")
print("Trying few methods")
print("-"*20)
# ----------------------

java_course_participants = frozenset({'student-1', 'student-2', 'student-3', 'student-4'})
C_course_participants = frozenset({'student-3', 'student-4', 'student-5', 'student-6'})

# union : OR 
complete_student_list = java_course_participants.union(C_course_participants)
print("complete_student_list : ", complete_student_list)

# intersection : AND
students_attending_both = java_course_participants.intersection(C_course_participants)
print("students_attending_both : ", students_attending_both)

# difference : set1 - set2
student_having_only_java = java_course_participants.difference(C_course_participants)
print("student_having_only_java : ", student_having_only_java)

print("#"*40, end="\n\n")
###################