using KartGame.KartSystems;
using log4net.Util;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTest : MonoBehaviour
{

    void etoudissement()
    {
        //faire tourner la voiture 3 sec
        for(int i=0; i< 3; i++)
        {

        }
    }
    
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Sortie1")) //si la voiture sort de la route
         {
            
            transform.Rotate(0, 188, 0);
            transform.position = new Vector3(-83.98f, 0.4f, -35.87f);            

         }
         else if (other.gameObject.CompareTag("Sortie2"))
        {
            transform.Rotate(0, 84.955f, 0);
            transform.position = new Vector3(-25.7f, 0.4f, -43.3f);
        }
         
        
    }
}
