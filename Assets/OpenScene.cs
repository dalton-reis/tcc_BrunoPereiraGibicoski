using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    
	public Button btMatrix;
    void Start()
    {
		btMatrix.onClick.AddListener(matrixSceneOpener);         
    }
    void matrixSceneOpener(){
       SceneManager.LoadScene("MatrixScene", LoadSceneMode.Single); 
    }

}
