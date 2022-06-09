using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemHewan : MonoBehaviour
{
    public static SistemHewan instance;
    public int ID;
    public GameObject TempatSpawnHewan;
    public GameObject Gui_Utama;
    public GameObject[] KoleksiHewan;
    public AudioClip[] SuaraHewan;
    AudioSource Suara;  


    
    // Start is called before the first frame update
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ID = 0;
        // SpawnObject();
        Suara = gameObject.AddComponent<AudioSource>();

    }
    public void SpawnObject()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Hewan");
        if(BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Benda = Instantiate(KoleksiHewan[ID]);
        Benda.transform.SetParent(TempatSpawnHewan.transform, false);
        TempatSpawnHewan.GetComponent<Animation>().Play("PopUp");
        KumpulanSuara.instance.Panggil_Suara(1);
    }
    private void update(){
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            GantiHewan(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            GantiHewan(false);
        }
    }

    public void GantiHewan(bool Kanan){
        if(Kanan)
        {
            if(ID >= KoleksiHewan.Length - 1)
            {
                ID = 0;
            }
            else {
                ID++;
            }
        }
        else
        {
            if(ID <= 0 )
            {
                ID = KoleksiHewan.Length - 1;
            }
            else {
                ID--;
            }
        }
        SpawnObject();
        PanggilSuaraHewan();

    }
    public void PanggilSuaraHewan(){
        Suara.clip = SuaraHewan[ID];
        Suara.Play(); 
    }
}
