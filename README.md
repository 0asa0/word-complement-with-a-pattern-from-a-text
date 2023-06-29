# word-complement-with-a-pattern-from-a-text
C# program that takes a text and a pattern from the user and prints all the words in the text that corresponds to this pattern. 

The pattern can contain letters, as well as either the character(s) of “*” or the character(s) of “-”.

The symbol “*” corresponds to any number of letters (zero or more).

The symbol “-“ corresponds to only one letter.

Examples:

Input: "Miss Polly had a poor dolly, who was sick. She called for the talled doctor Solly to come
quick. He knocked on the DOOR like a actor in the healthcare sector.";

Input: -olly

Output: Polly

 dolly
 
 Solly

 Input: *ed
 
 Output: called
 
 talled
 
 knocked 
