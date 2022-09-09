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