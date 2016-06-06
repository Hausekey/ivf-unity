using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.EventSystems;

public class SurveyManager : MonoBehaviour {
	public Page currentPage;

	// Use this for initialization
	public void Start () {
		ShowPage (currentPage);
	}

	public void ShowPage(Page page){
		if (currentPage != null) {
			currentPage.IsOpen = false;
		}

		currentPage = page;
		currentPage.IsOpen = true;
	}
		
}
