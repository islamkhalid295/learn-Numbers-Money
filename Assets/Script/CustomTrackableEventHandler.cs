using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using Random = System.Random;
using Image = UnityEngine.UI.Image;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CustomTrackableEventHandler : DefaultObserverEventHandler
{
    //CustomTrackableEventHandlerHelpers b = new CustomTrackableEventHandlerHelpers();
    //string[] CustomTrackableEventHandlerHelpers.names = { "1-1", "1-2", "5-1", "10-1", "10-2", "50-1", "100-1"};
    Random random = new Random();
    //public TextMeshProUGUI Result_txt = GameObject.FindWithTag("result").GetComponent<TextMeshProUGUI>();
    protected ObserverBehaviour iObserverBehaviour;

    protected override void Start()
    {
        iObserverBehaviour = GetComponent<ObserverBehaviour>();
        GameObject.FindWithTag("result").GetComponent<Text>().text = CustomTrackableEventHandlerHelpers.s;
        base.Start();
    }
    
    static string x = "zero0";
    
    public void dis ()
    {
        GameObject.FindWithTag("itext").GetComponent<TextMeshProUGUI>().text = CustomTrackableEventHandlerHelpers.names[CustomTrackableEventHandlerHelpers.value];
        GameObject.FindWithTag("image").GetComponent<Image>().sprite = CustomTrackableEventHandlerHelpers.e[CustomTrackableEventHandlerHelpers.value];
    }
    void HideImage()
    {
        GameObject.FindWithTag("true or false").GetComponent<Image>().enabled = false;
        GameObject.FindWithTag("result").GetComponent<Text>().enabled = false;
    }
    void enableImage()
    {
        GameObject.FindWithTag("true or false").GetComponent<Image>().enabled = true;
        GameObject.FindWithTag("result").GetComponent<Text>().enabled = true;
    }
    public void SkipImage()
    {
        int tmp = random.Next(0, CustomTrackableEventHandlerHelpers.n);
        if (CustomTrackableEventHandlerHelpers.value == tmp)
            tmp = random.Next(0, CustomTrackableEventHandlerHelpers.n);
        CustomTrackableEventHandlerHelpers.value = tmp;
        dis();
        GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text = (int.Parse(GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text) + 1).ToString();

    }
    protected override void OnTrackingFound()
    {
        
        if (CustomTrackableEventHandlerHelpers.names[CustomTrackableEventHandlerHelpers.value].Substring(0, CustomTrackableEventHandlerHelpers.names[CustomTrackableEventHandlerHelpers.value].Length-2) == iObserverBehaviour.TargetName.Substring(0, iObserverBehaviour.TargetName.Length - 2) /*&& iObserverBehaviour.TargetName != x*/)
        {
            GameObject.FindWithTag("result").GetComponent<Text>().text = "ﻮﻓﺍﺮﺑ";
            GameObject.FindWithTag("result").GetComponent<Text>().fontSize = 110;
            GameObject.FindWithTag("result").GetComponent<Text>().color = new Color(120f / 255f, 255f / 255f, 0f / 255f, 1f);
            GameObject.FindWithTag("true or false").GetComponent<Image>().sprite = CustomTrackableEventHandlerHelpers.t[0];
            enableImage();
            Invoke("HideImage", 4.0f);
            FindObjectOfType<AudioManeger>().playsound("correct");
            FindObjectOfType<AudioManeger>().playsound("correct1");

            GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text = (int.Parse(GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text)+1).ToString();
            GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text = (int.Parse(GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text)+1).ToString();
            GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().color = Color.green;
            x = iObserverBehaviour.TargetName;
            int tmp = random.Next(0, CustomTrackableEventHandlerHelpers.n);
            if (CustomTrackableEventHandlerHelpers.value == tmp)
                tmp = random.Next(0, CustomTrackableEventHandlerHelpers.n);
            CustomTrackableEventHandlerHelpers.value = tmp;
            dis();

            /*while (CustomTrackableEventHandlerHelpers.names[CustomTrackableEventHandlerHelpers.value] == "seven7")
                value = random.Next(0, n);*/

        }
        else if(iObserverBehaviour.TargetName.Substring(0, iObserverBehaviour.TargetName.Length - 2) != x.Substring(0, x.Length - 2))
        {
            FindObjectOfType<AudioManeger>().playsound("wrong");
            FindObjectOfType<AudioManeger>().playsound("wrong1");
            GameObject.FindWithTag("true or false").GetComponent<Image>().sprite = CustomTrackableEventHandlerHelpers.t[1];
            GameObject.FindWithTag("result").GetComponent<Text>().text = "ﺔﻴﻧﺎﺗ ﺓﺮﻣ ﻝﻭﺎﺣ ﻂﻠﻏ";
            enableImage();
            Invoke("HideImage", 4.0f);
            if (GameObject.FindWithTag("result").GetComponent<Text>().fontSize < 110)
                GameObject.FindWithTag("result").GetComponent<Text>().fontSize += 10;
            else
                GameObject.FindWithTag("result").GetComponent<Text>().fontSize = 90;
            GameObject.FindWithTag("result").GetComponent<Text>().color = Color.red;
            /*GameObject.FindWithTag("result").GetComponent<TextMeshProUGUI>().text = "Wrong Answer";
            GameObject.FindWithTag("result").GetComponent<TextMeshProUGUI>().color = Color.red;*/
            //if (int.Parse(GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text)!=0)
            //GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text = (int.Parse(GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text) - 1).ToString();
            GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text = (int.Parse(GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text)+1).ToString();

            GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().color = Color.red;

            x = iObserverBehaviour.TargetName;
            /*value = random.Next(0, n);
            while (CustomTrackableEventHandlerHelpers.names[value].Equals(x))
                value = random.Next(0, n);
            GameObject.FindWithTag("itext").GetComponent<TextMeshProUGUI>().text = CustomTrackableEventHandlerHelpers.names[value];*/
            //GameObject.FindWithTag("image").GetComponent<Image>().sprite = e[value];
        }
        base.OnTrackingFound();
        /*Debug.Log($"anaaaaa{iObserverBehaviour.TargetName}");*/


    }

    protected override void OnTrackingLost()
    {
        // you can even do something on tracking lost
        base.OnTrackingLost();
    }

}