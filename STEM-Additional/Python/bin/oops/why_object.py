"""
Encapsulation and Abstraction
"""
print("in_string")
print("-"*20)
# -------------------

in_string = '''
123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"
123.123.123.123 - - [26/Apr/2000:00:23:47 -0400] "GET /asctortf/ HTTP/1.0" 200 8130 "http://search.netscape.com/Computers/Data_Formats/Document/Text/RTF" "Mozilla/4.05 (Macintosh; I; PPC)"
'''
print("#"*40, end="\n\n")
#################

print("Methods inside 'str' class ")
print("-"*20)
# -------------------

print(dir(in_string))

print("#"*40, end="\n\n")
#################

# -------------------
# Encapsulation: hide/store data & related inside the object
# -------------------
# in_string is str class object
# in_string is having log data in it
# in_string is also having some methods
# -------------------

# -------------------
# Abstraction: Through methods we can get the data without knowing its implementation
# -------------------