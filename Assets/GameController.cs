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
        Card_Position[0].position = Place_Position[0].position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
