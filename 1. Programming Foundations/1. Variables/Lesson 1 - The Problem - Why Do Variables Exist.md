Computers only understands numbers like 10101010 00110101 00001111


Example: computer memory address
Address      Value
1000         25
1001         90
1002         1500
1003         5
1004         999
Computer know value 25 is stored in memory address 1000
Instead of writing 25 in address 1000
Programmer write int age = 25; Now the programmer thinks about the age, not memory address.

Conceptually:
Programmer
age = 25
↓
Compiler
Address 1000 = 25


Variable: It refers to a place in memory where a value can be stored and retrieved.
    Variable is not the value.
    variable is not the memory itself.
    it is the name that lets us access a memory location.


Visual Representation

Variable Name
     │
     ▼
+---------+        +------------------+
|   age   | -----> | Memory Location  |
+---------+        |      1000        |
                   |      Value: 25   |
                   +------------------+


Key takeaways:
    we arenot creating a age inside the computer, we are giving the meaningful name then the compiler translates the human friendly name into the memory 
    operations the computer actually understands.
    