# Short Palindrome

Consider a string, s, of n lowercase English letters where each character, si (0 < i < n), denotes the letter at index 2: in s. We define an (a, b, c, d) palindromic tuple of s to be a sequence of indices in s satisfying the following criteria:

• sa = sd, meaning the characters located at indices a and d are the same.
• sb = se, meaning the characters located at indices b and c are the same.
• 0<a<b<c<d< Isl, meaning that a, b, c, and d are ascending in value and are valid indices within string s.

Given s, find and print the number of (a, b, c, d) tuples satisfying the above conditions. As this value can be quite large, print it modulo (109 + 7).


Function Description
Complete the function shortPalindrome in the editor below.
shortPalindrome has the following paramter(s):  
- string s: a string


Returns
- int: the number of tuples, modulo (109 + 7)
