using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Buttonmovie : MonoBehaviour {

    void OnGUI()
    {
        /*if (GUI.Button(new Rect(20, 10, 200, 50), "PLAY ControlMode.CancelOnTouch"))
        {
            Handheld.PlayFullScreenMovie("test.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
        }

        if (GUI.Button(new Rect(20, 90, 200, 25), "PLAY ControlMode.Full"))
        {
            Handheld.PlayFullScreenMovie("test.mp4", Color.black, FullScreenMovieControlMode.Full);
        }*/

        /*if (GUI.Button(new Rect(20, 170, 500, 80), "PLAY ControlMode.Hidden"))
        {
            Handheld.PlayFullScreenMovie("test.mp4", Color.black, FullScreenMovieControlMode.Hidden);
        }//apk要用這個*/

       /* if (GUI.Button(new Rect(20, 250, 400, 50), "change the scene"))
        {
            //Handheld.PlayFullScreenMovie("test.mp4", Color.black, FullScreenMovieControlMode.Minimal);
           
        }*/

    }

    public void Start()
    {
        Button button = GameObject.Find("Button").GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("lob");
        });
    }

}
