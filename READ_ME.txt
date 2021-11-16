Follow instructions to install app:

1) Download "RELEASE 1.0.zip"
2) Extract it on Desktop
3) Go to Folder and Execute setup.exe
4) Follow setup instruction. If app is opening after, close it.
We need to setup MySQL in order to use app.
5) Install MySQL et MySQL Workbenck
6) Open MySQL WorkBenck, 2 cases :
- first time on this software, create an instance with those informations: 
Connection Name : bts
HostName : localhost
Username : bts
Password : P@ssw0rd
- already use the software. Connect you with your main instance, then go Server → Users and Privilegies → Add Account, fill those fields :
Login name : bts
Limit to hosts matching : localhost
Password : P@ssw0rd
Confirm password : P@ssw0rd
8) Connect with following account
9) Add a SCHEMA : right click → « Create Schema » → rename it « bts »
10) Import scripts : Server → Data Import → « Import from Dump Project Folder » → choose the path « Database »
Go to « Import progress » and Execute Import.
Tables needed to make app works are now here.
11) Launch app
12) You're done !