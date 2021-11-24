using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrashSend : MonoBehaviour, IDropHandler
{
    //This is put into the Trash or the Send objects/images
    public bool trash; //if it the trash or send
    public GameObject email; // the email interface
    public GameObject playerHealth, checkEmail, score;
    CanvasGroup canvasGroup;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            //put object into place, not rly needed but cool
            canvasGroup.blocksRaycasts = true;
            checkEmail.GetComponent<CheckEmail>().ResetPos();
            eventData.pointerDrag.GetComponent<CheckEmail>().droppedOnSlot = true;

            //Win/Lose condition
            if (eventData.pointerDrag.GetComponent<CheckEmail>().gotVirus == true && trash == true ||
                eventData.pointerDrag.GetComponent<CheckEmail>().gotVirus == false && trash == false)
            {
                email.SetActive(false);
                Debug.Log("WELLLLL DONEEEEEE WOWOWOWWW");
                score.GetComponent<ScorePointSystem>().AddScoreEmail();

            }

            else
            {
                email.SetActive(false);
                Debug.Log("WWRONGGGGG STOOPID");
                playerHealth.GetComponent<PlayerHealth>().LoseHealth();
            }
        }
    }
    private void Awake()
    {
       canvasGroup = checkEmail.GetComponent<CanvasGroup>();
    }

}
