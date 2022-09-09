# In this section, we are discussing about

# 3. List : We have option to store collection of values like list of names, list of emailids, list of addresses etc
#                     But we don't know how?
#                     - MUTABLE : After creating the list, throught the program, we can modify/alter like
#                         (We add elements / We can remove elements / We can update elements)
#                     - Automatically index no will be assigned to each value

print("List PART - 1")
print("How to store the values?")
print("-"*20)
# -------------------------

my_list_1 = [10, 12.5, "Python", [100, 200]]
# Internally it will create object of predefined/builtin class 'list' and store the values
my_list_2 = list([10, 12.5, "Python", [100, 200]]) # same as my_list_2 = [10, 12.5, "Python", [100, 200]]

print("my_list_1 : ", my_list_1)
print("my_list_2 : ", my_list_2)

print("#"*40, end="\n\n")
#####################

print("List PART - 2")
print("indexes are similar to strings")
print("-"*20)
# -------------------------
# we can access each element/sub list/step etc same as string

my_courses = ["Java", "Python", ["online", "offline"] ]
print("my_courses : ", my_courses)

print("1st course : ", my_courses[0]) # "Java"
print("2nd character of 1st course : ", my_courses[0][1]) # "a"
print("teaching mode : ", my_courses[2]) # ["online", "offline"]
print("1st teaching mode : ", my_courses[2][0]) # "online"

print("#"*40, end="\n\n")
#####################

print("List PART - 3")
print("Methods inside list class")
print("-"*20)
# -------------------------

print(dir(my_courses))

print("#"*40, end="\n\n")
#####################

print("List PART - 4")
print("Trying few methods")
print("-"*20)
# -------------------------

my_courses = ["Java", "Python", "Perl" ]
print("my_courses : ", my_courses)

# add
my_courses.append('C')
print("my_courses.append('C') : ", my_courses) # ["Java", "Python", "Perl" , "C"]

# remove
removed_element = my_courses.pop() # 1) remove last element 2) return removed element
print("my_courses after pop : ", my_courses)
print("removed_element : ", removed_element)

# update python to javascript
my_courses[1] = 'Java script'
print("my_course after update python to javascript : ", my_courses)

print("#"*40, end="\n\n")
#####################