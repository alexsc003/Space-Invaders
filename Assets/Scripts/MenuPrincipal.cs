using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField]
    GameObject menuPrincipal, menuSeleccion;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Jugar()
    {
        if(menuPrincipal.activeSelf) 
        {
            menuPrincipal.SetActive(false);
            menuSeleccion.SetActive(true);
        }
    }
}
