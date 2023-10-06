using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Transform[] Org_Position;
    public Transform[] Card_Position;
    public Transform[] Place_Position;
    public Transform[] Placeing;


    // Start is called before the first frame update
    void Start()
    {
        SetOrgPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetOrgPosition()
    {
        int i = 0;
        foreach (Transform x in Org_Position) {
            Card_Position[i].position = x.position;
            i++;
        }
    }


     public void SetPosition()
    {
        int i = 0;
        foreach (Transform x in Org_Position)
        {
            Card_Position[i].position = x.position;
            i++;
        }
    }
}
