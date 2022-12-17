using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDrag : MonoBehaviour,IPointerDownHandler,IBeginDragHandler,IDragHandler, IEndDragHandler
{
    [SerializeField] private GameObject glowing;
     private Canvas gameCanvas;

    private RectTransform cardTransform;
    private void Awake()
    {
        cardTransform = GetComponent<RectTransform>();
        gameCanvas= FindObjectOfType<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       glowing.SetActive(true);
       cardTransform.Rotate(0,0,0);
    }

    public void OnDrag(PointerEventData eventData)
    {
        cardTransform.anchoredPosition += eventData.delta / gameCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        glowing.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

}
