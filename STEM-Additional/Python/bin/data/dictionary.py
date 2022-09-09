"""
In this section, we are discussing about,
5. Dictionary : We have option to store collection of values like list of names, list of emailids, list of addresses etc
                    But we don't know how?
                    - MUTABLE : After creating the list, throught the program, we can modify/alter like
                        (We add elements / We can remove elements / We can update elements)
                    - We got option to provide our own index to each value. alse called as KEY/VALUE pair

"""

print("Dictionary PART - 1")
print("Store the values & print")
print("-"*20)
# --------------------

# We can make use of any IMMUTABLE object for KEY, Value can be any type of value
my_dictionary_1 = { 0:"Python", 1:2, 2:"Online"}
my_dictionary_2 = { "course": "Python", "duration": 2, "location": "Online"}
#it will create object of predefined class 'dict' and store the values in it

my_dictionary_3 = dict({ "course": "Python", "duration": 2, "location": "Online"})
# same as my_dictionary_3 = { "course": "Python", "duration": 2, "location": "Online"}

print("my_dictionary_1 : ", my_dictionary_1)
print("my_dictionary_2 : ", my_dictionary_2)
print("my_dictionary_3 : ", my_dictionary_3)

print("#"*40, end="\n\n")
##################

print("Dictionary PART - 2")
print("Accessing each value using key")
print("-"*20)
# --------------------

my_dictionary = { "course": "Python", "duration": 2, "location": "Online"}
print("my_dictionary : ", my_dictionary)

print("Course name : ", my_dictionary["course"]) # "Python"
print("2nd character in Course name : ", my_dictionary["course"][1]) # "y"

print("#"*40, end="\n\n")
##################

print("Dictionary PART - 4")
print("Trying few methods")
print("-"*20)
# --------------------

my_dictionary = { "course": "Python", "duration": 2, "location": "Online"}
print("my_dictionary : ", my_dictionary)

# 1 Read
print("Course Name : ", my_dictionary["course"]) # ERROR if key not found
print("Course Name : ", my_dictionary.get("course")) # It will return None if key not found

# 2 Add
my_dictionary["author"] = "abc" # if key not present then add
print("Dictionary after adding 'author' : ", my_dictionary["author"])

# 3 Update location to "India"
my_dictionary['location'] = "India" # if key present then update
print("after updating location to india : ", my_dictionary)

# 4 remove
removed_element = my_dictionary.popitem()
print("my_dictionary after popitem : ", my_dictionary)
print("removed_element : ", removed_element)

print("#"*40, end="\n\n")
##################

print("Dictionary PART - 5")
print("Trying few methods")
print("-"*20)
# --------------------

my_dictionary = { "course": "Python", "duration": 2, "location": "Online"}
print("my_dictionary : ", my_dictionary)

only_keys = my_dictionary.keys()
print('only_keys : ', only_keys)
print('type of only_keys : ', type(only_keys) )

only_values = my_dictionary.values()
print('only_values : ', only_values)
print('type of only_values : ', type(only_values) )

only_items = my_dictionary.items()
print('only_items : ', only_items)
print('type of only_items : ', type(only_items) )

print("#"*40, end="\n\n")
##################