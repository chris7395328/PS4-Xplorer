using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SonyPS4CommonDialog : MonoBehaviour
{
    MenuStack menuStack;
	float waitTime = 0;
	float progressDelay = 0;
	float progressTime = 0;
	string imeText = "";

	public InputField TargetKeyboardText;
	public bool openKeyboardOnScreen = false;
    //public Controlador ControladorScr;

	MenuLayout menuMain;
	MenuLayout menuUserMessage;
	MenuLayout menuSystemMessage1;
	MenuLayout menuErrorMessage;
	MenuLayout menuProgress;

    public delegate void FolderCreateAction();
    public static event FolderCreateAction OnFolderCreate;

    public delegate void RenameFileAction();
    public static event RenameFileAction OnRenameFile;

    public delegate void FileCreateAction();
    public static event FileCreateAction OnCreateFile;

    public delegate void FileDownloadAction();
    public static event FileDownloadAction OnDownloadFile;

    void Start()
	{
        try
        {
            Sony.PS4.Dialog.Main.OnLog += OnLog;
            Sony.PS4.Dialog.Main.OnLogWarning += OnLogWarning;
            Sony.PS4.Dialog.Main.OnLogError += OnLogError;

            Sony.PS4.Dialog.Common.OnGotDialogResult += OnGotDialogResult;
            Sony.PS4.Dialog.Ime.OnGotIMEDialogResult += OnGotIMEDialogResult;

            Sony.PS4.Dialog.Main.Initialise();
        }
        catch {; }

        //ControladorScr.enabled = true;
    }

	public void OnEnter() {}
	public void OnExit() {}
    
	public void ShowKeyboardOnScreen()
	{
		Sony.PS4.Dialog.Ime.SceImeDialogParam ImeParam = new Sony.PS4.Dialog.Ime.SceImeDialogParam();
		Sony.PS4.Dialog.Ime.SceImeParamExtended ImeExtendedParam = new Sony.PS4.Dialog.Ime.SceImeParamExtended();

		// Set supported languages, 'or' flags together or set to 0 to support all languages.
        ImeParam.supportedLanguages = Sony.PS4.Dialog.Ime.FlagsSupportedLanguages.LANGUAGE_ENGLISH_US |
             Sony.PS4.Dialog.Ime.FlagsSupportedLanguages.LANGUAGE_SPANISH |
             Sony.PS4.Dialog.Ime.FlagsSupportedLanguages.LANGUAGE_SPANISH_LA |
             Sony.PS4.Dialog.Ime.FlagsSupportedLanguages.LANGUAGE_PORTUGUESE_BR |
             Sony.PS4.Dialog.Ime.FlagsSupportedLanguages.LANGUAGE_RUSSIAN;

		ImeParam.option = Sony.PS4.Dialog.Ime.Option.DEFAULT;
		ImeParam.title = "Keyboard";
		ImeParam.maxTextLength = 255;
		ImeParam.inputTextBuffer = TargetKeyboardText.text;

        ImeParam.posx = 565;
        ImeParam.posy = 277;

		Sony.PS4.Dialog.Ime.Open(ImeParam, ImeExtendedParam);
	}

	public void KeyboardOnScreen()
	{
		openKeyboardOnScreen = true;
	}

    void OnGotIMEDialogResult(Sony.PS4.Dialog.Messages.PluginMessage msg)
    {
		Sony.PS4.Dialog.Ime.ImeDialogResult result = Sony.PS4.Dialog.Ime.GetResult();
        TargetKeyboardText.text = result.text;
        imeText = "";

        /*OnScreenLog.Add("IME result: " + result.result);
        OnScreenLog.Add("IME button: " + result.button);
        OnScreenLog.Add("IME text: " + result.text);
        */

        if (result.result == Sony.PS4.Dialog.Ime.EnumImeDialogResult.RESULT_OK)
		{
			imeText = result.text;
		}

		FillTextButtonWithKeyboardResult();

        if (OnFolderCreate != null && Controlador.instancia.FileFolderAction == Controlador.ActionsWhichRequiresKeyboard.CreateFolder)
        {
            Controlador.instancia.FileFolderAction = Controlador.ActionsWhichRequiresKeyboard.Nothing;
            OnFolderCreate();
        }

        if (OnRenameFile != null && Controlador.instancia.FileFolderAction == Controlador.ActionsWhichRequiresKeyboard.RenameFile)
        {
            Controlador.instancia.FileFolderAction = Controlador.ActionsWhichRequiresKeyboard.Nothing;
            OnRenameFile();
        }

        if (OnCreateFile != null && Controlador.instancia.FileFolderAction == Controlador.ActionsWhichRequiresKeyboard.CrearFichero)
        {
            Controlador.instancia.FileFolderAction = Controlador.ActionsWhichRequiresKeyboard.Nothing;
            OnCreateFile();
        }

        if (OnDownloadFile != null && Controlador.instancia.FileFolderAction == Controlador.ActionsWhichRequiresKeyboard.DescargarFichero)
        {
            Controlador.instancia.FileFolderAction = Controlador.ActionsWhichRequiresKeyboard.Nothing;
            OnDownloadFile();
        }

        openKeyboardOnScreen = false;
    }


	public void FillTextButtonWithKeyboardResult()
	{
        TargetKeyboardText.text = imeText;
    }

	void OnLog(Sony.PS4.Dialog.Messages.PluginMessage msg)
	{

	}

	void OnLogWarning(Sony.PS4.Dialog.Messages.PluginMessage msg)
	{

	}

	void OnLogError(Sony.PS4.Dialog.Messages.PluginMessage msg)
	{

	}

	void OnGotDialogResult(Sony.PS4.Dialog.Messages.PluginMessage msg)
	{
		Sony.PS4.Dialog.Common.CommonDialogResult result = Sony.PS4.Dialog.Common.GetResult ();
	}

	void Update()
	{
        if(openKeyboardOnScreen)
		    Sony.PS4.Dialog.Main.Update ();
	}

	void OnGUI()
	{
		if (openKeyboardOnScreen)
			ShowKeyboardOnScreen ();
			
	}

}
