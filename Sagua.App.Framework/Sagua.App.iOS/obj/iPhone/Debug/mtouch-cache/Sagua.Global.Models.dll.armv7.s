.subsections_via_symbols
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,17,1,18,1,64,10,0,0
	.byte 3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0,11,11,62,11,3,8,0
	.byte 0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73,19,56,10,0,0,7,22
	.byte 0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13,0,0,10,57,1,3,8
	.byte 0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13,15,0,73,19,0,0,14
	.byte 16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0,0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 3.4.0 (monotouch-7.2.4-branch/959fd8c Wed Jul  2 19:27:33 EDT 2014)"
	.asciz "Sagua.Global.Models.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14
	.align 2
Lcie0_end:
.text
	.align 3
methods:
	.space 16
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id
_Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 4
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,8,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int
_Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 8
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,8,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_1:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor
_Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 12
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
bl _p_1

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id
_Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 16
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,8,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int
_Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 20
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,8,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_4:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor
_Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 24
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
bl _p_1

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id
_Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 28
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,20,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_6:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int
_Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 32
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,20,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_7:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name
_Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 36
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,16,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_8:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string
_Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 40
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,16,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_9:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor
_Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 44
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
bl _p_2

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_a:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info
_Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 48
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,16,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_b:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string
_Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 52
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,16,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_c:
.text
	.align 2
	.no_dead_strip _Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor
_Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_Global_Models_got - . + 56
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
bl _p_2

	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,124,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_d:
.text
	.align 3
methods_end:

	.long 0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id
bl _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int
bl _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor
bl _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id
bl _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int
bl _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor
bl _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id
bl _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int
bl _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name
bl _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string
bl _Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor
bl _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info
bl _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string
bl _Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor
bl method_addresses
method_addresses_end:
.section __TEXT, __const
	.align 3
code_offsets:

	.long 0

.text
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.section __TEXT, __const
	.align 3
method_info_offsets:

	.long 15,10,2,2
	.short 0, 10
	.byte 1,3,3,3,3,3,3,3,3,3,31,3,3,3,255,255,255,255,216
.section __TEXT, __const
	.align 3
extra_method_table:

	.long 11,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.section __TEXT, __const
	.align 3
extra_method_info_offsets:

	.long 0
.section __TEXT, __const
	.align 3
class_name_table:

	.short 11, 1, 11, 0, 0, 5, 0, 0
	.short 0, 4, 0, 0, 0, 2, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 3
	.short 0
.section __TEXT, __const
	.align 3
got_info_offsets:

	.long 18,10,2,2
	.short 0, 10
	.byte 43,2,1,1,1,1,1,1,1,1,54,1,1,1,1,1,1,1
.section __TEXT, __const
	.align 3
ex_info_offsets:

	.long 15,10,2,2
	.short 0, 10
	.byte 72,62,53,48,62,53,48,62,53,62,130,116,48,62,53,255,255,255,252,233
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 20,12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32,18,12,13,0,72,14,8,135,2,68,14
	.byte 12,136,3,142,1,68,14,32
.section __TEXT, __const
	.align 3
class_info_offsets:

	.long 5,10,1,2
	.short 0
	.byte 131,71,7,23,23,23

.text
	.align 4
plt:
_mono_aot_Sagua_Global_Models_plt:
	.no_dead_strip plt_Sagua_Global_Common_BaseRestPostModel__ctor
plt_Sagua_Global_Common_BaseRestPostModel__ctor:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_Global_Models_got - . + 72,62
	.no_dead_strip plt_Sagua_Global_Common_BaseRestResult__ctor
plt_Sagua_Global_Common_BaseRestResult__ctor:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_Global_Models_got - . + 76,67
plt_end:
.section __TEXT, __const
	.align 3
image_table:

	.long 3
	.asciz "Sagua.Global.Models"
	.asciz "C49CAB67-E27C-47B9-B871-BE59E5D242AC"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,1,0,5305,26680
	.asciz "Sagua.Global.Common"
	.asciz "F86E93D2-3AFA-4280-AE59-CDD0141D8441"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,1,0,5305,26679
	.asciz "mscorlib"
	.asciz "D682AB0B-3FD6-42A4-A7BE-C03BC5443B3F"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
.data
	.align 3
_mono_aot_Sagua_Global_Models_got:
	.space 84
got_end:
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "C49CAB67-E27C-47B9-B871-BE59E5D242AC"
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "Sagua.Global.Models"
.data
	.align 3
_mono_aot_file_info:

	.long 99,0
	.align 2
	.long _mono_aot_Sagua_Global_Models_got
	.align 2
	.long methods
	.align 2
	.long 0
	.align 2
	.long blob
	.align 2
	.long class_name_table
	.align 2
	.long class_info_offsets
	.align 2
	.long method_info_offsets
	.align 2
	.long ex_info_offsets
	.align 2
	.long code_offsets
	.align 2
	.long method_addresses
	.align 2
	.long extra_method_info_offsets
	.align 2
	.long extra_method_table
	.align 2
	.long got_info_offsets
	.align 2
	.long methods_end
	.align 2
	.long unwind_info
	.align 2
	.long mem_end
	.align 2
	.long image_table
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end

	.long 18,84,3,15,14,387000831,0,938
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,128,4,4,14
	.long 0,0,0,0,0
	.globl _mono_aot_module_Sagua_Global_Models_info
	.align 2
_mono_aot_module_Sagua_Global_Models_info:
	.align 2
	.long _mono_aot_file_info
.section __TEXT, __const
	.align 3
blob:

	.byte 0,0,1,4,0,1,5,0,1,6,0,1,7,0,1,8,0,1,9,0,1,10,0,1,11,0,1,12,0,1,13,0
	.byte 1,14,0,1,15,0,1,16,0,1,17,12,0,39,42,47,40,40,40,40,40,40,40,40,40,40,40,40,40,40,3,193
	.byte 0,0,9,3,193,0,0,4,10,0,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,1,3,5,16,0
	.byte 0,192,255,255,243,24,0,0,29,128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28,5,4,1,4,5,16
	.byte 0,16,1,4,1,20,10,21,4,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0,192,255,255,248,16,0
	.byte 0,25,128,140,72,128,152,208,0,0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1,32,10,21,4,255,255
	.byte 255,255,255,52,0,0,1,24,0,1,2,6,24,0,0,192,255,255,249,16,0,0,20,128,132,68,128,144,208,0,0,13
	.byte 8,0,4,0,68,1,28,5,4,1,32,10,0,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,1,3
	.byte 5,16,0,0,192,255,255,243,24,0,0,29,128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28,5,4,1
	.byte 4,5,16,0,16,1,4,1,20,10,21,4,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0,192,255,255
	.byte 248,16,0,0,25,128,140,72,128,152,208,0,0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1,32,10,21
	.byte 4,255,255,255,255,255,52,0,0,1,24,0,1,2,6,24,0,0,192,255,255,249,16,0,0,20,128,132,68,128,144,208
	.byte 0,0,13,8,0,4,0,68,1,28,5,4,1,32,10,0,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28
	.byte 0,1,3,5,16,0,0,192,255,255,243,24,0,0,29,128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28
	.byte 5,4,1,4,5,16,0,16,1,4,1,20,10,21,4,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0
	.byte 192,255,255,248,16,0,0,25,128,140,72,128,152,208,0,0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1
	.byte 32,10,0,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,1,3,5,16,0,0,192,255,255,243,24,0
	.byte 0,29,128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28,5,4,1,4,5,16,0,16,1,4,1,20,10
	.byte 21,4,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0,192,255,255,248,16,0,0,25,128,140,72,128,152
	.byte 208,0,0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1,32,10,21,4,255,255,255,255,255,52,0,0,1
	.byte 24,0,1,2,6,24,0,0,192,255,255,249,16,0,0,20,128,132,68,128,144,208,0,0,13,8,0,4,0,68,1,28
	.byte 5,4,1,32,10,0,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,1,3,5,16,0,0,192,255,255
	.byte 243,24,0,0,29,128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28,5,4,1,4,5,16,0,16,1,4
	.byte 1,20,10,21,4,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0,192,255,255,248,16,0,0,25,128,140
	.byte 72,128,152,208,0,0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1,32,10,21,4,255,255,255,255,255,52
	.byte 0,0,1,24,0,1,2,6,24,0,0,192,255,255,249,16,0,0,20,128,132,68,128,144,208,0,0,13,8,0,4,0
	.byte 68,1,28,5,4,1,32,0,128,144,8,0,0,1,4,128,128,12,0,0,4,194,0,23,123,194,0,23,120,194,0,23
	.byte 119,194,0,23,117,4,128,128,12,0,0,4,194,0,23,123,194,0,23,120,194,0,23,119,194,0,23,117,4,128,160,24
	.byte 0,0,4,194,0,23,123,194,0,23,120,194,0,23,119,194,0,23,117,4,128,160,20,0,0,4,194,0,23,123,194,0
	.byte 23,120,194,0,23,119,194,0,23,117,98,111,101,104,109,0
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_1:

	.byte 5
	.asciz "Sagua_Global_Common_BaseRestPostModel"

	.byte 8,16
LDIFF_SYM6=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "Sagua_Global_Common_BaseRestPostModel"

LDIFF_SYM7=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_4:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM10=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM11=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM11
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM12=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM12
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM13=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_3:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM14=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM14
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM15=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM15
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM16=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM17=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM18=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_0:

	.byte 5
	.asciz "Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel"

	.byte 12,16
LDIFF_SYM19=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM19
	.byte 2,35,0,6
	.asciz "<Id>k__BackingField"

LDIFF_SYM20=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM20
	.byte 2,35,8,0,7
	.asciz "Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel"

LDIFF_SYM21=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM22=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM22
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM23=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.GetDoctorByIdPostModel:get_Id"
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM24=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM25=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM26=Lfde0_end - Lfde0_start
	.long LDIFF_SYM26
Lfde0_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id

LDIFF_SYM27=Lme_0 - _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id
	.long LDIFF_SYM27
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.GetDoctorByIdPostModel:set_Id"
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int
	.long Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM28=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM29=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM30=Lfde1_end - Lfde1_start
	.long LDIFF_SYM30
Lfde1_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int

LDIFF_SYM31=Lme_1 - _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int
	.long LDIFF_SYM31
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.GetDoctorByIdPostModel:.ctor"
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM32=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM33=Lfde2_end - Lfde2_start
	.long LDIFF_SYM33
Lfde2_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor

LDIFF_SYM34=Lme_2 - _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel__ctor
	.long LDIFF_SYM34
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 5
	.asciz "Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel"

	.byte 12,16
LDIFF_SYM35=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,35,0,6
	.asciz "<Id>k__BackingField"

LDIFF_SYM36=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,8,0,7
	.asciz "Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel"

LDIFF_SYM37=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM37
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM38=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM38
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM39=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.SetDoctorPhotoPostModel:get_Id"
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM40=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM41=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM42=Lfde3_end - Lfde3_start
	.long LDIFF_SYM42
Lfde3_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id

LDIFF_SYM43=Lme_3 - _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id
	.long LDIFF_SYM43
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.SetDoctorPhotoPostModel:set_Id"
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM44=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM44
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM45=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM46=Lfde4_end - Lfde4_start
	.long LDIFF_SYM46
Lfde4_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int

LDIFF_SYM47=Lme_4 - _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int
	.long LDIFF_SYM47
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestPostModels.SetDoctorPhotoPostModel:.ctor"
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor
	.long Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM48=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM49=Lfde5_end - Lfde5_start
	.long LDIFF_SYM49
Lfde5_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor

LDIFF_SYM50=Lme_5 - _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel__ctor
	.long LDIFF_SYM50
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_8:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM51=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM52=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM53=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM53
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM54=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM54
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM55=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM55
LTDIE_7:

	.byte 5
	.asciz "Sagua_Global_Common_BaseRestResult"

	.byte 16,16
LDIFF_SYM56=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,0,6
	.asciz "<IsOk>k__BackingField"

LDIFF_SYM57=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,35,12,6
	.asciz "<ErrorMessage>k__BackingField"

LDIFF_SYM58=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,8,0,7
	.asciz "Sagua_Global_Common_BaseRestResult"

LDIFF_SYM59=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM59
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM60=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM60
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM61=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM61
LTDIE_6:

	.byte 5
	.asciz "Sagua_Global_Models_RestResults_GetDoctorByIdResults"

	.byte 24,16
LDIFF_SYM62=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,35,0,6
	.asciz "<Id>k__BackingField"

LDIFF_SYM63=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2,35,20,6
	.asciz "<Name>k__BackingField"

LDIFF_SYM64=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,16,0,7
	.asciz "Sagua_Global_Models_RestResults_GetDoctorByIdResults"

LDIFF_SYM65=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM65
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM66=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM67=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 2
	.asciz "Sagua.Global.Models.RestResults.GetDoctorByIdResults:get_Id"
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM68=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM69=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM70=Lfde6_end - Lfde6_start
	.long LDIFF_SYM70
Lfde6_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id

LDIFF_SYM71=Lme_6 - _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id
	.long LDIFF_SYM71
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.GetDoctorByIdResults:set_Id"
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int
	.long Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM72=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM73=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM73
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM74=Lfde7_end - Lfde7_start
	.long LDIFF_SYM74
Lfde7_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int

LDIFF_SYM75=Lme_7 - _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int
	.long LDIFF_SYM75
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.GetDoctorByIdResults:get_Name"
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name
	.long Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM76=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM77=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM78=Lfde8_end - Lfde8_start
	.long LDIFF_SYM78
Lfde8_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name

LDIFF_SYM79=Lme_8 - _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name
	.long LDIFF_SYM79
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.GetDoctorByIdResults:set_Name"
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string
	.long Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM80=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM81=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM82=Lfde9_end - Lfde9_start
	.long LDIFF_SYM82
Lfde9_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string

LDIFF_SYM83=Lme_9 - _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string
	.long LDIFF_SYM83
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.GetDoctorByIdResults:.ctor"
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor
	.long Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM84=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM85=Lfde10_end - Lfde10_start
	.long LDIFF_SYM85
Lfde10_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor

LDIFF_SYM86=Lme_a - _Sagua_Global_Models_RestResults_GetDoctorByIdResults__ctor
	.long LDIFF_SYM86
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_9:

	.byte 5
	.asciz "Sagua_Global_Models_RestResults_SetDoctorPhotoResults"

	.byte 20,16
LDIFF_SYM87=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,35,0,6
	.asciz "<Info>k__BackingField"

LDIFF_SYM88=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,35,16,0,7
	.asciz "Sagua_Global_Models_RestResults_SetDoctorPhotoResults"

LDIFF_SYM89=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM89
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM90=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM90
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM91=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2
	.asciz "Sagua.Global.Models.RestResults.SetDoctorPhotoResults:get_Info"
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info
	.long Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM92=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM93=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM94=Lfde11_end - Lfde11_start
	.long LDIFF_SYM94
Lfde11_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info

LDIFF_SYM95=Lme_b - _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info
	.long LDIFF_SYM95
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.SetDoctorPhotoResults:set_Info"
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string
	.long Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM96=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM97=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM98=Lfde12_end - Lfde12_start
	.long LDIFF_SYM98
Lfde12_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string

LDIFF_SYM99=Lme_c - _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string
	.long LDIFF_SYM99
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.Global.Models.RestResults.SetDoctorPhotoResults:.ctor"
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor
	.long Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM100=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde13_end - Lfde13_start
	.long LDIFF_SYM101
Lfde13_start:

	.long 0
	.align 2
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor

LDIFF_SYM102=Lme_d - _Sagua_Global_Models_RestResults_SetDoctorPhotoResults__ctor
	.long LDIFF_SYM102
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:

	.long Ldebug_line_end - . -4
	.short 2
	.long Ldebug_line_header_end - . -4
	.byte 1,1,251,14,13,0,1,1,1,1,0,0,0,1,0,0,1
.section __DWARF, __debug_line,regular,debug
	.asciz "/Users/hai/Desktop/Share/HugoApplications/Sagua.App.Framework/Sagua.Global.Models/RestPostModels"
	.asciz "/Users/hai/Desktop/Share/HugoApplications/Sagua.App.Framework/Sagua.Global.Models/RestResults"

	.byte 0
	.asciz "<unknown>"

	.byte 0,0,0
	.asciz "GetDoctorByIdPostModel.cs"

	.byte 1,0,0
	.asciz "SetDoctorPhotoPostModel.cs"

	.byte 1,0,0
	.asciz "GetDoctorByIdResults.cs"

	.byte 2,0,0,0
Ldebug_line_header_end:
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_get_Id

	.byte 3,7,4,2,1,3,7,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestPostModels_GetDoctorByIdPostModel_set_Id_int

	.byte 3,7,4,2,1,3,7,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_get_Id

	.byte 3,6,4,3,1,3,6,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestPostModels_SetDoctorPhotoPostModel_set_Id_int

	.byte 3,6,4,3,1,3,6,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Id

	.byte 3,11,4,4,1,3,11,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Id_int

	.byte 3,11,4,4,1,3,11,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_get_Name

	.byte 3,12,4,4,1,3,12,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_GetDoctorByIdResults_set_Name_string

	.byte 3,12,4,4,1,3,12,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_get_Info

	.byte 3,17,4,4,1,3,17,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_Global_Models_RestResults_SetDoctorPhotoResults_set_Info_string

	.byte 3,17,4,4,1,3,17,2,200,0,1,2,208,0,1,0,1,1,0,1,1
Ldebug_line_end:
.text
	.align 3
mem_end:
