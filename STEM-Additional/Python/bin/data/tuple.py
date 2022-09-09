"""
In this section,
4. Tuple : We have option to store collection of values like tuple of names, tuple of emailids, tuple of addresses etc
                    But we don't know how?
                    - IMMUTABLE: After creating the tuple, throught the program, we CAN'T modify/alter like
                        (We CAN'T add elements / We CAN'T remove elements / We CAN'T update elements)
                    - Automatically index no will be assigned to each value

"""
print("tuple PART - 1")
print("How to store the values?")
print("-"*20)
# -------------------------

my_tuple_1 = (10, 12.5, "Python", [100, 200])
# Internally it will create object of predefined/builtin class 'tuple' and store the values
my_tuple_2 = tuple([10, 12.5, "Python", [100, 200]]) # same as my_tuple_2 = [10, 12.5, "Python", [100, 200]]

print("my_tuple_1 : ", my_tuple_1)
print("my_tuple_2 : ", my_tuple_2)

print("#"*40, end="\n\n")
#####################

print("tuple PART - 2")
print("indexes are similar to strings")
print("-"*20)
# -------------------------
# we can access each element/sub tuple/step etc same as string

my_courses = ("Java", "Python", ["online", "offline"] )
print("my_courses : ", my_courses)

print("1st course : ", my_courses[0]) # "Java"
print("2nd character of 1st course : ", my_courses[0][1]) # "a"
print("teaching mode : ", my_courses[2]) # ["online", "offline"]
print("1st teaching mode : ", my_courses[2][0]) # "online"

print("#"*40, end="\n\n")
#####################

print("tuple PART - 3")
print("Methods inside tuple class")
print("-"*20)
# -------------------------

print(dir(my_courses))

print("#"*40, end="\n\n")
#####################

print("tuple PART - 4")
print("Trying few methods")
print("-"*20)
# -------------------------

my_courses = ("Java", "Python", "Perl" )
print("my_courses : ", my_courses)

index_of_python  = my_courses.index("Python")
print("index_of_python : ", index_of_python) # 1

count_of_python  = my_courses.count("Python")
print("count_of_python : ", count_of_python) # 1

print("#"*40, end="\n\n")
#####################