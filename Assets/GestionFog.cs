using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionFog : MonoBehaviour
{
    [SerializeField] GameObject FogExter;
    [SerializeField] GameObject FogInter;

    public string fogState = "Default";

    public static GestionFog Instance;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        fogState = "Exter";
    }

    // Update is called once per frame
    void Update()
    {
        FogActivation();
    }

    void FogActivation()
    {
        if (fogState == "Exter")
        {
            FogExter.SetActive(true);
            FogInter.SetActive(false);
        }
        else if (fogState == "Inter")
        {
            FogInter.SetActive(true);
            FogExter.SetActive(false);
        }
    }
}
