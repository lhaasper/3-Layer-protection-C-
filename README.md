What you need:

Visual Studio (Consider not using code)

A little c# and c++ knowledge

Enigma Protector/VMP (VMP is optional)


----------------------------
 
 Add the plugin to enigma and make a new string...
 The string should be set to "binary" and in the input, you put in the MD5 Checksum of the desired password
 Now you protect your file (program.cs) aka project.sln and call it extender.exe
 
 Now you go to loader.cpp and replace the "password" with your desired password...
 
 (After you compiled the loader and protected it with VMP) you can now only run the extender using the loader meaning it cant be dumped.
 
 
 
 
 Process:
Loader > Runs extender within loader.exe
extender > downloads your file through bytes and runs it off the bytes


EDIT AS OF 2020:
This can now be cracked and the method isn't safe anymore.
