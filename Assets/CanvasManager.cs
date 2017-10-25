using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

	public Canvas mainMenuCanvas, conversationCanvas;
	public Text resultPanelTopic, resultText;
	public string currentTopic;


// Managing canvases, enabling and disabling canvases when necessary

	void Start(){

		mainMenuCanvas = GameObject.Find ("MainMenuCanvas").GetComponent<Canvas> ();
		conversationCanvas = GameObject.Find ("ConversationCanvas").GetComponent<Canvas> ();
		resultPanelTopic = GameObject.Find ("ResultPanelTopic").GetComponent<Text> ();
		resultText = GameObject.Find ("ResultText").GetComponent<Text> ();

	}

	public void OpenConversationCanvas(string topicName){
	
		mainMenuCanvas.enabled = false;
		conversationCanvas.enabled = true;
		resultPanelTopic.text = topicName;

		string convTopicText = GetTopic (topicName);
		resultText.text = convTopicText;
	}

	public void ReOpenConversationCanvas(){

		mainMenuCanvas.enabled = false;
		conversationCanvas.enabled = true;
		resultPanelTopic.text = currentTopic;

		string convTopicText = GetTopic (currentTopic);
		resultText.text = convTopicText;
	}

	public void ReturnToMain(){

		mainMenuCanvas.enabled = true;
		conversationCanvas.enabled = false;
		resultPanelTopic.text = "";

		currentTopic = "";
		resultText.text = "";
	}


	private string GetTopic(string topicName){
	
		switch (topicName) {

		case "Dinner":
			return "Dinnercito!";

		case "Party":
			return "Party Phrase!";

		case "Wedding":
			return "Wedding Phrase!";

		case "Birth":
			return "Birth Phrase!";

		case "Food":
			return "Food Phrase!";

		case "Sports":
			return "Sports Phrase!";

		case "Love":
			return "Love Phrase!";

		
		default:
			return "No Topics Found!";
				


		}
	
	}

}
