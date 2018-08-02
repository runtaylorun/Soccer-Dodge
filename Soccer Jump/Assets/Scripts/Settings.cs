using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Image startBtn;
    public Image settingsBtn;
    public Image tutorialBtn;
    public Image muteBtn;
    public Image menuBtn;
    public Image title;
    public Text startBtnText;
    public Text settingsBtnText;
    public Text tutorialBtnTxt;
    public Text muteBtnTxt;
    public Text menuBtnTxt;
    public Text tutorialTxt;
    public Text muteTxt;
    public AudioSource tapBtn;


	public void Start()
	{
        if(!PlayerPrefs.HasKey("indexTut") && !PlayerPrefs.HasKey("isDisabledTut") && !PlayerPrefs.HasKey("isMuted") && !PlayerPrefs.HasKey("indexMuted")) 
        {
            PlayerPrefs.SetInt("indexTut", 0);
            PlayerPrefs.SetInt("isDisabledTut", 0);
            PlayerPrefs.SetInt("isMuted", 0);
            PlayerPrefs.SetInt("indexMuted", 0);
            Debug.Log("keys initialized");
        }
        if(PlayerPrefs.GetInt("isDisabledTut") == 0)
        {
            tutorialBtnTxt.text = "no";
        } else
        {
            tutorialBtnTxt.text = "yes";
        }
        if(PlayerPrefs.GetInt("isMuted") == 0)
        {
            muteBtnTxt.text = "no";
        } else 
        {
            muteBtnTxt.text = "yes";
        }

	}
	public void toSettings()
    {
        tapBtn.Play();
        startBtn.enabled = false;
        settingsBtn.enabled = false;
        title.enabled = false;
        startBtnText.enabled = false;
        settingsBtnText.enabled = false;
        tutorialBtn.enabled = true;
        muteBtn.enabled = true;
        menuBtn.enabled = true;
        tutorialBtnTxt.enabled = true;
        muteBtnTxt.enabled = true;
        menuBtnTxt.enabled = true;
        muteTxt.enabled = true;
        tutorialTxt.enabled = true;
    }

    public void toMenu()
    {
        tapBtn.Play();
        startBtn.enabled = true;
        settingsBtn.enabled = true;
        title.enabled = true;
        startBtnText.enabled = true;
        settingsBtnText.enabled = true;
        tutorialBtn.enabled = false;
        muteBtn.enabled = false;
        menuBtn.enabled = false;
        tutorialBtnTxt.enabled = false;
        muteBtnTxt.enabled = false;
        menuBtnTxt.enabled = false;
        muteTxt.enabled = false;
        tutorialTxt.enabled = false;
    }

    public void muteSetting()
    {
        tapBtn.Play();
        if(PlayerPrefs.GetInt("isMuted") == 0)
        {
            PlayerPrefs.SetInt("indexMuted", 1);
            muteBtnTxt.text = "yes";
            PlayerPrefs.SetInt("isMuted", PlayerPrefs.GetInt("indexMuted"));
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("isMuted"));
        } else 
        {
            PlayerPrefs.SetInt("indexMuted", 0);
            muteBtnTxt.text = "no";
            PlayerPrefs.SetInt("isMuted", PlayerPrefs.GetInt("indexMuted"));
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("isMuted"));
        }
    }

    public void tutorialSetting()
    {
        tapBtn.Play();
        if (PlayerPrefs.GetInt("isDisabledTut") == 0)
        {
            PlayerPrefs.SetInt("indexTut", 1);
            tutorialBtnTxt.text = "yes";
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("isDisabledTut", PlayerPrefs.GetInt("indexTut"));
            Debug.Log(PlayerPrefs.GetInt("isDisabledTut"));

        } else
        {
            PlayerPrefs.SetInt("indexTut", 0);
            tutorialBtnTxt.text = "no";
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("isDisabledTut", PlayerPrefs.GetInt("indexTut"));
            Debug.Log(PlayerPrefs.GetInt("isDisabledTut"));
        }
    }
}