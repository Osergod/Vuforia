using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_ChangeModel : MonoBehaviour
{
    [Header("Modelos 3D")]
    public GameObject modelo1;
    public GameObject modelo2;
    public GameObject modelo3;

    void Start()
    {
        MostrarModelo1();
    }

    public void MostrarModelo1()
    {
        if (modelo1 != null) modelo1.SetActive(true);
        if (modelo2 != null) modelo2.SetActive(false);
        if (modelo3 != null) modelo3.SetActive(false);
    }

    public void MostrarModelo2()
    {
        if (modelo1 != null) modelo1.SetActive(false);
        if (modelo2 != null) modelo2.SetActive(true);
        if (modelo3 != null) modelo3.SetActive(false);
    }

    public void MostrarModelo3()
    {
        if (modelo1 != null) modelo1.SetActive(false);
        if (modelo2 != null) modelo2.SetActive(false);
        if (modelo3 != null) modelo3.SetActive(true);
    }
}
