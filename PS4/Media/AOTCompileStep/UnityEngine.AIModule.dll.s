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
	.local UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate
	.type UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate,@function
_UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate:
UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate:

	.byte 72,131,236,8,73,139,5
	.long mono_aot_UnityEngine_AIModule_got - . + 12
	.byte 72,139,0,72,133,192,116,19,73,139,5
	.long mono_aot_UnityEngine_AIModule_got - . + 12
	.byte 72,139,0,72,139,248,144,144,144,255,80,24,72,131,196,8,195

	.size UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate,.-UnityEngine_AI_NavMesh_Internal_CallOnNavMeshPreUpdate
_.Lme_0:
.Lme_0:
.section .text
	.balign 16
_.Lm_6:
.Lm_6:
	.local wrapper_delegate_invoke__Module_invoke_void__this__
	.type wrapper_delegate_invoke__Module_invoke_void__this__,@function
_wrapper_delegate_invoke__Module_invoke_void__this__:
wrapper_delegate_invoke__Module_invoke_void__this__:

	.byte 72,131,236,24,76,137,52,36,76,137,124,36,8,76,139,255,73,139,5
	.long mono_aot_UnityEngine_AIModule_got - . + 20
	.byte 139,0,133,192,15,133,71,0,0,0,77,139,119,88,73,139,198,72,133,192,15,133,43,0,0,0,77,139,119,32,73,139
	.byte 198,72,133,192,116,11,73,139,71,16,73,139,254,255,208,235,6,73,139,71,16,255,208,76,139,52,36,76,139,124,36,8
	.byte 72,131,196,24,195,73,139,254,144,144,144,65,255,86,24,235,201,232
	.long .Lp_1 - . -4
	.byte 235,178

	.size wrapper_delegate_invoke__Module_invoke_void__this__,.-wrapper_delegate_invoke__Module_invoke_void__this__
_.Lme_6:
.Lme_6:
.section .text
	.balign 16
_.Lm_7:
.Lm_7:
	.local wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object
	.type wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object,@function
_wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object:
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object:

	.byte 85,72,139,236,72,131,236,32,72,137,125,248,72,137,117,240,72,137,85,232,72,131,236,32,72,51,246,72,137,52,36,72
	.byte 137,116,36,8,72,137,116,36,16,72,137,116,36,24,72,139,244,72,139,198,72,139,205,72,131,193,240,72,137,14,72,131
	.byte 192,8,72,139,205,72,131,193,232,72,137,8,72,139,125,248,232
	.long .Lp_2 - . -4
	.byte 201,195

	.size wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object,.-wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___AsyncCallback_object_System_AsyncCallback_object
_.Lme_7:
.Lme_7:
.section .text
	.balign 16
_.Lm_8:
.Lm_8:
	.local wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.type wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult,@function
_wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult:
wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult:

	.byte 85,72,139,236,72,131,236,16,72,137,125,248,72,137,117,240,72,131,236,16,72,51,246,72,137,52,36,72,137,116,36,8
	.byte 72,139,244,72,139,197,72,131,192,240,72,137,6,72,139,125,248,232
	.long .Lp_3 - . -4
	.byte 201,195

	.size wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult,.-wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
_.Lme_8:
.Lme_8:
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

	.long .Lm_0 - methods,-1,-1,-1,-1,-1,.Lm_6 - methods,.Lm_7 - methods
	.long .Lm_8 - methods

.section .text
	.local method_info_offsets
	.type method_info_offsets,@object
	.balign 8
_method_info_offsets:
method_info_offsets:

	.long 9,10,1,2
	.hword 0
	.byte 1,255,255,255,255,255,0,0,0,0,5,3,2
.section .text
	.local extra_method_table
	.type extra_method_table,@object
	.balign 8
_extra_method_table:
extra_method_table:

	.long 11,0,0,0,0,0,0,46
	.long 7,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,12,6,11,0
	.long 0,0,142,8,0
.section .text
	.local extra_method_info_offsets
	.type extra_method_info_offsets,@object
	.balign 8
_extra_method_info_offsets:
extra_method_info_offsets:

	.long 3,6,12,7,46,8,142
.section .text
	.local class_name_table
	.type class_name_table,@object
	.balign 8
_class_name_table:
class_name_table:

	.hword 11, 1, 0, 0, 0, 0, 0, 0
	.hword 0, 0, 0, 0, 0, 0, 0, 2
	.hword 11, 0, 0, 0, 0, 0, 0, 3
	.hword 0
.section .text
	.local got_info_offsets
	.type got_info_offsets,@object
	.balign 8
_got_info_offsets:
got_info_offsets:

	.long 4,10,1,2
	.hword 0
	.byte 128,212,2,1,4
.section .text
	.local ex_info_offsets
	.type ex_info_offsets,@object
	.balign 8
_ex_info_offsets:
ex_info_offsets:

	.long 9,10,1,2
	.hword 0
	.byte 129,58,255,255,255,254,198,0,0,0,0,129,61,3,3
.section .text
	.balign 8
_unwind_info:
unwind_info:
	.local unwind_info
	.type unwind_info,@object

	.byte 8,12,7,8,144,1,68,14,16,14,12,7,8,144,1,68,14,32,68,142,4,69,143,3,13,12,7,8,144,1,65,14
	.byte 16,134,2,67,13,6
.section .text
	.local class_info_offsets
	.type class_info_offsets,@object
	.balign 8
_class_info_offsets:
class_info_offsets:

	.long 3,10,1,2
	.hword 0
	.byte 129,70,7,23

.section .text
	.local plt
	.type plt,@function
	.balign 16
_plt:
plt:
_mono_aot_UnityEngine_AIModule_plt:
mono_aot_UnityEngine_AIModule_plt:
_.Lp_0:
.Lp_0:

	.byte 255,37
	.long mono_aot_UnityEngine_AIModule_got - . + 28,0
_.Lp_1:
.Lp_1:
	.local plt__jit_icall_mono_thread_interruption_checkpoint
	.type plt__jit_icall_mono_thread_interruption_checkpoint,@function
_plt__jit_icall_mono_thread_interruption_checkpoint:
plt__jit_icall_mono_thread_interruption_checkpoint:

	.byte 255,37
	.long mono_aot_UnityEngine_AIModule_got - . + 36,220
	.size plt__jit_icall_mono_thread_interruption_checkpoint,.-plt__jit_icall_mono_thread_interruption_checkpoint
_.Lp_2:
.Lp_2:
	.local plt__jit_icall_mono_delegate_begin_invoke
	.type plt__jit_icall_mono_delegate_begin_invoke,@function
_plt__jit_icall_mono_delegate_begin_invoke:
plt__jit_icall_mono_delegate_begin_invoke:

	.byte 255,37
	.long mono_aot_UnityEngine_AIModule_got - . + 44,258
	.size plt__jit_icall_mono_delegate_begin_invoke,.-plt__jit_icall_mono_delegate_begin_invoke
_.Lp_3:
.Lp_3:
	.local plt__jit_icall_mono_delegate_end_invoke
	.type plt__jit_icall_mono_delegate_end_invoke,@function
_plt__jit_icall_mono_delegate_end_invoke:
plt__jit_icall_mono_delegate_end_invoke:

	.byte 255,37
	.long mono_aot_UnityEngine_AIModule_got - . + 52,287
	.size plt__jit_icall_mono_delegate_end_invoke,.-plt__jit_icall_mono_delegate_end_invoke
	.size mono_aot_UnityEngine_AIModule_plt,.-mono_aot_UnityEngine_AIModule_plt
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

	.long 2
	.string "UnityEngine.AIModule"
	.string "DDC21495-1BF5-4CD5-A1B0-163F53E2802F"
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
	.local mono_aot_UnityEngine_AIModule_got
	.type mono_aot_UnityEngine_AIModule_got,@object
_mono_aot_UnityEngine_AIModule_got:
mono_aot_UnityEngine_AIModule_got:
	.skip 64
_got_end:
got_end:
.section .data
	.local mono_aot_got_addr
	.type mono_aot_got_addr,@object
	.balign 8
_mono_aot_got_addr:
mono_aot_got_addr:
	.balign 8
	.quad mono_aot_UnityEngine_AIModule_got
.section .data
	.balign 8
_mono_aot_file_info:
mono_aot_file_info:
	.local mono_aot_file_info
	.type mono_aot_file_info,@object

	.long 4,64,4,9,2,51472895,1024,1024
	.long 128,0,0,0,0,0,0
.section .data
	.local blob
	.type blob,@object
	.balign 8
_blob:
blob:

	.byte 0,0,2,2,2,0,1,3,0,0,0,0,1,1,60,77,111,100,117,108,101,62,58,105,110,118,111,107,101,95,118,111
	.byte 105,100,95,95,116,104,105,115,95,95,32,40,41,0,1,2,60,77,111,100,117,108,101,62,58,98,101,103,105,110,95,105
	.byte 110,118,111,107,101,95,73,65,115,121,110,99,82,101,115,117,108,116,95,95,116,104,105,115,95,95,95,65,115,121,110,99
	.byte 67,97,108,108,98,97,99,107,95,111,98,106,101,99,116,32,40,83,121,115,116,101,109,46,65,115,121,110,99,67,97,108
	.byte 108,98,97,99,107,44,111,98,106,101,99,116,41,0,1,3,60,77,111,100,117,108,101,62,58,101,110,100,95,105,110,118
	.byte 111,107,101,95,118,111,105,100,95,95,116,104,105,115,95,95,95,73,65,115,121,110,99,82,101,115,117,108,116,32,40,83
	.byte 121,115,116,101,109,46,73,65,115,121,110,99,82,101,115,117,108,116,41,0,12,0,39,16,2,0,1,33,7,35,109,111
	.byte 110,111,95,116,104,114,101,97,100,95,105,110,116,101,114,114,117,112,116,105,111,110,95,99,104,101,99,107,112,111,105,110
	.byte 116,0,7,26,109,111,110,111,95,100,101,108,101,103,97,116,101,95,98,101,103,105,110,95,105,110,118,111,107,101,0,7
	.byte 24,109,111,110,111,95,100,101,108,101,103,97,116,101,95,101,110,100,95,105,110,118,111,107,101,0,2,0,0,2,9,0
	.byte 2,24,0,2,24,0,0,128,144,16,0,0,1,4,128,200,16,8,0,1,193,0,0,8,193,0,0,5,193,0,0,4
	.byte 193,0,0,2,14,128,160,104,0,0,8,193,0,0,8,193,0,3,15,193,0,0,4,193,0,3,14,193,0,3,37,193
	.byte 0,3,13,193,0,3,20,193,0,3,17,193,0,3,16,193,0,3,13,193,0,3,37,5,4,3
.section .text
	.local mono_assembly_guid
	.type mono_assembly_guid,@object
_mono_assembly_guid:
mono_assembly_guid:
	.string "DDC21495-1BF5-4CD5-A1B0-163F53E2802F"
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
	.string "UnityEngine.AIModule"
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
	.globl mono_aot_module_UnityEngine_AIModule_info
	.type mono_aot_module_UnityEngine_AIModule_info,@object
	.balign 8
_mono_aot_module_UnityEngine_AIModule_info:
mono_aot_module_UnityEngine_AIModule_info:
	.balign 8
	.quad .Lglobals
.section .text
	.local mem_end
	.type mem_end,@object
	.balign 8
_mem_end:
mem_end:
