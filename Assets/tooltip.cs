using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tooltip : MonoBehaviour {

    private Text tooltipText;

    [SerializeField]
    private Camera uiCamera;
    private RectTransform bgRectTrans;

    private GameObject tt;
    private void Awake(){
        tt = gameObject;
       //tt = transform.Find("/Canvas/Tooltip").GetComponent<GameObject>();
       bgRectTrans = transform.Find("/Canvas/Tooltip/bgTooltip").GetComponent<RectTransform>();
       tooltipText = transform.Find("/Canvas/Tooltip/textTooltip").GetComponent<Text>();
       pShowTooltip("ushaafdsf");
    }
    private void update(){
        Vector2 localpoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(),Input.mousePosition, uiCamera, out localpoint);
    transform.localPosition = localpoint;
    }
    private void pShowTooltip(string tooltipString){
        tt.SetActive(true);
        tooltipText.text = tooltipString;
        float textPaddingSize = 4f; 
        Vector2 bgSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        bgRectTrans.sizeDelta = bgSize;  
    }
    private void pHideTooltip(){
        tt.SetActive(false);

    }
    
}
