using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseGame : MonoBehaviour
{
    public GameObject ButtonPause;
    [Header("Panel UI")]
    public Transform PanelPause;
    private bool open;

    //berfungsi untuk memanggil script time manager
    public TimeManager tm;
    // memanggil audio sfx
    public SoundManager sm;

    private void Start()
    {
    }
    private void Update()
    {
        if (open == true)
        {
            PanelPause.localScale = Vector3.LerpUnclamped(PanelPause.localScale, Vector3.one, 0.5f);
        }
        //animasi close panel
        else
        {
            PanelPause.localScale = Vector2.LerpUnclamped(PanelPause.localScale, Vector3.right, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (open==false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    //merupakan tempat script pause button
    public void Pause() 
    {
        sm.buttonclick();
        tm._pause = true;
        open = true;
        ButtonPause.SetActive(false);
    }
    //memulai kembali permainan
    public void Resume() 
    {
        sm.buttonclick();
        tm._pause = false;
        open = false;
        ButtonPause.SetActive(true);
    }
    //memainkan permainana baru
    public void restart() 
    {
        sm.buttonclick();

        Application.LoadLevel(Application.loadedLevel);
    }
    //mengeluarkan permainan
    public void Quit() 
    {
        sm.buttonclick();

        Application.Quit();
    }
}
