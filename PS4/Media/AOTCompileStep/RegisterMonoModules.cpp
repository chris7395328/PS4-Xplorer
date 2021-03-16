
#if defined(TARGET_IPHONE_SIMULATOR) && TARGET_IPHONE_SIMULATOR
    #define DECL_USER_FUNC(f) void f() __attribute__((weak_import))
    #define REGISTER_USER_FUNC(f)\
        do {\
        if(f != NULL)\
            mono_dl_register_symbol(#f, (void*)f);\
        else\
            ::printf_console("Symbol '%s' not found. Maybe missing implementation for Simulator?\n", #f);\
        }while(0)
#else
    #define DECL_USER_FUNC(f) void f() 
    #if !defined(__arm64__)
    #define REGISTER_USER_FUNC(f) mono_dl_register_symbol(#f, (void*)&f)
    #else
        #define REGISTER_USER_FUNC(f)
    #endif
#endif
extern "C"
{
    typedef void* gpointer;
    typedef int gboolean;
    void                mono_aot_register_module(gpointer *aot_info);
#if __ORBIS__ || SN_TARGET_PSP2
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif
#if !(TARGET_IPHONE_SIMULATOR)
    extern gboolean     mono_aot_only;
    extern gpointer*    mono_aot_module_ArabicSupport_info; // ArabicSupport.dll
    extern gpointer*    mono_aot_module_Assembly_CSharp_info; // Assembly-CSharp.dll
    extern gpointer*    mono_aot_module_HtmlAgilityPack_info; // HtmlAgilityPack.dll
    extern gpointer*    mono_aot_module_I18N_CJK_info; // I18N.CJK.dll
    extern gpointer*    mono_aot_module_I18N_info; // I18N.dll
    extern gpointer*    mono_aot_module_I18N_MidEast_info; // I18N.MidEast.dll
    extern gpointer*    mono_aot_module_I18N_Other_info; // I18N.Other.dll
    extern gpointer*    mono_aot_module_I18N_Rare_info; // I18N.Rare.dll
    extern gpointer*    mono_aot_module_I18N_West_info; // I18N.West.dll
    extern gpointer*    mono_aot_module_Mono_Security_info; // Mono.Security.dll
    extern gpointer*    mono_aot_module_mscorlib_info; // mscorlib.dll
    extern gpointer*    mono_aot_module_PARAM_SFO_info; // PARAM.SFO.dll
    extern gpointer*    mono_aot_module_PS4_Tools_info; // PS4_Tools.dll
    extern gpointer*    mono_aot_module_SharpCompress_3_5_info; // SharpCompress.3.5.dll
    extern gpointer*    mono_aot_module_SonyPS4CommonDialog_info; // SonyPS4CommonDialog.dll
    extern gpointer*    mono_aot_module_System_Configuration_info; // System.Configuration.dll
    extern gpointer*    mono_aot_module_System_Core_info; // System.Core.dll
    extern gpointer*    mono_aot_module_System_info; // System.dll
    extern gpointer*    mono_aot_module_System_Xml_info; // System.Xml.dll
    extern gpointer*    mono_aot_module_UnityEngine_AIModule_info; // UnityEngine.AIModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_AnimationModule_info; // UnityEngine.AnimationModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_AudioModule_info; // UnityEngine.AudioModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_CoreModule_info; // UnityEngine.CoreModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_DirectorModule_info; // UnityEngine.DirectorModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_info; // UnityEngine.dll
    extern gpointer*    mono_aot_module_UnityEngine_ImageConversionModule_info; // UnityEngine.ImageConversionModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_IMGUIModule_info; // UnityEngine.IMGUIModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_InputModule_info; // UnityEngine.InputModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_Physics2DModule_info; // UnityEngine.Physics2DModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_PhysicsModule_info; // UnityEngine.PhysicsModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_TerrainModule_info; // UnityEngine.TerrainModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_TextRenderingModule_info; // UnityEngine.TextRenderingModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_TilemapModule_info; // UnityEngine.TilemapModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_UI_info; // UnityEngine.UI.dll
    extern gpointer*    mono_aot_module_UnityEngine_UIModule_info; // UnityEngine.UIModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_UnityWebRequestAudioModule_info; // UnityEngine.UnityWebRequestAudioModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_UnityWebRequestModule_info; // UnityEngine.UnityWebRequestModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_UnityWebRequestTextureModule_info; // UnityEngine.UnityWebRequestTextureModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_UnityWebRequestWWWModule_info; // UnityEngine.UnityWebRequestWWWModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_VideoModule_info; // UnityEngine.VideoModule.dll
    extern gpointer*    mono_aot_module_UnityEngine_VRModule_info; // UnityEngine.VRModule.dll
#endif // !(TARGET_IPHONE_SIMULATOR)
}
DLL_EXPORT void RegisterMonoModules()
{
#if !(TARGET_IPHONE_SIMULATOR) && !defined(__arm64__)
    mono_aot_only = true;
    mono_aot_register_module(mono_aot_module_ArabicSupport_info);
    mono_aot_register_module(mono_aot_module_Assembly_CSharp_info);
    mono_aot_register_module(mono_aot_module_HtmlAgilityPack_info);
    mono_aot_register_module(mono_aot_module_I18N_CJK_info);
    mono_aot_register_module(mono_aot_module_I18N_info);
    mono_aot_register_module(mono_aot_module_I18N_MidEast_info);
    mono_aot_register_module(mono_aot_module_I18N_Other_info);
    mono_aot_register_module(mono_aot_module_I18N_Rare_info);
    mono_aot_register_module(mono_aot_module_I18N_West_info);
    mono_aot_register_module(mono_aot_module_Mono_Security_info);
    mono_aot_register_module(mono_aot_module_mscorlib_info);
    mono_aot_register_module(mono_aot_module_PARAM_SFO_info);
    mono_aot_register_module(mono_aot_module_PS4_Tools_info);
    mono_aot_register_module(mono_aot_module_SharpCompress_3_5_info);
    mono_aot_register_module(mono_aot_module_SonyPS4CommonDialog_info);
    mono_aot_register_module(mono_aot_module_System_Configuration_info);
    mono_aot_register_module(mono_aot_module_System_Core_info);
    mono_aot_register_module(mono_aot_module_System_info);
    mono_aot_register_module(mono_aot_module_System_Xml_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_AIModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_AnimationModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_AudioModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_CoreModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_DirectorModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_ImageConversionModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_IMGUIModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_InputModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_Physics2DModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_PhysicsModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_TerrainModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_TextRenderingModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_TilemapModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UI_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UIModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UnityWebRequestAudioModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UnityWebRequestModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UnityWebRequestTextureModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_UnityWebRequestWWWModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_VideoModule_info);
    mono_aot_register_module(mono_aot_module_UnityEngine_VRModule_info);
#endif // !(TARGET_IPHONE_SIMULATOR) && !defined(__arm64__)

}

