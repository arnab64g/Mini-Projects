package com.example.bmicalculator;

public class BMRCalculation {
    static double bmrcalculation(double h, double w, double a, int un, int g, int act){
        double []data = {1.2, 1.375, 1.55, 1.725, 1.9};
        double bmr = 1.0;
        double result;
        if (un == 0){
            if (g == 0){
                bmr =  (10 * w) + (6.25 * h) - (5 * a) + 5;
            }
            else if (g == 1){
                bmr = (10 * w) + (6.25 * h) - (5 * a) - 161;
            }
        }
        else if (un == 1){
            if (g == 0){
                bmr = (4.536 * w) + (15.88 * h) - (5 * a) + 5;
            }
            else if (g == 1){
                bmr = (4.536 * w) + (15.88 * h) - (5 * a) - 161;
            }
        }

        result = bmr *  data[act];
        return  result;
    }
}
