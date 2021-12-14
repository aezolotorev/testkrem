using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject sliderWithText;
    public Slider slider;
    public Text textscore;
    public float sliderValue;
    public GameObject completeCanvas;

    public void SetValue(int value)
    {
        if (value < 70)
        {
            slider.value = value;
            textscore.text = value.ToString() + "%";
        }
        else
        {
            sliderWithText.SetActive(false);
            completeCanvas.SetActive(true);
        }



    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }



}
