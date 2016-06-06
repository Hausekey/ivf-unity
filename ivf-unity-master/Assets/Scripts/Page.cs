using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Page : MonoBehaviour {
	//controls animator & canvas group of one page of the survey
	private Animator _animator;
	private CanvasGroup _canvasGroup;
	public string pageName;
	public bool IsOpen{
		get { return _animator.GetBool ("IsOpen"); }
		set { _animator.SetBool ("IsOpen", value); }
	}

	public void Awake(){
		_animator = GetComponent<Animator> ();
		_canvasGroup = GetComponent<CanvasGroup> ();

		var rect = GetComponent<RectTransform> ();
		_animator.Update (Time.smoothDeltaTime);
		_animator.Update (Time.smoothDeltaTime);
		rect.offsetMax = new Vector2 (0, -58);
		rect.offsetMin = new Vector2(0, -293);
	}
	public void Update(){
		if (!_animator.GetCurrentAnimatorStateInfo (0).IsName ("Open")) {
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
		} else {
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;		
		}

	}

}
