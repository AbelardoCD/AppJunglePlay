using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botnonesURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void adoptaArbol(){

        Application.OpenURL("https://www.arbioperu.com/hectareas/arbio/public");
    }
    public void dona(){

        Application.OpenURL("https://www.arbioperu.com/donaciones");
    }
}
