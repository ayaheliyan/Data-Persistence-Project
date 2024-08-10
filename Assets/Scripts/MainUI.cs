using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;
using UnityEngine.UI;


public class MainUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField NameFieldText;
    [SerializeField] private TMP_Text NameOutput;


    public void InputFieldName()
    {
        PlayerPrefs.SetString("ScoreOutput", NameFieldText.text);
    }

    public void OutputText()
    {
        NameOutput.text = "Your score : "  + PlayerPrefs.GetString("ScoreOutput") ;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
        //MainManager.Instance.SaveName(); 
       // EditorApplication.ExitPlaymode();
    }
}
