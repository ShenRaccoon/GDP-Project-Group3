using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email : MonoBehaviour
{
    //Email pop-up
    public GameObject email;
   public void PopEmail()
   {
        email.gameObject.SetActive(true);
   }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

    public void AddNew()
    {

    }
}
