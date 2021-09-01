using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EndEdit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
{
    private bool wMouseOver = false;
    private List<string> edWithTooltip = new List<string>();
    private string currentName = "";

    private void Awake(){
        string[] edits = {"mcfield00",
                          "mcfield01",
                          "mcfield02",
                          "mcfield03",
                          "mcfield10",
                          "mcfield11",
                          "mcfield12",
                          "mcfield13",
                          "mcfield20",
                          "mcfield21",
                          "mcfield22",
                          "mcfield23",
                          "mcfield30",
                          "mcfield31",
                          "mcfield32",
                          "mcfield33"};
        edWithTooltip.AddRange(edits);
    }

    void Update()
    {
        if ((wMouseOver)&&(currentName != this.name)){
         tooltip.pShowTooltip_Static(fTextTooltip(this.name));
         currentName = this.name;
        }
        if ((!this.GetComponent<InputField>().isFocused) && (this.GetComponent<InputField>().text.Length == 0))
        {
            this.GetComponent<InputField>().text = "0";   
        }
        
    }
    private string fTextTooltip(string prString){

        string str = GameObject.Find("/Canvas/pnMath/lbSig").GetComponent<Text>().text;  
		pLimpaCores();
        switch (prString){
                   case "mcfield00":
                   if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                   break;
                    case "mcfield01":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield02":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield03":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                case "mcfield10":
                   if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                   break;
                    case "mcfield11":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield12":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield13":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                   case "mcfield20":
                   if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                   break;
                    case "mcfield21":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield22":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield23":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                case "mcfield30":
                   if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                   break;
                    case "mcfield31":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield32":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;
                    case "mcfield33":
                    if(str == "+"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " + " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow;                  
                   }else 
                   if(str == "-"){
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " - " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow;        
                   }else{
                    prString = GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text + " + " +
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text + " * " + 
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text;

                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.yellow; 
                               GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.yellow;  
                               GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.yellow; 
                   }
                    break;                 
                   default:
                   prString = "Campo não tratado";
                   break;                      
                }
        return prString;
    }
     private void pLimpaCores()
     {
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<Image>().color = Color.white;
		 
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<Image>().color = Color.white;
         GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<Image>().color = Color.white;
     }
      public void OnPointerExit(PointerEventData eventData)
     {
         wMouseOver = false;
		 if(edWithTooltip.Contains(this.name)&&(GameObject.Find("/Canvas/pnMath/lbSig").activeSelf)){
		 pLimpaCores();
         currentName = "";
        }

         //tooltip.pShowTooltip_Static("saiu");
         tooltip.pHideTooltip_Static();
     }
	 
	 public void OnPointerEnter(PointerEventData eventData)
     {
        if(edWithTooltip.Contains(this.name) && (GameObject.Find("/Canvas/pnMath/lbSig").activeSelf)){
         wMouseOver = true;

        } 
         //do stuff
     }
}
