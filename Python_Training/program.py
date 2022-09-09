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

in_string = '''
123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"
123.123.123.123 - - [26/Apr/2000:00:23:47 -0400] "GET /asctortf/ HTTP/1.0" 200 8130 "http://search.netscape.com/Computers/Data_Formats/Document/Text/RTF" "Mozilla/4.05 (Macintosh; I; PPC)"
'''
# mylist = []
# mylist.append("orange")
# for item in in_string:
#     sp = item.split()
#     ip = sp[0]

#     print("IP is ",ip)
#     mylist.append(ip)

#     date = sp[3]
#     req_date = date.split(":")
#     print ("Date ",req_date[0][1])
#     mylist.append(req_date[0][1])

#     picture = sp[6]
#     req_pic = picture.split("/")
#     if(req_pic[2] == ""):
#         print("No Image")
#         mylist.append("No Image")
#     else:
#         print ("Pic ",req_pic[2])
#         mylist.append(req_pic[2])

    
#     url = sp[10]
#     url.split('"')
#     print ('URL ',url)
#     mylist.append(url)

# print(mylist)

# mylist = []
# mystring = in_string.split()
# mylist.append(mystring[0])
# print(mylist)

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