using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffect : MonoBehaviour
{
    //it shouldnt be an intereger
    int targetchars = 0;
    //target of status
    //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void statusManager(int targetchars)
    {
        
    }
    
    void StatusRunner(string statusName)
    {
        Invoke(statusName, 0.0f);
    }
    //status effects go below 



}
