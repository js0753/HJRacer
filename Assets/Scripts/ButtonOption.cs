using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.Application.LoadLevel not used anymore

public class ButtonOption : MonoBehaviour {

	//public void PlayButton(){
	//	SceneManager.LoadScene (2);
	//}

	public void PlayGame(){
		SceneManager.LoadScene (2);
	}

	public void MainMenu(){
		SceneManager.LoadScene (1);
	}

	//Below are Track Select Options

	public void Track01(){
		SceneManager.LoadScene (3);
	}

	public void Track02(){
		SceneManager.LoadScene (4);
	}

	public void Credits(){
		SceneManager.LoadScene (5);
	}
}
