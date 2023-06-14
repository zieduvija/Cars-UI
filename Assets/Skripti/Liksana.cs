using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Liksana : MonoBehaviour, IDropHandler {
    public Objekti objekti;
    float zRotacija , velkRotacija, xStarpiba, yStarpiba, zStarpiba;
    private Vector2 izmers, velkIzmers;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {

                zRotacija = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkRotacija = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                izmers = GetComponent<RectTransform>().localScale;
                velkIzmers = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

                xStarpiba = Mathf.Abs(velkIzmers.x - izmers.x);
                yStarpiba = Mathf.Abs(velkIzmers.y - izmers.y);
                zStarpiba = Mathf.Abs(velkRotacija - zRotacija);

                if ((zStarpiba <= 6 || (zStarpiba >= 354 && zStarpiba <= 360)) &&
                    (xStarpiba <= 0.3 && yStarpiba <= 0.3))
                {
                    objekti.novietotsPareizi = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
                        GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale =
                        GetComponent<RectTransform>().localScale;

                    objekti.audio.PlayOneShot(objekti.skana[0]);
                    
                    switch (eventData.pointerDrag.tag)
                    {
                        case "autobuss":
                            objekti.audio.PlayOneShot(objekti.skana[1]);
                            break;
                        case "policija":
                            objekti.audio.PlayOneShot(objekti.skana[2]);
                            break;
                        case "ugunsdzesejs":
                            objekti.audio.PlayOneShot(objekti.skana[3]);
                            break;
                        case "ekskavators":
                            objekti.audio.PlayOneShot(objekti.skana[4]);
                            break;
                        case "cementa":
                            objekti.audio.PlayOneShot(objekti.skana[5]);
                            break;
                        case "atkritumu":
                            objekti.audio.PlayOneShot(objekti.skana[6]);
                            break;
                        case "traktors1":
                            objekti.audio.PlayOneShot(objekti.skana[7]);
                            break;
                        case "traktors5":
                            objekti.audio.PlayOneShot(objekti.skana[8]);
                            break;
                        case "b2":
                            objekti.audio.PlayOneShot(objekti.skana[9]);
                            break;
                        case "e46":
                            objekti.audio.PlayOneShot(objekti.skana[10]);
                            break;
                        case "e61":
                            objekti.audio.PlayOneShot(objekti.skana[11]);
                            break;
                        case "atrie":
                            objekti.audio.PlayOneShot(objekti.skana[12]);
                            break;
                    }
                }
            }
            else
            {
                objekti.novietotsPareizi = false;

                switch (eventData.pointerDrag.tag)
                {
                    case "autobuss":
                        objekti.autobuss.GetComponent<RectTransform>().localPosition = objekti.autobussPos;
                        break;
                    case "policija":
                        objekti.policija.GetComponent<RectTransform>().localPosition = objekti.policijaPos;
                        break;
                    case "ugunsdzesejs":
                        objekti.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objekti.ugunsdzesejsPos;
                        break;
                    case "ekskavators":
                        objekti.ekskavators.GetComponent<RectTransform>().localPosition = objekti.ekskavatorsPos;
                        break;
                    case "cementa":
                        objekti.cementa.GetComponent<RectTransform>().localPosition = objekti.cementaPos;
                        break;
                    case "atkritumu":
                        objekti.atkritumu.GetComponent<RectTransform>().localPosition = objekti.atkritumuPos;
                        break;
                    case "traktors1":
                        objekti.traktors1.GetComponent<RectTransform>().localPosition = objekti.traktors1Pos;
                        break;
                    case "traktors5":
                        objekti.traktors5.GetComponent<RectTransform>().localPosition = objekti.traktors5Pos;
                        break;
                    case "b2":
                        objekti.b2.GetComponent<RectTransform>().localPosition = objekti.b2Pos;
                        break;
                    case "e46":
                        objekti.e46.GetComponent<RectTransform>().localPosition = objekti.e46Pos;
                        break;
                    case "e61":
                        objekti.e61.GetComponent<RectTransform>().localPosition = objekti.e61Pos;
                        break;
                    case "atrie":
                        objekti.atrie.GetComponent<RectTransform>().localPosition = objekti.atriePos;
                        break;

                }
            }
        }



    }
    

}
