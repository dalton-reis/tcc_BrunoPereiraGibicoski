using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class uBezier : MonoBehaviour
{
    public LineRenderer wLineRenderer;


    private int wQtdPoints;
    private Vector3[] wPositions;
    public Vector3[] wPoints;
    private Vector3[] wPoints2;
    private GameObject[] wCList;
    private LineRenderer lineRenderer;
    public GameObject[] wGameObjList;

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
    void Start()
    {
        wQtdPoints = uiHandler.strToInt(GameObject.Find("/Canvas/uQtdPoints").GetComponent<InputField>());

        for (int i = 0; i < wPoints.Length; i++)
        {
            setPoint(wGameObjList[i], wPoints[i]);
        }
        wQtdPoints = wQtdPoints - 1;
        wPositions = new Vector3[wQtdPoints + 1];
        wLineRenderer.positionCount = wQtdPoints + 1;

        lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
        lineRenderer.startColor = Color.black;
        lineRenderer.loop = false;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material.color = Color.black;

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



        wPoints2 = new Vector3[GameObject.Find("/Canvas/Dropdown").GetComponent<Dropdown>().value + 3];
        for (int i = 0; i < wPoints2.Length; i++)
        {
            wPoints2[i] = getPoint(wGameObjList[i]);//wPoints[i];//
        }
        lineRenderer.positionCount = wPoints2.Length;
        lineRenderer.useWorldSpace = true;
        for (int i = 0; i < wPoints2.Length; i++)
        {
            lineRenderer.SetPosition(i, wPoints2[i]);
        }

        pDrawNCurve();
        // for (int i = 0; i < wCList.Length; i++)
        // {
        //     wCList[i].transform.position = wPositions[i];
        // }
    }


    private void pDrawNCurve()
    {
        for (int i = 0; i <= wQtdPoints; i++)
        {
            float t = i / (float)wQtdPoints;
            wPositions[i] = CalculateNBezierPoint(t, wPoints2);
            wCList[i].transform.position = wPositions[i];
            wCList[i].GetComponent<uSphere>().setT(t);
            wCList[i].transform.position = wPositions[i];
        }
        wLineRenderer.SetPositions(wPositions);
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
