"""
From below string extract
ip : 123.123.123.123
dt : 26/Apr/2000
pics : wpaper.gif
url : http://www.jafsoft.com/asctortf/ 
"""

print("in_string")
print("-"*20)
# -------------------

in_string = '123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"'
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

in_string = '123.123.123.123 - - [26/Apr/2000:00:23:48 -0400] "GET /pics/wpaper.gif HTTP/1.0" 200 6248 "http://www.jafsoft.com/asctortf/" "Mozilla/4.05 (Macintosh; I; PPC)"'
print(repr(in_string))

print("#"*40, end="\n\n")
#################

print("Extract IP - 1 - way")
print("-"*20)
# -------------------

ip = in_string[0:15]
print(ip)

print("#"*40, end="\n\n")
#################

print("Extract IP - 2 - way")
print("-"*20)
# -------------------

index_of_1st_space = in_string.index(" ")
ip = in_string[0:index_of_1st_space]
print(ip)

print("#"*40, end="\n\n")
#################

print("Extract IP - 3 - way")
print("-"*20)
# -------------------

sp = in_string.split() # split by space
print("sp : ", sp)

ip = sp[0]
print(ip)

print("#"*40, end="\n\n")
#################

print("Extract Date")
print("-"*20)
# -------------------

raw_date = sp[3] # '[26/Apr/2000:00:23:48'
index_of_1st_colon = raw_date.index(":")
dt = raw_date[1:index_of_1st_colon]
print(dt)

print("#"*40, end="\n\n")
#################

print("Extract Pics")
print("-"*20)
# -------------------

raw_pic = sp[6] # '/pics/wpaper.gif'

# 1
raw_pic_sp = raw_pic.split("/") # ['','pics', 'wpaper.gif']
im1 = raw_pic_sp[2]
im2 = raw_pic_sp[-1]

#2
last_slash_index = raw_pic.rindex('/')
im3 = raw_pic[last_slash_index+1 : ]

#3
im4 = raw_pic.removeprefix("/pics/")

print(im1, im2, im3, im4, sep="\n")

print("#"*40, end="\n\n")
#################


print("Extract URL")
print("-"*20)
# -------------------

url = sp[10] # '"http://www.jafsoft.com/asctortf/"'
url = url[1:-1]
print(url)
print("#"*40, end="\n\n")
#################