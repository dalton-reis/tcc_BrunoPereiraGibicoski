using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    
	public Button btMatrixScene;
	public Button btSplineScene;
	public Button btClose;

    void Start()
    {
		btMatrixScene.onClick.AddListener(matrixSceneOpener);   
		btSplineScene.onClick.AddListener(splineSceneOpener);       
		btClose.onClick.AddListener(appCloser);        
    }
    void matrixSceneOpener(){
       SceneManager.LoadScene("MatrixScene", LoadSceneMode.Single); 
    }
     void splineSceneOpener(){
       SceneManager.LoadScene("SplineScene", LoadSceneMode.Single); 
    }
    void appCloser(){
       Application.Quit();
    }


}
