using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiHandlerSpline : MonoBehaviour
{
    public Button btVoltar;

    void Start()
    {
        btVoltar.onClick.AddListener(btVoltarClick);
        GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>().text = "10";
    }

    void Update()
    {
        
    }
    void btVoltarClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
