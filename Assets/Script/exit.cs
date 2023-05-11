using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("s").GetComponent<TextMeshProUGUI>().text = CustomTrackableEventHandlerHelpers.score;
    }

    
   
    public void doExitGame()
    {
        Application.Quit();
    }
    public void goBack()
    {

        CustomTrackableEventHandlerHelpers.score = GameObject.FindWithTag("score").GetComponent<TextMeshProUGUI>().text + " " + '/' + " " +GameObject.FindWithTag("try").GetComponent<TextMeshProUGUI>().text;
        SceneManager.LoadScene(0);
        
    }
}
