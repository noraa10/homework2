/*
 

EXERCISES 
1.1 Suppose you have a sorted list of 128 names, and you’re searching  
through it using binary search. What’s the maximum number of  
steps it would take?

 
 _For a sorted list of 128 names using binary search, the maximum number of steps it would take is 7. This is because 128 = 2^7. Each time we cut the list in half is 1 step with binary search. Since we can double 7 times to reach 128, the maximum steps is 7.


1.2 Suppose you double the size of the list. What’s the maximum  
number of steps now?

 _Now if we double the size of the list to 256 names, the maximum steps increases too. 256 = 2^8. So now with a list of size 256, the maximum number of steps for binary search would be 8. 

Each time we double the size of the input, we add 1 to the exponent. And because the exponent tells us the number of steps, increasing the size means increasing the maximum steps by 1 as well.


 
1.3 You have a name, and you want to find the person’s phone number  
in the phone book.


- We want to find a person's phone number in the phone book.  
- The phone book lists names in alphabetical order.
- This allows us to use a search method called binary search.
- Binary search works by cutting the search space in half each step.
- We keep cutting the remaining names in half until we find the number.
- This takes around log(n) steps where n is the number of names, also known as log time.



1.4 You have a phone number, and you want to find the person’s name  
in the phone book. (Hint: You’ll have to search through the whole  
book!)


- We only know the phone number, not the name.  
- In this case, we must look at each name one by one.
- This is called a linear search.
- A linear search takes around n steps to find the number, also known as liner time



1.5 You want to read the numbers of every person in the phone book.

- We need to look at every single name and number  
- So this also takes around n steps, like a linear search , also known as liner time


1.6 You want to read the numbers of just the As. (This is a tricky one!  
It involves concepts that are covered more in chapter 4. Read the  
answer—you may be surprised!)

- For this question, we only want names starting with the letter A
- But the phone book may not list all the A names together
- So we still may need to look at all names 
- This would also take around n steps, like a linear search , also known as liner time

  
 */