using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class uBezier : MonoBehaviour
{
    public LineRenderer wLineRenderer;


    private int wQtdPoints;
    private Vector3[] wPositions;
    private Vector3[] wPoints;
    private Vector3[] wPoints2;
    private GameObject[] wCList;
    private LineRenderer lineRenderer;
    public GameObject[] wGameObjList;
    private int dropDownIndex;

    private void setPoint(GameObject prPoint, Vector3 prVect)
    {
        //Debug.Log("set");
        prPoint.transform.GetChild(0).gameObject.GetComponent<InputField>().text = prVect.x.ToString();
        prPoint.transform.GetChild(1).gameObject.GetComponent<InputField>().text = prVect.y.ToString();
        prPoint.transform.GetChild(2).gameObject.GetComponent<InputField>().text = prVect.z.ToString();
    }
    private Vector3 getPoint(GameObject prPoint)
    {
        //Debug.Log("get");
        return new Vector3(uiHandler.strToFloat(prPoint.transform.GetChild(0).gameObject.GetComponent<InputField>()), uiHandler.strToFloat(prPoint.transform.GetChild(1).gameObject.GetComponent<InputField>()), uiHandler.strToFloat(prPoint.transform.GetChild(2).gameObject.GetComponent<InputField>()));
    }
    void pGetPointsStart()
    {
        if (wPoints == null)
        {
            wPoints = new Vector3[10];
        }
        dropDownIndex = GameObject.Find("/Canvas/Dropdown").GetComponent<Dropdown>().value;
        wPoints[0] = new Vector3(-10, 0, 0);
        wPoints[0] = new Vector3(-10, 0, 0);
        wPoints[1] = new Vector3(0, 10, 0);
        wPoints[2] = new Vector3(10, 0, 0);
        wPoints[3] = new Vector3(-10, 0, 0);
        wPoints[4] = new Vector3(0, 10, 0);
        wPoints[5] = new Vector3(10, 0, 0);
        wPoints[6] = new Vector3(-10, 0, 0);
        wPoints[7] = new Vector3(0, 10, 0);
        wPoints[8] = new Vector3(10, 0, 0);
        wPoints[9] = new Vector3(10, 0, 0);
    }
    void Awake()
    {
        pGetPointsStart();
        for (int i = 0; i < wPoints.Length; i++)
        {
            setPoint(wGameObjList[i], wPoints[i]);
        }
        lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
        lineRenderer.startColor = Color.black;
        lineRenderer.loop = false;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material.color = Color.black;
    }
    void Start()
    {
        wQtdPoints = uiHandler.strToInt(GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>());


        wQtdPoints = wQtdPoints - 1;
        wPositions = new Vector3[wQtdPoints + 1];
        wLineRenderer.positionCount = wQtdPoints + 1;



        Gizmos.color = Color.yellow;
        wCList = new GameObject[wQtdPoints + 1];
        for (int i = 0; i < wQtdPoints + 1; i++)
        {
            wCList[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            wCList[i].transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            wCList[i].AddComponent<uSphere>();
        }
    }

    void Update()
    {
        if ((uiHandler.strToInt(GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>()) != 1) && (wQtdPoints + 1 != uiHandler.strToInt(GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>())))
        {

            for (int i = 0; i < wQtdPoints + 1; i++)
            {
                Destroy(wCList[i]);
            }
            Start();
        }


        if (dropDownIndex != GameObject.Find("/Canvas/Dropdown").GetComponent<Dropdown>().value)
        {
            dropDownIndex = GameObject.Find("/Canvas/Dropdown").GetComponent<Dropdown>().value;
            switch (dropDownIndex)
            {
                case 0://3 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-10, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(0, 10, 0));
                    setPoint(wGameObjList[2], new Vector3(10, 0, 0));
                    break;
                case 1://4 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-10, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 10, 0));
                    setPoint(wGameObjList[2], new Vector3(10, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(10, 0, 0));
                    break;
                case 2://5 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 10, 0));
                    setPoint(wGameObjList[2], new Vector3(0, 15, 0));
                    setPoint(wGameObjList[3], new Vector3(10, 10, 0));
                    setPoint(wGameObjList[4], new Vector3(5, 0, 0));
                    break;
                case 3://6 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 5, 0));
                    setPoint(wGameObjList[2], new Vector3(-5, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(5, 10, 0));
                    setPoint(wGameObjList[4], new Vector3(10, 5, 0));
                    setPoint(wGameObjList[5], new Vector3(5, 0, 0));
                    break;
                case 4://7 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-9, 4, 0));
                    setPoint(wGameObjList[2], new Vector3(-7, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(0, 12, 0));
                    setPoint(wGameObjList[4], new Vector3(7, 10, 0));
                    setPoint(wGameObjList[5], new Vector3(9, 4, 0));
                    setPoint(wGameObjList[6], new Vector3(5, 0, 0));
                    break;
                case 5://8 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 5, 0));
                    setPoint(wGameObjList[2], new Vector3(-10, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(-5, 15, 0));
                    setPoint(wGameObjList[4], new Vector3(5, 15, 0));
                    setPoint(wGameObjList[5], new Vector3(10, 10, 0));
                    setPoint(wGameObjList[6], new Vector3(10, 5, 0));
                    setPoint(wGameObjList[7], new Vector3(5, 0, 0));
                    break;
                case 6://9 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 5, 0));
                    setPoint(wGameObjList[2], new Vector3(-10, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(-7, 15, 0));
                    setPoint(wGameObjList[4], new Vector3(0, 17, 0));
                    setPoint(wGameObjList[5], new Vector3(7, 15, 0));
                    setPoint(wGameObjList[6], new Vector3(10, 10, 0));
                    setPoint(wGameObjList[7], new Vector3(10, 5, 0));
                    setPoint(wGameObjList[8], new Vector3(5, 0, 0));
                    break;
                case 7://10 pontos de controle
                    setPoint(wGameObjList[0], new Vector3(-5, 0, 0));
                    setPoint(wGameObjList[1], new Vector3(-10, 5, 0));
                    setPoint(wGameObjList[2], new Vector3(-12, 10, 0));
                    setPoint(wGameObjList[3], new Vector3(-10, 15, 0));
                    setPoint(wGameObjList[4], new Vector3(-5, 20, 0));
                    setPoint(wGameObjList[5], new Vector3(5, 20, 0));
                    setPoint(wGameObjList[6], new Vector3(10, 15, 0));
                    setPoint(wGameObjList[7], new Vector3(12, 10, 0));
                    setPoint(wGameObjList[8], new Vector3(10, 5, 0));
                    setPoint(wGameObjList[9], new Vector3(5, 0, 0));
                    break;
            }
        }
        wPoints2 = new Vector3[GameObject.Find("/Canvas/Dropdown").GetComponent<Dropdown>().value + 3];
        for (int i = 0; i < wPoints2.Length; i++)
        {
            wPoints2[i] = getPoint(wGameObjList[i]);
        }
        lineRenderer.positionCount = wPoints2.Length;
        lineRenderer.useWorldSpace = true;
        for (int i = 0; i < wPoints2.Length; i++)
        {
            lineRenderer.SetPosition(i, wPoints2[i]);
        }

        pDrawNCurve();
    }


    private void pDrawNCurve()
    {
        for (int i = 0; i <= wQtdPoints; i++)
        {
            float t = i / (float)wQtdPoints;
            wPositions[i] = CalculateNCasteljau(t, wPoints2);
            wCList[i].transform.position = wPositions[i];
            wCList[i].GetComponent<uSphere>().setT(t);
            wCList[i].transform.position = wPositions[i];
        }
        wLineRenderer.SetPositions(wPositions);
    }
    private Vector3 CalculateNCasteljau(float t, Vector3[] p)
    {
        Vector3[] p1 = new Vector3[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            p1[i] = p[i];
        }
        float nt = 1.0f - t;
        int lnght = p1.Length;
        while (lnght > 1)
        {
            for (int i = 0, e = lnght - 1; i < e; i++)
            {
                p1[i] = nt * p1[i] + t * p1[i + 1];
            }
            lnght = lnght - 1;
        }
        return p1[0];
    }
    public Vector3 CalculateNBezierPoint(float t, Vector3[] p)
    {
        Vector3 bt = Vector3.zero;
        int n = p.Length - 1;

        for (int i = 0; i <= n; i++)
        {
            bt += Combinacao(n, i) * Potencia(1 - t, n - i) * Potencia(t, i) * p[i];
        }

        return bt;

    }

    public static int Combinacao(int n, int i)
    {
        return Fatorial(n) / (Fatorial(i) * Fatorial(n - i));
    }


    public static int Fatorial(int n)
    {
        int y = 1;

        for (int i = 1; i <= n; i++)
        {
            y *= i;
        }

        return y;
    }

    public static float Potencia(float b, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            float y = b;

            for (int i = 1; i <= n - 1; i++)
            {
                y *= y;
            }
            return y;
        }
    }
}
