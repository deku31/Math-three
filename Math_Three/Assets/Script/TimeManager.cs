using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
	#region Singleton

	private static TimeManager _instance = null;

	public static TimeManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindObjectOfType<TimeManager>();

				if (_instance == null)
				{
					Debug.LogError("Fatal Error: TimeManager not Found");
				}
			}

			return _instance;
		}
	}

	#endregion

	public int duration;

	private float time;

	//memulai atau menghentikan penghitung waktu saat ditekan pause
	public bool _pause;

	private void Start()
	{
		time = 0;
	}

	private void Update()
	{
		if (GameFlowManager.Instance.IsGameOver)
		{
			return;
		}

		if (time > duration)
		{
			GameFlowManager.Instance.GameOver();
			return;
		}
        if (_pause==false)
        {
			time += Time.deltaTime;
		}
	}

	public float GetRemainingTime()
	{
		return duration - time;
	}
}
