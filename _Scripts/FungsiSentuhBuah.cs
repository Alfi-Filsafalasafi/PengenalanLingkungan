using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungsiSentuhBuah : MonoBehaviour
{
    private void OnMouseDown(){
        GetComponent<Animation>().Play("button");
        Sistem.instance.PanggilSuaraBuah();
    }
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
