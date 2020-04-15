using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiHandler : MonoBehaviour
{
    public GameObject cube;
    public static Matrix4x4 matrix;
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
    // Start is called before the first frame update

    void OnDrawGizmos()
    {
       // Gizmos.color = new Color(0.75f, 0.0f, 0.0f, 0.75f);

        // Convert the local coordinate values into world
        // coordinates for the matrix transformation.
       Gizmos.matrix = transform.localToWorldMatrix;
       Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }

    void Start()
    {
        MeshRenderer gameObjectRenderer = cube.GetComponent<MeshRenderer>();
        Color red = new Color(255,211,0);

        Material newMaterial = new Material("Default-Material");


        newMaterial.color = red;
        gameObjectRenderer.material = newMaterial;

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


        var Col0 = new Vector4(float.Parse(field00.text), float.Parse(field01.text), float.Parse(field02.text), float.Parse(field03.text));
        var Col1 = new Vector4(float.Parse(field10.text), float.Parse(field11.text), float.Parse(field12.text), float.Parse(field13.text));
        var Col2 = new Vector4(float.Parse(field20.text), float.Parse(field21.text), float.Parse(field22.text), float.Parse(field23.text));
        var Col3 = new Vector4(float.Parse(field30.text), float.Parse(field31.text), float.Parse(field32.text), float.Parse(field33.text));

        matrix.SetColumn(0, Col0);
        matrix.SetColumn(1, Col1);
        matrix.SetColumn(2, Col2);
        matrix.SetColumn(3, Col3);

        Debug.Log("Restart:");
        Debug.Log(matrix.GetColumn(0));
        Debug.Log(matrix.GetColumn(1));
        Debug.Log(matrix.GetColumn(2));
        Debug.Log(matrix.GetColumn(3));
        //var m = Matrix4x4.TRS(position, rotation, scale);
        //cube.transform.position = position;
        //cube.transform.rotation = rotation;
        //cube.transform. = position;

    }

    // Update is called once per frame
    void Update()
    {
        var Col0 = new Vector4(float.Parse(field00.text), float.Parse(field01.text), float.Parse(field02.text), float.Parse(field03.text));
        var Col1 = new Vector4(float.Parse(field10.text), float.Parse(field11.text), float.Parse(field12.text), float.Parse(field13.text));
        var Col2 = new Vector4(float.Parse(field20.text), float.Parse(field21.text), float.Parse(field22.text), float.Parse(field23.text));
        var Col3 = new Vector4(float.Parse(field30.text), float.Parse(field31.text), float.Parse(field32.text), float.Parse(field33.text));

        

        matrix.SetColumn(0, Col0);
        matrix.SetColumn(1, Col1);
        matrix.SetColumn(2, Col2);
        matrix.SetColumn(3, Col3);

        //rotate
        Vector3 forward;
        forward.x = matrix.m02;
        forward.y = matrix.m12;
        forward.z = matrix.m22;
        Vector3 upwards;
        upwards.x = matrix.m01;
        upwards.y = matrix.m11;
        upwards.z = matrix.m21;
        cube.transform.rotation = Quaternion.LookRotation(forward, upwards);

        //scale
        Vector3 scale;
        scale.x = new Vector4(matrix.m00, matrix.m10, matrix.m20, matrix.m30).magnitude;
        scale.y = new Vector4(matrix.m01, matrix.m11, matrix.m21, matrix.m31).magnitude;
        scale.z = new Vector4(matrix.m02, matrix.m12, matrix.m22, matrix.m32).magnitude;
        cube.transform.localScale = scale;

        //position
        Vector3 position;
        position.x = matrix.m03;
        position.y = matrix.m13;
        position.z = matrix.m23;
        cube.transform.position = position;

        Debug.Log("Update:");
        Debug.Log(matrix.GetColumn(0));
        Debug.Log(matrix.GetColumn(1));
        Debug.Log(matrix.GetColumn(2));
        Debug.Log(matrix.GetColumn(3));

    }
}
