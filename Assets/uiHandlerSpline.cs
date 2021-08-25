using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Line : MonoBehaviour {

	public Vector3 p0, p1;
}

[CustomEditor(typeof(Line))]
public class LineInspector : Editor {
    private void OnSceneGUI () {
		Line line = target as Line;

		Handles.color = Color.white;
		Handles.DrawLine(line.p0, line.p1);
	}
}

public class uiHandlerSpline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
