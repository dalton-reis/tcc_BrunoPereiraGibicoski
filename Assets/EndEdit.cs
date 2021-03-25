using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndEdit : MonoBehaviour
{
    public InputField mainInputField;

    void LockInput(InputField input)
    {
        if (input.text.Length > 0)
        {
            Debug.Log("Text has been entered");
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("Main Input Empty");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        //mainInputField.onEndEdit.AddListener(delegate { LockInput(mainInputField); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
