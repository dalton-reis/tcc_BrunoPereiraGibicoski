using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class uSphere : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler
{
    
    private bool wMouseOver = false;
    // Start is called before the first frame update
    private float wT;

    // Update is called once per frame
    void Update()
    {
     if ((wMouseOver))
        {
            tooltip.pShowTooltip_Static("T = " + wT);
        }
    }
    public void setT(float prfloat)
    {
        wT = prfloat;
    }
      public void OnMouseExit()
    {
            wMouseOver = false;
            tooltip.pHideTooltip_Static();

    }
    public void OnMouseOver()
    {
            wMouseOver = true;
    }
}
