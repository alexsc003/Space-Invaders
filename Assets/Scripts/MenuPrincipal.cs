using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField]
    GameObject menuPrincipal;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void Jugar()
    {
        if(menuPrincipal.activeSelf) 
        {
            menuPrincipal.SetActive(false);
            juegoActivo.SetActive(true);
        }
        if (menuPrincipal != null) {
    }
}
