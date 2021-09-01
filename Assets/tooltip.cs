using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltip : MonoBehaviour {

    public static tooltip instance;
    private Text tooltipText;

    private RectTransform bgRectTrans;

    private void Awake(){
       instance = this;
       bgRectTrans = transform.Find("/Canvas/Tooltip/bgTooltip").GetComponent<RectTransform>();
       tooltipText = transform.Find("/Canvas/Tooltip/textTooltip").GetComponent<Text>();
       //pShowTooltip("testhrthrthrtjhrthurtjhft");
       pHideTooltip();
    }
    private void Update(){
        Vector2 localpoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(),Input.mousePosition, null, out localpoint);
        transform.localPosition = localpoint;
    }
    private void pShowTooltip(string tooltipString){
        gameObject.SetActive(true);
        tooltipText.text = tooltipString;
        float textPaddingSize = 4f; 
        Vector2 bgSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        bgRectTrans.sizeDelta = bgSize;  
    }
    private void pHideTooltip(){
        gameObject.SetActive(false);

    }
    public static void pShowTooltip_Static(string tooltipString){
        instance.pShowTooltip(tooltipString);
    }    
    public static void pHideTooltip_Static(){
        instance.pHideTooltip();
    }
}
