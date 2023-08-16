package org.example.problem;

import java.util.*;

public class _01_05_One_Away {
    /*
    Date: 2023-08-15
    01_05_One_Away

    There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character.
    Given two strings, write a function to check if they are one edit (or zero edits) away.

    Example 1:
    Input:
    first = "pale"
    second = "ple"
    Output: True

    Example 2:
    Input:
    first = "pales"
    second = "pal"
    Output: False

    Example 3:
    Input:
    first = "pales"
    second = "pbles"
    Output: True

    Example 4:
    Input:
    first = "pales"
    second = "pbzles"
    Output: False

    Example 5:
    Input:
    first = ""
    second = ""
    Output: True

    Example 6:
    Input:
    first = "teacher"
    second = "teather"
    Output: True

    */
    public void oneAway(){
        System.out.println("##### 01_05_One_Away #####");
        // solution 1
        System.out.println("solution 1");
        Boolean result = oneAway_1("pale", "ple");
        Boolean expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = oneAway_1("pales", "pal");
        expectResult = false;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = oneAway_1("pales", "pbles");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = oneAway_1("pales", "pbzles");
        expectResult = false;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = oneAway_1("", "");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = oneAway_1("teacher", "teather");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));
    }
    private boolean oneAway_1(String s1, String s2) {
        // Time complexity:
        // Space complexity:
        if(s1.equals(s2)) {
            return true;
        }

        List<String> s1List = new ArrayList<>(Arrays.asList(s1.split("")));
        List<String> s2List = new ArrayList<>(Arrays.asList(s2.split("")));
        List<Integer> ext = new ArrayList<>();

        for(int i = 0; i < s1List.size(); i++){
            String c = s1List.get(i);
            if (s2List.contains(c)) {
                s2List.remove(c);
            } else {
                ext.add(i);
            }
        }

        // remove
        if(s1.length() - 1 == s2.length() && ext.size() == 1) {
            return true;
        }

        // insert
        if(s1.length() + 1 == s2.length() && s2List.size() == 1) {
            return true;
        }

        if(s1.length() == s2.length() && ext.size() == 1 && s2List.size() == 1) {
            if(ext.get(ext.size() - 1 ) == s2.indexOf(s2List.get(s2List.size() - 1 ))){
                return true;
            }
        }

        return false;
    }
}
