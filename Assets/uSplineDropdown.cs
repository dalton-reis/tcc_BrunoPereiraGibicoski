using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uSplineDropdown : MonoBehaviour
{
    Dropdown wDropdown;
    public GameObject p4,p5,p6,p7,p8,p9,p10;

    void Start()
    {
        wDropdown = GetComponent<Dropdown>();

        wDropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(wDropdown);
        });
        DropdownValueChanged(wDropdown);

    }

    void DropdownValueChanged(Dropdown prDrop)
    {
        //Debug.Log(prDrop.value);
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
        p7.SetActive(false);
        p8.SetActive(false);
        p9.SetActive(false);
        p10.SetActive(false);
        switch (prDrop.value)
        {
            case 1:
                p4.SetActive(true);
                break;

            case 2:
                p4.SetActive(true);
                p5.SetActive(true);
                break;

            case 3:
                p4.SetActive(true);
                p5.SetActive(true);
                p6.SetActive(true);
                break;

            case 4:
                p4.SetActive(true);
                p5.SetActive(true);
                p6.SetActive(true);
                p7.SetActive(true);
                break;

            case 5:
                p4.SetActive(true);
                p5.SetActive(true);
                p6.SetActive(true);
                p7.SetActive(true);
                p8.SetActive(true);
                break;

            case 6:
                p4.SetActive(true);
                p5.SetActive(true);
                p6.SetActive(true);
                p7.SetActive(true);
                p8.SetActive(true);
                p9.SetActive(true);
                break;

            case 7:
                p4.SetActive(true);
                p5.SetActive(true);
                p6.SetActive(true);
                p7.SetActive(true);
                p8.SetActive(true);
                p9.SetActive(true);
                p10.SetActive(true);
                break;
        }
    }
}
