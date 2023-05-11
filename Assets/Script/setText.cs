using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System;

using Random = System.Random;

public class setText : MonoBehaviour
{
   
        public TextMeshProUGUI textMeshPro;
    int num;
    string[] names =  { "one1", "two2", "three3", "four4", "five5", "six6", "seven7", "eight8", "nine9" };


    void Start()
        {
        textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();

        Random random = new Random();
        int value = random.Next(0, names.Length);
        Console.Write(names[value]);


        /*num = UnityEngine.Random.RandomRange(1, 9);*/
        textMeshPro.text ="five5" /*names[value]*/ /*num.ToString()*/;
    }
    private void Update()
    {
        
        
    }
}
