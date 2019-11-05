using System;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{

   public void CambiarEscena(string nombre){
       print("Cambio escena:" + nombre);
       SceneManager.LoadScene(nombre);
   }

   
}
