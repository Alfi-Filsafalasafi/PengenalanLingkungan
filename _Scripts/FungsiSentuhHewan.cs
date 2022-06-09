using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungsiSentuhHewan : MonoBehaviour
{
    private void OnMouseDown(){
        GetComponent<Animation>().Play("button");
        SistemHewan.instance.PanggilSuaraHewan();
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
