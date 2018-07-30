using System.Collections;
using System.Collections.Generic;
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

    private bool muteisYes = false;
    private bool tutIsYes = false;


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
        if(muteisYes == true)
        {
            muteBtnTxt.text = "No";
            muteisYes = false;
        } else 
        {
            muteBtnTxt.text = "Yes";
            muteisYes = true;
        }
    }

    public void tutorialSetting()
    {
        tapBtn.Play();
        if (tutIsYes == true)
        {
            tutorialBtnTxt.text = "No";
            tutIsYes = false;
        }
        else
        {
            tutorialBtnTxt.text = "Yes";
            tutIsYes = true;
        }
    }
}