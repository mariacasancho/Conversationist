using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MenuItem : MonoBehaviour {
	public string topicName;
	private CanvasManager canMan;

	void Start(){
		canMan = GetComponent<CanvasManager> ();
	}

	public void OnPointerClick( PointerEventData data )
	{
		Debug.Log( "OnPointerClick called." );
		Debug.Log (data.button);
		canMan.OpenConversationCanvas (topicName);
	}

}
