.section .text
	.local methods
	.type methods,@function
	.balign 8
_methods:
methods:
	.skip 16
.section .text
	.balign 16
_.Lm_0:
.Lm_0:
	.local UnityEngine_Tilemaps_Tile__ctor
	.type UnityEngine_Tilemaps_Tile__ctor,@function
_UnityEngine_Tilemaps_Tile__ctor:
UnityEngine_Tilemaps_Tile__ctor:

	.byte 72,131,236,88,76,137,60,36,76,139,255,72,141,124,36,72,232
	.long .Lp_1 - . -4
	.byte 73,141,71,24,72,139,76,36,72,72,137,8,72,139,76,36,80,72,137,72,8,72,141,124,36,8,232
	.long .Lp_2 - . -4
	.byte 72,141,116,36,8,73,141,127,40,186,64,0,0,0,232
	.long .Lp_3 - . -4
	.byte 65,199,71,104,1,0,0,0,65,199,71,108,1,0,0,0,73,139,255,232
	.long .Lm_1 - . -4
	.byte 76,139,60,36,72,131,196,88,195

	.size UnityEngine_Tilemaps_Tile__ctor,.-UnityEngine_Tilemaps_Tile__ctor
_.Lme_0:
.Lme_0:
.section .text
	.balign 16
_.Lm_1:
.Lm_1:
	.local UnityEngine_Tilemaps_TileBase__ctor
	.type UnityEngine_Tilemaps_TileBase__ctor,@function
_UnityEngine_Tilemaps_TileBase__ctor:
UnityEngine_Tilemaps_TileBase__ctor:

	.byte 72,131,236,8,72,137,60,36,232
	.long .Lp_4 - . -4
	.byte 72,131,196,8,195

	.size UnityEngine_Tilemaps_TileBase__ctor,.-UnityEngine_Tilemaps_TileBase__ctor
_.Lme_1:
.Lme_1:
.section .text
	.local methods_end
	.type methods_end,@function
	.balign 8
_methods_end:
methods_end:
.section .text
	.local code_offsets
	.type code_offsets,@object
	.balign 8
_code_offsets:
code_offsets:

	.long .Lm_0 - methods,.Lm_1 - methods,-1

.section .text
	.local method_info_offsets
	.type method_info_offsets,@object
	.balign 8
_method_info_offsets:
method_info_offsets:

	.long 3,10,1,2
	.hword 0
	.byte 1,2,255,255,255,255,253
.section .text
	.local extra_method_table
	.type extra_method_table,@object
	.balign 8
_extra_method_table:
extra_method_table:

	.long 11,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.section .text
	.local extra_method_info_offsets
	.type extra_method_info_offsets,@object
	.balign 8
_extra_method_info_offsets:
extra_method_info_offsets:

	.long 0
.section .text
	.local class_name_table
	.type class_name_table,@object
	.balign 8
_class_name_table:
class_name_table:

	.hword 19, 0, 0, 4, 19, 2, 0, 0
	.hword 0, 0, 0, 0, 0, 1, 0, 0
	.hword 0, 0, 0, 0, 0, 8, 0, 0
	.hword 0, 0, 0, 0, 0, 0, 0, 5
	.hword 0, 3, 0, 0, 0, 0, 0, 6
	.hword 20, 7, 0
.section .text
	.local got_info_offsets
	.type got_info_offsets,@object
	.balign 8
_got_info_offsets:
got_info_offsets:

	.long 2,10,1,2
	.hword 0
	.byte 5,2
.section .text
	.local ex_info_offsets
	.type ex_info_offsets,@object
	.balign 8
_ex_info_offsets:
ex_info_offsets:

	.long 3,10,1,2
	.hword 0
	.byte 28,3,255,255,255,255,225
.section .text
	.balign 8
_unwind_info:
unwind_info:
	.local unwind_info
	.type unwind_info,@object

	.byte 11,12,7,8,144,1,68,14,96,68,143,12,8,12,7,8,144,1,68,14,16
.section .text
	.local class_info_offsets
	.type class_info_offsets,@object
	.balign 8
_class_info_offsets:
class_info_offsets:

	.long 8,10,1,2
	.hword 0
	.byte 34,7,99,23,23,23,23,99

.section .text
	.local plt
	.type plt,@function
	.balign 16
_plt:
plt:
_mono_aot_UnityEngine_TilemapModule_plt:
mono_aot_UnityEngine_TilemapModule_plt:
_.Lp_0:
.Lp_0:

	.byte 255,37
	.long mono_aot_UnityEngine_TilemapModule_got - . + 12,0
_.Lp_1:
.Lp_1:
	.local plt_UnityEngine_Color_get_white
	.type plt_UnityEngine_Color_get_white,@function
_plt_UnityEngine_Color_get_white:
plt_UnityEngine_Color_get_white:

	.byte 255,37
	.long mono_aot_UnityEngine_TilemapModule_got - . + 20,8
	.size plt_UnityEngine_Color_get_white,.-plt_UnityEngine_Color_get_white
_.Lp_2:
.Lp_2:
	.local plt_UnityEngine_Matrix4x4_get_identity
	.type plt_UnityEngine_Matrix4x4_get_identity,@function
_plt_UnityEngine_Matrix4x4_get_identity:
plt_UnityEngine_Matrix4x4_get_identity:

	.byte 255,37
	.long mono_aot_UnityEngine_TilemapModule_got - . + 28,13
	.size plt_UnityEngine_Matrix4x4_get_identity,.-plt_UnityEngine_Matrix4x4_get_identity
_.Lp_3:
.Lp_3:
	.local plt_string_memcpy_byte__byte__int
	.type plt_string_memcpy_byte__byte__int,@function
_plt_string_memcpy_byte__byte__int:
plt_string_memcpy_byte__byte__int:

	.byte 255,37
	.long mono_aot_UnityEngine_TilemapModule_got - . + 36,18
	.size plt_string_memcpy_byte__byte__int,.-plt_string_memcpy_byte__byte__int
_.Lp_4:
.Lp_4:
	.local plt_UnityEngine_ScriptableObject__ctor
	.type plt_UnityEngine_ScriptableObject__ctor,@function
_plt_UnityEngine_ScriptableObject__ctor:
plt_UnityEngine_ScriptableObject__ctor:

	.byte 255,37
	.long mono_aot_UnityEngine_TilemapModule_got - . + 44,23
	.size plt_UnityEngine_ScriptableObject__ctor,.-plt_UnityEngine_ScriptableObject__ctor
	.size mono_aot_UnityEngine_TilemapModule_plt,.-mono_aot_UnityEngine_TilemapModule_plt
	.local plt_end
	.type plt_end,@function
_plt_end:
plt_end:
.section .text
	.local mono_image_table
	.type mono_image_table,@object
	.balign 8
_mono_image_table:
mono_image_table:

	.long 3
	.string "UnityEngine.TilemapModule"
	.string "72552026-378C-4458-9EAA-567E998C8ACA"
	.string ""
	.string ""
	.balign 8

	.long 0,0,0,0,0
	.string "UnityEngine.CoreModule"
	.string "A8485AB1-E26D-487A-B5CB-B11AC51ED483"
	.string ""
	.string ""
	.balign 8

	.long 0,0,0,0,0
	.string "mscorlib"
	.string "1ACEAF3B-8B30-4073-96C3-3CD275DF64A0"
	.string ""
	.string "b77a5c561934e089"
	.balign 8

	.long 1,2,0,0,0
.section .bss
	.balign 8
	.local mono_aot_UnityEngine_TilemapModule_got
	.type mono_aot_UnityEngine_TilemapModule_got,@object
_mono_aot_UnityEngine_TilemapModule_got:
mono_aot_UnityEngine_TilemapModule_got:
	.skip 56
_got_end:
got_end:
.section .data
	.local mono_aot_got_addr
	.type mono_aot_got_addr,@object
	.balign 8
_mono_aot_got_addr:
mono_aot_got_addr:
	.balign 8
	.quad mono_aot_UnityEngine_TilemapModule_got
.section .data
	.balign 8
_mono_aot_file_info:
mono_aot_file_info:
	.local mono_aot_file_info
	.type mono_aot_file_info,@object

	.long 2,56,5,3,2,51472895,1024,1024
	.long 128,0,0,0,0,0,0
.section .data
	.local blob
	.type blob,@object
	.balign 8
_blob:
blob:

	.byte 240,0,0,0,0,12,0,39,3,193,0,2,212,3,193,0,1,27,3,194,0,2,30,3,193,0,0,31,2,0,0,2
	.byte 12,0,0,128,144,16,0,0,1,23,128,144,20,0,0,4,194,0,3,81,194,0,3,96,194,0,0,4,194,0,3,94
	.byte 194,0,3,84,194,0,3,49,194,0,3,50,194,0,3,51,194,0,3,52,194,0,3,53,194,0,3,54,194,0,3,55
	.byte 194,0,3,56,194,0,3,57,194,0,3,58,194,0,3,59,194,0,3,82,194,0,3,60,194,0,3,61,194,0,3,62
	.byte 194,0,3,63,194,0,3,80,194,0,3,64,4,128,160,120,0,0,8,194,0,0,20,194,0,0,19,194,0,0,4,194
	.byte 0,0,17,4,128,160,32,0,0,8,194,0,0,20,194,0,0,19,194,0,0,4,194,0,0,17,4,128,144,16,0,0
	.byte 1,194,0,0,8,194,0,0,5,194,0,0,4,194,0,0,2,4,128,136,112,0,0,8,193,0,1,221,193,0,1,222
	.byte 194,0,0,4,193,0,1,223,23,128,144,20,0,0,4,194,0,3,81,194,0,3,96,194,0,0,4,194,0,3,94,194
	.byte 0,3,84,194,0,3,49,194,0,3,50,194,0,3,51,194,0,3,52,194,0,3,53,194,0,3,54,194,0,3,55,194
	.byte 0,3,56,194,0,3,57,194,0,3,58,194,0,3,59,194,0,3,82,194,0,3,60,194,0,3,61,194,0,3,62,194
	.byte 0,3,63,194,0,3,80,194,0,3,64,4,128,144,24,0,0,8,193,0,1,221,193,0,1,222,194,0,0,4,193,0
	.byte 1,223
.section .text
	.local mono_assembly_guid
	.type mono_assembly_guid,@object
_mono_assembly_guid:
mono_assembly_guid:
	.string "72552026-378C-4458-9EAA-567E998C8ACA"
.section .text
	.local mono_aot_version
	.type mono_aot_version,@object
_mono_aot_version:
mono_aot_version:
	.string "67"
.section .text
	.local mono_runtime_version
	.type mono_runtime_version,@object
_mono_runtime_version:
mono_runtime_version:
	.string ""
.section .text
	.local mono_aot_assembly_name
	.type mono_aot_assembly_name,@object
_mono_aot_assembly_name:
mono_aot_assembly_name:
	.string "UnityEngine.TilemapModule"
.section .text
	.balign 8
_.Lglobals_hash:
.Lglobals_hash:

	.hword 37, 3, 0, 0, 0, 6, 0, 0
	.hword 0, 5, 0, 14, 0, 16, 0, 0
	.hword 0, 1, 0, 8, 0, 10, 38, 0
	.hword 0, 0, 0, 0, 0, 9, 0, 15
	.hword 0, 0, 0, 0, 0, 0, 0, 0
	.hword 0, 20, 40, 2, 37, 12, 0, 17
	.hword 0, 18, 0, 0, 0, 0, 0, 0
	.hword 0, 0, 0, 4, 39, 19, 0, 0
	.hword 0, 0, 0, 0, 0, 0, 0, 0
	.hword 0, 0, 0, 7, 0, 11, 0, 13
	.hword 0, 21, 0
.section .text
_name_0:
name_0:
	.string "methods"
.section .text
_name_1:
name_1:
	.string "methods_end"
.section .text
_name_2:
name_2:
	.string "code_offsets"
.section .text
_name_3:
name_3:
	.string "method_info_offsets"
.section .text
_name_4:
name_4:
	.string "extra_method_table"
.section .text
_name_5:
name_5:
	.string "extra_method_info_offsets"
.section .text
_name_6:
name_6:
	.string "class_name_table"
.section .text
_name_7:
name_7:
	.string "got_info_offsets"
.section .text
_name_8:
name_8:
	.string "ex_info_offsets"
.section .text
_name_9:
name_9:
	.string "unwind_info"
.section .text
_name_10:
name_10:
	.string "class_info_offsets"
.section .text
_name_11:
name_11:
	.string "plt"
.section .text
_name_12:
name_12:
	.string "plt_end"
.section .text
_name_13:
name_13:
	.string "mono_image_table"
.section .text
_name_14:
name_14:
	.string "mono_aot_got_addr"
.section .text
_name_15:
name_15:
	.string "mono_aot_file_info"
.section .text
_name_16:
name_16:
	.string "blob"
.section .text
_name_17:
name_17:
	.string "mono_assembly_guid"
.section .text
_name_18:
name_18:
	.string "mono_aot_version"
.section .text
_name_19:
name_19:
	.string "mono_runtime_version"
.section .text
_name_20:
name_20:
	.string "mono_aot_assembly_name"
.section .data
	.balign 8
_.Lglobals:
.Lglobals:
	.balign 8
	.quad .Lglobals_hash
	.balign 8
	.quad name_0
	.balign 8
	.quad methods
	.balign 8
	.quad name_1
	.balign 8
	.quad methods_end
	.balign 8
	.quad name_2
	.balign 8
	.quad code_offsets
	.balign 8
	.quad name_3
	.balign 8
	.quad method_info_offsets
	.balign 8
	.quad name_4
	.balign 8
	.quad extra_method_table
	.balign 8
	.quad name_5
	.balign 8
	.quad extra_method_info_offsets
	.balign 8
	.quad name_6
	.balign 8
	.quad class_name_table
	.balign 8
	.quad name_7
	.balign 8
	.quad got_info_offsets
	.balign 8
	.quad name_8
	.balign 8
	.quad ex_info_offsets
	.balign 8
	.quad name_9
	.balign 8
	.quad unwind_info
	.balign 8
	.quad name_10
	.balign 8
	.quad class_info_offsets
	.balign 8
	.quad name_11
	.balign 8
	.quad plt
	.balign 8
	.quad name_12
	.balign 8
	.quad plt_end
	.balign 8
	.quad name_13
	.balign 8
	.quad mono_image_table
	.balign 8
	.quad name_14
	.balign 8
	.quad mono_aot_got_addr
	.balign 8
	.quad name_15
	.balign 8
	.quad mono_aot_file_info
	.balign 8
	.quad name_16
	.balign 8
	.quad blob
	.balign 8
	.quad name_17
	.balign 8
	.quad mono_assembly_guid
	.balign 8
	.quad name_18
	.balign 8
	.quad mono_aot_version
	.balign 8
	.quad name_19
	.balign 8
	.quad mono_runtime_version
	.balign 8
	.quad name_20
	.balign 8
	.quad mono_aot_assembly_name

	.long 0,0
	.globl mono_aot_module_UnityEngine_TilemapModule_info
	.type mono_aot_module_UnityEngine_TilemapModule_info,@object
	.balign 8
_mono_aot_module_UnityEngine_TilemapModule_info:
mono_aot_module_UnityEngine_TilemapModule_info:
	.balign 8
	.quad .Lglobals
.section .text
	.local mem_end
	.type mem_end,@object
	.balign 8
_mem_end:
mem_end:
