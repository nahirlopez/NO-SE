using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonarr : MonoBehaviour
{
    public GameObject cubito;
    public int grados;
    public int cant;

    public void cloneobject()
    {
        GameObject clon;
        for(int i= 0; i<cant; i++) { 
        clon = Instantiate(cubito);
        clon.transform.Rotate(i, grados * i, 0);
        clon.transform.Translate(i, 5*i, 0);
            //Destroy(clon, 1);
        }
    }
}
