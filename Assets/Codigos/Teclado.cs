using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Teclado : MonoBehaviour {

    public InputField txtTexto;
    public GameObject Inicial;

    private bool mayusculas = false;
    private bool Paso = true;
    private bool Edito = false;

    private bool PasoBorrar = true;
    private float Espera = 0.5f;

    private int Posicion = 0;
    private bool MoverCursor = true;
    
    public void OnEnable()
    {                
        Paso = true;
        PasoBorrar = true;
        Edito = false;
        mayusculas = true;
        Mayusculas();

        StartCoroutine(IniciarCaret());
    }

    IEnumerator IniciarCaret()
    {
        yield return null;

        Paso = true;
        PasoBorrar = true;
        Posicion = 0;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(Inicial);
        MostrarCursor();
    }

    void MostrarCursor()
    {
        if (txtTexto.isActiveAndEnabled)
        {
            txtTexto.caretPosition = Posicion;
            txtTexto.GetType().GetField("m_AllowInput", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(txtTexto, true);
            txtTexto.GetType().InvokeMember("SetCaretVisible", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Instance, null, txtTexto, null);
        }
    }

    public void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(Inicial);
        }

        if (Input.GetAxis("rightstick1horizontal") < 0 && MoverCursor && Posicion > 0)
        {
            MoverCursor = false;
            Posicion--;
            txtTexto.caretPosition = Posicion;

            txtTexto.text = txtTexto.text.Insert(Posicion, " ");
            txtTexto.text = txtTexto.text.Remove(Posicion, 1);

            StartCoroutine(YaPuedeMoverCursor());
        }
        else if (Input.GetAxis("rightstick1horizontal") > 0 && MoverCursor && Posicion < txtTexto.text.Length)
        {
            MoverCursor = false;
            Posicion++;
            txtTexto.caretPosition = Posicion;

            txtTexto.text = txtTexto.text.Insert(Posicion, " ");
            txtTexto.text = txtTexto.text.Remove(Posicion, 1);

            StartCoroutine(YaPuedeMoverCursor());
        }
        else if (Input.GetAxis("rightstick1vertical") < 0 && MoverCursor && Posicion > 0)
        {
            MoverCursor = false;
            
            int FinLinea = txtTexto.text.LastIndexOf("\n", Posicion - 1);
            if (FinLinea < 0)
            {
                Posicion = 0;
            }
            else
            {
                Posicion = FinLinea;
            }
            txtTexto.caretPosition = Posicion;

            txtTexto.text = txtTexto.text.Insert(Posicion, " ");
            txtTexto.text = txtTexto.text.Remove(Posicion, 1);
            
            StartCoroutine(YaPuedeMoverCursor());
        }
        else if (Input.GetAxis("rightstick1vertical") > 0 && MoverCursor && Posicion < txtTexto.text.Length)
        {
            MoverCursor = false;
            
            int FinLinea = txtTexto.text.IndexOf("\n", Posicion) + 1;
            if (FinLinea > Posicion)
            {
                Posicion = FinLinea;
            }
            else
            {
                Posicion = txtTexto.text.Length;
            }
            txtTexto.caretPosition = Posicion;
            
            txtTexto.text = txtTexto.text.Insert(Posicion, " ");
            txtTexto.text = txtTexto.text.Remove(Posicion, 1);

            StartCoroutine(YaPuedeMoverCursor());
        }
                
        if (Input.GetAxis("joystick1_left_trigger") != 0 && Paso)
        {
            Paso = false;
            Mayusculas();

            StartCoroutine(SeguirPasando());
        }

        if (Input.GetAxis("joystick1_right_trigger") != 0 && Paso)
        {
            Paso = false;
            NuevaLinea();

            Edito = true;

            StartCoroutine(SeguirPasando());
        }

        if ((Input.GetKey(KeyCode.Joystick1Button2) || Input.GetKey(KeyCode.Keypad4)) && PasoBorrar)
        {
            PasoBorrar = false;
            Borrar();

            StartCoroutine(SeguirPasandoBorrar());
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button2) || Input.GetKeyUp(KeyCode.Keypad4))
        {
            Espera = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            txtTexto.text = txtTexto.text.Insert(Posicion, " ");
            Edito = true;

            Posicion++;
            MostrarCursor();
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && !Edito)
        {
            Controlador.instancia.CerrarTextoSinSalvar();
        }
    }

    IEnumerator YaPuedeMoverCursor()
    {
        yield return new WaitForSeconds(0.1f);
        MoverCursor = true;
    }

    private IEnumerator SeguirPasando()
    {
        yield return new WaitForSeconds(0.5f);
        Paso = true;
    }

    private IEnumerator SeguirPasandoBorrar()
    {
        yield return new WaitForSeconds(Espera);

        if (Espera > 0)
        {
            Espera = Espera - 0.1f;
        }
        
        PasoBorrar = true;
    }

    public void BotonClick(string Letra)
    {
        if (mayusculas)
        {
            txtTexto.text = txtTexto.text.Insert(Posicion, Letra.ToUpper());
        }
        else
        {
            txtTexto.text = txtTexto.text.Insert(Posicion, Letra);
        }

        Edito = true;
        Posicion++;
        MostrarCursor();
    }

    public void Mayusculas()
    {
        mayusculas = !mayusculas;

        if (mayusculas)
        {
            for (int i = 11; i < 38; i++)
            {
                transform.GetChild(i).GetComponentInChildren<Text>().text = transform.GetChild(i).GetComponentInChildren<Text>().text.ToUpper();
            }
        }
        else
        {
            for (int i = 11; i < 38; i++)
            {
                transform.GetChild(i).GetComponentInChildren<Text>().text = transform.GetChild(i).GetComponentInChildren<Text>().text.ToLower();
            }
        }
    }

    public void Borrar()
    {
        if (txtTexto.text.Length > 0 && Posicion > 0)
        {
            try
            {
                txtTexto.text = txtTexto.text.Remove(Posicion - 1, 1);
                Edito = true;
                Posicion--;
                MostrarCursor();
            }
            catch
            {
                ;
            }
        }
    }

    public void NuevaLinea()
    {
        txtTexto.text = txtTexto.text.Insert(Posicion, "\n");
        Edito = true;
        Posicion++;
        MostrarCursor();
    }

    public void Listo()
    {
        Controlador.instancia.SalvarCambiosTexto();
        Edito = false;
    }

    public void Cerrar()
    {
        Controlador.instancia.CerrarTextoSinSalvar();
    }
}
