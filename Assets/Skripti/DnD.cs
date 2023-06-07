using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DnD : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    //Uzglabās norādi uz Objekti skriptu
    public Objekti objekti;
    //Uzglabās norādi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;

    public void OnBeginDrag(PointerEventData eventData)
    {
        objekti.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 cursorPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(objekti.kanva.transform as RectTransform, eventData.position, eventData.pressEventCamera, out cursorPos);
        transform.position = objekti.kanva.transform.TransformPoint(cursorPos);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objekti.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;

        if (objekti.novietotsPareizi)
        {
            objekti.pedejaisVilktais = null;
            objekti.novietotsPareizi = false;
            objekti.novietotieObjekti++; // Skaita spēlētāja novietotās mašīnas
        }
        else
        {
            kanvasGrupa.blocksRaycasts = true;
        }
    }

    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }
}