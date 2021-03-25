using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matriz
{
    public matriz(int pIndex,Matrix4x4 pMatrix, Color pCor){
      index = pIndex;
      matrix = pMatrix;
      cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
      cube.GetComponent<Renderer>().material.color = pCor;
      cube.name = index.ToString();
      cube.tag = "Cube";
    }
    public int index;
   
    public Matrix4x4 matrix;  
    public GameObject cube;



}

public class uiHandler : MonoBehaviour
{
    

 public List<matriz> allObjects;
    public static Matrix4x4 matrix;

    public static Matrix4x4 matrixSum;
    private int wCubeIndex;
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
    
    public Button btReset;
    
    public Button btTransposta;
    public Button btCores;
    public Button btInsert;
    public Button btDelete;
    public Button btSum;
    public Button btCloseSum;
    public Button btSumSum;
    public Button btPegaSum;
    public Button btSumSub;
    public Button btSumMult;
    
    private Color cor;
    public GameObject SumPanel;
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
        btCloseSumClick();
        allObjects= new List<matriz>();
        wCubeIndex = 0;
        cor = Color.yellow;
        btTransposta.onClick.AddListener(btTranspostaClick); 
        btReset.onClick.AddListener(btResetClick);
        btCores.onClick.AddListener(btCoresClick);
        btInsert.onClick.AddListener(btInsertClick);
        btDelete.onClick.AddListener(btDeleteClick);
        btSum.onClick.AddListener(btSumClick);
        btCloseSum.onClick.AddListener(btCloseSumClick);
        btSumSum.onClick.AddListener(btSumSumClick);
        btPegaSum.onClick.AddListener(btPegaSumClick);
        btSumSub.onClick.AddListener(btSumSubClick);
        btSumMult.onClick.AddListener(btSumMultClick);
        
        
        

//List<GameObject> selected = new List<GameObject>();
 //while ( selected.Count < 5 ) {
 //  int randomIndex = Random.Range( 0, allObjects.Count );
 //  if ( !selected.Contains( allObjects[randomIndex] ) )
  //   selected.Add( allObjects[randomIndex] );
// }

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
        //var m = Matrix4x4.TRS(position, rotation, scale);
        //cube.transform.position = position;
        //cube.transform.rotation = rotation;
        //cube.transform. = position;
        
        matriz m = new matriz(wCubeIndex,matrix,cor);
        allObjects.Add(m);
        //public matriz(int pIndex,Matrix4x4 pMatrix, Color pCor)
    }

    void btCoresClick(){
    if (cor == Color.yellow){
        cor = Color.blue;

    }else
    if (cor == Color.blue){
    cor = Color.cyan;

    }else
    if (cor == Color.cyan){
    cor = Color.grey;

    }else
    if (cor == Color.grey){
    cor = Color.green;

    }else
    if (cor == Color.green){
    cor = Color.white;

    }else
    if (cor == Color.white){
    cor = Color.red;

    }else
    if (cor == Color.red){
    cor = Color.magenta;
    
    }else{
    cor = Color.yellow;
    }
    
    

    }

    void btTranspostaClick(){
        //string f00;
        string f01 = field01.text;
        string f02 = field02.text;
        string f03 = field03.text;
        string f10 = field10.text;
        //string f11;
        string f12 = field12.text;
        string f13 = field13.text;
        string f20 = field20.text;
        string f21 = field21.text;
        //string f22;
        string f23 = field23.text;
        string f30 = field30.text;
        string f31 = field31.text;
        string f32 = field32.text;
        //string f33;
        //field00.text = "1";
        field01.text = f10;
        field02.text = f20;
        field03.text = f30;

        field10.text = f01;
        //field11.text = "1";
        field12.text = f21;
        field13.text = f31;

        field20.text = f02;
        field21.text = f12;
        //field22.text = "1";
        field23.text = f32;

        field30.text = f03;
        field31.text = f13;
        field32.text = f23;
        //field33.text = "1";
    }

    void btInsertClick(){
        wCubeIndex = wCubeIndex + 1;
        btCoresClick();
        btResetClick();
        matriz m = new matriz(wCubeIndex,matrix,cor);
        allObjects.Add(m);
    }
    void btResetClick()
    {
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
    }

    void btDeleteClick(){
        
        //GameObject cube = allObjects[wCubeIndex];
        if (allObjects.Count > 1){
            Destroy(allObjects[wCubeIndex].cube);
            allObjects.Remove(allObjects[wCubeIndex]);
            wCubeIndex = allObjects.Count - 1;
            cor = allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color;
            matrix = allObjects[wCubeIndex].matrix;
            field00.text = matrix.m00.ToString();
            field01.text = matrix.m10.ToString();
            field02.text = matrix.m20.ToString();
            field03.text = matrix.m30.ToString();
            field10.text = matrix.m01.ToString();
            field11.text = matrix.m11.ToString();
            field12.text = matrix.m21.ToString();
            field13.text = matrix.m31.ToString();
            field20.text = matrix.m02.ToString();
            field21.text = matrix.m12.ToString();
            field22.text = matrix.m22.ToString();
            field23.text = matrix.m32.ToString();
            field30.text = matrix.m03.ToString();
            field31.text = matrix.m13.ToString();
            field32.text = matrix.m23.ToString();
            field33.text = matrix.m33.ToString();
        } else{
        btResetClick();

        }
    }
        void Update()
    {
     
     if (Input.GetMouseButtonDown(0))
     {
         Debug.Log("Mouse is down");
         
         RaycastHit hitInfo = new RaycastHit();
         bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
         if (hit) 
         {
             Debug.Log("name: " + hitInfo.transform.gameObject.name);
             Debug.Log("tag: " + hitInfo.transform.gameObject.tag);
             if (hitInfo.transform.gameObject.tag == "Cube")
             {
            wCubeIndex = int.Parse(hitInfo.transform.gameObject.name);
            cor = allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color;
            matrix = allObjects[wCubeIndex].matrix;
            field00.text = matrix.m00.ToString();
            field01.text = matrix.m10.ToString();
            field02.text = matrix.m20.ToString();
            field03.text = matrix.m30.ToString();
            field10.text = matrix.m01.ToString();
            field11.text = matrix.m11.ToString();
            field12.text = matrix.m21.ToString();
            field13.text = matrix.m31.ToString();
            field20.text = matrix.m02.ToString();
            field21.text = matrix.m12.ToString();
            field22.text = matrix.m22.ToString();
            field23.text = matrix.m32.ToString();
            field30.text = matrix.m03.ToString();
            field31.text = matrix.m13.ToString();
            field32.text = matrix.m23.ToString();
            field33.text = matrix.m33.ToString();

                 Debug.Log ("It's working!");
             } else {
                 Debug.Log ("nopz " + hitInfo.transform.gameObject.tag);
             }
         } else {
             Debug.Log("No hit");
         }
         Debug.Log("Mouse is down");
     } 

        allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color = cor;
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
        allObjects[wCubeIndex].cube.transform.rotation = Quaternion.LookRotation(forward, upwards);

        //scale
        Vector3 scale;
        scale.x = new Vector4(matrix.m00, matrix.m10, matrix.m20, matrix.m30).magnitude;
        scale.y = new Vector4(matrix.m01, matrix.m11, matrix.m21, matrix.m31).magnitude;
        scale.z = new Vector4(matrix.m02, matrix.m12, matrix.m22, matrix.m32).magnitude;
        allObjects[wCubeIndex].cube.transform.localScale = scale;

        //position
        Vector3 position;
        position.x = matrix.m03;
        position.y = matrix.m13;
        position.z = matrix.m23;
        allObjects[wCubeIndex].cube.transform.position = position;

        
        allObjects[wCubeIndex].matrix = matrix;

        Debug.Log("Update:");
        Debug.Log(matrix.GetColumn(0));
        Debug.Log(matrix.GetColumn(1));
        Debug.Log(matrix.GetColumn(2));
        Debug.Log(matrix.GetColumn(3));

    }

    void btSumClick(){

        if (SumPanel != null)
            {
             SumPanel.SetActive(true);
            }

        GameObject[] FoundObject = GameObject.FindGameObjectsWithTag("editSomaMa");

         foreach (GameObject obj in FoundObject) {
             
             obj.SetActive (true); 
              
            if (obj.GetComponentInChildren<InputField>() != null){
                InputField maField = obj.GetComponentInChildren<InputField>();
                
                //Debug.Log(maField.name);
                switch (maField.name){
                   case "mafield00":
                   maField.text = matrix.m00.ToString();
                   break;
                   case "mafield01":
                   maField.text = matrix.m10.ToString();
                   break;
                   case "mafield02":
                   maField.text = matrix.m20.ToString();
                   break;
                   case "mafield03":
                   maField.text = matrix.m30.ToString();
                   break;
                   case "mafield10":
                   maField.text = matrix.m01.ToString();
                   break;
                   case "mafield11":
                   maField.text = matrix.m11.ToString();
                   break;
                   case "mafield12":
                   maField.text = matrix.m21.ToString();
                   break;
                   case "mafield13":
                   maField.text = matrix.m31.ToString();
                   break;
                   case "mafield20":
                   maField.text = matrix.m02.ToString();
                   break;
                   case "mafield21":
                   maField.text = matrix.m12.ToString();
                   break;
                   case "mafield22":
                   maField.text = matrix.m22.ToString();
                   break;
                   case "mafield23":
                   maField.text = matrix.m32.ToString();
                   break;
                   case "mafield30":
                   maField.text = matrix.m03.ToString();
                   break;
                   case "mafield31":
                   maField.text = matrix.m13.ToString();
                   break;
                   case "mafield32":
                   maField.text = matrix.m23.ToString();
                   break;
                   case "mafield33":
                   maField.text = matrix.m33.ToString();
                   break;
                  
                   default:
                   maField.text = "0";
                   break; 
                     
                }
                
            } 
         }
        FoundObject = GameObject.FindGameObjectsWithTag("editSomaMb");

         foreach (GameObject obj in FoundObject) {
             
             obj.SetActive (true); 
              
            if (obj.GetComponentInChildren<InputField>() != null){
                InputField maField = obj.GetComponentInChildren<InputField>();
                maField.text = "0";
                
                //Debug.Log(maField.name);
                // switch (maField.name){
                //    case "mbfield00":
                //    maField.text = "1";
                //    break;
                //    case "mbfield11":
                //    maField.text = "1";
                //    break;
                //    case "mbfield22":
                //    maField.text = "1";
                //    break;
                //    case "mbfield33":
                //    maField.text = "1";
                //    break;
                  
                //    default:
                //    maField.text = "0";
                //    break; 
                     
                // }
                
            } 
         }
        FoundObject = GameObject.FindGameObjectsWithTag("editSomaMc");

         foreach (GameObject obj in FoundObject) {
             
             obj.SetActive (true); 
              
            if (obj.GetComponentInChildren<InputField>() != null){
                InputField maField = obj.GetComponentInChildren<InputField>();
                maField.text = "0";
                //Debug.Log(maField.name);
                // switch (maField.name){
                //    case "mcfield00":
                //    maField.text = "1";
                //    break;
                //    case "mcfield11":
                //    maField.text = "1";
                //    break;
                //    case "mcfield22":
                //    maField.text = "1";
                //    break;
                //    case "mcfield33":
                //    maField.text = "1";
                //    break;
                  
                //    default:
                //    maField.text = "0";
                //    break; 
                     
                // }
                
            } 
         } 
        

    }
    void btCloseSumClick(){
            SumPanel.SetActive(false);
    }
    void btSumSumClick(){
       
        var Col0 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text));
        
        var Col1 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text));
        
        var Col2 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text));
        
        var Col3 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);       

        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();
         
    }
    void btSumSubClick(){
       
        var Col0 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text));
        
        var Col1 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text));
        
        var Col2 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text));
        
        var Col3 = new Vector4(float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text), 
                               float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);       

        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();
         
    }

       void btSumMultClick(){
       
        var Col0 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))), 
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))));
        
        var Col1 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))), 
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))));
        
        var Col2 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))), 
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))));
        
        var Col3 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))), 
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))),
            
            ((float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/Panel/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/Panel/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);       

        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/Panel/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();
         
    }
    void btPegaSumClick(){
        field00.text = matrixSum.m00.ToString();
        field01.text = matrixSum.m01.ToString();
        field02.text = matrixSum.m02.ToString();
        field03.text = matrixSum.m03.ToString();

        field10.text = matrixSum.m10.ToString();
        field11.text = matrixSum.m11.ToString();
        field12.text = matrixSum.m12.ToString();
        field13.text = matrixSum.m13.ToString();

        field20.text = matrixSum.m20.ToString();
        field21.text = matrixSum.m21.ToString();
        field22.text = matrixSum.m22.ToString();
        field23.text = matrixSum.m23.ToString();

        field30.text = matrixSum.m30.ToString();
        field31.text = matrixSum.m31.ToString();
        field32.text = matrixSum.m32.ToString();
        field33.text = matrixSum.m33.ToString();  
        SumPanel.SetActive(false);
    }
}
