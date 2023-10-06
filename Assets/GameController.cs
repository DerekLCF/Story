using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{

    public TextMeshProUGUI Hint;
    public Transform[] Slot;
    public Transform[] Photo;
    public Transform[] Ans;
    public GameObject WinScene;
    string Temp;
    void Start()
    {

        WinScene.SetActive(false);

        foreach (var x in Ans)
        {
            Temp += x.name+" ";

        }
        Hint.text = "Hints:"+Temp;

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckWin()
    {
        Debug.Log("CheckWin");

        int i = 0;
         bool AllCorrect = true;
        foreach (var x in Ans) {
            if (Slot[i].childCount >0)
            {
                if (Ans[i] != Slot[i].GetChild(0))
                {
                    AllCorrect = false;
                    Debug.Log(i+" Wrong");
                }
            }
            else {
                AllCorrect = false;
            }
            i++;
        }


        if (AllCorrect)
        {
            Debug.Log("Win!!!!!!!!");
            WinScene.SetActive(true);
        }
        else {
            Debug.Log("Have Wrong");
        }
    }
}
