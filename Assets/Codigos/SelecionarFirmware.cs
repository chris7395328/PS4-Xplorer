using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarFirmware : MonoBehaviour {

    public GameObject selectLang;
    [DllImport("universal")]
    private static extern UInt16 get_firmware();
    public void Awake()
    {


        //int Valor = PlayerPrefs.GetInt("FW755", 0);
        //this changes now
        int Valor = get_firmware();
        if (Valor > 0)
        {            
            Controlador.instancia.FW = Valor;
            
            selectLang.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    public void Start()
    {
        
    }

    public void FirmawareClic(int Valor)
    {
        PlayerPrefs.SetInt("FW755", Valor);
        PlayerPrefs.Save();

        Controlador.instancia.FW = Valor;

        selectLang.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
