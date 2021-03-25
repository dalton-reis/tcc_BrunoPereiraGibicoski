using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumPanel : MonoBehaviour
{
    public GameObject Panel;
    public static Matrix4x4 matrixA;
    
    public InputField fieldA00;
    public InputField fieldA01;
    public InputField fieldA02;
    public InputField fieldA03;
    public InputField fieldA10;
    public InputField fieldA11;
    public InputField fieldA12;
    
    public InputField fieldA13;
    public InputField fieldA20;
    public InputField fieldA21;
    public InputField fieldA22;
    public InputField fieldA23;
    public InputField fieldA30;
    public InputField fieldA31;
    public InputField fieldA32;
    public InputField fieldA33;
    public static Matrix4x4 matrixB;
    public InputField fieldB00;
    public InputField fieldB01;
    public InputField fieldB02;
    public InputField fieldB03;
    public InputField fieldB10;
    public InputField fieldB11;
    public InputField fieldB12;
    public InputField fieldB13;
    public InputField fieldB20;
    public InputField fieldB21;
    public InputField fieldB22;
    public InputField fieldB23;
    public InputField fieldB30;
    public InputField fieldB31;
    public InputField fieldB32;
    public InputField fieldB33;
    public static Matrix4x4 matrixC;
    public InputField fieldC00;
    public InputField fieldC01;
    public InputField fieldC02;
    public InputField fieldC03;
    public InputField fieldC10;
    public InputField fieldC11;
    public InputField fieldC12;
    public InputField fieldC13;
    public InputField fieldC20;
    public InputField fieldC21;
    public InputField fieldC22;
    public InputField fieldC23;
    public InputField fieldC30;
    public InputField fieldC31;
    public InputField fieldC32;
    public InputField fieldC33;


    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
    public void ClosePanel()
    {
        //if (Panel != null)
        //{
            Panel.SetActive(false);
        //}
    }
}
