using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    
    public void playNumbers()
    {
        CustomTrackableEventHandlerHelpers.s = "ﺕﺮﻜﻟﺍ ﺕﺎﻫ\r\nﺓﺭﻮﺼﻟﺍ ﻲﻓ ﻲﻠﻟﺍ";
        //string[] names = { "one1", "two2", "three3", "four4", "five5", "six6", "seven7", "eight8", "nine9" }
        CustomTrackableEventHandlerHelpers.names[0] = "one1";
        CustomTrackableEventHandlerHelpers.names[1] = "two2";
        CustomTrackableEventHandlerHelpers.names[2] = "three3";
        CustomTrackableEventHandlerHelpers.names[3] = "four4";
        CustomTrackableEventHandlerHelpers.names[4] = "five5";
        CustomTrackableEventHandlerHelpers.names[5] = "six6";
        CustomTrackableEventHandlerHelpers.names[6] = "seven7";
        CustomTrackableEventHandlerHelpers.names[7] = "eight8";
        CustomTrackableEventHandlerHelpers.names[8] = "nine9";

        CustomTrackableEventHandlerHelpers.e[0] = Resources.Load<Sprite>("Number/one1_scaled");
        CustomTrackableEventHandlerHelpers.e[1] = Resources.Load<Sprite>("Number/two2_scaled");
        CustomTrackableEventHandlerHelpers.e[2] = Resources.Load<Sprite>("Number/three3_scaled");
        CustomTrackableEventHandlerHelpers.e[3] = Resources.Load<Sprite>("Number/four4_scaled");
        CustomTrackableEventHandlerHelpers.e[4] = Resources.Load<Sprite>("Number/five5_scaled");
        CustomTrackableEventHandlerHelpers.e[5] = Resources.Load<Sprite>("Number/six6_scaled");
        CustomTrackableEventHandlerHelpers.e[6] = Resources.Load<Sprite>("Number/seven7_scaled");
        CustomTrackableEventHandlerHelpers.e[7] = Resources.Load<Sprite>("Number/eight8_scaled");
        CustomTrackableEventHandlerHelpers.e[8] = Resources.Load<Sprite>("Number/nine9_scaled");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void playMoney()
    {
        CustomTrackableEventHandlerHelpers.s = "ﺔﻠﻤﻌﻟﺍ ﺕﺎﻫ\r\nﺓﺭﻮﺼﻟﺍ ﻲﻓ ﻲﻠﻟﺍ";
        //new string[] { "1-1", "1-2", "5-1", "10-1", "10-2", "50-1", "100-1"};
        CustomTrackableEventHandlerHelpers.names[0] = "1-1"; 
        //CustomTrackableEventHandlerHelpers.names[0] = "1-2"; 
        CustomTrackableEventHandlerHelpers.names[1] = "5-1"; 
        CustomTrackableEventHandlerHelpers.names[2] = "10-1"; 
        //CustomTrackableEventHandlerHelpers.names[4] = "10-2"; 
        CustomTrackableEventHandlerHelpers.names[3] = "20-1"; 
        //CustomTrackableEventHandlerHelpers.names[6] = "20-2"; 
        CustomTrackableEventHandlerHelpers.names[4] = "50-1"; 
        //CustomTrackableEventHandlerHelpers.names[8] = "50-2"; 
        CustomTrackableEventHandlerHelpers.names[5] = "100-1"; 
        //CustomTrackableEventHandlerHelpers.names[10] = "100-2"; 
        CustomTrackableEventHandlerHelpers.names[6] = "200-1"; 
        //CustomTrackableEventHandlerHelpers.names[12] = "200-2";

        CustomTrackableEventHandlerHelpers.e[0] = Resources.Load<Sprite>("EGY_Money/1-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[0] = Resources.Load<Sprite>("EGY_Money/1-2_scaled");
        CustomTrackableEventHandlerHelpers.e[1] = Resources.Load<Sprite>("EGY_Money/5-1_scaled");
        CustomTrackableEventHandlerHelpers.e[2] = Resources.Load<Sprite>("EGY_Money/10-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[4] = Resources.Load<Sprite>("EGY_Money/10-2_scaled");
        CustomTrackableEventHandlerHelpers.e[3] = Resources.Load<Sprite>("EGY_Money/20-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[6] = Resources.Load<Sprite>("EGY_Money/20-2_scaled");
        CustomTrackableEventHandlerHelpers.e[4] = Resources.Load<Sprite>("EGY_Money/50-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[8] = Resources.Load<Sprite>("EGY_Money/50-2_scaled");
        CustomTrackableEventHandlerHelpers.e[5] = Resources.Load<Sprite>("EGY_Money/100-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[10] = Resources.Load<Sprite>("EGY_Money/100-2_scaled");
        CustomTrackableEventHandlerHelpers.e[6] = Resources.Load<Sprite>("EGY_Money/200-1_scaled");
        //CustomTrackableEventHandlerHelpers.e[12] = Resources.Load<Sprite>("EGY_Money/200-2_scaled");
        SceneManager.LoadScene(2);

    }



}
