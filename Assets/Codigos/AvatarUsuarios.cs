using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AvatarUsuarios : MonoBehaviour {

    List<string> MisUsuario = new List<string>();
    List<string> MisUsuarioCarpeta = new List<string>();
    private bool Paso = true;
    private int Pos = 0;

    public void OnEnable()
    {
        Paso = true;
        Pos = 0;
        
        if (MisUsuario.Count == 0)
        {
            string[] MisProfiles = Directory.GetFileSystemEntries("/user/home/");

            foreach (string carpeta in MisProfiles)
            {
                if (File.Exists(carpeta + "/username.dat"))
                {
                    StreamReader sr = new StreamReader(carpeta + "/username.dat");
                    MisUsuario.Add(sr.ReadLine());
                    sr.Close();
                    MisUsuarioCarpeta.Add(carpeta.Replace("/user/home/", ""));
                }
            }
        }

        transform.GetChild(2).GetComponent<Text>().text = MisUsuario[0];
	}

    public void OnDisable()
    {
        Pos = 0;
    }

    public void Update()
    {
        if ((Input.GetAxis("dpad1_horizontal") < 0 || Input.GetKeyDown(KeyCode.LeftArrow)) && Paso && Pos > 0)
        {
            Paso = false;
            Pos--;
            transform.GetChild(2).GetComponent<Text>().text = MisUsuario[Pos];

            StartCoroutine(SeguirPasando());
        }

        if ((Input.GetAxis("dpad1_horizontal") > 0 || Input.GetKeyDown(KeyCode.RightArrow)) && Paso && Pos < MisUsuario.Count - 1)
        {
            Paso = false;
            Pos++;
            transform.GetChild(2).GetComponent<Text>().text = MisUsuario[Pos];

            StartCoroutine(SeguirPasando());
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Paso = false;
            Controlador.instancia.DescompactarAvatar("", MisUsuarioCarpeta[Pos].ToUpper());
        }
    }

    private IEnumerator SeguirPasando()
    {
        yield return new WaitForSeconds(0.15f);
        Paso = true;
    }
}
