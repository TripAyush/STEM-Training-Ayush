"""
Get data from server_log.txt and extract
IP
DATE
PICS
URL
and send extracted info to log_report.txt & log_report.csv
"""

# ------------------------
# Our Plan - Split into smaller tasks
# ------------------------
# Task - 1 : Read data from file & keep it in a variable (list)
# Task - 2 : create log_report.txt & log_report.csv and add header
# Task - 3 : Extract Info & Send output to file
# ------------------------

print("# Task - 1 : Read data from file & keep it in a variable (list)")
print("-"*20)
# -------------------

# Step - 1: Connect to file
# ---------------------
my_file_handle = open("../log/server_log.txt", "r")

# Step - 2: Read
# ---------------------
list_of_lines = my_file_handle.readlines()

# Step - 3: disconnect
# ---------------------
my_file_handle.close()

print(list_of_lines)

print("#"*40, end="\n\n")
#################

print("# Task - 2 : create log_report.txt & log_report.csv and add header")
print("-"*20)
# -------------------

# Step - 1: Connect to file
# ---------------------
my_txt_file_handle = open('log_report.txt', 'w')
my_csv_file_handle = open('log_report.csv', 'w')

# Step - 2: Write # 1) write 2) writelines 3) print function
# ---------------------
# txt file
# my_txt_file_handle.write("IP\tDATE\tPICS\tURL\n")
# my_txt_file_handle.writelines(["IP\t", "DATE\t", "PICS\t", "URL\n"])
print("IP", "DATE", "PICS", "URL", sep="\t", file=my_txt_file_handle, flush=True)

# csv file
# my_csv_file_handle.write("IP,DATE,PICS,URL\n")
# my_csv_file_handle.writelines(["IP,", "DATE,", "PICS,", "URL\n"])
print("IP", "DATE", "PICS", "URL", sep=",", file=my_csv_file_handle, flush=True)

print("Created EMPTY file with header. Please check log_report.txt & log_report.csv\n")
print("#"*40, end="\n\n")
#################

print("# Task - 3 : Extract Info & Send output to file")
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

        print(ip, dt, im, url, sep="\t", file=my_txt_file_handle, flush=True)
        print(ip, dt, im, url, sep=",", file=my_csv_file_handle, flush=True)

my_txt_file_handle.close()
my_csv_file_handle.close()
print("Report Created. Please check 'log_report.txt' & 'log_report.csv' \n")

print("#"*40, end="\n\n")
#################
