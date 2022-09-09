"""
From below string
Extract
IP
DATE
PICS
URL
from each line

NOTE: if /pics/ present then extract image name and print else print 'No Image'

Final Output:
123.123.123.123  26/Apr/2000  wpaper.gif  http://www.jafsoft.com/asctortf/
123.123.123.123  26/Apr/2000  No Image  http://search.netscape.com/Computers/Data_Formats/Document/Text/RTF
"""

print("in_string")
print("-"*20)
# -------------------

in_string = '''
123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"
123.123.123.123 - - [26/Apr/2000:00:23:47 -0400] "GET /asctortf/ HTTP/1.0" 200 8130 "http://search.netscape.com/Computers/Data_Formats/Document/Text/RTF" "Mozilla/4.05 (Macintosh; I; PPC)"
'''
print(in_string)

print("#"*40, end="\n\n")
#################

print("type of in_string")
print("-"*20)
# -------------------

print(type(in_string))

print("#"*40, end="\n\n")
#################

print("Methods inside 'str' class ")
print("-"*20)
# -------------------

print(dir(in_string))

print("#"*40, end="\n\n")
#################

print("raw format of in_string")
print("-"*20)
# -------------------

print(repr(in_string))

print("#"*40, end="\n\n")
#################

print("make list of lines")
print("-"*20)
# -------------------

list_of_lines = in_string.split("\n")
print(list_of_lines)

print("#"*40, end="\n\n")
#################


print("print each line using for loop")
print("-"*20)
# -------------------

for each_line in list_of_lines:
    print("each_line : ", each_line)

print("#"*40, end="\n\n")
#################

print("filter IP address line")
print("-"*20)
# -------------------

for each_line in list_of_lines:
    # if each_line != '':
    # if each_line[:3].isdigit():
    if each_line.startswith('123'):
        print("each_line : ", each_line)

print("#"*40, end="\n\n")
#################

print("Extract Info")
print("-"*20)
# -------------------

for each_line in list_of_lines:
    if each_line.startswith('123'):

        sp = each_line.split()

        ip = sp[0]

        raw_date = sp[3]  # '[26/Apr/2000:00:23:48'
        index_of_1st_colon = raw_date.index(":")
        dt = raw_date[1:index_of_1st_colon]

        raw_pic = sp[6]  # '/pics/wpaper.gif'
        if raw_pic.startswith("/pics/"):
            raw_pic_sp = raw_pic.split("/")  # ['','pics', 'wpaper.gif']
            im = raw_pic_sp[-1]
        else:
            im = "No Image"

        url = sp[10]  # '"http://www.jafsoft.com/asctortf/"'
        url = url[1:-1]

        print(ip, dt, im, url)

print("#"*40, end="\n\n")
#################




"""
write 2nd program using while loop
"""
print("in_string")
print("-"*20)
# -------------------

in_string = '''
123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"
123.123.123.123 - - [26/Apr/2000:00:23:47 -0400] "GET /asctortf/ HTTP/1.0" 200 8130 "http://search.netscape.com/Computers/Data_Formats/Document/Text/RTF" "Mozilla/4.05 (Macintosh; I; PPC)"
'''
print(in_string)

print("#"*40, end="\n\n")
#################

print("type of in_string")
print("-"*20)
# -------------------

print(type(in_string))

print("#"*40, end="\n\n")
#################

print("Methods inside 'str' class ")
print("-"*20)
# -------------------

print(dir(in_string))

print("#"*40, end="\n\n")
#################

print("raw format of in_string")
print("-"*20)
# -------------------

print(repr(in_string))

print("#"*40, end="\n\n")
#################

print("make list of lines")
print("-"*20)
# -------------------

list_of_lines = in_string.split("\n")
print(list_of_lines)

print("#"*40, end="\n\n")
#################


print("print each line using for loop")
print("-"*20)
# -------------------
line_no = 0
while line_no < len(list_of_lines):
    print("each_line : ", list_of_lines[line_no])
    line_no = line_no + 1

# for each_line in list_of_lines:
#     print("each_line : ", each_line)

print("#"*40, end="\n\n")
#################

print("filter IP address line")
print("-"*20)
# -------------------

line_no = 0
while line_no < len(list_of_lines):
    if list_of_lines[line_no].startswith('123'):
        print("each_line : ", list_of_lines[line_no])
    line_no = line_no + 1

# for each_line in list_of_lines:
#     # if each_line != '':
#     # if each_line[:3].isdigit():
#     if each_line.startswith('123'):
#         print("each_line : ", each_line)

print("#"*40, end="\n\n")
#################

print("Extract Info")
print("-"*20)
# -------------------

line_no = 0
while line_no < len(list_of_lines):
    if list_of_lines[line_no].startswith('123'):
# for each_line in list_of_lines:
#     if each_line.startswith('123'):

        sp = list_of_lines[line_no].split()

        ip = sp[0]

        raw_date = sp[3]  # '[26/Apr/2000:00:23:48'
        index_of_1st_colon = raw_date.index(":")
        dt = raw_date[1:index_of_1st_colon]

        raw_pic = sp[6]  # '/pics/wpaper.gif'
        if raw_pic.startswith("/pics/"):
            raw_pic_sp = raw_pic.split("/")  # ['','pics', 'wpaper.gif']
            im = raw_pic_sp[-1]
        else:
            im = "No Image"

        url = sp[10]  # '"http://www.jafsoft.com/asctortf/"'
        url = url[1:-1]

        print(ip, dt, im, url)
    line_no = line_no + 1

print("#"*40, end="\n\n")
#################