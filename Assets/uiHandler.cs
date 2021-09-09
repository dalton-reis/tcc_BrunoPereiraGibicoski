using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class matriz
{
    public int index;
    public Matrix4x4 matrix;
    public GameObject cube;

    public matriz(int pIndex, Matrix4x4 pMatrix, Color pCor)
    {
        index = pIndex;
        matrix = pMatrix;
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material.color = pCor;
        cube.name = index.ToString();
        cube.tag = "Cube";
    }
}

public class uiHandler : MonoBehaviour
{
    public List<matriz> allObjects;
    public static Matrix4x4 matrix;
    public static Matrix4x4 matrixSum;

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
    public Button btVoltar;
    public GameObject SumPanel;
    public Text xyzShow;

    private int wCubeIndex;
    private Color cor;
    private float strToFloat(InputField prImp)
    {
        if ((prImp.text == null) | (prImp.text == ""))
        {
            return 0;
        }
        else
        {
            return float.Parse(prImp.text);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }
    void Start()
    {
        //Inicialização de variáveis
        btCloseSumClick();
        allObjects = new List<matriz>();
        wCubeIndex = 0;
        cor = Color.yellow;
        //Ligando eventos aos seus respectivos botões
        btTransposta.onClick.AddListener(btTranspostaClick);
        btReset.onClick.AddListener(btResetClick);
        btCores.onClick.AddListener(btCoresClick);
        btInsert.onClick.AddListener(btInsertClick);
        btSum.onClick.AddListener(btSumClick);
        btCloseSum.onClick.AddListener(btCloseSumClick);
        btSumSum.onClick.AddListener(btSumSumClick);
        btPegaSum.onClick.AddListener(btPegaSumClick);
        btSumSub.onClick.AddListener(btSumSubClick);
        btSumMult.onClick.AddListener(btSumMultClick);
        btVoltar.onClick.AddListener(btVoltarClick);
        //Inicializando a matriz
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

        var Col0 = new Vector4(strToFloat(field00), strToFloat(field10), strToFloat(field20), strToFloat(field30));
        var Col1 = new Vector4(strToFloat(field01), strToFloat(field11), strToFloat(field21), strToFloat(field31));
        var Col2 = new Vector4(strToFloat(field02), strToFloat(field12), strToFloat(field22), strToFloat(field32));
        var Col3 = new Vector4(strToFloat(field03), strToFloat(field13), strToFloat(field23), strToFloat(field33));

        matrix.SetColumn(0, Col0);
        matrix.SetColumn(1, Col1);
        matrix.SetColumn(2, Col2);
        matrix.SetColumn(3, Col3);

        matriz m = new matriz(wCubeIndex, matrix, cor);
        allObjects.Add(m);
        xyzShow.text = "X:" + allObjects[wCubeIndex].cube.transform.position.x +
                       "/Y:" + allObjects[wCubeIndex].cube.transform.position.y +
                       "Z:" + allObjects[wCubeIndex].cube.transform.position.z;
    }

    void btVoltarClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
    void btCoresClick()
    {
        //Rotina que altera cor do polígono
        if (cor == Color.yellow)
        {
            cor = Color.blue;
        }
        else
        if (cor == Color.blue)
        {
            cor = Color.cyan;
        }
        else
        if (cor == Color.cyan)
        {
            cor = Color.grey;
        }
        else
        if (cor == Color.grey)
        {
            cor = Color.green;
        }
        else
        if (cor == Color.green)
        {
            cor = Color.white;
        }
        else
        if (cor == Color.white)
        {
            cor = Color.red;
        }
        else
        if (cor == Color.red)
        {
            cor = Color.magenta;
        }
        else
        {
            cor = Color.yellow;
        }
    }
    void btTranspostaClick()
    {
        //Rotina que converte a matriz na matriz transposta
        string f01 = field01.text;
        string f02 = field02.text;
        string f03 = field03.text;

        string f10 = field10.text;
        string f12 = field12.text;
        string f13 = field13.text;

        string f20 = field20.text;
        string f21 = field21.text;
        string f23 = field23.text;

        string f30 = field30.text;
        string f31 = field31.text;
        string f32 = field32.text;

        field01.text = f10;
        field02.text = f20;
        field03.text = f30;

        field10.text = f01;
        field12.text = f21;
        field13.text = f31;

        field20.text = f02;
        field21.text = f12;
        field23.text = f32;

        field30.text = f03;
        field31.text = f13;
        field32.text = f23;
    }
    void btInsertClick()
    {
        //Rotina que insere mais um polígono
        wCubeIndex = wCubeIndex + 1;
        btCoresClick();
        btResetClick();
        matriz m = new matriz(wCubeIndex, matrix, cor);
        allObjects.Add(m);
        xyzShow.text = "X:" + allObjects[wCubeIndex].cube.transform.position.x +
                       "/Y:" + allObjects[wCubeIndex].cube.transform.position.y +
                       "/Z:" + allObjects[wCubeIndex].cube.transform.position.z;
    }
    void btResetClick()
    {
        //Rotina que converte a matriz para a matriz identidade
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

        var Col0 = new Vector4(strToFloat(field00), strToFloat(field10), strToFloat(field20), strToFloat(field30));
        var Col1 = new Vector4(strToFloat(field01), strToFloat(field11), strToFloat(field21), strToFloat(field31));
        var Col2 = new Vector4(strToFloat(field02), strToFloat(field12), strToFloat(field22), strToFloat(field32));
        var Col3 = new Vector4(strToFloat(field03), strToFloat(field13), strToFloat(field23), strToFloat(field33));

        matrix.SetColumn(0, Col0);
        matrix.SetColumn(1, Col1);
        matrix.SetColumn(2, Col2);
        matrix.SetColumn(3, Col3);

        Debug.Log("Restart:");
        Debug.Log(matrix.ToString());
    }
    void btDeleteClick()
    {
        //Rotina que deleta o polígono atual
        if (allObjects.Count > 1)
        {
            Destroy(allObjects[wCubeIndex].cube);
            allObjects.Remove(allObjects[wCubeIndex]);
            wCubeIndex = allObjects.Count - 1;
            cor = allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color;
            matrix = allObjects[wCubeIndex].matrix;
            field00.text = matrix.m00.ToString();
            field01.text = matrix.m01.ToString();
            field02.text = matrix.m02.ToString();
            field03.text = matrix.m03.ToString();
            field10.text = matrix.m10.ToString();
            field11.text = matrix.m11.ToString();
            field12.text = matrix.m12.ToString();
            field13.text = matrix.m13.ToString();
            field20.text = matrix.m20.ToString();
            field21.text = matrix.m21.ToString();
            field22.text = matrix.m22.ToString();
            field23.text = matrix.m23.ToString();
            field30.text = matrix.m30.ToString();
            field31.text = matrix.m31.ToString();
            field32.text = matrix.m32.ToString();
            field33.text = matrix.m33.ToString();
        }
        else
        {
            btResetClick();
        }
    }
    void Update()
    {
        //Rotina padrão que é ativada uma vez por frame
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                //Debug.Log("name: " + hitInfo.transform.gameObject.name);
                //Debug.Log("tag: " + hitInfo.transform.gameObject.tag);
                if (hitInfo.transform.gameObject.tag == "Cube")
                {
                    wCubeIndex = int.Parse(hitInfo.transform.gameObject.name);
                    cor = allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color;
                    matrix = allObjects[wCubeIndex].matrix;
                    field00.text = matrix.m00.ToString();
                    field01.text = matrix.m01.ToString();
                    field02.text = matrix.m02.ToString();
                    field03.text = matrix.m03.ToString();
                    field10.text = matrix.m10.ToString();
                    field11.text = matrix.m11.ToString();
                    field12.text = matrix.m12.ToString();
                    field13.text = matrix.m13.ToString();
                    field20.text = matrix.m20.ToString();
                    field21.text = matrix.m21.ToString();
                    field22.text = matrix.m22.ToString();
                    field23.text = matrix.m23.ToString();
                    field30.text = matrix.m30.ToString();
                    field31.text = matrix.m31.ToString();
                    field32.text = matrix.m32.ToString();
                    field33.text = matrix.m33.ToString();
                }
                else
                {
                    //Debug.Log ("nopz " + hitInfo.transform.gameObject.tag);
                }
            }
            //else {
            //    Debug.Log("No hit");
            //}
        }
        allObjects[wCubeIndex].cube.GetComponent<Renderer>().material.color = cor;

        var Col0 = new Vector4(strToFloat(field00), strToFloat(field10), strToFloat(field20), strToFloat(field30));
        var Col1 = new Vector4(strToFloat(field01), strToFloat(field11), strToFloat(field21), strToFloat(field31));
        var Col2 = new Vector4(strToFloat(field02), strToFloat(field12), strToFloat(field22), strToFloat(field32));
        var Col3 = new Vector4(strToFloat(field03), strToFloat(field13), strToFloat(field23), strToFloat(field33));

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
        Debug.Log(matrix.ToString());

        xyzShow.text = "X:" + allObjects[wCubeIndex].cube.transform.position.x +
                       "/Y:" + allObjects[wCubeIndex].cube.transform.position.y +
                       "/Z:" + allObjects[wCubeIndex].cube.transform.position.z;
    }
    void btSumClick()
    {

        if (SumPanel != null)
        {
            SumPanel.SetActive(true);
        }
        GameObject.Find("/Canvas/pnMath/lbEqual").SetActive(false);
        GameObject.Find("/Canvas/pnMath/lbSig").SetActive(false);
        GameObject[] FoundObject = GameObject.FindGameObjectsWithTag("editSomaMa");

        foreach (GameObject obj in FoundObject)
        {

            obj.SetActive(true);

            if (obj.GetComponentInChildren<InputField>() != null)
            {
                InputField maField = obj.GetComponentInChildren<InputField>();

                //Debug.Log(maField.name);
                switch (maField.name)
                {
                    case "mafield00":
                        maField.text = matrix.m00.ToString();
                        break;
                    case "mafield01":
                        maField.text = matrix.m01.ToString();
                        break;
                    case "mafield02":
                        maField.text = matrix.m02.ToString();
                        break;
                    case "mafield03":
                        maField.text = matrix.m03.ToString();
                        break;
                    case "mafield10":
                        maField.text = matrix.m10.ToString();
                        break;
                    case "mafield11":
                        maField.text = matrix.m11.ToString();
                        break;
                    case "mafield12":
                        maField.text = matrix.m12.ToString();
                        break;
                    case "mafield13":
                        maField.text = matrix.m13.ToString();
                        break;
                    case "mafield20":
                        maField.text = matrix.m20.ToString();
                        break;
                    case "mafield21":
                        maField.text = matrix.m21.ToString();
                        break;
                    case "mafield22":
                        maField.text = matrix.m22.ToString();
                        break;
                    case "mafield23":
                        maField.text = matrix.m23.ToString();
                        break;
                    case "mafield30":
                        maField.text = matrix.m30.ToString();
                        break;
                    case "mafield31":
                        maField.text = matrix.m31.ToString();
                        break;
                    case "mafield32":
                        maField.text = matrix.m32.ToString();
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

        foreach (GameObject obj in FoundObject)
        {

            obj.SetActive(true);

            if (obj.GetComponentInChildren<InputField>() != null)
            {
                InputField maField = obj.GetComponentInChildren<InputField>();
                maField.text = "0";
            }
        }
        FoundObject = GameObject.FindGameObjectsWithTag("editSomaMc");

        foreach (GameObject obj in FoundObject)
        {

            obj.SetActive(true);

            if (obj.GetComponentInChildren<InputField>() != null)
            {
                InputField maField = obj.GetComponentInChildren<InputField>();
                maField.text = "0";
            }
        }


    }
    void btCloseSumClick()
    {
        SumPanel.SetActive(false);
    }
    void btSumSumClick()
    {
        GameObject.Find("/Canvas/pnMath/lbEqual").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").GetComponentInChildren<Text>().text = "+";
        var Col0 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text));

        var Col1 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text));

        var Col2 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text));

        var Col3 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) + float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);

        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();

    }
    void btSumSubClick()
    {
        GameObject.Find("/Canvas/pnMath/lbEqual").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").GetComponentInChildren<Text>().text = "-";
        var Col0 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text));

        var Col1 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text));

        var Col2 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text));

        var Col3 = new Vector4(float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text),
                               float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) - float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);

        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();

    }
    void btSumMultClick()
    {
        GameObject.Find("/Canvas/pnMath/lbEqual").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").SetActive(true);
        GameObject.Find("/Canvas/pnMath/lbSig").GetComponentInChildren<Text>().text = "*";
        var Col0 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield00").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield10").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield20").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield30").GetComponentInChildren<InputField>().text))));

        var Col1 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield01").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield11").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield21").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield31").GetComponentInChildren<InputField>().text))));

        var Col2 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield02").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield12").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield22").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield32").GetComponentInChildren<InputField>().text))));

        var Col3 = new Vector4(
            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield00").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield01").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield02").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield03").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield10").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield11").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield12").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield13").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield20").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield21").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield22").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield23").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))),

            ((float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield30").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield03").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield31").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield13").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield32").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield23").GetComponentInChildren<InputField>().text)) +
             (float.Parse(GameObject.Find("/Canvas/pnMath/MatrixAnt/mafield33").GetComponentInChildren<InputField>().text) * float.Parse(GameObject.Find("/Canvas/pnMath/MatrixSum/mbfield33").GetComponentInChildren<InputField>().text))));

        matrixSum.SetColumn(0, Col0);
        matrixSum.SetColumn(1, Col1);
        matrixSum.SetColumn(2, Col2);
        matrixSum.SetColumn(3, Col3);

        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield00").GetComponentInChildren<InputField>().text = matrixSum.m00.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield01").GetComponentInChildren<InputField>().text = matrixSum.m01.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield02").GetComponentInChildren<InputField>().text = matrixSum.m02.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield03").GetComponentInChildren<InputField>().text = matrixSum.m03.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield10").GetComponentInChildren<InputField>().text = matrixSum.m10.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield11").GetComponentInChildren<InputField>().text = matrixSum.m11.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield12").GetComponentInChildren<InputField>().text = matrixSum.m12.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield13").GetComponentInChildren<InputField>().text = matrixSum.m13.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield20").GetComponentInChildren<InputField>().text = matrixSum.m20.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield21").GetComponentInChildren<InputField>().text = matrixSum.m21.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield22").GetComponentInChildren<InputField>().text = matrixSum.m22.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield23").GetComponentInChildren<InputField>().text = matrixSum.m23.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield30").GetComponentInChildren<InputField>().text = matrixSum.m30.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield31").GetComponentInChildren<InputField>().text = matrixSum.m31.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield32").GetComponentInChildren<InputField>().text = matrixSum.m32.ToString();
        GameObject.Find("/Canvas/pnMath/MatrixPos/mcfield33").GetComponentInChildren<InputField>().text = matrixSum.m33.ToString();

    }
    void btPegaSumClick()
    {
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
