using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    public InputField field00;
    public InputField field01;
    public InputField field02;
    public InputField field03;
    public InputField field10;
    public InputField field11;
    public InputField field12;
    public InputField field13;
    public InputField field20;
    public InputField field21;
    public InputField field22;
    public InputField field23;
    public InputField field30;
    public InputField field31;
    public InputField field32;
    public InputField field33;
 public void Reset(){
     field00.text = "1";
        field01.text = "0";
        field02.text = "0";
        field03.text = "0";

        field10.text = "0";
        field11.text = "1";
        field12.text = "0";
        field13.text = "0";

        field20.text = "0";
        field21.text = "0";
        field22.text = "1";
        field23.text = "0";

        field30.text = "0";
        field31.text = "0";
        field32.text = "0";
        field33.text = "1";
 }
}
