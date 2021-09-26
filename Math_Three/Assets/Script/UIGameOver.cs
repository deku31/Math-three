using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
	public SoundManager audio;
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void Show()
	{
		gameObject.SetActive(true);
		//audio saat gameover
		audio.Gameover();
		audio.bgm.Stop();
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}