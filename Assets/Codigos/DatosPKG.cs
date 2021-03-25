using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class DatosPKG : MonoBehaviour {


    [DllImport("universal")]
    private static extern int InstallPKG(string path, string name, string imgpath);
    [DllImport("universal")]
    private static extern int UnloadPKGModule();

    public Image PKGIcono;
    public Text Titulo;
    public Text TextoDetalle;
    public Text TituloID;

    

    public void OnEnable()
    {
        try
        {
            var pkg = PS4_Tools.PKG.SceneRelated.Read_PKG(Controlador.instancia.camino);

            string elTexto = "";
            string AppVersion = "1.00";
            int SysVersion = 0;

            for (int i = 0; i < pkg.Param.Tables.Count; i++)
            {
                if (pkg.Param.Tables[i].Value.Trim() != "")
                {
                    elTexto += pkg.Param.Tables[i].Name + ": " + pkg.Param.Tables[i].Value + "\n";

                    if (pkg.Param.Tables[i].Name == "VERSION")
                    {
                        AppVersion = pkg.Param.Tables[i].Value;
                    }
                    if (pkg.Param.Tables[i].Name == "SYSTEM_VER")
                    {
                        SysVersion = int.Parse(pkg.Param.Tables[i].Value);
                    }
                }
            }

            decimal Hex = 0;
            if (SysVersion > 0)
                Hex = System.Convert.ToDecimal(SysVersion.ToString("X").Substring(0, 3)) / 100;

            Titulo.text = "  " + pkg.PS4_Title + " " + System.Convert.ToDecimal(AppVersion).ToString("n2") + " (" + pkg.PKGState.ToString() + ") - System v" + Hex.ToString("n2");
            TituloID.text = "  Title Id: " + pkg.Param.TitleID;
            TextoDetalle.text = elTexto;

            if (pkg.Icon != null)
            {
                Texture2D texture = new Texture2D(0, 0, TextureFormat.RGB24, false);
                texture.filterMode = FilterMode.Trilinear;
                texture.LoadImage(pkg.Icon);
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.0f, 0.0f), 1.0f);
                PKGIcono.sprite = sprite;
            }
            else
            {
                PKGIcono.sprite = null;
            }
        }
        catch (System.Exception ex)
        {
            Titulo.text = "  Error: " + ex.Message;
            TextoDetalle.text = "";
            PKGIcono.sprite = null;
            SistemaSonidos.instancia.PlayError();
        }
    }
}
