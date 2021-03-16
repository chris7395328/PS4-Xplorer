using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpcionesAvanzadas : MonoBehaviour {

    private int Opcion = 0;
    private bool Paso = true;

    public GameObject[] MisOpciones = new GameObject[3];
    public Font arialJapon;
    public Font arialChina;
    public Font arialKorea;

    public void Awake()
    {
        switch (Controlador.instancia.Idioma)
        {
            case 8: //SystemLanguage.Portuguese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "OPÇÕES AVANÇADAS";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Ativar FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Permissões R/W (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Configuração Inicio";
                break;
            case 9: //SystemLanguage.Spanish:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Opciones Avanzadas";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Activar FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Permisos R/W (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Salvar Home";
                break;
            case 7: //SystemLanguage.Japanese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialJapon;

                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "詳細オプション";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "FTPを有効にする";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "書き込み制限無し（危険！）";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "ホームをセットする";
                break;
            case 4: //SystemLanguage.French:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Options avancés";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Activer FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Accès complet R/W (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Définir comme page d’accueil";
                break;
            case 5: //SystemLanguage.German:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Erweiterte Optionen";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Aktiviere FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Voll R/W (Gefährlich!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Als Home einstellen";
                break;
            case 10: //SystemLanguage.Ukrainian:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Додаткові Опції";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Включити FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Повне R/W (не безпечно!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Поставити Додому";
                break;
            case 6: //SystemLanguage.Italian:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "OPZIONI AVANZATE";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Attiva FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Pieno R/W (pericolo!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Imposta Home";
                break;
            case 2: //SystemLanguage.Chinese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialChina;

                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "高级选项";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "启用FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "完全R/W权限（慎用！）";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "设置主页";
                break;
            case 1: //SystemLanguage.Arabic:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "ﺔﻣﺪﻘﺘﻣ تارﺎﻴﺧ";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "تﺎﻔﻠﻤﻟا ﻞﻘﻧ لﻮﻛﻮﺗوﺮﺑ ﻞﻴﻌﻔﺗ";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "ﺔﻠﻣﺎﻛ ﺔﺑﺎﺘﻛو ءاﺮﻗ تﺎﻧوذأ";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "ﺔﺴﻴﺋر ﺔﺤﻔﺼﻛ ﻦﻴﻴﻌﺗ";
                break;
            case 11: //SystemLanguage.Vietnamese:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Các tùy chọn nâng cao";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Bật FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Full R/W (Nguy hiểm !)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Đặt thư mục là trang chủ";
                break;
            case 12: //Persian
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("تنظیمات پیشرفته");
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "FTP " + UPersian.Utils.UPersianUtils.RtlFix("فعال کردن سرویس");
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("فعال کردن دسترسی خواندن و نوشتن بصورت کامل");
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("تنظیم بعنوان خانه");
                break;
            case 13: //SystemLanguage.Russian:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Расширенные Настройки";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Включить FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Включить R/W (Опасно!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Установить домашней";
                break;
            case 14: //SystemLanguage.Turkish:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "GELİŞMİŞ SEÇENEKLER";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "FTP'yi Aktif et";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Tam Okuma/Yazma (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Ana Sayfa Olarak Ayarla";
                break;
            case 15: //SystemLanguage.Polish:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "OPCJE ZAAWANSOWANE";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Aktywuj FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Pelny R/W (Uwaga!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Ustaw jako ''Home''";
                break;
            case 16: //SystemLanguage.Swedish:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "FÖRVALTA OPTIONER";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Aktivera FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Full R/W (fara!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Ange hem";
                break;
            case 17: //SystemLanguage.Catalan:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "OPCIONS AVANÇADES";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Activar FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "R/W complet (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Guardar com a Home";
                break;
            case 18: //SystemLanguage.Danish:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Avancerede Indstillinger";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Aktivér FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Fuld R/W (Fare!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Placér hjem";
                break;
            case 19: //SystemLanguage.Greek:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Προχωρημενεσ Ρυθμισεισ";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Ενεργοποίηση FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Πλήρης R/W (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Όρισε Αρχική";
                break;
            case 20: //SystemLanguage.Indonesian:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Pilihan Lanjutan";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Aktifkan FTP";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Baca/Tulis penuh (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Setel Rumah";
                break;
            case 21: //SystemLanguage.Dutch:
                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "Geavanceerde instellingen";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "FTP activeren";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Volledige R/W (!)";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Stel in als Home";
                break;
            case 22: //SystemLanguage.Korean:
                this.transform.GetChild(0).GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialKorea;

                this.transform.GetChild(0).GetComponentInChildren<Text>().text = "고급 옵션";
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "FTP 활성화";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "모든 읽고 쓰는 권한 부여";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "이 경로를 홈으로 설정";
                break;
        }
    }

    public void OnDisable()
    {
        Opcion = 0;
        MisOpciones[0].transform.GetChild(0).gameObject.SetActive(true);
        MisOpciones[1].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[2].transform.GetChild(0).gameObject.SetActive(false);
    }

    public void OnEnable()
    {
        Paso = true;
    }

    void Update()
    {
        if ((Input.GetAxis("dpad1_vertical") > 0 || Input.GetKey(KeyCode.UpArrow)) && Opcion > 0 && Paso)
        {
            Paso = false;

            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(false);
            Opcion--;
            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(true);

            StartCoroutine(SeguirPasando());
        }

        if ((Input.GetAxis("dpad1_vertical") < 0 || Input.GetKey(KeyCode.DownArrow)) && Opcion < 2 && Paso)
        {
            Paso = false;

            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(false);
            Opcion++;
            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(true);

            StartCoroutine(SeguirPasando());
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            switch (Opcion)
            {
                case 0:
                    Controlador.instancia.ActivarFTP();
                    break;
                case 1:
                    Controlador.instancia.ActivarFullRW();
                    break;
                case 2:
                    Controlador.instancia.SalvarHome();
                    break;
            }
        }
    }

    private IEnumerator SeguirPasando()
    {
        yield return new WaitForSeconds(0.2f);
        Paso = true;
    }
}
