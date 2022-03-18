using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Windows;

public class EndEdit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool wMouseOver = false;
    private List<string> edWithTooltip = new List<string>(){"mcfield00",
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

    private List<string> objMatrixAnt = new List<string>(){"/Canvas/pnMath/MatrixAnt/mafield00",
                                                           "/Canvas/pnMath/MatrixAnt/mafield01",
                                                           "/Canvas/pnMath/MatrixAnt/mafield02",
                                                           "/Canvas/pnMath/MatrixAnt/mafield03",
                                                           "/Canvas/pnMath/MatrixAnt/mafield10",
                                                           "/Canvas/pnMath/MatrixAnt/mafield11",
                                                           "/Canvas/pnMath/MatrixAnt/mafield12",
                                                           "/Canvas/pnMath/MatrixAnt/mafield13",
                                                           "/Canvas/pnMath/MatrixAnt/mafield20",
                                                           "/Canvas/pnMath/MatrixAnt/mafield21",
                                                           "/Canvas/pnMath/MatrixAnt/mafield22",
                                                           "/Canvas/pnMath/MatrixAnt/mafield23",
                                                           "/Canvas/pnMath/MatrixAnt/mafield30",
                                                           "/Canvas/pnMath/MatrixAnt/mafield31",
                                                           "/Canvas/pnMath/MatrixAnt/mafield32",
                                                           "/Canvas/pnMath/MatrixAnt/mafield33"};

    private List<string> objMatrixSum = new List<string>(){"/Canvas/pnMath/MatrixSum/mbfield00",
                                                           "/Canvas/pnMath/MatrixSum/mbfield01",
                                                           "/Canvas/pnMath/MatrixSum/mbfield02",
                                                           "/Canvas/pnMath/MatrixSum/mbfield03",
                                                           "/Canvas/pnMath/MatrixSum/mbfield10",
                                                           "/Canvas/pnMath/MatrixSum/mbfield11",
                                                           "/Canvas/pnMath/MatrixSum/mbfield12",
                                                           "/Canvas/pnMath/MatrixSum/mbfield13",
                                                           "/Canvas/pnMath/MatrixSum/mbfield20",
                                                           "/Canvas/pnMath/MatrixSum/mbfield21",
                                                           "/Canvas/pnMath/MatrixSum/mbfield22",
                                                           "/Canvas/pnMath/MatrixSum/mbfield23",
                                                           "/Canvas/pnMath/MatrixSum/mbfield30",
                                                           "/Canvas/pnMath/MatrixSum/mbfield31",
                                                           "/Canvas/pnMath/MatrixSum/mbfield32",
                                                           "/Canvas/pnMath/MatrixSum/mbfield33"};
    private string currentName = "";
    void Update()
    {
        if ((wMouseOver) && (currentName != this.name))
        {
            tooltip.pShowTooltip_Static(fTextTooltip(this.name));
            currentName = this.name;
        }
        if ((!this.GetComponent<InputField>().isFocused) && (this.GetComponent<InputField>().text.Length == 0))
        {
            this.GetComponent<InputField>().text = "0";
        }

    }
    private int fGetIndexList(int prList, string prString)
    {
        if (prList == 0)
        {
            return objMatrixSum.IndexOf("/Canvas/pnMath/MatrixSum/mbfield" + prString.Substring(prString.Length - 2, 2));

        }
        else
        {
            return objMatrixAnt.IndexOf("/Canvas/pnMath/MatrixAnt/mafield" + prString.Substring(prString.Length - 2, 2));
        }
    }
    private string fTextTooltip(string prString)
    {
        Color wColor = Color.yellow;
        Color wColorText;
        string wColorTooltip;
        string wSign = GameObject.Find("/Canvas/pnMath/lbSig").GetComponent<Text>().text;
        string prRet = "nope";
        pLimpaCores();
        if (wSign == "*")
        {
            prRet = "";
            //if (GameObject.Find("/Canvas/GameObject/field10").activeSelf)
            //{
                for (var i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            wColorText = Color.black;
                            wColorTooltip = "black";
                            break;
                        case 1:
                            wColorText = Color.grey;
                            wColorTooltip = "grey";
                            break;
                        case 2:
                            wColorText = Color.magenta;
                            wColorTooltip = "magenta";
                            break;
                        case 3:
                            wColorText = new Color32(0, 0, 128, 255);
                            wColorTooltip = "navy";
                            break;
                        default:
                            wColorText = Color.black;
                            wColorTooltip = "black";
                            break;
                    }
                    if (prRet != "")
                    {
                        prRet = prRet + " + ";
                    }
                    prRet = prRet + "<color=" + wColorTooltip + ">" + GameObject.Find(objMatrixAnt[fGetIndexList(1, prString.Substring(prString.Length - 2, 1) + i)]).GetComponentInChildren<InputField>().text + "</color>" + " * " +
                                    "<color=" + wColorTooltip + ">" + GameObject.Find(objMatrixSum[fGetIndexList(0, i + prString.Substring(prString.Length - 1, 1))]).GetComponentInChildren<InputField>().text + "</color>";
                    GameObject.Find(objMatrixAnt[fGetIndexList(1, prString.Substring(prString.Length - 2, 1) + i)]).GetComponentInChildren<Image>().color = wColor;
                    GameObject.Find(objMatrixSum[fGetIndexList(0, i + prString.Substring(prString.Length - 1, 1))]).GetComponentInChildren<Image>().color = wColor;
                    GameObject.Find(objMatrixAnt[fGetIndexList(1, prString.Substring(prString.Length - 2, 1) + i)]).GetComponentInChildren<InputField>().textComponent.color = wColorText;
                    GameObject.Find(objMatrixSum[fGetIndexList(0, i + prString.Substring(prString.Length - 1, 1))]).GetComponentInChildren<InputField>().textComponent.color = wColorText;
                }
            //}
            //else
            //{
                
            //}
        }
        else
        {
            prRet = GameObject.Find(objMatrixAnt[fGetIndexList(1, prString.Substring(prString.Length - 2, 2))]).GetComponentInChildren<InputField>().text + " " + wSign + " " +
                    GameObject.Find(objMatrixSum[fGetIndexList(0, prString.Substring(prString.Length - 2, 2))]).GetComponentInChildren<InputField>().text;
            GameObject.Find(objMatrixAnt[fGetIndexList(1, prString.Substring(prString.Length - 2, 2))]).GetComponentInChildren<Image>().color = wColor;
            GameObject.Find(objMatrixSum[fGetIndexList(0, prString.Substring(prString.Length - 2, 2))]).GetComponentInChildren<Image>().color = wColor;
        }
        return prRet;
    }
    private void pLimpaCores()
    {
        foreach (string comp in objMatrixAnt)
        {
            GameObject.Find(comp).GetComponentInChildren<Image>().color = Color.white;
            GameObject.Find(comp).GetComponentInChildren<InputField>().textComponent.color = Color.black;
        }
        foreach (string comp in objMatrixSum)
        {
            GameObject.Find(comp).GetComponentInChildren<Image>().color = Color.white;
            GameObject.Find(comp).GetComponentInChildren<InputField>().textComponent.color = Color.black;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (edWithTooltip.Contains(this.name) && (GameObject.Find("/Canvas/pnMath/lbSig").activeSelf))
        {
            wMouseOver = false;
            pLimpaCores();
            currentName = "";
            tooltip.pHideTooltip_Static();
        }

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (edWithTooltip.Contains(this.name) && (GameObject.Find("/Canvas/pnMath/lbSig").activeSelf))
        {
            wMouseOver = true;
        }
    }
}
