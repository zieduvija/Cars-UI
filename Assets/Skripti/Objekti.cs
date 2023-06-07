using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{

	public GameObject autobuss,
		policija,
		ugunsdzesejs,
		ekskavators,
		cementa,
		atkritumu,
		traktors1,
		traktors5,
		b2,
		e46,
		e61,
		atrie;
	
	[HideInInspector]
	public Vector2 autobussPos,
		policijaPos,
		ugunsdzesejsPos,
		ekskavatorsPos,
		cementaPos,
		atkritumuPos,
		traktors1Pos,
		traktors5Pos,
		b2Pos,
		e46Pos,
		e61Pos,
		atriePos;

	public Canvas kanva;
	public AudioSource audio;
	public AudioClip[] skana;
	
	public bool novietotsPareizi = false;
	public GameObject pedejaisVilktais;
	
	public int novietotieObjekti = 0;

	void Start()
	{
		autobussPos = autobuss.GetComponent<RectTransform>().localPosition;
		policijaPos = policija.GetComponent<RectTransform>().localPosition;
		ugunsdzesejsPos = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
		ekskavatorsPos = ekskavators.GetComponent<RectTransform>().localPosition;
		cementaPos = cementa.GetComponent<RectTransform>().localPosition;
		atkritumuPos = atkritumu.GetComponent<RectTransform>().localPosition;
		traktors1Pos = traktors1.GetComponent<RectTransform>().localPosition;
		traktors5Pos = traktors5.GetComponent<RectTransform>().localPosition;
		b2Pos = b2.GetComponent<RectTransform>().localPosition;
		e46Pos = e46.GetComponent<RectTransform>().localPosition;
		e61Pos = e61.GetComponent<RectTransform>().localPosition;
		atriePos = atrie.GetComponent<RectTransform>().localPosition;

	}
}
