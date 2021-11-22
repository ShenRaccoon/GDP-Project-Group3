using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailShuffle : MonoBehaviour
{
    ArrayList emailTitle = new ArrayList()
    {
        "Title1", "Title2" , "Title3" ,"Title4" ,"Title5"
    };

    ArrayList emailDescription = new ArrayList()
    {
        "Description1" , "Description2" , "Description3" , "Description4" , "Description5"
    };

    ArrayList emailLink = new ArrayList()
    {
        "Link 1" , "Link 2" , "Link 3" , "Link 4" , "Link 5"
    };

    public string Shuffle()
    {
        string combinedString = (string)emailTitle[Random.Range(0, emailTitle.Count)];
        combinedString += (string)emailDescription[Random.Range(0, emailDescription.Count)];
        combinedString += (string)emailLink[Random.Range(0, emailLink.Count)];
        return combinedString;
    }
}
