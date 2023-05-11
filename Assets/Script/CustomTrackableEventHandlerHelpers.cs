using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = System.Random;


internal class CustomTrackableEventHandlerHelpers : MonoBehaviour
{
    static public string[] names = new string[9];
    static public string score= "Play your first game";
    static public string s= "";
    
    static public Sprite[] e = new Sprite[9];
    static public Sprite[] t = new Sprite[2];
    static public int value;
    Random random = new Random();
    static public int n = 0;
    public void Start()
    {
        n = 8;
        if (SceneManager.GetActiveScene().buildIndex == 2)
            n = 6;
        value = random.Next(0, n);

        
        GameObject.FindWithTag("itext").GetComponent<TextMeshProUGUI>().text = CustomTrackableEventHandlerHelpers.names[CustomTrackableEventHandlerHelpers.value];
        GameObject.FindWithTag("image").GetComponent<Image>().sprite = CustomTrackableEventHandlerHelpers.e[CustomTrackableEventHandlerHelpers.value];
        t[0]= Resources.Load<Sprite>("image/true");
        t[1]= Resources.Load<Sprite>("image/false");
    }
}