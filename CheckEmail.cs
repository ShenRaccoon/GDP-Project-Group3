using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckEmail : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // this script is to put on the "send/trash" button which you drag to the trash or the send
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    Vector3 initial;
    public Vector3 resetPos;
    public bool droppedOnSlot, // If button dropped on anything
        gotVirus; // for email

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        ResetPos();
    }
    private void Start()
    {
        ResetPos();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("down");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end drag");
        canvasGroup.blocksRaycasts = true;
        // Button go back to initial spot if not 
        if(droppedOnSlot == false)
        {
            transform.position = initial;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("start drag");
        canvasGroup.blocksRaycasts = false;
        eventData.pointerDrag.GetComponent<CheckEmail>().droppedOnSlot = false;
    }

    public void ResetPos()
    {
        transform.localPosition = resetPos;
        initial = transform.position;
    }
}
