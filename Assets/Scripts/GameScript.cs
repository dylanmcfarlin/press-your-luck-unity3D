using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public bool btnOnAndOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StopBtn()
    {
        //so everytime it's clicked it goes on & off
        btnOnAndOff = !btnOnAndOff;
    }
}
