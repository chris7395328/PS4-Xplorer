using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SeleccionarLenguaje : MonoBehaviour {

    public Controlador ControladorScr;

    public void Start()
    {
        int Valor = PlayerPrefs.GetInt("Idioma", 0);
        if (Valor > 0)
        {
            Controlador.instancia.Idioma = Valor;

            ControladorScr.enabled = true;
            this.gameObject.SetActive(false);
        }
        else
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Arabic:
                    Valor = 1;
                    break;
                case SystemLanguage.Chinese:
                case SystemLanguage.ChineseSimplified:
                case SystemLanguage.ChineseTraditional:
                    Valor = 2;
                    break;
                case SystemLanguage.English:
                    Valor = 3;
                    break;
                case SystemLanguage.French:
                    Valor = 4;
                    break;
                case SystemLanguage.German:
                    Valor = 5;
                    break;
                case SystemLanguage.Italian:
                    Valor = 6;
                    break;
                case SystemLanguage.Japanese:
                    Valor = 7;
                    break;
                case SystemLanguage.Portuguese:
                    Valor = 8;
                    break;
                case SystemLanguage.Spanish:
                    Valor = 9;
                    break;
                case SystemLanguage.Ukrainian:
                    Valor = 10;
                    break;
                case SystemLanguage.Vietnamese:
                    Valor = 11;
                    break;
                case SystemLanguage.Russian:
                    Valor = 13;
                    break;
                case SystemLanguage.Turkish:
                    Valor = 14;
                    break;
                case SystemLanguage.Polish:
                    Valor = 15;
                    break;
                case SystemLanguage.Swedish:
                    Valor = 16;
                    break;
                case SystemLanguage.Catalan:
                    Valor = 17;
                    break;
                case SystemLanguage.Danish:
                    Valor = 18;
                    break;
                case SystemLanguage.Greek:
                    Valor = 19;
                    break;
                case SystemLanguage.Indonesian:
                    Valor = 20;
                    break;
                case SystemLanguage.Dutch:
                    Valor = 21;
                    break;
                case SystemLanguage.Korean:
                    Valor = 22;
                    break;
                default:
                    Valor = 3;
                    break;
            }

            EventSystem.current.SetSelectedGameObject(null);
            GameObject BotonInicial = this.transform.GetChild(1).transform.GetChild(Valor - 1).gameObject;
            EventSystem.current.SetSelectedGameObject(BotonInicial);
        }
    }

    public void LenguajeClic(int Valor)
    {
        PlayerPrefs.SetInt("Idioma", Valor);
        PlayerPrefs.Save();

        Controlador.instancia.Idioma = Valor;

        ControladorScr.enabled = true;
        this.gameObject.SetActive(false);
    }
}
