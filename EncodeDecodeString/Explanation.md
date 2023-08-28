# Code Explanation ([Problem](https://www.lintcode.com/problem/659/))

### `Encode(List<string> strs)`

1. `var builder = new StringBuilder();`: This line creates a new instance of the `StringBuilder` class, which is used to efficiently build strings by concatenating multiple parts.

2. `foreach (var word in strs)`: This line starts a loop that iterates through each string `word` in the input list `strs`.

3. Inside the loop:
    - `builder.Append($"{word.Length}#{word}");`: This line appends to the `builder` the length of the current `word`, followed by a '#' character, and then the `word` itself. This forms a pattern where each word is encoded as "length#word".

4. After the loop completes:
    - `return builder.ToString();`: This line returns the concatenated string that was built using the `builder`. This string is the encoded representation of the input list of strings.

### `Decode(string str)`

1. `var l = 0;`: This line initializes a variable `l` that will be used as an index to traverse the input encoded string `str`.

2. `var result = new List<string>();`: This line creates an empty list `result` where the decoded strings will be stored.

3. `var wordLength = "";`: This line initializes an empty string `wordLength` which will be used to accumulate the length of the upcoming word in the encoded string.

4. The following lines start a `while` loop that continues as long as the index `l` is within the bounds of the input string `str`:

    - `if (str[l] != '#')`: This condition checks if the character at index `l` in the `str` is not equal to '#'. If true, it means the current character is part of the length of the upcoming word.
        - `wordLength += str[l];`: This line appends the current character to the `wordLength` string.
        - `l++;`: Increments the index `l` to move to the next character in the string.

    - If the current character is '#':
        - `var parsedLength = int.Parse(wordLength);`: This line converts the accumulated `wordLength` string to an integer, representing the length of the upcoming word.
        - `var word = str[(l + 1) .. (l + parsedLength + 1)];`: This line extracts the word from the encoded string by slicing the substring starting from index `l + 1` and ending at index `l + parsedLength`. This is the actual word encoded in the format "length#word".
        - `result.Add(word);`: Adds the extracted `word` to the `result` list.
        - `l += parsedLength + 1;`: Increments the index `l` to move past the current word and its length.
        - `wordLength = "";`: Resets the `wordLength` to an empty string for the next word.

5. After the loop completes, the method returns the `result` list containing the decoded strings.

In summary, these two methods together allow you to encode a list of strings into a single string and then decode the encoded string back into the original list of strings. The encoding involves concatenating the length of each word with the word itself using a '#' separator, and the decoding process involves parsing the length, extracting the word, and storing it in a list.