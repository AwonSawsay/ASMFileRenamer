# ASMFileRenamer
Program that will perform a bulk "find &amp; replace" function on an ASM (text) file, based on a user created table.

(This program is case-sensitive)  
Start by entering strings you would like to search for in the OriginalName column  
Enter the string you would like to replace it with in the NewName column  
Uncheck Enable if you would like to skip renaming this string  
Use the Save as button to save an XML file of the strings you've added  
Open XML Renaming File button to open a previously saved XML File 
Import asm662 label file button to import a renaming list from HondaRulez asm662 label.txt file 
Imported list will be saved as tempxml.xml, to save as a new name click Save as  
Check the Reverse columns upon load to reverse the OriginalName and NewName Columns  
Check Ignore "label" NewName Strings upon load to ignore any NewName string that starts with label  
Use load asm file button to open the file you would liek to perform bulk find & replace on  
Click Save renamed ASM button to save a new file prefixed RENAMED_ with the find & replace completed  

