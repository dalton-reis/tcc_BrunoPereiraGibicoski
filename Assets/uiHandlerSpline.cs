using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiHandlerSpline : MonoBehaviour
{
    public Button btVoltar;
    public Button btInstructions;
    public Button btInstructionsClose;
    public GameObject HelpPanel;

    void Start()
    {
        btInstructionsCloseClick();
        btVoltar.onClick.AddListener(btVoltarClick);
        btInstructions.onClick.AddListener(btInstructionsClick);
        btInstructionsClose.onClick.AddListener(btInstructionsCloseClick);
        GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>().text = "10";
    }

    void Update()
    {
        
    }
    void btVoltarClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }void btInstructionsClick()
    {
        if (HelpPanel != null)
        {
            HelpPanel.SetActive(true);
            HelpPanel.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }
    }
    void btInstructionsCloseClick()
    {
        HelpPanel.SetActive(false);
    }
}
