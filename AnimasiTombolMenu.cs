using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiTombolMenu : MonoBehaviour
{
    public void _Animasi()
    {
        GetComponent<Animation>().Play("btn_in_menu");
        KumpulanSuara.instance.Panggil_Suara(0);
    }
}
