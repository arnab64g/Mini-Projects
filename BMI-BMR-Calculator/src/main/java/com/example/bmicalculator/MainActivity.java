package com.example.bmicalculator;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import java.util.ArrayList;
public class MainActivity extends AppCompatActivity {
    @SuppressLint("SetTextI18n")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        final TextView textView = findViewById(R.id.textView);
        textView.setText("Choose Unit");
        final Spinner spinner = findViewById(R.id.spinner);
        final Spinner spinner1 = findViewById(R.id.spinner2);
        String [] unitList = new String[]{"Metric", "Imperial"};
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<>(this, android.R.layout.simple_expandable_list_item_1);
        arrayAdapter.addAll(unitList);
        spinner.setAdapter(arrayAdapter);
        ArrayList<String> arrayList = new ArrayList<>();
        arrayList.add("Little/no exercise ");
        arrayList.add("Light exercise ");
        arrayList.add("Moderate exercise");
        arrayList.add("Very active");
        arrayList.add("Extra active");
        ArrayAdapter<String> arrayAdapter1;
        arrayAdapter1 = new ArrayAdapter<>(this, android.R.layout.simple_expandable_list_item_1);
        final TextView textView1 = findViewById(R.id.textView2);
        final TextView textView2 = findViewById(R.id.textView3);
        final EditText editText =  findViewById(R.id.editTextNumberSigned);
        final EditText editText1 = findViewById(R.id.editTextNumberSigned2);
        final EditText editText2 = findViewById(R.id.editTextNumberSigned3);
        final TextView textView3 = findViewById(R.id.textView4);
        final EditText editText3 = findViewById(R.id.editTextNumber);
        textView3.setText("");
        ArrayList <String> gander = new ArrayList<>();
        gander.add("Male");
        gander.add("Female");
        ArrayAdapter <String> ganderAdapter = new ArrayAdapter<>(this, android.R.layout.simple_expandable_list_item_1);
        ganderAdapter.addAll(gander);
        final Spinner spinner2 = findViewById(R.id.spinner3);
        arrayAdapter1.addAll(arrayList);
        spinner2.setAdapter(ganderAdapter);
        spinner1.setAdapter(arrayAdapter1);
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                if (i == 0){
                    textView1.setText("Height(cm) ");
                    textView1.setVisibility(View.VISIBLE);
                    textView2.setText("Weight (Kg) ");
                    editText1.setVisibility(View.INVISIBLE);
                }
                else  if(i == 1){
                    textView1.setText("Height(Ft/In) ");
                    textView1.setVisibility(View.VISIBLE);
                    textView2.setText("Weight(lb) ");
                    editText1.setVisibility(View.VISIBLE);
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
                textView1.setVisibility(View.INVISIBLE);
                textView2.setVisibility(View.INVISIBLE);
            }
        });
        Button button = findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            @SuppressLint("DefaultLocale")
            @Override
            public void onClick(View view) {
                if (spinner.getSelectedItemPosition() == 0){
                    try {
                        double hg =  Double.parseDouble(editText.getText().toString());
                        double wg = Double.parseDouble(editText2.getText().toString());
                        double bmi = (wg)/(Math.pow(hg/100, 2));
                        double age = Double.parseDouble(editText3.getText().toString());
                        double bmr = BMRCalculation.bmrcalculation(hg, wg, age, 0, spinner2.getSelectedItemPosition(), spinner1.getSelectedItemPosition());
                        textView3.setText(String.format("\tBMI: %.2f\nBMR: %.2f kcal/d", bmi, bmr));
                    }catch (Exception e){
                        textView3.setText("NULL Field");
                    }
                }
                else if(spinner.getSelectedItemPosition() == 1){
                    try {
                        double h1 = Double.parseDouble(editText.getText().toString());
                        double h2 = Double.parseDouble(editText1.getText().toString());
                        double wg = Double.parseDouble(editText2.getText().toString());
                        double bmi = (wg*703)/Math.pow((h1*12+h2) ,2);
                        double age = Double.parseDouble(editText3.getText().toString());
                        double bmr = BMRCalculation.bmrcalculation(h1+h2, wg, age, 1, spinner2.getSelectedItemPosition(), spinner1.getSelectedItemPosition());
                        textView3.setText(String.format("\nBMI: %.2f\nBMR: %.2f kcal/d", bmi, bmr));
                    }catch (Exception e){
                        textView3.setText("Null Field");
                    }
                }
            }
        });
    }
}
