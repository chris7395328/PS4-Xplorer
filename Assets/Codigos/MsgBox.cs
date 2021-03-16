using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgBox : MonoBehaviour {

    public Font arialJapon;
    public Font arialChina;
    public Font arialKorea;

    public void Awake()
    {
        switch (Controlador.instancia.Idioma)
        {
            case 8: //SystemLanguage.Portuguese:
                this.transform.GetChild(0).GetComponent<Text>().text = "O arquivo já existe...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Você gostaria de substituir o arquivo existente?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Todos";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Sim";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Não";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Cancelar";

                break;
            case 9: //SystemLanguage.Spanish:
                this.transform.GetChild(0).GetComponent<Text>().text = "El archivo ya existe...";
                this.transform.GetChild(1).GetComponent<Text>().text = "¿Desea reemplazar el archivo existente?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Todos";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Sí";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "No";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Cancelar";

                break;
            case 7: //SystemLanguage.Japanese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialJapon;
                this.transform.GetChild(1).GetComponentInChildren<Text>().font = arialJapon;
                this.transform.GetChild(3).GetComponentInChildren<Text>().font = arialJapon;
                this.transform.GetChild(4).GetComponentInChildren<Text>().font = arialJapon;
                this.transform.GetChild(5).GetComponentInChildren<Text>().font = arialJapon;
                this.transform.GetChild(6).GetComponentInChildren<Text>().font = arialJapon;

                this.transform.GetChild(0).GetComponent<Text>().text = "既にファイルが存在します...";
                this.transform.GetChild(1).GetComponent<Text>().text = "現在のファイルを置き換えますか？";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "すべて";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "はい";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "いいえ";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "キャンセル";
                
                break;
            case 4: //SystemLanguage.French:
                this.transform.GetChild(0).GetComponent<Text>().text = "Fichier déjà existant...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Ouhaitez-vous remplacer le fichier existant ?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Tous";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Oui";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Non";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Annuler";
                
                break;
            case 5: //SystemLanguage.German:
                this.transform.GetChild(0).GetComponent<Text>().text = "Datei existiert bereits...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Soll die existierende Datei ersetzt werden?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Alle";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Ja";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Nein";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Abbrechen";
                
                break;
            case 10: //SystemLanguage.Ukrainian:
                this.transform.GetChild(0).GetComponent<Text>().text = "Файл уже існує...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Чи бажаєте ви замінити існуючий файл?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Усі";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Так";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Ні";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Відміна";
                
                break;
            case 6: //SystemLanguage.Italian:
                this.transform.GetChild(0).GetComponent<Text>().text = "Il file esiste già...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Vorresti sostituire il file esistente?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Tutti";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Sì";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "No";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Annulla";
                
                break;
            case 2: //SystemLanguage.Chinese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialChina;
                this.transform.GetChild(1).GetComponentInChildren<Text>().font = arialChina;
                this.transform.GetChild(3).GetComponentInChildren<Text>().font = arialChina;
                this.transform.GetChild(4).GetComponentInChildren<Text>().font = arialChina;
                this.transform.GetChild(5).GetComponentInChildren<Text>().font = arialChina;
                this.transform.GetChild(6).GetComponentInChildren<Text>().font = arialChina;

                this.transform.GetChild(0).GetComponent<Text>().text = "文件已存在...";
                this.transform.GetChild(1).GetComponent<Text>().text = "您想替换现有的文件吗？";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "全部";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "是";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "否";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "取消";
                
                break;
            case 1: //SystemLanguage.Arabic:
                this.transform.GetChild(0).GetComponent<Text>().text = "...ًﺎﻘﺒﺴﻣ دﻮﺟﻮﻣ ﻒﻠﻤﻟا";
                this.transform.GetChild(1).GetComponent<Text>().text = "؟ دﻮﺟﻮﻤﻟا ﻒﻠﻤﻟا لاﺪﺒﺘﺳا ﻲﻓ ﺐﻏﺮﺗ ﻞﻫ";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "ﻞﻜﻟا";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "ﻢﻌﻧ";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "ﻻ";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "ءﺎﻐﻟإ";
                
                break;
            case 11: //SystemLanguage.Vietnamese:
                this.transform.GetChild(0).GetComponent<Text>().text = "Tập tin đã tồn tại...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Bạn có muốn thay thế tập tin đã tồn tại ?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Tất cả";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Có";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Không";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Hủy";
                
                break;
            case 12: //Persian
                this.transform.GetChild(0).GetComponent<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("فایل مورد نظر وجود دارد");
                this.transform.GetChild(1).GetComponent<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("آیا تمایل دارید با فایل فعلی جايگزين شود ؟");
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("همه");
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("بله");
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("خیر");
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("لغو");
                
                break;
            case 13: //SystemLanguage.Russian:
                this.transform.GetChild(0).GetComponent<Text>().text = "Файл уже существует...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Вы хотите заменить существующий файл?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Все";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Да";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Нет";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Отмена";
                
                break;
            case 14: //SystemLanguage.Turkish:
                this.transform.GetChild(0).GetComponent<Text>().text = "Dosya zaten mevcut...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Mevcut dosyayı değiştirmek ister misiniz?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Hepsi";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Evet";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Hayır";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "İptal";
                
                break;
            case 15: //SystemLanguage.Polish:
                this.transform.GetChild(0).GetComponent<Text>().text = "Plik juz istnieje...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Czy chcesz zamienic istniejacy plik ?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Wszystko";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Tak";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Nie";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Odrzuć";
                
                break;
            case 16: //SystemLanguage.Swedish:
                this.transform.GetChild(0).GetComponent<Text>().text = "Filen finns redan...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Vill du ersätta den befintliga filen?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Alla";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Ja";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Nej";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Avbryt";
                
                break;
            case 17: //SystemLanguage.Catalan:
                this.transform.GetChild(0).GetComponent<Text>().text = "L'arxiu ja existeix...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Voldires reemplaçar l'arxiu existent?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Tots";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Si";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "No";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Cancela";
                
                break;
            case 18: //SystemLanguage.Danish:
                this.transform.GetChild(0).GetComponent<Text>().text = "Filen eksisterer allerede...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Vil du erstatte den eksisterende fil?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Alle";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Ja";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Nej";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Annuller";
                
                break;
            case 19: //SystemLanguage.Greek:
                this.transform.GetChild(0).GetComponent<Text>().text = "Το αρχείο υπάρχει ήδη...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Θα ήθελες να αντικαταστήσεις το υπάρχον αρχείο;";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Όλα";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Ναι";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Όχι";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Ακύρωση";
                
                break;
            case 20: //SystemLanguage.Indonesian:
                this.transform.GetChild(0).GetComponent<Text>().text = "File sudah ada...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Apakah Anda ingin mengganti file yang ada?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Semua";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Iya nih";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Tidak";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Membatalkan";
                
                break;
            case 21: //SystemLanguage.Dutch:
                this.transform.GetChild(0).GetComponent<Text>().text = "Het bestand bestaat reeds...";
                this.transform.GetChild(1).GetComponent<Text>().text = "Wil je het bestaande bestand overschrijven?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "Alle";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "Ja";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "Nee";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "Annuleren";

                break;
            case 22: //SystemLanguage.Korean:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialKorea;
                this.transform.GetChild(1).GetComponentInChildren<Text>().font = arialKorea;
                this.transform.GetChild(3).GetComponentInChildren<Text>().font = arialKorea;
                this.transform.GetChild(4).GetComponentInChildren<Text>().font = arialKorea;
                this.transform.GetChild(5).GetComponentInChildren<Text>().font = arialKorea;
                this.transform.GetChild(6).GetComponentInChildren<Text>().font = arialKorea;

                this.transform.GetChild(0).GetComponent<Text>().text = "파일이 이미 존재합니다...";
                this.transform.GetChild(1).GetComponent<Text>().text = "기존 파일에 덮어씌우시겠습니까?";
                this.transform.GetChild(6).GetComponentInChildren<Text>().text = "모두 예";
                this.transform.GetChild(3).GetComponentInChildren<Text>().text = "예";
                this.transform.GetChild(4).GetComponentInChildren<Text>().text = "아니오";
                this.transform.GetChild(5).GetComponentInChildren<Text>().text = "취소";

                break;
        }
    }
		
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            AccionCancelar();
        }
	}

    public void AccionSi()
    {
        Controlador.instancia.AccionSobrescribir = Controlador.Sobreescribir.Si;
        this.gameObject.SetActive(false);
    }

    public void AccionNo()
    {
        Controlador.instancia.AccionSobrescribir = Controlador.Sobreescribir.No;
        this.gameObject.SetActive(false);
    }

    public void AccionCancelar()
    {
        Controlador.instancia.AccionSobrescribir = Controlador.Sobreescribir.Cancel;
        this.gameObject.SetActive(false);
    }

    public void AccionSiTodo()
    {
        Controlador.instancia.AccionSobrescribir = Controlador.Sobreescribir.SiTodo;
        this.gameObject.SetActive(false);
    }
}
