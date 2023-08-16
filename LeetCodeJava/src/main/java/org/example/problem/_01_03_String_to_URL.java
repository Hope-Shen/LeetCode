package org.example.problem;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

public class _01_03_String_to_URL {
    /*
    Date: 2023-08-14
    01_03_String_to_URL

    Write a method to replace all spaces in a string with '%20'.
    You may assume that the string has sufficient space at the end to hold the additional characters,and that you are given the "true" length of the string.
    (Note: If implementing in Java,please use a character array so that you can perform this operation in place.)

    Example 1:
    Input: "Mr John Smith ", 13
    Output: "Mr%20John%20Smith"

    Example 2:
    Input: "               ", 5
    Output: "%20%20%20%20%20"

    */
    public void stringToURL(){
        System.out.println("##### 01_03_String_to_URL #####");
        // solution 1
        System.out.println("solution 1");
        String result = stringToURL_1("Mr John Smith ", 13);
        String expectResult = "Mr%20John%20Smith";
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = stringToURL_1("               ", 5);
        expectResult = "%20%20%20%20%20";
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        // solution 2
        System.out.println("solution 2");
        result = stringToURL_2("Mr John Smith ", 13);
        expectResult = "Mr%20John%20Smith";
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = stringToURL_2("               ", 5);
        expectResult = "%20%20%20%20%20";
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));
    }
    private String stringToURL_1(String s, int length) {
        // Time complexity: substring 函式會創建一個新的子字串，其長度為 length，
        //                  而 replaceAll 函式則會對子字串進行遍歷並替換符合的字元。
        //                  因此，運行時間與輸入字串的長度和 length 之間的較小者成正比，
        //                  即 O(min(n, length))，其中 n 是輸入字串的長度。
        // Space complexity: 取決於輸入字串的長度、length 以及替換的次數，即 O(min(n, length) + 替換次數)
        return s.substring(0, length).replaceAll("\\s", "%20");
    }

    private String stringToURL_2(String s, int length) {
        // Time complexity: O(n)
        // Space complexity: O(n) -> O(3n): length * 3

        char[] chars = new char[s.length() * 3];
        char[] sChars = s.toCharArray();
        int index = 0;
        for(int i = 0; i < length; i++){
            if(sChars[i] == ' '){
                chars[index] = '%';
                chars[index+1] = '2';
                chars[index+2] = '0';
                index = index + 3;
            } else {
                chars[index] = sChars[i];
                index++;
            }
        }
        return new String(chars, 0, index);
    }
}
