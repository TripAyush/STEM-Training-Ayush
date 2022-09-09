"""
File Operations

Python program to communicate with external files (text files)
text files with any extension .txt, .csv, .log, .mylog etc
In short, file which can be opened in notepad
"""

'''
Steps to communicate with files
Step - 1: Connect to file
Step - 2: Read/Write
Step - 3: disconnect
'''

'''
We have functions 

Step - 1: Connect to file
    - open function

Step - 2: Read/Write
    - Write : 1) write 2) writelines 3) print function
    - Read : 1) read 2) readline 3) for loop to read line by line
    4) readlines 5) list/tuple/set/dict classes to read files

Step - 3: disconnect
    - flush() # It will not disconnect. It will send data from BUFFER to file
    - close() # 1st step, it will call flush() then 2nd step it will close()
'''

print("Write Operations")
print("-" * 20)
# ---------------------

# Step - 1: Connect to file
# ---------------------
# my_file_handle = open('provide file name or file path', 'mode')
my_file_handle = open('my_out_file.txt', 'w')
# mode 'w' : Write only
# mode 'w' : It will create new file
# mode 'w' : It will ERASE the content if file already exists

# Step - 2: Write # 1) write 2) writelines 3) print function
# ---------------------

# our data
x = 10  # int data
s = "Python\n"  # str data
x = str(x) + "\n"  # converting int to str because write & writelines expects string

# 1) write # we can pass ONE string of any length
my_file_handle.write(x)  # Send data to buffer
my_file_handle.write(s)  # Send data to buffer
my_file_handle.flush()  # Send data from buffer to file

# 2) writelines : if data in list/tuple/any collection
my_data = [x, s]  # data is in list
my_file_handle.writelines(my_data)
my_file_handle.flush()

# 3) print function
print(x.strip(), s.strip(), 20, "Java", sep="\n", end="", file=my_file_handle, flush=True)
# my_file_handle.flush() : not required to call for print

# Step - 3: disconnect
# ---------------------
my_file_handle.close()

print("All write completed. Please check 'my_out_file.txt' ")

print("#" * 40, end="\n\n")
#####################


print("Read Operations: 1) read")
print("-"*20)
# ---------------------

# Step - 1: Connect to file
# ---------------------
my_file_handle = open("my_out_file.txt", "r")
# mode "r" : Read only
# mode "r" : It will not create file if not present

# Step - 2: Read
# ---------------------
file_content = my_file_handle.read() # complete file content will be returned in string
print("file_content : ", file_content)
print("file_content RAW: ", repr(file_content))

# Step - 3: disconnect
# ---------------------
my_file_handle.close()

print("#"*40, end="\n\n")
#####################


print("Read Operations: 2) readline")
print("-"*20)
# ---------------------

# Step - 1: Connect to file
# ---------------------
my_file_handle = open("my_out_file.txt", "r")
# mode "r" : Read only
# mode "r" : It will not create file if not present

# Step - 2: Read
# ---------------------
file_content = my_file_handle.readline() # one line
print("1st line : ", file_content)

# seek pointer will be used
file_content = my_file_handle.readline() # second line
print("2nd line : ", file_content)

# we set seek to any character
my_file_handle.seek(0) # Beginning of the file, 0th char
file_content = my_file_handle.readline() # one line
print("1st line : ", file_content)

# Step - 3: disconnect
# ---------------------
my_file_handle.close()

print("#"*40, end="\n\n")
#####################