using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opciones : MonoBehaviour {

    private int Opcion = 0;
    private bool Paso = true;
        
    public GameObject[] MisOpciones = new GameObject[8];
    public Font arialJapon;
    public Font arialChina;
    public Font arialKorea;

    string CadenaEliminar = "Delete";
    string CadenaSeguro = "Sure ?";
    Color ColorTexto;

    public void Awake()
    {
        ColorTexto = MisOpciones[4].transform.GetComponentInChildren<Text>().color;

        switch (Controlador.instancia.Idioma)
        {
            case 8: //SystemLanguage.Portuguese:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nova pasta";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Novo arquivo";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Baixe o URL aqui";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Recortar";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Copiar";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Colar";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Renomear";

                CadenaEliminar = "Deletar";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Certeza ?";
                break;
            case 9: //SystemLanguage.Spanish:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nueva Carpeta";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Nuevo Fichero";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Descargar URL aquí";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Cortar";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Copiar";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Pegar";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Renombrar";

                CadenaEliminar = "Eliminar";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Seguro ?";
                break;
            case 7: //SystemLanguage.Japanese:
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[3].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[4].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[5].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[6].transform.GetComponentInChildren<Text>().font = arialJapon;
                MisOpciones[7].transform.GetComponentInChildren<Text>().font = arialJapon;

                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "新しいフォルダ";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "新しいファイル";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Urlをダウンロード";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "切り取り";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "コピー";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "貼り付け";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "名前を変える";

                CadenaEliminar = "削除";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "本当に削除してもよろしいですか？";
                break;
            case 4: //SystemLanguage.French:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nouveau Dossier";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Nouveau Fichier";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Téléchargez l'URL ici";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Couper";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Copier";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Coller";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Renommer";

                CadenaEliminar = "Supprimer";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Sur ?";
                break;
            case 5: //SystemLanguage.German:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Neuer Ordner";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Neue Datei";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Laden Sie die URL herunter";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Ausschneiden";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopieren";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Einfügen";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Umbenennen";

                CadenaEliminar = "Löschen";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Sicher ?";
                break;
            case 10: //SystemLanguage.Ukrainian:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Нова папка";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Новий файл";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Завантажте URL-адресу";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Вирізати";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Копіювати";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Вставити";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Переіменувати";

                CadenaEliminar = "Видалити";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Певен ?";
                break;
            case 6: //SystemLanguage.Italian:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nuova Cartella";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Nuovo File";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Scarica l'URL qui";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Taglia";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Copia";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Incolla";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Rinomina";

                CadenaEliminar = "Cancella";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Sicuro ?";
                break;
            case 2: //SystemLanguage.Chinese:
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[3].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[4].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[5].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[6].transform.GetComponentInChildren<Text>().font = arialChina;
                MisOpciones[7].transform.GetComponentInChildren<Text>().font = arialChina;

                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "新建文件夹";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "新文件";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "在此处下载网址";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "剪切";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "复制";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "粘贴";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "重命名";

                CadenaEliminar = "删除";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "确定 ？";
                break;
            case 1: //SystemLanguage.Arabic:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "ﺪﻳﺪﺟ ﺪﻠﺠﻣ";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "ﺪﻳﺪﺟ ﻒﻠﻣ";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "ﺎﻨﻫ ﻂﺑار ﻞﻴﻤﺤﺗ";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "ﺺﻗ";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "ﺦﺴﻧ";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "ﻖﺼﻟ";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "ﺔﻴﻤﺴﺗ ةدﺎﻋإ";

                CadenaEliminar = "فﺬﺣ";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "؟ﺪﻛﺎﺘﻣ ﺖﻧأ ﻞﻫ";
                break;
            case 11: //SystemLanguage.Vietnamese:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Tạo thư mục mới";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Tập tin mới";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Url tải xuống";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Cắt";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Chép";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Dán";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Đổi tên";

                CadenaEliminar = "Xóa";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Bạn có chắc chắn?";
                break;
            case 12: //Persian
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("پوشه جدید");
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("پرونده جدید");
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("URL را بارگیری کنید");
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("بریدن");
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("کپی کردن");
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("چسباندن");
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = UPersian.Utils.UPersianUtils.RtlFix("تغییر نام");

                CadenaEliminar = UPersian.Utils.UPersianUtils.RtlFix("حذف کردن");
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = UPersian.Utils.UPersianUtils.RtlFix("آیا اطمینان دارید؟");
                break;
            case 13: //SystemLanguage.Russian:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Новая папка";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Новый файл";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Скачать URL здесь";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Вырезать";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Копировать";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Вставить";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Переименовать";

                CadenaEliminar = "Удалить";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Уверены ?";
                break;
            case 14: //SystemLanguage.Turkish:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Yeni klasör";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Yeni dosya";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "URL'yi Buradan İndirin";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Kes";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopyala";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Yapıştır";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Yeniden adlandır";

                CadenaEliminar = "Sil";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Emin misiniz ?";
                break;
            case 15: //SystemLanguage.Polish:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nowy Folder";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Nowy Plik";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Pobierz adres URL";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Wytnij";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopiuj";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Wklej";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Zmien";

                CadenaEliminar = "Usun";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Jestes pewny ?";
                break;
            case 16: //SystemLanguage.Swedish:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Ny Mapp";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Ny fil";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Ladda ner URL";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Klipp";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopiera";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Klistra in";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Byt namn på";

                CadenaEliminar = "Ta bort";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Säker ?";
                break;
            case 17: //SystemLanguage.Catalan:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Carpeta Nova";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Fitxer nou";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Descarregueu l'URL aquí";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Tallar";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Copiar";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Enganxa";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Canvia el nom";

                CadenaEliminar = "El.liminar";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Segur ?";
                break;
            case 18: //SystemLanguage.Danish:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Ny Mappe";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Ny fil";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Download url her";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Klip";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopi";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Sæt ind";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Omdøb";

                CadenaEliminar = "Slet";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Sikker ?";
                break;
            case 19: //SystemLanguage.Greek:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Νέος Φάκελος";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Νέο αρχείο";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Κατεβάστε το url εδώ";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Αποκοπή";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Αντιγραφή";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Επικόλληση";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Μετονομασία";

                CadenaEliminar = "Διαγραφή";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Σίγουρα;";
                break;
            case 20: //SystemLanguage.Indonesian:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Map Baru";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "File baru";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Unduh Url Disini";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Potong";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Salin";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Tempel";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Ubah nama";

                CadenaEliminar = "Hapus";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Yakin";
                break;
            case 21: //SystemLanguage.Dutch:
                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "Nieuwe Map";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "Nieuw bestand";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "Download URL hier";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "Knippen";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "Kopiëren";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "Plakken";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "Hernoemen";

                CadenaEliminar = "Verwijderen";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "Bevestigen?";
                break;
            case 22: //SystemLanguage.Korean:
                MisOpciones[0].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[1].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[2].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[3].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[4].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[5].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[6].transform.GetComponentInChildren<Text>().font = arialKorea;
                MisOpciones[7].transform.GetComponentInChildren<Text>().font = arialKorea;

                MisOpciones[0].transform.GetComponentInChildren<Text>().text = "새폴더";
                MisOpciones[1].transform.GetComponentInChildren<Text>().text = "새로운 파일";
                MisOpciones[2].transform.GetComponentInChildren<Text>().text = "여기에서 URL 다운로드";
                MisOpciones[3].transform.GetComponentInChildren<Text>().text = "잘라내기";
                MisOpciones[4].transform.GetComponentInChildren<Text>().text = "복사";
                MisOpciones[5].transform.GetComponentInChildren<Text>().text = "붙여넣기";
                MisOpciones[6].transform.GetComponentInChildren<Text>().text = "이름 바꾸기";

                CadenaEliminar = "삭제";
                MisOpciones[7].transform.GetComponentInChildren<Text>().text = CadenaEliminar;
                CadenaSeguro = "한 번 더 확인해 주세요, 맞습니까?";
                break;
        }
    }

    public void OnDisable()
    {
        Opcion = 0;
        MisOpciones[0].transform.GetChild(0).gameObject.SetActive(true);
        MisOpciones[1].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[2].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[3].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[4].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[5].transform.GetChild(0).gameObject.SetActive(false);

        MisOpciones[6].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[6].GetComponent<Image>().color = new Color(255, 255, 255, 1f);
        MisOpciones[6].transform.GetComponentInChildren<Text>().color = ColorTexto;
        MisOpciones[7].transform.GetChild(0).gameObject.SetActive(false);
        MisOpciones[7].transform.GetChild(1).GetComponent<Text>().text = CadenaEliminar;
        Controlador.instancia.Seguro = false;
    }

    public void OnEnable()
    {
        Paso = true;

        if (Controlador.instancia.Multiseleccion)
        {
            MisOpciones[6].GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            MisOpciones[6].transform.GetComponentInChildren<Text>().color = new Color(ColorTexto.r, ColorTexto.g, ColorTexto.b, 0.3f);
        }
    }
    
	void Update ()
    {
        if ((Input.GetAxis("dpad1_vertical") > 0 || Input.GetKey(KeyCode.UpArrow)) && Opcion > 0 && Paso)
        {
            Paso = false;

            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(false);
            Opcion--;
            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(true);

            if (Controlador.instancia.Seguro)
            {
                MisOpciones[7].transform.GetChild(1).GetComponent<Text>().text = CadenaEliminar;
                Controlador.instancia.Seguro = false;
            }

            StartCoroutine(SeguirPasando());
        }

        if ((Input.GetAxis("dpad1_vertical") < 0 || Input.GetKey(KeyCode.DownArrow)) && Opcion < 7 && Paso)
        {
            Paso = false;

            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(false);
            Opcion++;
            MisOpciones[Opcion].transform.GetChild(0).gameObject.SetActive(true);

            if (Controlador.instancia.Seguro)
            {
                MisOpciones[7].transform.GetChild(1).GetComponent<Text>().text = CadenaEliminar;
                Controlador.instancia.Seguro = false;
            }

            StartCoroutine(SeguirPasando());
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            switch (Opcion)
            {
                case 0:
                    Controlador.instancia.NuevaCarpeta();
                    break;
                case 1:
                    Controlador.instancia.NuevoFichero();
                    break;
                case 2:
                    Controlador.instancia.DescargarFichero();
                    break;
                case 3:
                    Controlador.instancia.Cortar();
                    break;
                case 4:
                    Controlador.instancia.Copiar();
                    break;
                case 5:
                    Controlador.instancia.Pegar();
                    break;
                case 6:
                    Controlador.instancia.Renombra();
                    break;
                case 7:
                    if (Controlador.instancia.Seguro)
                    {
                        Controlador.instancia.Eliminar();
                    }
                    else
                    {
                        MisOpciones[Opcion].transform.GetChild(1).GetComponent<Text>().text = CadenaSeguro;
                        Controlador.instancia.Seguro = true;
                    }
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
