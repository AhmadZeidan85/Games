using System;
using UnityEngine;

namespace Assignment29
{

public static class Utilities
{

    public static int Add(params int[] numbers){
        int summation = 0;
        foreach (var number in numbers)
        {
            summation += number;
        }
        return summation;
    }

     public static String RepeatString(this String text, int times)
        {
            String Result="";
            for (int i=0;i<times; i++){
                Result+=text;

            }

            return Result;
            
        }

    
}
}
