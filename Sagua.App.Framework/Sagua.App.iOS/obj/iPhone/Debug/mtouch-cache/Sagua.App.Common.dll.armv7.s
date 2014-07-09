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
	.asciz "Sagua.App.Common.dll"
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
	.no_dead_strip _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor
_Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 4
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,120,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,112,9,45,233,84,208,77,226,13,176,160,225,32,0,139,229,36,16,139,229,40,32,139,229
	.byte 44,48,139,229,112,224,157,229,48,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 8
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,96,160,227,0,80,160,227,0,0,160,227
	.byte 8,0,139,229,0,224,155,229,100,224,158,229,0,0,94,227,0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229
	.byte 124,224,158,229,0,0,94,227,0,224,158,21,0,224,155,229,140,224,158,229,0,0,94,227,0,224,158,21,36,64,155,229
	.byte 20,64,139,229,0,0,84,227,11,0,0,10,0,0,148,229,0,0,144,229,8,0,144,229,4,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 12
	.byte 1,16,159,231,1,0,80,225,1,0,0,10,0,0,160,227,20,0,139,229,20,96,155,229,0,224,155,229,224,224,158,229
	.byte 0,0,94,227,0,224,158,21
bl _p_1

	.byte 0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 16
	.byte 0,0,159,231
bl _p_2

	.byte 72,0,139,229
bl _p_3

	.byte 72,0,155,229,0,80,160,225,0,224,155,229,24,225,158,229,0,0,94,227,0,224,158,21,5,0,160,225,1,0,160,227
	.byte 0,224,155,229,48,225,158,229,0,0,94,227,0,224,158,21,5,0,160,225,1,16,160,227,0,224,213,229
bl _p_4

	.byte 0,224,155,229,80,225,158,229,0,0,94,227,0,224,158,21,5,0,160,225,68,0,139,229,5,0,160,227,0,0,160,227
	.byte 0,0,160,227,0,224,155,229,116,225,158,229,0,0,94,227,0,224,158,21,12,0,139,226,0,0,160,227,0,0,160,227
	.byte 12,0,139,229,0,0,160,227,16,0,139,229,12,0,139,226,5,16,160,227,0,32,160,227,0,48,160,227
bl _p_5

	.byte 12,0,139,226,24,0,139,226,12,0,155,229,24,0,139,229,16,0,155,229,28,0,139,229,0,224,155,229,200,225,158,229
	.byte 0,0,94,227,0,224,158,21,68,48,155,229,3,0,160,225,24,16,139,226,24,16,155,229,28,32,155,229,0,224,211,229
bl _p_6

	.byte 0,224,155,229,244,225,158,229,0,0,94,227,0,224,158,21,5,0,160,225,60,0,139,229,6,0,160,225,64,0,139,229
	.byte 0,224,155,229,20,226,158,229,0,0,94,227,0,224,158,21,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 20
	.byte 0,0,159,231
bl _p_2

	.byte 64,16,155,229,56,0,139,229
bl _p_7

	.byte 0,224,155,229,68,226,158,229,0,0,94,227,0,224,158,21,56,16,155,229,60,32,155,229,2,0,160,225,0,224,210,229
bl _p_8

	.byte 0,224,155,229,104,226,158,229,0,0,94,227,0,224,158,21,5,0,160,225,8,0,139,229,0,224,155,229,128,226,158,229
	.byte 0,0,94,227,0,224,158,21,0,224,155,229,144,226,158,229,0,0,94,227,0,224,158,21,8,0,155,229,0,224,155,229
	.byte 164,226,158,229,0,0,94,227,0,224,158,21,84,208,139,226,112,9,189,232,128,128,189,232

Lme_1:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,32,208,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,48,224,157,229,24,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 24
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,224,155,229,84,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229,108,224,158,229,0,0,94,227,0,224,158,21,0,224,155,229
	.byte 124,224,158,229,0,0,94,227,0,224,158,21,239,2,0,227,0,2,64,227,239,2,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_9

	.byte 0,224,155,229,164,224,158,229,0,0,94,227,0,224,158,21,32,208,139,226,0,9,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_BaseViewModel_get_Page
_Sagua_App_Common_BaseViewModel_get_Page:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 28
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,12,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page
_Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 32
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,12,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_4:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_BaseViewModel_get_Settings
_Sagua_App_Common_BaseViewModel_get_Settings:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,16,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 36
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,96,160,227,0,224,157,229,64,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21
	.byte 8,0,157,229,16,0,144,229,0,96,160,225,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229
	.byte 132,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225,0,224,157,229,156,224,158,229,0,0,94,227
	.byte 0,224,158,21,16,208,141,226,64,1,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings
_Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 40
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 12,16,157,229,16,16,128,229,0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,20,208,141,226,0,1,189,232,128,128,189,232

Lme_6:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page
_Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page:

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,24,208,77,226,0,96,160,225,8,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 44
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,64,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,88,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225
	.byte 6,0,160,225
bl _p_10

	.byte 0,224,157,229,116,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,132,224,158,229,0,0,94,227,0,224,158,21
	.byte 6,0,160,225,8,0,157,229,20,0,141,229,0,224,157,229,160,224,158,229,0,0,94,227,0,224,158,21,20,16,157,229
	.byte 6,0,160,225
bl _p_11

	.byte 0,224,157,229,188,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,0,0,160,227,0,224,157,229,212,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 48
	.byte 0,0,159,231,0,128,160,225,0,0,160,227
bl _p_12

	.byte 16,0,141,229,0,224,157,229,4,225,158,229,0,0,94,227,0,224,158,21,16,16,157,229,6,0,160,225
bl _p_13

	.byte 0,224,157,229,32,225,158,229,0,0,94,227,0,224,158,21,0,224,157,229,48,225,158,229,0,0,94,227,0,224,158,21
	.byte 24,208,141,226,64,1,189,232,128,128,189,232

Lme_7:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_InvertedBoolValueConverter__ctor
_Sagua_App_Common_InvertedBoolValueConverter__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 52
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,120,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_8:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,44,208,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,64,224,157,229,24,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 56
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,96,160,227,0,224,155,229,88,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229,112,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,128,224,158,229,0,0,94,227,0,224,158,21,12,0,155,229,0,16,144,229,22,32,209,229,0,0,82,227
	.byte 40,0,0,27,0,16,145,229,0,16,145,229,0,32,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 60
	.byte 2,32,159,231,2,0,81,225,32,0,0,27,8,16,128,226,8,0,208,229,0,16,160,227,0,0,80,227,0,0,160,19
	.byte 1,0,160,3,36,0,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 64
	.byte 0,0,159,231
bl _p_14

	.byte 36,16,155,229,8,16,192,229,32,0,139,229,0,96,160,225,0,224,155,229,4,225,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,20,225,158,229,0,0,94,227,0,224,158,21,32,0,155,229,0,16,160,225,0,224,155,229,44,225,158,229
	.byte 0,0,94,227,0,224,158,21,44,208,139,226,64,9,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_15

	.byte 216,2,0,2

Lme_9:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,44,208,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,64,224,157,229,24,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 68
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,96,160,227,0,224,155,229,88,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229,112,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,128,224,158,229,0,0,94,227,0,224,158,21,12,0,155,229,0,16,144,229,22,32,209,229,0,0,82,227
	.byte 40,0,0,27,0,16,145,229,0,16,145,229,0,32,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 60
	.byte 2,32,159,231,2,0,81,225,32,0,0,27,8,16,128,226,8,0,208,229,0,16,160,227,0,0,80,227,0,0,160,19
	.byte 1,0,160,3,36,0,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 64
	.byte 0,0,159,231
bl _p_14

	.byte 36,16,155,229,8,16,192,229,32,0,139,229,0,96,160,225,0,224,155,229,4,225,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,20,225,158,229,0,0,94,227,0,224,158,21,32,0,155,229,0,16,160,225,0,224,155,229,44,225,158,229
	.byte 0,0,94,227,0,224,158,21,44,208,139,226,64,9,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_15

	.byte 216,2,0,2

Lme_a:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_EnumToListValueConverter__ctor
_Sagua_App_Common_EnumToListValueConverter__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 72
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,120,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_b:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,112,9,45,233,44,208,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,72,224,157,229,24,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 76
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,96,160,227,0,224,155,229,88,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229,112,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,128,224,158,229,0,0,94,227,0,224,158,21,12,80,155,229,5,64,160,225,0,0,85,227,10,0,0,10
	.byte 0,0,149,229,0,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 80
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,64,160,227,4,224,155,229,0,224,158,229,0,224,155,229,212,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,0,160,225
bl _p_16

	.byte 36,0,139,229,0,224,155,229,240,224,158,229,0,0,94,227,0,224,158,21,36,0,155,229,32,0,139,229,0,96,160,225
	.byte 0,224,155,229,12,225,158,229,0,0,94,227,0,224,158,21,0,224,155,229,28,225,158,229,0,0,94,227,0,224,158,21
	.byte 32,0,155,229,0,16,160,225,0,224,155,229,52,225,158,229,0,0,94,227,0,224,158,21,44,208,139,226,112,9,189,232
	.byte 128,128,189,232

Lme_c:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
_Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo:

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,36,208,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,56,224,157,229,24,224,139,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 84
	.byte 0,0,159,231,0,0,139,229,0,224,155,229,0,224,158,229,4,224,139,229,0,96,160,227,0,224,155,229,88,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,155,229,0,224,158,229,0,224,155,229,112,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,155,229,128,224,158,229,0,0,94,227,0,224,158,21,12,0,155,229,0,96,160,225,0,224,155,229,152,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,224,155,229,168,224,158,229,0,0,94,227,0,224,158,21,6,0,160,225,6,0,160,225
	.byte 0,224,155,229,192,224,158,229,0,0,94,227,0,224,158,21,36,208,139,226,64,9,189,232,128,128,189,232

Lme_d:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
_Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler:

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,24,208,77,226,0,96,160,225,8,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 88
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,80,160,227,0,64,160,227,0,224,157,229
	.byte 72,224,158,229,0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,96,224,158,229,0,0,94,227
	.byte 0,224,158,21,6,0,160,225,8,0,150,229,0,80,160,225,4,224,157,229,0,224,158,229,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,5,0,160,225,5,64,160,225,0,224,157,229,156,224,158,229,0,0,94,227,0,224,158,21
	.byte 6,0,160,225,0,0,86,227,63,0,0,11,8,176,134,226,5,0,160,225,8,16,157,229,5,0,160,225
bl _p_17

	.byte 0,160,160,225,0,224,157,229,208,224,158,229,0,0,94,227,0,224,158,21,0,0,90,227,9,0,0,10,0,0,154,229
	.byte 0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 92
	.byte 1,16,159,231,1,0,80,225,37,0,0,27,5,0,160,225,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 96
	.byte 0,0,159,231,0,128,160,225,11,0,160,225,10,16,160,225,5,32,160,225
bl _p_18

	.byte 20,0,141,229,0,224,157,229,60,225,158,229,0,0,94,227,0,224,158,21,20,0,157,229,16,0,141,229,0,80,160,225
	.byte 0,224,157,229,88,225,158,229,0,0,94,227,0,224,158,21,16,0,157,229,0,16,160,225,4,16,160,225,4,0,80,225
	.byte 191,255,255,26,0,224,157,229,124,225,158,229,0,0,94,227,0,224,158,21,0,224,157,229,140,225,158,229,0,0,94,227
	.byte 0,224,158,21,24,208,141,226,112,13,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_15

	.byte 216,2,0,2,14,16,160,225,0,0,159,229
bl _p_15

	.byte 241,2,0,2

Lme_e:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
_Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler:

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,24,208,77,226,0,96,160,225,8,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 100
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,80,160,227,0,64,160,227,0,224,157,229
	.byte 72,224,158,229,0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,96,224,158,229,0,0,94,227
	.byte 0,224,158,21,6,0,160,225,8,0,150,229,0,80,160,225,4,224,157,229,0,224,158,229,0,224,157,229,132,224,158,229
	.byte 0,0,94,227,0,224,158,21,5,0,160,225,5,64,160,225,0,224,157,229,156,224,158,229,0,0,94,227,0,224,158,21
	.byte 6,0,160,225,0,0,86,227,63,0,0,11,8,176,134,226,5,0,160,225,8,16,157,229,5,0,160,225
bl _p_19

	.byte 0,160,160,225,0,224,157,229,208,224,158,229,0,0,94,227,0,224,158,21,0,0,90,227,9,0,0,10,0,0,154,229
	.byte 0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 92
	.byte 1,16,159,231,1,0,80,225,37,0,0,27,5,0,160,225,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 96
	.byte 0,0,159,231,0,128,160,225,11,0,160,225,10,16,160,225,5,32,160,225
bl _p_18

	.byte 20,0,141,229,0,224,157,229,60,225,158,229,0,0,94,227,0,224,158,21,20,0,157,229,16,0,141,229,0,80,160,225
	.byte 0,224,157,229,88,225,158,229,0,0,94,227,0,224,158,21,16,0,157,229,0,16,160,225,4,16,160,225,4,0,80,225
	.byte 191,255,255,26,0,224,157,229,124,225,158,229,0,0,94,227,0,224,158,21,0,224,157,229,140,225,158,229,0,0,94,227
	.byte 0,224,158,21,24,208,141,226,112,13,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_15

	.byte 216,2,0,2,14,16,160,225,0,0,159,229
bl _p_15

	.byte 241,2,0,2

Lme_f:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_ObservableObject__ctor
_Sagua_App_Common_ObservableObject__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,20,208,77,226,8,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 104
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,224,157,229,60,224,158,229,0,0,94,227
	.byte 0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,84,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229
	.byte 0,224,157,229,104,224,158,229,0,0,94,227,0,224,158,21,0,224,157,229,120,224,158,229,0,0,94,227,0,224,158,21
	.byte 20,208,141,226,0,1,189,232,128,128,189,232

Lme_10:
.text
	.align 2
	.no_dead_strip _Sagua_App_Common_ObservableObject_OnPropertyChanged_string
_Sagua_App_Common_ObservableObject_OnPropertyChanged_string:

	.byte 128,64,45,233,13,112,160,225,32,1,45,233,32,208,77,226,8,0,141,229,12,16,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 108
	.byte 0,0,159,231,0,0,141,229,0,224,157,229,0,224,158,229,4,224,141,229,0,80,160,227,0,224,157,229,68,224,158,229
	.byte 0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229,92,224,158,229,0,0,94,227,0,224,158,21
	.byte 0,224,157,229,108,224,158,229,0,0,94,227,0,224,158,21,8,0,157,229,8,0,144,229,0,80,160,225,0,224,157,229
	.byte 136,224,158,229,0,0,94,227,0,224,158,21,5,0,160,225,0,0,85,227,37,0,0,10,0,224,157,229,164,224,158,229
	.byte 0,0,94,227,0,224,158,21,0,224,157,229,180,224,158,229,0,0,94,227,0,224,158,21,5,0,160,225,8,0,157,229
	.byte 16,0,141,229,12,0,157,229,24,0,141,229,0,224,157,229,216,224,158,229,0,0,94,227,0,224,158,21,0,0,159,229
	.byte 0,0,0,234
	.long _mono_aot_Sagua_App_Common_got - . + 112
	.byte 0,0,159,231
bl _p_2

	.byte 24,16,157,229,20,0,141,229
bl _p_20

	.byte 0,224,157,229,8,225,158,229,0,0,94,227,0,224,158,21,16,16,157,229,20,32,157,229,5,0,160,225,15,224,160,225
	.byte 12,240,149,229,0,224,157,229,44,225,158,229,0,0,94,227,0,224,158,21,4,224,157,229,0,224,158,229,0,224,157,229
	.byte 68,225,158,229,0,0,94,227,0,224,158,21,0,224,157,229,84,225,158,229,0,0,94,227,0,224,158,21,32,208,141,226
	.byte 32,1,189,232,128,128,189,232

Lme_11:
.text
	.align 3
methods_end:

	.long 0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor
bl _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_BaseViewModel_get_Page
bl _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page
bl _Sagua_App_Common_BaseViewModel_get_Settings
bl _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings
bl _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page
bl _Sagua_App_Common_InvertedBoolValueConverter__ctor
bl _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_EnumToListValueConverter__ctor
bl _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
bl _Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
bl _Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
bl _Sagua_App_Common_ObservableObject__ctor
bl _Sagua_App_Common_ObservableObject_OnPropertyChanged_string
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

	.long 19,10,2,2
	.short 0, 10
	.byte 1,3,6,3,3,3,3,3,4,3,37,5,3,4,3,5,5,3,255,255,255,255,191
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

	.short 11, 1, 11, 0, 0, 0, 0, 5
	.short 0, 0, 0, 0, 0, 3, 0, 2
	.short 0, 0, 0, 4, 0, 0, 0, 6
	.short 0
.section __TEXT, __const
	.align 3
got_info_offsets:

	.long 32,10,4,2
	.short 0, 10, 20, 30
	.byte 69,2,1,1,1,1,1,5,5,5,92,1,1,1,1,1,12,1,1,5,121,1,1,1,5,1,1,5,12,1,128,150
	.byte 1
.section __TEXT, __const
	.align 3
ex_info_offsets:

	.long 19,10,2,2
	.short 0, 12
	.byte 129,101,46,129,0,76,62,53,62,53,117,46,132,224,120,46,126,88,128,154,128,154,46,255,255,255,248,66
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 18,12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32,29,12,13,0,72,14,8,135,2,68,14,28,132
	.byte 7,133,6,134,5,136,4,139,3,142,1,68,14,112,68,13,11,23,12,13,0,72,14,8,135,2,68,14,16,136,4,139
	.byte 3,142,1,68,14,48,68,13,11,20,12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32,20,12
	.byte 13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,40,25,12,13,0,72,14,8,135,2,68,14,20,134
	.byte 5,136,4,139,3,142,1,68,14,64,68,13,11,29,12,13,0,72,14,8,135,2,68,14,28,132,7,133,6,134,5,136
	.byte 4,139,3,142,1,68,14,72,68,13,11,25,12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,139,3,142,1,68
	.byte 14,56,68,13,11,28,12,13,0,72,14,8,135,2,68,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68
	.byte 14,56,20,12,13,0,72,14,8,135,2,68,14,16,133,4,136,3,142,1,68,14,48
.section __TEXT, __const
	.align 3
class_info_offsets:

	.long 6,10,1,2
	.short 0
	.byte 136,63,7,25,25,25,25

.text
	.align 4
plt:
_mono_aot_Sagua_App_Common_plt:
	.no_dead_strip plt__class_init_Xamarin_Forms_UriImageSource
plt__class_init_Xamarin_Forms_UriImageSource:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 128,156
	.no_dead_strip plt__jit_icall_mono_object_new_fast
plt__jit_icall_mono_object_new_fast:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 132,161
	.no_dead_strip plt_Xamarin_Forms_UriImageSource__ctor
plt_Xamarin_Forms_UriImageSource__ctor:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 136,184
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_CachingEnabled_bool
plt_Xamarin_Forms_UriImageSource_set_CachingEnabled_bool:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 140,189
	.no_dead_strip plt_System_TimeSpan__ctor_int_int_int
plt_System_TimeSpan__ctor_int_int_int:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 144,194
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_CacheValidity_System_TimeSpan
plt_Xamarin_Forms_UriImageSource_set_CacheValidity_System_TimeSpan:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 148,199
	.no_dead_strip plt_System_Uri__ctor_string
plt_System_Uri__ctor_string:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 152,204
	.no_dead_strip plt_Xamarin_Forms_UriImageSource_set_Uri_System_Uri
plt_Xamarin_Forms_UriImageSource_set_Uri_System_Uri:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 156,209
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 160,214
	.no_dead_strip plt_Sagua_App_Common_ObservableObject__ctor
plt_Sagua_App_Common_ObservableObject__ctor:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 164,242
	.no_dead_strip plt_Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page
plt_Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 168,244
	.no_dead_strip plt_Xamarin_Forms_DependencyService_Get_Sagua_App_Components_Settings_ISettings_Xamarin_Forms_DependencyFetchTarget
plt_Xamarin_Forms_DependencyService_Get_Sagua_App_Components_Settings_ISettings_Xamarin_Forms_DependencyFetchTarget:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 172,246
	.no_dead_strip plt_Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings
plt_Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 176,258
	.no_dead_strip plt__jit_icall_mono_object_new_ptrfree_box
plt__jit_icall_mono_object_new_ptrfree_box:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 180,260
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 184,290
	.no_dead_strip plt_Sagua_Global_Common_EnumExtension_GetChildren_System_Enum
plt_Sagua_Global_Common_EnumExtension_GetChildren_System_Enum:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 188,325
	.no_dead_strip plt_System_Delegate_Combine_System_Delegate_System_Delegate
plt_System_Delegate_Combine_System_Delegate_System_Delegate:
_p_17:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 192,330
	.no_dead_strip plt_System_Threading_Interlocked_CompareExchange_System_ComponentModel_PropertyChangedEventHandler_System_ComponentModel_PropertyChangedEventHandler__System_ComponentModel_PropertyChangedEventHandler_System_ComponentModel_PropertyChangedEventHandler
plt_System_Threading_Interlocked_CompareExchange_System_ComponentModel_PropertyChangedEventHandler_System_ComponentModel_PropertyChangedEventHandler__System_ComponentModel_PropertyChangedEventHandler_System_ComponentModel_PropertyChangedEventHandler:
_p_18:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 196,335
	.no_dead_strip plt_System_Delegate_Remove_System_Delegate_System_Delegate
plt_System_Delegate_Remove_System_Delegate_System_Delegate:
_p_19:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 200,347
	.no_dead_strip plt_System_ComponentModel_PropertyChangedEventArgs__ctor_string
plt_System_ComponentModel_PropertyChangedEventArgs__ctor_string:
_p_20:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_Sagua_App_Common_got - . + 204,352
plt_end:
.section __TEXT, __const
	.align 3
image_table:

	.long 5
	.asciz "Sagua.App.Common"
	.asciz "63379317-CF95-4D94-8FB3-5C0F2A7D4D33"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,1,0,5303,24636
	.asciz "mscorlib"
	.asciz "D682AB0B-3FD6-42A4-A7BE-C03BC5443B3F"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
	.asciz "Xamarin.Forms.Core"
	.asciz "929C2B5F-212C-4FC4-B7FE-11FC996A9FE6"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "System"
	.asciz "D2C16AE0-1730-443C-9674-F4CB3B0BC31F"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
	.asciz "Sagua.Global.Common"
	.asciz "0FAC608B-80E6-426F-BE60-D48906FD1996"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,1,0,5303,20564
.data
	.align 3
_mono_aot_Sagua_App_Common_got:
	.space 212
got_end:
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "63379317-CF95-4D94-8FB3-5C0F2A7D4D33"
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "Sagua.App.Common"
.data
	.align 3
_mono_aot_file_info:

	.long 99,0
	.align 2
	.long _mono_aot_Sagua_App_Common_got
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

	.long 32,212,21,19,14,387000831,0,2243
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,128,4,4,14
	.long 0,0,0,0,0
	.globl _mono_aot_module_Sagua_App_Common_info
	.align 2
_mono_aot_module_Sagua_App_Common_info:
	.align 2
	.long _mono_aot_file_info
.section __TEXT, __const
	.align 3
blob:

	.byte 0,0,1,4,0,4,5,6,7,8,0,1,9,0,1,10,0,1,11,0,1,12,0,1,13,0,2,14,15,0,1,16
	.byte 0,3,17,18,19,0,3,20,18,19,0,1,21,0,2,22,23,0,1,24,0,3,25,26,27,0,3,28,26,27,0,1
	.byte 29,0,2,30,31,12,0,39,42,47,40,40,11,2,131,13,1,14,2,128,214,2,14,2,129,178,3,40,40,40,40,40
	.byte 40,34,255,254,0,0,0,0,255,43,0,0,1,40,40,11,2,130,141,1,14,2,130,141,1,40,40,40,11,2,130,175
	.byte 1,40,40,11,2,128,154,3,34,255,254,0,0,0,0,255,43,0,0,2,40,40,40,14,2,128,153,3,15,2,128,214
	.byte 2,7,20,109,111,110,111,95,111,98,106,101,99,116,95,110,101,119,95,102,97,115,116,0,3,194,0,7,71,3,194,0
	.byte 7,61,3,193,0,22,220,3,194,0,7,63,3,195,0,12,179,3,194,0,7,58,7,25,109,111,110,111,95,97,114,99
	.byte 104,95,116,104,114,111,119,95,101,120,99,101,112,116,105,111,110,0,3,17,3,5,3,255,254,0,0,0,0,255,43,0
	.byte 0,1,3,7,7,27,109,111,110,111,95,111,98,106,101,99,116,95,110,101,119,95,112,116,114,102,114,101,101,95,98,111
	.byte 120,0,7,32,109,111,110,111,95,97,114,99,104,95,116,104,114,111,119,95,99,111,114,108,105,98,95,101,120,99,101,112
	.byte 116,105,111,110,0,3,196,0,0,2,3,193,0,19,16,3,255,254,0,0,0,0,255,43,0,0,2,3,193,0,19,18
	.byte 3,195,0,4,48,10,0,4,255,255,255,255,255,52,0,0,1,24,0,1,2,6,20,0,0,192,255,255,249,16,0,0
	.byte 18,128,128,68,128,140,208,0,0,13,8,0,3,0,68,6,28,1,32,10,19,16,255,255,255,255,255,92,0,0,1,24
	.byte 0,1,2,1,16,0,1,3,7,84,0,1,4,6,56,0,1,5,2,24,1,1,6,5,32,0,1,7,4,36,1,1
	.byte 8,5,84,1,1,9,5,44,0,1,10,2,32,1,1,11,5,48,1,1,12,5,36,0,1,13,2,24,0,1,14,5
	.byte 16,0,0,192,255,255,201,20,0,0,128,167,130,172,108,130,184,208,0,0,11,36,208,0,0,11,40,208,0,0,11,44
	.byte 208,0,0,11,48,208,0,0,11,32,6,5,208,0,0,11,8,0,64,0,108,1,24,1,20,0,4,0,4,0,4,0
	.byte 4,0,4,0,4,0,4,0,16,0,4,0,8,6,8,0,16,0,4,0,16,0,4,0,4,5,8,1,4,0,16,1
	.byte 4,1,4,0,16,0,4,0,4,0,4,0,0,5,4,0,16,1,8,1,4,1,4,1,4,0,40,0,4,0,4,0
	.byte 4,0,4,5,28,0,20,0,16,0,4,0,0,5,4,0,16,1,8,1,8,0,16,0,16,0,8,0,4,5,4,0
	.byte 24,0,4,0,4,0,0,5,4,0,16,1,4,1,4,5,16,2,36,10,49,4,255,255,255,255,255,76,0,0,1,24
	.byte 0,1,2,1,16,0,0,192,255,255,254,40,0,0,48,128,172,92,128,184,208,0,0,11,12,208,0,0,11,16,208,0
	.byte 0,11,20,208,0,0,11,24,208,0,0,11,8,0,8,0,92,1,24,0,16,0,8,0,8,5,4,0,4,1,16,10
	.byte 73,5,255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,1,3,5,16,0,0,192,255,255,243,24,0,0,29
	.byte 128,164,72,128,176,208,0,0,13,8,6,0,8,0,72,1,28,5,4,1,4,5,16,0,16,1,4,1,20,10,0,4
	.byte 255,255,255,255,255,56,0,0,1,24,0,1,2,7,28,0,0,192,255,255,248,16,0,0,25,128,140,72,128,152,208,0
	.byte 0,13,12,208,0,0,13,8,0,4,0,72,2,32,5,4,1,32,10,73,5,255,255,255,255,255,56,0,0,1,24,0
	.byte 1,2,7,28,0,1,3,5,16,0,0,192,255,255,243,24,0,0,29,128,164,72,128,176,208,0,0,13,8,6,0,8
	.byte 0,72,1,28,5,4,1,4,5,16,0,16,1,4,1,20,10,0,4,255,255,255,255,255,56,0,0,1,24,0,1,2
	.byte 7,28,0,0,192,255,255,248,16,0,0,25,128,140,72,128,152,208,0,0,13,12,208,0,0,13,8,0,4,0,72,2
	.byte 32,5,4,1,32,10,94,10,255,255,255,255,255,56,0,0,1,24,0,1,2,6,28,0,1,3,1,16,0,1,4,2
	.byte 28,1,1,5,5,28,0,1,6,2,24,1,1,7,5,48,1,1,8,5,28,0,0,192,255,255,229,16,0,0,59,129
	.byte 56,72,129,68,208,0,0,13,8,6,0,23,0,72,0,24,1,4,0,4,5,4,1,16,0,16,2,12,0,20,0,4
	.byte 5,4,0,16,1,4,1,4,0,16,0,16,0,4,0,4,5,8,0,20,0,4,5,4,1,32,10,0,4,255,255,255
	.byte 255,255,52,0,0,1,24,0,1,2,6,20,0,0,192,255,255,249,16,0,0,18,128,128,68,128,140,208,0,0,13,8
	.byte 0,3,0,68,6,28,1,32,10,115,6,255,255,255,255,255,80,0,0,1,24,0,1,2,1,16,0,1,3,15,128,132
	.byte 0,1,4,5,16,0,0,192,255,255,234,24,0,0,81,129,52,96,129,80,208,0,0,11,12,208,0,0,11,16,208,0
	.byte 0,11,20,208,0,0,11,24,208,0,0,11,8,6,0,24,0,96,1,24,1,20,0,4,0,4,0,4,0,4,0,4
	.byte 0,4,0,16,0,4,0,4,0,4,5,4,1,4,0,4,2,12,0,16,0,8,5,8,1,4,5,16,0,20,2,20
	.byte 10,115,6,255,255,255,255,255,80,0,0,1,24,0,1,2,1,16,0,1,3,15,128,132,0,1,4,5,16,0,0,192
	.byte 255,255,234,24,0,0,81,129,52,96,129,80,208,0,0,11,12,208,0,0,11,16,208,0,0,11,20,208,0,0,11,24
	.byte 208,0,0,11,8,6,0,24,0,96,1,24,1,20,0,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,0,4
	.byte 0,4,5,4,1,4,0,4,2,12,0,16,0,8,5,8,1,4,5,16,0,20,2,20,10,0,4,255,255,255,255,255
	.byte 52,0,0,1,24,0,1,2,6,20,0,0,192,255,255,249,16,0,0,18,128,128,68,128,140,208,0,0,13,8,0,3
	.byte 0,68,6,28,1,32,10,128,141,8,255,255,255,255,255,80,0,0,1,24,0,1,2,1,16,0,1,3,6,84,1,1
	.byte 4,5,28,1,1,5,1,28,0,1,6,5,16,0,0,192,255,255,237,24,0,0,77,129,60,96,129,72,208,0,0,11
	.byte 12,208,0,0,11,16,208,0,0,11,20,208,0,0,11,24,208,0,0,11,8,6,0,22,0,96,1,24,1,20,0,4
	.byte 0,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,0,4,5,4,0,24,0,4,0,8,5,24,1,4,5,16
	.byte 0,20,2,20,10,128,171,6,255,255,255,255,255,80,0,0,1,24,0,1,2,1,16,0,1,3,2,24,0,1,4,5
	.byte 16,0,0,192,255,255,247,24,0,0,49,128,200,96,128,212,208,0,0,11,12,208,0,0,11,16,208,0,0,11,20,208
	.byte 0,0,11,24,208,0,0,11,8,6,0,8,0,96,1,24,1,20,1,4,5,16,0,16,1,4,1,20,10,128,197,9
	.byte 255,255,255,255,255,64,0,0,1,24,0,1,2,7,36,0,1,3,2,24,0,1,4,13,52,1,1,5,11,108,1,1
	.byte 6,1,28,0,2,2,7,7,36,0,0,192,255,255,214,16,0,0,99,129,148,80,129,192,208,0,0,13,8,6,5,4
	.byte 0,42,0,80,0,24,1,4,5,4,1,4,0,24,1,4,1,4,0,16,1,4,0,4,0,4,5,4,2,8,0,4
	.byte 0,4,0,4,5,16,0,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,5,4,1,4,0,16,0,4,0,4
	.byte 0,4,0,4,0,8,5,24,1,4,0,20,1,4,1,4,0,4,5,4,1,32,10,128,197,9,255,255,255,255,255,64
	.byte 0,0,1,24,0,1,2,7,36,0,1,3,2,24,0,1,4,13,52,1,1,5,11,108,1,1,6,1,28,0,2,2
	.byte 7,7,36,0,0,192,255,255,214,16,0,0,99,129,148,80,129,192,208,0,0,13,8,6,5,4,0,42,0,80,0,24
	.byte 1,4,5,4,1,4,0,24,1,4,1,4,0,16,1,4,0,4,0,4,5,4,2,8,0,4,0,4,0,4,5,16
	.byte 0,4,0,4,0,4,0,4,0,4,0,4,0,16,0,4,5,4,1,4,0,16,0,4,0,4,0,4,0,4,0,8
	.byte 5,24,1,4,0,20,1,4,1,4,0,4,5,4,1,32,10,0,4,255,255,255,255,255,52,0,0,1,24,0,1,2
	.byte 6,20,0,0,192,255,255,249,16,0,0,18,128,128,68,128,140,208,0,0,13,8,0,3,0,68,6,28,1,32,10,128
	.byte 226,11,255,255,255,255,255,60,0,0,1,24,0,1,2,1,16,0,1,3,7,28,0,2,4,9,6,28,0,1,5,1
	.byte 16,0,1,6,3,36,1,1,7,5,48,1,1,8,5,36,0,1,9,1,24,0,0,192,255,255,226,16,0,0,64,129
	.byte 92,76,129,104,208,0,0,13,12,208,0,0,13,8,5,0,23,0,76,1,24,1,20,5,4,1,4,0,16,1,4,0
	.byte 4,5,4,1,16,0,16,3,20,0,16,0,16,0,8,0,4,5,4,0,24,0,4,0,8,5,0,1,16,1,40,0
	.byte 128,144,8,0,0,1,6,128,144,8,0,0,1,193,0,21,171,193,0,21,168,193,0,21,167,193,0,21,165,2,3,6
	.byte 128,160,20,0,0,4,193,0,21,171,193,0,21,168,193,0,21,167,193,0,21,165,15,16,6,128,144,8,0,0,1,193
	.byte 0,21,171,193,0,21,168,193,0,21,167,193,0,21,165,10,11,6,128,144,8,0,0,1,193,0,21,171,193,0,21,168
	.byte 193,0,21,167,193,0,21,165,13,14,6,128,160,12,0,0,4,193,0,21,171,193,0,21,168,193,0,21,167,193,0,21
	.byte 165,15,16,98,111,101,104,109,0
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
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_0:

	.byte 5
	.asciz "Sagua_App_Common_UrlStringToCacheImageSourceValueConverter"

	.byte 8,16
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,35,0,0,7
	.asciz "Sagua_App_Common_UrlStringToCacheImageSourceValueConverter"

LDIFF_SYM7=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
	.byte 2
	.asciz "Sagua.App.Common.UrlStringToCacheImageSourceValueConverter:.ctor"
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM10=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM11=Lfde0_end - Lfde0_start
	.long LDIFF_SYM11
Lfde0_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor

LDIFF_SYM12=Lme_0 - _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter__ctor
	.long LDIFF_SYM12
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_3:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 8,16
LDIFF_SYM13=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM14=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM15=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM15
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM16=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_2:

	.byte 5
	.asciz "System_Type"

	.byte 12,16
LDIFF_SYM17=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM17
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM18=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM18
	.byte 2,35,8,0,7
	.asciz "System_Type"

LDIFF_SYM19=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM20=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM21=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_6:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM22=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM23=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM23
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM24=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM24
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM25=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_5:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM26=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM26
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM27=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM28=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM29=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM29
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM30=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM30
LTDIE_7:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM31=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM32=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM33=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM34=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM35=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_8:

	.byte 5
	.asciz "System_Globalization_NumberFormatInfo"

	.byte 144,1,16
LDIFF_SYM36=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,35,0,6
	.asciz "isReadOnly"

LDIFF_SYM37=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,35,8,6
	.asciz "decimalFormats"

LDIFF_SYM38=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2,35,12,6
	.asciz "currencyFormats"

LDIFF_SYM39=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 2,35,16,6
	.asciz "percentFormats"

LDIFF_SYM40=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 2,35,20,6
	.asciz "digitPattern"

LDIFF_SYM41=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 2,35,24,6
	.asciz "zeroPattern"

LDIFF_SYM42=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,35,28,6
	.asciz "currencyDecimalDigits"

LDIFF_SYM43=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 2,35,32,6
	.asciz "currencyDecimalSeparator"

LDIFF_SYM44=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM44
	.byte 2,35,36,6
	.asciz "currencyGroupSeparator"

LDIFF_SYM45=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM45
	.byte 2,35,40,6
	.asciz "currencyGroupSizes"

LDIFF_SYM46=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,35,44,6
	.asciz "currencyNegativePattern"

LDIFF_SYM47=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM47
	.byte 2,35,48,6
	.asciz "currencyPositivePattern"

LDIFF_SYM48=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2,35,52,6
	.asciz "currencySymbol"

LDIFF_SYM49=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 2,35,56,6
	.asciz "nanSymbol"

LDIFF_SYM50=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2,35,60,6
	.asciz "negativeInfinitySymbol"

LDIFF_SYM51=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM51
	.byte 2,35,64,6
	.asciz "negativeSign"

LDIFF_SYM52=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,68,6
	.asciz "numberDecimalDigits"

LDIFF_SYM53=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,35,72,6
	.asciz "numberDecimalSeparator"

LDIFF_SYM54=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM54
	.byte 2,35,76,6
	.asciz "numberGroupSeparator"

LDIFF_SYM55=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM55
	.byte 2,35,80,6
	.asciz "numberGroupSizes"

LDIFF_SYM56=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,35,84,6
	.asciz "numberNegativePattern"

LDIFF_SYM57=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,35,88,6
	.asciz "percentDecimalDigits"

LDIFF_SYM58=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,92,6
	.asciz "percentDecimalSeparator"

LDIFF_SYM59=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,35,96,6
	.asciz "percentGroupSeparator"

LDIFF_SYM60=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,100,6
	.asciz "percentGroupSizes"

LDIFF_SYM61=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,104,6
	.asciz "percentNegativePattern"

LDIFF_SYM62=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,35,108,6
	.asciz "percentPositivePattern"

LDIFF_SYM63=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM63
	.byte 2,35,112,6
	.asciz "percentSymbol"

LDIFF_SYM64=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM64
	.byte 2,35,116,6
	.asciz "perMilleSymbol"

LDIFF_SYM65=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,35,120,6
	.asciz "positiveInfinitySymbol"

LDIFF_SYM66=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM66
	.byte 2,35,124,6
	.asciz "positiveSign"

LDIFF_SYM67=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM67
	.byte 3,35,128,1,6
	.asciz "ansiCurrencySymbol"

LDIFF_SYM68=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 3,35,132,1,6
	.asciz "m_dataItem"

LDIFF_SYM69=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 3,35,136,1,6
	.asciz "m_useUserOverride"

LDIFF_SYM70=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 3,35,140,1,6
	.asciz "validForParseAsNumber"

LDIFF_SYM71=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 3,35,141,1,6
	.asciz "validForParseAsCurrency"

LDIFF_SYM72=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 3,35,142,1,0,7
	.asciz "System_Globalization_NumberFormatInfo"

LDIFF_SYM73=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM73
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM74=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM74
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM75=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM75
LTDIE_10:

	.byte 5
	.asciz "System_Globalization_Calendar"

	.byte 24,16
LDIFF_SYM76=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,35,0,6
	.asciz "m_isReadOnly"

LDIFF_SYM77=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,35,16,6
	.asciz "twoDigitYearMax"

LDIFF_SYM78=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,35,20,6
	.asciz "M_AbbrEraNames"

LDIFF_SYM79=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,35,8,6
	.asciz "M_EraNames"

LDIFF_SYM80=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,35,12,0,7
	.asciz "System_Globalization_Calendar"

LDIFF_SYM81=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM81
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM82=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM82
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM83=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM83
LTDIE_11:

	.byte 8
	.asciz "System_Globalization_DateTimeFormatFlags"

	.byte 4
LDIFF_SYM84=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 9
	.asciz "Unused"

	.byte 0,9
	.asciz "But"

	.byte 1,9
	.asciz "Serialized"

	.byte 2,9
	.asciz "By"

	.byte 3,9
	.asciz "Microsoft"

	.byte 4,0,7
	.asciz "System_Globalization_DateTimeFormatFlags"

LDIFF_SYM85=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM85
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM86=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM86
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM87=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM87
LTDIE_9:

	.byte 5
	.asciz "System_Globalization_DateTimeFormatInfo"

	.byte 184,1,16
LDIFF_SYM88=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,35,0,6
	.asciz "m_isReadOnly"

LDIFF_SYM89=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,35,8,6
	.asciz "amDesignator"

LDIFF_SYM90=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,12,6
	.asciz "pmDesignator"

LDIFF_SYM91=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,16,6
	.asciz "dateSeparator"

LDIFF_SYM92=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,35,20,6
	.asciz "timeSeparator"

LDIFF_SYM93=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 2,35,24,6
	.asciz "shortDatePattern"

LDIFF_SYM94=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2,35,28,6
	.asciz "longDatePattern"

LDIFF_SYM95=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,35,32,6
	.asciz "shortTimePattern"

LDIFF_SYM96=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 2,35,36,6
	.asciz "longTimePattern"

LDIFF_SYM97=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,35,40,6
	.asciz "monthDayPattern"

LDIFF_SYM98=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2,35,44,6
	.asciz "yearMonthPattern"

LDIFF_SYM99=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 2,35,48,6
	.asciz "firstDayOfWeek"

LDIFF_SYM100=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,35,52,6
	.asciz "calendarWeekRule"

LDIFF_SYM101=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM101
	.byte 2,35,56,6
	.asciz "abbreviatedDayNames"

LDIFF_SYM102=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 2,35,60,6
	.asciz "dayNames"

LDIFF_SYM103=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,64,6
	.asciz "monthNames"

LDIFF_SYM104=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 2,35,68,6
	.asciz "genitiveMonthNames"

LDIFF_SYM105=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM105
	.byte 2,35,72,6
	.asciz "abbreviatedMonthNames"

LDIFF_SYM106=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM106
	.byte 2,35,76,6
	.asciz "m_genitiveAbbreviatedMonthNames"

LDIFF_SYM107=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,80,6
	.asciz "allShortDatePatterns"

LDIFF_SYM108=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,84,6
	.asciz "allLongDatePatterns"

LDIFF_SYM109=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM109
	.byte 2,35,88,6
	.asciz "allShortTimePatterns"

LDIFF_SYM110=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM110
	.byte 2,35,92,6
	.asciz "allLongTimePatterns"

LDIFF_SYM111=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2,35,96,6
	.asciz "monthDayPatterns"

LDIFF_SYM112=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,100,6
	.asciz "yearMonthPatterns"

LDIFF_SYM113=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,35,104,6
	.asciz "shortestDayNames"

LDIFF_SYM114=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM114
	.byte 2,35,108,6
	.asciz "culture"

LDIFF_SYM115=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM115
	.byte 2,35,112,6
	.asciz "calendar"

LDIFF_SYM116=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 2,35,116,6
	.asciz "fullDateTimePattern"

LDIFF_SYM117=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,120,6
	.asciz "nDataItem"

LDIFF_SYM118=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,35,124,6
	.asciz "m_useUserOverride"

LDIFF_SYM119=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 3,35,128,1,6
	.asciz "m_isDefaultCalendar"

LDIFF_SYM120=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 3,35,129,1,6
	.asciz "CultureID"

LDIFF_SYM121=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 3,35,132,1,6
	.asciz "bUseCalendarInfo"

LDIFF_SYM122=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 3,35,136,1,6
	.asciz "generalShortTimePattern"

LDIFF_SYM123=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 3,35,140,1,6
	.asciz "generalLongTimePattern"

LDIFF_SYM124=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM124
	.byte 3,35,144,1,6
	.asciz "m_eraNames"

LDIFF_SYM125=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 3,35,148,1,6
	.asciz "m_abbrevEraNames"

LDIFF_SYM126=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 3,35,152,1,6
	.asciz "m_abbrevEnglishEraNames"

LDIFF_SYM127=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM127
	.byte 3,35,156,1,6
	.asciz "m_dateWords"

LDIFF_SYM128=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM128
	.byte 3,35,160,1,6
	.asciz "optionalCalendars"

LDIFF_SYM129=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 3,35,164,1,6
	.asciz "leapYearMonthNames"

LDIFF_SYM130=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM130
	.byte 3,35,168,1,6
	.asciz "formatFlags"

LDIFF_SYM131=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM131
	.byte 3,35,172,1,6
	.asciz "m_name"

LDIFF_SYM132=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 3,35,176,1,6
	.asciz "all_date_time_patterns"

LDIFF_SYM133=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 3,35,180,1,0,7
	.asciz "System_Globalization_DateTimeFormatInfo"

LDIFF_SYM134=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM134
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM135=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM135
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM136=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM136
LTDIE_12:

	.byte 5
	.asciz "System_Globalization_TextInfo"

	.byte 52,16
LDIFF_SYM137=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,35,0,6
	.asciz "m_listSeparator"

LDIFF_SYM138=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 2,35,8,6
	.asciz "m_isReadOnly"

LDIFF_SYM139=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM139
	.byte 2,35,20,6
	.asciz "customCultureName"

LDIFF_SYM140=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2,35,12,6
	.asciz "m_win32LangID"

LDIFF_SYM141=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 2,35,24,6
	.asciz "ci"

LDIFF_SYM142=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,35,16,6
	.asciz "handleDotI"

LDIFF_SYM143=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 2,35,28,6
	.asciz "data"

LDIFF_SYM144=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 2,35,32,0,7
	.asciz "System_Globalization_TextInfo"

LDIFF_SYM145=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM145
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM146=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM147=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM147
LTDIE_15:

	.byte 5
	.asciz "Mono_Globalization_Unicode_CodePointIndexer"

	.byte 24,16
LDIFF_SYM148=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM148
	.byte 2,35,0,6
	.asciz "ranges"

LDIFF_SYM149=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 2,35,8,6
	.asciz "TotalCount"

LDIFF_SYM150=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM150
	.byte 2,35,12,6
	.asciz "defaultIndex"

LDIFF_SYM151=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM151
	.byte 2,35,16,6
	.asciz "defaultCP"

LDIFF_SYM152=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,20,0,7
	.asciz "Mono_Globalization_Unicode_CodePointIndexer"

LDIFF_SYM153=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM153
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM154=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM154
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM155=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM155
LTDIE_14:

	.byte 5
	.asciz "Mono_Globalization_Unicode_SimpleCollator"

	.byte 52,16
LDIFF_SYM156=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM156
	.byte 2,35,0,6
	.asciz "textInfo"

LDIFF_SYM157=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 2,35,8,6
	.asciz "cjkIndexer"

LDIFF_SYM158=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,35,12,6
	.asciz "contractions"

LDIFF_SYM159=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,35,16,6
	.asciz "level2Maps"

LDIFF_SYM160=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 2,35,20,6
	.asciz "unsafeFlags"

LDIFF_SYM161=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,35,24,6
	.asciz "cjkCatTable"

LDIFF_SYM162=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,35,32,6
	.asciz "cjkLv1Table"

LDIFF_SYM163=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 2,35,36,6
	.asciz "cjkLv2Table"

LDIFF_SYM164=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 2,35,40,6
	.asciz "cjkLv2Indexer"

LDIFF_SYM165=LTDIE_15_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM165
	.byte 2,35,28,6
	.asciz "lcid"

LDIFF_SYM166=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 2,35,44,6
	.asciz "frenchSort"

LDIFF_SYM167=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 2,35,48,0,7
	.asciz "Mono_Globalization_Unicode_SimpleCollator"

LDIFF_SYM168=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM168
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM169=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM169
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM170=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM170
LTDIE_13:

	.byte 5
	.asciz "System_Globalization_CompareInfo"

	.byte 24,16
LDIFF_SYM171=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 2,35,0,6
	.asciz "culture"

LDIFF_SYM172=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 2,35,8,6
	.asciz "win32LCID"

LDIFF_SYM173=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 2,35,12,6
	.asciz "m_name"

LDIFF_SYM174=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 2,35,16,6
	.asciz "collator"

LDIFF_SYM175=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 2,35,20,0,7
	.asciz "System_Globalization_CompareInfo"

LDIFF_SYM176=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM176
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM177=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM177
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM178=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM178
LTDIE_4:

	.byte 5
	.asciz "System_Globalization_CultureInfo"

	.byte 108,16
LDIFF_SYM179=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 2,35,0,6
	.asciz "m_isReadOnly"

LDIFF_SYM180=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM180
	.byte 2,35,8,6
	.asciz "cultureID"

LDIFF_SYM181=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM181
	.byte 2,35,12,6
	.asciz "parent_lcid"

LDIFF_SYM182=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 2,35,16,6
	.asciz "datetime_index"

LDIFF_SYM183=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,35,20,6
	.asciz "number_index"

LDIFF_SYM184=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,35,24,6
	.asciz "default_calendar_type"

LDIFF_SYM185=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM185
	.byte 2,35,28,6
	.asciz "m_useUserOverride"

LDIFF_SYM186=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 2,35,32,6
	.asciz "numInfo"

LDIFF_SYM187=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 2,35,36,6
	.asciz "dateTimeInfo"

LDIFF_SYM188=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM188
	.byte 2,35,40,6
	.asciz "textInfo"

LDIFF_SYM189=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 2,35,44,6
	.asciz "m_name"

LDIFF_SYM190=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 2,35,48,6
	.asciz "englishname"

LDIFF_SYM191=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 2,35,52,6
	.asciz "nativename"

LDIFF_SYM192=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM192
	.byte 2,35,56,6
	.asciz "iso3lang"

LDIFF_SYM193=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM193
	.byte 2,35,60,6
	.asciz "iso2lang"

LDIFF_SYM194=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,35,64,6
	.asciz "win3lang"

LDIFF_SYM195=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM195
	.byte 2,35,68,6
	.asciz "territory"

LDIFF_SYM196=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM196
	.byte 2,35,72,6
	.asciz "native_calendar_names"

LDIFF_SYM197=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 2,35,76,6
	.asciz "compareInfo"

LDIFF_SYM198=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 2,35,80,6
	.asciz "textinfo_data"

LDIFF_SYM199=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 2,35,84,6
	.asciz "m_dataItem"

LDIFF_SYM200=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM200
	.byte 2,35,88,6
	.asciz "calendar"

LDIFF_SYM201=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM201
	.byte 2,35,92,6
	.asciz "parent_culture"

LDIFF_SYM202=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM202
	.byte 2,35,96,6
	.asciz "constructed"

LDIFF_SYM203=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 2,35,100,6
	.asciz "cached_serialized_form"

LDIFF_SYM204=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 2,35,104,0,7
	.asciz "System_Globalization_CultureInfo"

LDIFF_SYM205=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM205
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM206=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM206
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM207=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM207
LTDIE_23:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 8,16
LDIFF_SYM208=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM208
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM209=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM209
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM210=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM210
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM211=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM211
LTDIE_22:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 8,16
LDIFF_SYM212=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM212
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM213=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM213
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM214=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM214
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM215=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM215
LTDIE_24:

	.byte 5
	.asciz "System_DelegateData"

	.byte 16,16
LDIFF_SYM216=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM217=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM217
	.byte 2,35,8,6
	.asciz "method_name"

LDIFF_SYM218=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM218
	.byte 2,35,12,0,7
	.asciz "System_DelegateData"

LDIFF_SYM219=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM219
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM220=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM220
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM221=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM221
LTDIE_21:

	.byte 5
	.asciz "System_Delegate"

	.byte 44,16
LDIFF_SYM222=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM223=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 2,35,8,6
	.asciz "invoke_impl"

LDIFF_SYM224=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM224
	.byte 2,35,12,6
	.asciz "m_target"

LDIFF_SYM225=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM225
	.byte 2,35,16,6
	.asciz "method"

LDIFF_SYM226=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM226
	.byte 2,35,20,6
	.asciz "delegate_trampoline"

LDIFF_SYM227=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,35,24,6
	.asciz "method_code"

LDIFF_SYM228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 2,35,28,6
	.asciz "method_info"

LDIFF_SYM229=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 2,35,32,6
	.asciz "original_method_info"

LDIFF_SYM230=LTDIE_22_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 2,35,36,6
	.asciz "data"

LDIFF_SYM231=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,35,40,0,7
	.asciz "System_Delegate"

LDIFF_SYM232=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM232
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM233=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM233
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM234=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM234
LTDIE_20:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 52,16
LDIFF_SYM235=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 2,35,0,6
	.asciz "prev"

LDIFF_SYM236=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,35,44,6
	.asciz "kpm_next"

LDIFF_SYM237=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,48,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM238=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM238
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM239=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM239
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM240=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM240
LTDIE_19:

	.byte 5
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

	.byte 52,16
LDIFF_SYM241=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM241
	.byte 2,35,0,0,7
	.asciz "Xamarin_Forms_PropertyChangingEventHandler"

LDIFF_SYM242=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM242
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM243=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM243
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM244=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_25:

	.byte 5
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

	.byte 52,16
LDIFF_SYM245=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM245
	.byte 2,35,0,0,7
	.asciz "System_ComponentModel_PropertyChangedEventHandler"

LDIFF_SYM246=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM247=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM247
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM248=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_26:

	.byte 5
	.asciz "System_EventHandler"

	.byte 52,16
LDIFF_SYM249=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM249
	.byte 2,35,0,0,7
	.asciz "System_EventHandler"

LDIFF_SYM250=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM250
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM251=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM251
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM252=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM252
LTDIE_28:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM253=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM253
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM254=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM254
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM255=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM255
LTDIE_27:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM256=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM257=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM258=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM258
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM259=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM259
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM260=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM260
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM261=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM262=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM263=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM264=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM265=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM265
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM266=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM266
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM267=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM267
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM268=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM268
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM269=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM269
LTDIE_29:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM270=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM271=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM272=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM273=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM273
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM274=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM275=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM276=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM277=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM277
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM278=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM278
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM279=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM280=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM281=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM281
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM282=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM282
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM283=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM283
LTDIE_30:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 20,16
LDIFF_SYM284=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM284
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM285=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,8,6
	.asciz "_size"

LDIFF_SYM286=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,35,12,6
	.asciz "_version"

LDIFF_SYM287=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,16,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM288=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM288
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM289=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM289
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM290=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM290
LTDIE_31:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM291=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM292=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM293=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM294=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM294
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM295=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM295
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM296=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM296
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM297=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM298=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM298
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM299=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM300=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM301=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM301
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM302=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM302
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM303=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM303
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM304=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM304
LTDIE_18:

	.byte 5
	.asciz "Xamarin_Forms_BindableObject"

	.byte 44,16
LDIFF_SYM305=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,35,0,6
	.asciz "PropertyChanging"

LDIFF_SYM306=LTDIE_19_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,35,8,6
	.asciz "PropertyChanged"

LDIFF_SYM307=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 2,35,12,6
	.asciz "BindingContextChanged"

LDIFF_SYM308=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,35,16,6
	.asciz "inheritedContext"

LDIFF_SYM309=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM309
	.byte 2,35,20,6
	.asciz "bindings"

LDIFF_SYM310=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 2,35,24,6
	.asciz "values"

LDIFF_SYM311=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 2,35,28,6
	.asciz "manuallySetValues"

LDIFF_SYM312=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,35,32,6
	.asciz "delayedSetters"

LDIFF_SYM313=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM313
	.byte 2,35,36,6
	.asciz "applying"

LDIFF_SYM314=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM314
	.byte 2,35,40,0,7
	.asciz "Xamarin_Forms_BindableObject"

LDIFF_SYM315=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM315
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM316=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM316
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM317=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM317
LTDIE_34:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM318=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM318
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM319=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM319
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM320=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM320
LTDIE_37:

	.byte 5
	.asciz "System_UInt64"

	.byte 16,16
LDIFF_SYM321=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM322=LDIE_U8 - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 2,35,8,0,7
	.asciz "System_UInt64"

LDIFF_SYM323=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM323
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM324=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM324
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM325=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM325
LTDIE_36:

	.byte 5
	.asciz "_Node"

	.byte 44,16
LDIFF_SYM326=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM326
	.byte 2,35,0,6
	.asciz "Marked"

LDIFF_SYM327=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 2,35,32,6
	.asciz "Key"

LDIFF_SYM328=LDIE_U8 - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,35,36,6
	.asciz "SubKey"

LDIFF_SYM329=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM329
	.byte 2,35,8,6
	.asciz "Data"

LDIFF_SYM330=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,35,16,6
	.asciz "Next"

LDIFF_SYM331=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM331
	.byte 2,35,28,0,7
	.asciz "_Node"

LDIFF_SYM332=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM332
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM333=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM333
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM334=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM334
LTDIE_35:

	.byte 5
	.asciz "System_Collections_Concurrent_SplitOrderedList`2"

	.byte 36,16
LDIFF_SYM335=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM335
	.byte 2,35,0,6
	.asciz "head"

LDIFF_SYM336=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 2,35,8,6
	.asciz "tail"

LDIFF_SYM337=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM337
	.byte 2,35,12,6
	.asciz "buckets"

LDIFF_SYM338=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM338
	.byte 2,35,16,6
	.asciz "count"

LDIFF_SYM339=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM339
	.byte 2,35,24,6
	.asciz "size"

LDIFF_SYM340=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM340
	.byte 2,35,28,6
	.asciz "slim"

LDIFF_SYM341=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM341
	.byte 2,35,32,6
	.asciz "comparer"

LDIFF_SYM342=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM342
	.byte 2,35,20,0,7
	.asciz "System_Collections_Concurrent_SplitOrderedList`2"

LDIFF_SYM343=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM343
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM344=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM344
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM345=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM345
LTDIE_33:

	.byte 5
	.asciz "System_Collections_Concurrent_ConcurrentDictionary`2"

	.byte 16,16
LDIFF_SYM346=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM346
	.byte 2,35,0,6
	.asciz "comparer"

LDIFF_SYM347=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM347
	.byte 2,35,8,6
	.asciz "internalDictionary"

LDIFF_SYM348=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM348
	.byte 2,35,12,0,7
	.asciz "System_Collections_Concurrent_ConcurrentDictionary`2"

LDIFF_SYM349=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM349
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM350=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM350
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM351=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM351
LTDIE_41:

	.byte 5
	.asciz "System_MarshalByRefObject"

	.byte 12,16
LDIFF_SYM352=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM352
	.byte 2,35,0,6
	.asciz "_identity"

LDIFF_SYM353=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM353
	.byte 2,35,8,0,7
	.asciz "System_MarshalByRefObject"

LDIFF_SYM354=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM354
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM355=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM355
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM356=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM356
LTDIE_45:

	.byte 5
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

	.byte 8,16
LDIFF_SYM357=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM357
	.byte 2,35,0,0,7
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

LDIFF_SYM358=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM358
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM359=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM359
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM360=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM360
LTDIE_44:

	.byte 5
	.asciz "System_Runtime_InteropServices_SafeHandle"

	.byte 24,16
LDIFF_SYM361=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM361
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM362=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 2,35,8,6
	.asciz "invalid_handle_value"

LDIFF_SYM363=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM363
	.byte 2,35,12,6
	.asciz "refcount"

LDIFF_SYM364=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM364
	.byte 2,35,16,6
	.asciz "owns_handle"

LDIFF_SYM365=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM365
	.byte 2,35,20,0,7
	.asciz "System_Runtime_InteropServices_SafeHandle"

LDIFF_SYM366=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM366
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM367=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM367
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM368=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM368
LTDIE_43:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

	.byte 24,16
LDIFF_SYM369=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM369
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeHandleZeroOrMinusOneIsInvalid"

LDIFF_SYM370=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM370
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM371=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM371
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM372=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM372
LTDIE_42:

	.byte 5
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

	.byte 24,16
LDIFF_SYM373=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 2,35,0,0,7
	.asciz "Microsoft_Win32_SafeHandles_SafeWaitHandle"

LDIFF_SYM374=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM374
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM375=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM375
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM376=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM376
LTDIE_40:

	.byte 5
	.asciz "System_Threading_WaitHandle"

	.byte 20,16
LDIFF_SYM377=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,35,0,6
	.asciz "safe_wait_handle"

LDIFF_SYM378=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM378
	.byte 2,35,12,6
	.asciz "disposed"

LDIFF_SYM379=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM379
	.byte 2,35,16,0,7
	.asciz "System_Threading_WaitHandle"

LDIFF_SYM380=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM380
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM381=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM381
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM382=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM382
LTDIE_39:

	.byte 5
	.asciz "System_Threading_EventWaitHandle"

	.byte 20,16
LDIFF_SYM383=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM383
	.byte 2,35,0,0,7
	.asciz "System_Threading_EventWaitHandle"

LDIFF_SYM384=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM384
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM385=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM385
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM386=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM386
LTDIE_38:

	.byte 5
	.asciz "System_Threading_ManualResetEvent"

	.byte 20,16
LDIFF_SYM387=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM387
	.byte 2,35,0,0,7
	.asciz "System_Threading_ManualResetEvent"

LDIFF_SYM388=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM388
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM389=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM389
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM390=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM390
LTDIE_47:

	.byte 5
	.asciz "System_Threading_TimerCallback"

	.byte 52,16
LDIFF_SYM391=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,0,0,7
	.asciz "System_Threading_TimerCallback"

LDIFF_SYM392=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM392
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM393=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM393
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM394=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM394
LTDIE_48:

	.byte 5
	.asciz "System_Int64"

	.byte 16,16
LDIFF_SYM395=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM395
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM396=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM396
	.byte 2,35,8,0,7
	.asciz "System_Int64"

LDIFF_SYM397=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM397
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM398=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM398
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM399=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM399
LTDIE_46:

	.byte 5
	.asciz "System_Threading_Timer"

	.byte 48,16
LDIFF_SYM400=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM400
	.byte 2,35,0,6
	.asciz "callback"

LDIFF_SYM401=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM401
	.byte 2,35,12,6
	.asciz "state"

LDIFF_SYM402=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM402
	.byte 2,35,16,6
	.asciz "due_time_ms"

LDIFF_SYM403=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM403
	.byte 2,35,20,6
	.asciz "period_ms"

LDIFF_SYM404=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM404
	.byte 2,35,28,6
	.asciz "next_run"

LDIFF_SYM405=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM405
	.byte 2,35,36,6
	.asciz "disposed"

LDIFF_SYM406=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,44,0,7
	.asciz "System_Threading_Timer"

LDIFF_SYM407=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM407
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM408=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM408
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM409=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM409
LTDIE_32:

	.byte 5
	.asciz "System_Threading_CancellationTokenSource"

	.byte 32,16
LDIFF_SYM410=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM410
	.byte 2,35,0,6
	.asciz "canceled"

LDIFF_SYM411=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM411
	.byte 2,35,24,6
	.asciz "disposed"

LDIFF_SYM412=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM412
	.byte 2,35,25,6
	.asciz "currId"

LDIFF_SYM413=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM413
	.byte 2,35,28,6
	.asciz "callbacks"

LDIFF_SYM414=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM414
	.byte 2,35,8,6
	.asciz "linkedTokens"

LDIFF_SYM415=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,35,12,6
	.asciz "handle"

LDIFF_SYM416=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM416
	.byte 2,35,16,6
	.asciz "timer"

LDIFF_SYM417=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM417
	.byte 2,35,20,0,7
	.asciz "System_Threading_CancellationTokenSource"

LDIFF_SYM418=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM418
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM419=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM419
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM420=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM420
LTDIE_53:

	.byte 5
	.asciz "System_Threading_ManualResetEventSlim"

	.byte 28,16
LDIFF_SYM421=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM421
	.byte 2,35,0,6
	.asciz "spinCount"

LDIFF_SYM422=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM422
	.byte 2,35,12,6
	.asciz "handle"

LDIFF_SYM423=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2,35,8,6
	.asciz "disposed"

LDIFF_SYM424=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,35,16,6
	.asciz "used"

LDIFF_SYM425=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM425
	.byte 2,35,20,6
	.asciz "state"

LDIFF_SYM426=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM426
	.byte 2,35,24,0,7
	.asciz "System_Threading_ManualResetEventSlim"

LDIFF_SYM427=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM427
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM428=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM428
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM429=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM429
LTDIE_52:

	.byte 5
	.asciz "System_Threading_CountdownEvent"

	.byte 20,16
LDIFF_SYM430=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM430
	.byte 2,35,0,6
	.asciz "initialCount"

LDIFF_SYM431=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM431
	.byte 2,35,12,6
	.asciz "initial"

LDIFF_SYM432=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM432
	.byte 2,35,16,6
	.asciz "evt"

LDIFF_SYM433=LTDIE_53_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM433
	.byte 2,35,8,0,7
	.asciz "System_Threading_CountdownEvent"

LDIFF_SYM434=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM434
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM435=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM435
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM436=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM436
LTDIE_54:

	.byte 8
	.asciz "System_Threading_Tasks_TaskCreationOptions"

	.byte 4
LDIFF_SYM437=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM437
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "PreferFairness"

	.byte 1,9
	.asciz "LongRunning"

	.byte 2,9
	.asciz "AttachedToParent"

	.byte 4,9
	.asciz "DenyChildAttach"

	.byte 8,9
	.asciz "HideScheduler"

	.byte 16,0,7
	.asciz "System_Threading_Tasks_TaskCreationOptions"

LDIFF_SYM438=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM438
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM439=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM439
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM440=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM440
LTDIE_55:

	.byte 5
	.asciz "System_Threading_Tasks_TaskScheduler"

	.byte 12,16
LDIFF_SYM441=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM441
	.byte 2,35,0,6
	.asciz "id"

LDIFF_SYM442=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM442
	.byte 2,35,8,0,7
	.asciz "System_Threading_Tasks_TaskScheduler"

LDIFF_SYM443=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM443
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM444=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM444
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM445=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM445
LTDIE_59:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 8,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM446=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM446
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM447=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM447
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM448=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM448
LTDIE_58:

	.byte 5
	.asciz "System_Exception"

	.byte 60,16
LDIFF_SYM449=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM449
	.byte 2,35,0,6
	.asciz "trace_ips"

LDIFF_SYM450=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM450
	.byte 2,35,8,6
	.asciz "inner_exception"

LDIFF_SYM451=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM451
	.byte 2,35,12,6
	.asciz "message"

LDIFF_SYM452=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM452
	.byte 2,35,16,6
	.asciz "help_link"

LDIFF_SYM453=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM453
	.byte 2,35,20,6
	.asciz "class_name"

LDIFF_SYM454=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM454
	.byte 2,35,24,6
	.asciz "stack_trace"

LDIFF_SYM455=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM455
	.byte 2,35,28,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM456=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM456
	.byte 2,35,32,6
	.asciz "remote_stack_index"

LDIFF_SYM457=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM457
	.byte 2,35,36,6
	.asciz "hresult"

LDIFF_SYM458=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM458
	.byte 2,35,40,6
	.asciz "source"

LDIFF_SYM459=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM459
	.byte 2,35,44,6
	.asciz "_data"

LDIFF_SYM460=LTDIE_59_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM460
	.byte 2,35,48,6
	.asciz "captured_traces"

LDIFF_SYM461=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 2,35,52,6
	.asciz "native_trace_ips"

LDIFF_SYM462=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM462
	.byte 2,35,56,0,7
	.asciz "System_Exception"

LDIFF_SYM463=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM463
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM464=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM464
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM465=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM465
LTDIE_60:

	.byte 5
	.asciz "System_Collections_Generic_List`1"

	.byte 20,16
LDIFF_SYM466=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM466
	.byte 2,35,0,6
	.asciz "_items"

LDIFF_SYM467=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM467
	.byte 2,35,8,6
	.asciz "_size"

LDIFF_SYM468=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM468
	.byte 2,35,12,6
	.asciz "_version"

LDIFF_SYM469=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM469
	.byte 2,35,16,0,7
	.asciz "System_Collections_Generic_List`1"

LDIFF_SYM470=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM470
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM471=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM471
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM472=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM472
LTDIE_57:

	.byte 5
	.asciz "System_AggregateException"

	.byte 64,16
LDIFF_SYM473=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 2,35,0,6
	.asciz "innerExceptions"

LDIFF_SYM474=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 2,35,60,0,7
	.asciz "System_AggregateException"

LDIFF_SYM475=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM475
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM476=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM476
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM477=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM477
LTDIE_62:

	.byte 5
	.asciz "_Node"

	.byte 16,16
LDIFF_SYM478=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 2,35,0,6
	.asciz "Value"

LDIFF_SYM479=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM479
	.byte 2,35,8,6
	.asciz "Next"

LDIFF_SYM480=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM480
	.byte 2,35,12,0,7
	.asciz "_Node"

LDIFF_SYM481=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM481
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM482=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM482
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM483=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM483
LTDIE_61:

	.byte 5
	.asciz "System_Collections_Concurrent_ConcurrentQueue`1"

	.byte 24,16
LDIFF_SYM484=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM484
	.byte 2,35,0,6
	.asciz "head"

LDIFF_SYM485=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM485
	.byte 2,35,8,6
	.asciz "tail"

LDIFF_SYM486=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,35,12,6
	.asciz "count"

LDIFF_SYM487=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM487
	.byte 2,35,20,6
	.asciz "syncRoot"

LDIFF_SYM488=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM488
	.byte 2,35,16,0,7
	.asciz "System_Collections_Concurrent_ConcurrentQueue`1"

LDIFF_SYM489=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM489
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM490=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM490
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM491=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM491
LTDIE_56:

	.byte 5
	.asciz "System_Threading_Tasks_TaskExceptionSlot"

	.byte 24,16
LDIFF_SYM492=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM492
	.byte 2,35,0,6
	.asciz "Exception"

LDIFF_SYM493=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM493
	.byte 2,35,8,6
	.asciz "Observed"

LDIFF_SYM494=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 2,35,20,6
	.asciz "ChildExceptions"

LDIFF_SYM495=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 2,35,12,6
	.asciz "parent"

LDIFF_SYM496=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM496
	.byte 2,35,16,0,7
	.asciz "System_Threading_Tasks_TaskExceptionSlot"

LDIFF_SYM497=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM497
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM498=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM498
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM499=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM499
LTDIE_63:

	.byte 8
	.asciz "System_Threading_Tasks_TaskStatus"

	.byte 4
LDIFF_SYM500=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM500
	.byte 9
	.asciz "Created"

	.byte 0,9
	.asciz "WaitingForActivation"

	.byte 1,9
	.asciz "WaitingToRun"

	.byte 2,9
	.asciz "Running"

	.byte 3,9
	.asciz "WaitingForChildrenToComplete"

	.byte 4,9
	.asciz "RanToCompletion"

	.byte 5,9
	.asciz "Canceled"

	.byte 6,9
	.asciz "Faulted"

	.byte 7,0,7
	.asciz "System_Threading_Tasks_TaskStatus"

LDIFF_SYM501=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM501
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM502=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM502
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM503=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM503
LTDIE_64:

	.byte 5
	.asciz "System_Threading_Tasks_TaskActionInvoker"

	.byte 8,16
LDIFF_SYM504=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM504
	.byte 2,35,0,0,7
	.asciz "System_Threading_Tasks_TaskActionInvoker"

LDIFF_SYM505=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM505
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM506=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM506
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM507=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM507
LTDIE_66:

	.byte 5
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

	.byte 8,16
LDIFF_SYM508=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM508
	.byte 2,35,0,0,7
	.asciz "System_Runtime_Remoting_Messaging_LogicalCallContext"

LDIFF_SYM509=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM509
LTDIE_66_POINTER:

	.byte 13
LDIFF_SYM510=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM510
LTDIE_66_REFERENCE:

	.byte 14
LDIFF_SYM511=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM511
LTDIE_65:

	.byte 5
	.asciz "System_Threading_ExecutionContext"

	.byte 16,16
LDIFF_SYM512=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM512
	.byte 2,35,0,6
	.asciz "_lcc"

LDIFF_SYM513=LTDIE_66_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM513
	.byte 2,35,8,6
	.asciz "_suppressFlow"

LDIFF_SYM514=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM514
	.byte 2,35,12,6
	.asciz "_capture"

LDIFF_SYM515=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM515
	.byte 2,35,13,0,7
	.asciz "System_Threading_ExecutionContext"

LDIFF_SYM516=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM516
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM517=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM517
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM518=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM518
LTDIE_51:

	.byte 5
	.asciz "System_Threading_Tasks_Task"

	.byte 84,16
LDIFF_SYM519=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM519
	.byte 2,35,0,6
	.asciz "parent"

LDIFF_SYM520=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM520
	.byte 2,35,8,6
	.asciz "contAncestor"

LDIFF_SYM521=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM521
	.byte 2,35,12,6
	.asciz "childTasks"

LDIFF_SYM522=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 2,35,16,6
	.asciz "taskId"

LDIFF_SYM523=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM523
	.byte 2,35,68,6
	.asciz "creationOptions"

LDIFF_SYM524=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM524
	.byte 2,35,72,6
	.asciz "scheduler"

LDIFF_SYM525=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM525
	.byte 2,35,20,6
	.asciz "exSlot"

LDIFF_SYM526=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM526
	.byte 2,35,24,6
	.asciz "wait_handle"

LDIFF_SYM527=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM527
	.byte 2,35,28,6
	.asciz "status"

LDIFF_SYM528=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM528
	.byte 2,35,76,6
	.asciz "invoker"

LDIFF_SYM529=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM529
	.byte 2,35,32,6
	.asciz "state"

LDIFF_SYM530=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM530
	.byte 2,35,36,6
	.asciz "executing"

LDIFF_SYM531=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 2,35,80,6
	.asciz "continuations"

LDIFF_SYM532=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM532
	.byte 2,35,40,6
	.asciz "token"

LDIFF_SYM533=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM533
	.byte 2,35,48,6
	.asciz "cancellationRegistration"

LDIFF_SYM534=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM534
	.byte 2,35,52,6
	.asciz "ec"

LDIFF_SYM535=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM535
	.byte 2,35,64,0,7
	.asciz "System_Threading_Tasks_Task"

LDIFF_SYM536=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM536
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM537=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM537
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM538=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM538
LTDIE_50:

	.byte 5
	.asciz "System_Threading_Tasks_Task`1"

	.byte 88,16
LDIFF_SYM539=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,35,0,6
	.asciz "value"

LDIFF_SYM540=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM540
	.byte 2,35,84,0,7
	.asciz "System_Threading_Tasks_Task`1"

LDIFF_SYM541=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM541
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM542=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM542
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM543=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM543
LTDIE_49:

	.byte 5
	.asciz "System_Threading_Tasks_TaskCompletionSource`1"

	.byte 12,16
LDIFF_SYM544=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM544
	.byte 2,35,0,6
	.asciz "source"

LDIFF_SYM545=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM545
	.byte 2,35,8,0,7
	.asciz "System_Threading_Tasks_TaskCompletionSource`1"

LDIFF_SYM546=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM546
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM547=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM547
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM548=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM548
LTDIE_68:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM549=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM549
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM550=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM550
LTDIE_68_POINTER:

	.byte 13
LDIFF_SYM551=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM551
LTDIE_68_REFERENCE:

	.byte 14
LDIFF_SYM552=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM552
LTDIE_69:

	.byte 17
	.asciz "Xamarin_Forms_IPlatform"

	.byte 8,7
	.asciz "Xamarin_Forms_IPlatform"

LDIFF_SYM553=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM553
LTDIE_69_POINTER:

	.byte 13
LDIFF_SYM554=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM554
LTDIE_69_REFERENCE:

	.byte 14
LDIFF_SYM555=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM555
LTDIE_71:

	.byte 5
	.asciz "System_Func`1"

	.byte 52,16
LDIFF_SYM556=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,35,0,0,7
	.asciz "System_Func`1"

LDIFF_SYM557=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM557
LTDIE_71_POINTER:

	.byte 13
LDIFF_SYM558=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM558
LTDIE_71_REFERENCE:

	.byte 14
LDIFF_SYM559=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM559
LTDIE_72:

	.byte 8
	.asciz "System_Threading_LazyThreadSafetyMode"

	.byte 4
LDIFF_SYM560=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM560
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "PublicationOnly"

	.byte 1,9
	.asciz "ExecutionAndPublication"

	.byte 2,0,7
	.asciz "System_Threading_LazyThreadSafetyMode"

LDIFF_SYM561=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM561
LTDIE_72_POINTER:

	.byte 13
LDIFF_SYM562=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM562
LTDIE_72_REFERENCE:

	.byte 14
LDIFF_SYM563=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM563
LTDIE_70:

	.byte 5
	.asciz "System_Lazy`1"

	.byte 44,16
LDIFF_SYM564=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 2,35,0,6
	.asciz "value"

LDIFF_SYM565=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM565
	.byte 2,35,20,6
	.asciz "factory"

LDIFF_SYM566=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM566
	.byte 2,35,8,6
	.asciz "monitor"

LDIFF_SYM567=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,35,12,6
	.asciz "exception"

LDIFF_SYM568=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM568
	.byte 2,35,16,6
	.asciz "mode"

LDIFF_SYM569=LTDIE_72 - Ldebug_info_start
	.long LDIFF_SYM569
	.byte 2,35,36,6
	.asciz "inited"

LDIFF_SYM570=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM570
	.byte 2,35,40,0,7
	.asciz "System_Lazy`1"

LDIFF_SYM571=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM571
LTDIE_70_POINTER:

	.byte 13
LDIFF_SYM572=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM572
LTDIE_70_REFERENCE:

	.byte 14
LDIFF_SYM573=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM573
LTDIE_67:

	.byte 5
	.asciz "Xamarin_Forms_Element"

	.byte 84,16
LDIFF_SYM574=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM574
	.byte 2,35,0,6
	.asciz "ChildAdded"

LDIFF_SYM575=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM575
	.byte 2,35,44,6
	.asciz "ChildRemoved"

LDIFF_SYM576=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM576
	.byte 2,35,48,6
	.asciz "DescendantAdded"

LDIFF_SYM577=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM577
	.byte 2,35,52,6
	.asciz "DescendantRemoved"

LDIFF_SYM578=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM578
	.byte 2,35,56,6
	.asciz "PlatformSet"

LDIFF_SYM579=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM579
	.byte 2,35,60,6
	.asciz "parent"

LDIFF_SYM580=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM580
	.byte 2,35,64,6
	.asciz "canvas"

LDIFF_SYM581=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM581
	.byte 2,35,68,6
	.asciz "styleId"

LDIFF_SYM582=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM582
	.byte 2,35,72,6
	.asciz "id"

LDIFF_SYM583=LTDIE_70_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM583
	.byte 2,35,76,6
	.asciz "<Owned>k__BackingField"

LDIFF_SYM584=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM584
	.byte 2,35,80,0,7
	.asciz "Xamarin_Forms_Element"

LDIFF_SYM585=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM585
LTDIE_67_POINTER:

	.byte 13
LDIFF_SYM586=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM586
LTDIE_67_REFERENCE:

	.byte 14
LDIFF_SYM587=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM587
LTDIE_17:

	.byte 5
	.asciz "Xamarin_Forms_ImageSource"

	.byte 64,16
LDIFF_SYM588=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM588
	.byte 2,35,0,6
	.asciz "SourceChanged"

LDIFF_SYM589=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM589
	.byte 2,35,44,6
	.asciz "cancellationTokenSource"

LDIFF_SYM590=LTDIE_32_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM590
	.byte 2,35,48,6
	.asciz "synchandle"

LDIFF_SYM591=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM591
	.byte 2,35,52,6
	.asciz "completionSource"

LDIFF_SYM592=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM592
	.byte 2,35,56,6
	.asciz "<Xamarin.Forms.IElement.Parent>k__BackingField"

LDIFF_SYM593=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM593
	.byte 2,35,60,0,7
	.asciz "Xamarin_Forms_ImageSource"

LDIFF_SYM594=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM594
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM595=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM595
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM596=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM596
LTDIE_16:

	.byte 5
	.asciz "Xamarin_Forms_UriImageSource"

	.byte 76,16
LDIFF_SYM597=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM597
	.byte 2,35,0,6
	.asciz "cachingEnabled"

LDIFF_SYM598=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM598
	.byte 2,35,64,6
	.asciz "cacheValidity"

LDIFF_SYM599=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM599
	.byte 2,35,68,0,7
	.asciz "Xamarin_Forms_UriImageSource"

LDIFF_SYM600=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM600
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM601=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM601
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM602=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM602
	.byte 2
	.asciz "Sagua.App.Common.UrlStringToCacheImageSourceValueConverter:Convert"
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM603=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM603
	.byte 2,123,32,3
	.asciz "value"

LDIFF_SYM604=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM604
	.byte 2,123,36,3
	.asciz "targetType"

LDIFF_SYM605=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 2,123,40,3
	.asciz "parameter"

LDIFF_SYM606=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM606
	.byte 2,123,44,3
	.asciz "culture"

LDIFF_SYM607=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM607
	.byte 2,123,48,11
	.asciz "url"

LDIFF_SYM608=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM608
	.byte 1,86,11
	.asciz "source"

LDIFF_SYM609=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM609
	.byte 1,85,11
	.asciz ""

LDIFF_SYM610=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM610
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM611=Lfde1_end - Lfde1_start
	.long LDIFF_SYM611
Lfde1_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM612=Lme_1 - _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM612
	.byte 12,13,0,72,14,8,135,2,68,14,28,132,7,133,6,134,5,136,4,139,3,142,1,68,14,112,68,13,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.UrlStringToCacheImageSourceValueConverter:ConvertBack"
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM613=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,123,8,3
	.asciz "value"

LDIFF_SYM614=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM614
	.byte 2,123,12,3
	.asciz "targetType"

LDIFF_SYM615=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM615
	.byte 2,123,16,3
	.asciz "parameter"

LDIFF_SYM616=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 2,123,20,3
	.asciz "culture"

LDIFF_SYM617=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 2,123,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM618=Lfde2_end - Lfde2_start
	.long LDIFF_SYM618
Lfde2_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM619=Lme_2 - _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM619
	.byte 12,13,0,72,14,8,135,2,68,14,16,136,4,139,3,142,1,68,14,48,68,13,11
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_74:

	.byte 5
	.asciz "Sagua_App_Common_ObservableObject"

	.byte 12,16
LDIFF_SYM620=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM620
	.byte 2,35,0,6
	.asciz "PropertyChanged"

LDIFF_SYM621=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 2,35,8,0,7
	.asciz "Sagua_App_Common_ObservableObject"

LDIFF_SYM622=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM622
LTDIE_74_POINTER:

	.byte 13
LDIFF_SYM623=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM623
LTDIE_74_REFERENCE:

	.byte 14
LDIFF_SYM624=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM624
LTDIE_77:

	.byte 5
	.asciz "System_Double"

	.byte 16,16
LDIFF_SYM625=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM626=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM626
	.byte 2,35,8,0,7
	.asciz "System_Double"

LDIFF_SYM627=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM627
LTDIE_77_POINTER:

	.byte 13
LDIFF_SYM628=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM628
LTDIE_77_REFERENCE:

	.byte 14
LDIFF_SYM629=LTDIE_77 - Ldebug_info_start
	.long LDIFF_SYM629
LTDIE_80:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM630=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM630
LTDIE_80_POINTER:

	.byte 13
LDIFF_SYM631=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM631
LTDIE_80_REFERENCE:

	.byte 14
LDIFF_SYM632=LTDIE_80 - Ldebug_info_start
	.long LDIFF_SYM632
LTDIE_79:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM633=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM633
	.byte 2,35,0,6
	.asciz "table"

LDIFF_SYM634=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM634
	.byte 2,35,8,6
	.asciz "linkSlots"

LDIFF_SYM635=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM635
	.byte 2,35,12,6
	.asciz "keySlots"

LDIFF_SYM636=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 2,35,16,6
	.asciz "valueSlots"

LDIFF_SYM637=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM637
	.byte 2,35,20,6
	.asciz "hcp"

LDIFF_SYM638=LTDIE_80_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM638
	.byte 2,35,24,6
	.asciz "touchedSlots"

LDIFF_SYM639=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM639
	.byte 2,35,28,6
	.asciz "emptySlot"

LDIFF_SYM640=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 2,35,32,6
	.asciz "count"

LDIFF_SYM641=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM641
	.byte 2,35,36,6
	.asciz "threshold"

LDIFF_SYM642=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM642
	.byte 2,35,40,6
	.asciz "generation"

LDIFF_SYM643=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM643
	.byte 2,35,44,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM644=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM644
LTDIE_79_POINTER:

	.byte 13
LDIFF_SYM645=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM645
LTDIE_79_REFERENCE:

	.byte 14
LDIFF_SYM646=LTDIE_79 - Ldebug_info_start
	.long LDIFF_SYM646
LTDIE_78:

	.byte 5
	.asciz "Xamarin_Forms_ResourceDictionary"

	.byte 12,16
LDIFF_SYM647=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM647
	.byte 2,35,0,6
	.asciz "innerDictionary"

LDIFF_SYM648=LTDIE_79_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM648
	.byte 2,35,8,0,7
	.asciz "Xamarin_Forms_ResourceDictionary"

LDIFF_SYM649=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM649
LTDIE_78_POINTER:

	.byte 13
LDIFF_SYM650=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM650
LTDIE_78_REFERENCE:

	.byte 14
LDIFF_SYM651=LTDIE_78 - Ldebug_info_start
	.long LDIFF_SYM651
LTDIE_81:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM652=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM652
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM653=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM653
LTDIE_81_POINTER:

	.byte 13
LDIFF_SYM654=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM654
LTDIE_81_REFERENCE:

	.byte 14
LDIFF_SYM655=LTDIE_81 - Ldebug_info_start
	.long LDIFF_SYM655
LTDIE_82:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM656=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM656
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM657=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM657
LTDIE_82_POINTER:

	.byte 13
LDIFF_SYM658=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM658
LTDIE_82_REFERENCE:

	.byte 14
LDIFF_SYM659=LTDIE_82 - Ldebug_info_start
	.long LDIFF_SYM659
LTDIE_83:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 52,16
LDIFF_SYM660=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM660
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM661=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM661
LTDIE_83_POINTER:

	.byte 13
LDIFF_SYM662=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM662
LTDIE_83_REFERENCE:

	.byte 14
LDIFF_SYM663=LTDIE_83 - Ldebug_info_start
	.long LDIFF_SYM663
LTDIE_76:

	.byte 5
	.asciz "Xamarin_Forms_VisualElement"

	.byte 200,1,16
LDIFF_SYM664=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM664
	.byte 2,35,0,6
	.asciz "isNativeStateConsistent"

LDIFF_SYM665=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM665
	.byte 2,35,120,6
	.asciz "mockX"

LDIFF_SYM666=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM666
	.byte 2,35,124,6
	.asciz "mockY"

LDIFF_SYM667=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM667
	.byte 3,35,132,1,6
	.asciz "mockWidth"

LDIFF_SYM668=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM668
	.byte 3,35,140,1,6
	.asciz "mockHeight"

LDIFF_SYM669=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM669
	.byte 3,35,148,1,6
	.asciz "widthRequest"

LDIFF_SYM670=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM670
	.byte 3,35,156,1,6
	.asciz "heightRequest"

LDIFF_SYM671=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM671
	.byte 3,35,164,1,6
	.asciz "minimumWidthRequest"

LDIFF_SYM672=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM672
	.byte 3,35,172,1,6
	.asciz "minimumHeightRequest"

LDIFF_SYM673=LDIE_R8 - Ldebug_info_start
	.long LDIFF_SYM673
	.byte 3,35,180,1,6
	.asciz "resourceDictionary"

LDIFF_SYM674=LTDIE_78_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM674
	.byte 2,35,84,6
	.asciz "ChildrenReordered"

LDIFF_SYM675=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM675
	.byte 2,35,88,6
	.asciz "BatchCommitted"

LDIFF_SYM676=LTDIE_81_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM676
	.byte 2,35,92,6
	.asciz "SizeChanged"

LDIFF_SYM677=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM677
	.byte 2,35,96,6
	.asciz "MeasureInvalidated"

LDIFF_SYM678=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM678
	.byte 2,35,100,6
	.asciz "Focused"

LDIFF_SYM679=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM679
	.byte 2,35,104,6
	.asciz "Unfocused"

LDIFF_SYM680=LTDIE_82_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM680
	.byte 2,35,108,6
	.asciz "isFocused"

LDIFF_SYM681=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM681
	.byte 3,35,188,1,6
	.asciz "FocusRequested"

LDIFF_SYM682=LTDIE_83_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM682
	.byte 2,35,112,6
	.asciz "UnfocusRequested"

LDIFF_SYM683=LTDIE_83_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM683
	.byte 2,35,116,6
	.asciz "batched"

LDIFF_SYM684=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM684
	.byte 3,35,192,1,6
	.asciz "isPlatformEnabled"

LDIFF_SYM685=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM685
	.byte 3,35,196,1,0,7
	.asciz "Xamarin_Forms_VisualElement"

LDIFF_SYM686=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM686
LTDIE_76_POINTER:

	.byte 13
LDIFF_SYM687=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM687
LTDIE_76_REFERENCE:

	.byte 14
LDIFF_SYM688=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM688
LTDIE_86:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM689=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM689
LTDIE_86_POINTER:

	.byte 13
LDIFF_SYM690=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM690
LTDIE_86_REFERENCE:

	.byte 14
LDIFF_SYM691=LTDIE_86 - Ldebug_info_start
	.long LDIFF_SYM691
LTDIE_85:

	.byte 5
	.asciz "System_Collections_ObjectModel_Collection`1"

	.byte 16,16
LDIFF_SYM692=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM692
	.byte 2,35,0,6
	.asciz "items"

LDIFF_SYM693=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM693
	.byte 2,35,8,6
	.asciz "syncRoot"

LDIFF_SYM694=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM694
	.byte 2,35,12,0,7
	.asciz "System_Collections_ObjectModel_Collection`1"

LDIFF_SYM695=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM695
LTDIE_85_POINTER:

	.byte 13
LDIFF_SYM696=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM696
LTDIE_85_REFERENCE:

	.byte 14
LDIFF_SYM697=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM697
LTDIE_87:

	.byte 5
	.asciz "_SimpleMonitor"

	.byte 12,16
LDIFF_SYM698=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM698
	.byte 2,35,0,6
	.asciz "_busyCount"

LDIFF_SYM699=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM699
	.byte 2,35,8,0,7
	.asciz "_SimpleMonitor"

LDIFF_SYM700=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM700
LTDIE_87_POINTER:

	.byte 13
LDIFF_SYM701=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM701
LTDIE_87_REFERENCE:

	.byte 14
LDIFF_SYM702=LTDIE_87 - Ldebug_info_start
	.long LDIFF_SYM702
LTDIE_88:

	.byte 5
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

	.byte 52,16
LDIFF_SYM703=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM703
	.byte 2,35,0,0,7
	.asciz "System_Collections_Specialized_NotifyCollectionChangedEventHandler"

LDIFF_SYM704=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM704
LTDIE_88_POINTER:

	.byte 13
LDIFF_SYM705=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM705
LTDIE_88_REFERENCE:

	.byte 14
LDIFF_SYM706=LTDIE_88 - Ldebug_info_start
	.long LDIFF_SYM706
LTDIE_84:

	.byte 5
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

	.byte 28,16
LDIFF_SYM707=LTDIE_85 - Ldebug_info_start
	.long LDIFF_SYM707
	.byte 2,35,0,6
	.asciz "_monitor"

LDIFF_SYM708=LTDIE_87_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM708
	.byte 2,35,16,6
	.asciz "CollectionChanged"

LDIFF_SYM709=LTDIE_88_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM709
	.byte 2,35,20,6
	.asciz "PropertyChanged"

LDIFF_SYM710=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM710
	.byte 2,35,24,0,7
	.asciz "System_Collections_ObjectModel_ObservableCollection`1"

LDIFF_SYM711=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM711
LTDIE_84_POINTER:

	.byte 13
LDIFF_SYM712=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM712
LTDIE_84_REFERENCE:

	.byte 14
LDIFF_SYM713=LTDIE_84 - Ldebug_info_start
	.long LDIFF_SYM713
LTDIE_89:

	.byte 5
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

	.byte 12,16
LDIFF_SYM714=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM714
	.byte 2,35,0,6
	.asciz "list"

LDIFF_SYM715=LTDIE_86_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM715
	.byte 2,35,8,0,7
	.asciz "System_Collections_ObjectModel_ReadOnlyCollection`1"

LDIFF_SYM716=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM716
LTDIE_89_POINTER:

	.byte 13
LDIFF_SYM717=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM717
LTDIE_89_REFERENCE:

	.byte 14
LDIFF_SYM718=LTDIE_89 - Ldebug_info_start
	.long LDIFF_SYM718
LTDIE_90:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM719=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM719
LTDIE_90_POINTER:

	.byte 13
LDIFF_SYM720=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM720
LTDIE_90_REFERENCE:

	.byte 14
LDIFF_SYM721=LTDIE_90 - Ldebug_info_start
	.long LDIFF_SYM721
LTDIE_75:

	.byte 5
	.asciz "Xamarin_Forms_Page"

	.byte 136,2,16
LDIFF_SYM722=LTDIE_76 - Ldebug_info_start
	.long LDIFF_SYM722
	.byte 2,35,0,6
	.asciz "LayoutChanged"

LDIFF_SYM723=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM723
	.byte 3,35,200,1,6
	.asciz "internalChildren"

LDIFF_SYM724=LTDIE_84_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM724
	.byte 3,35,204,1,6
	.asciz "logicalChildren"

LDIFF_SYM725=LTDIE_89_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM725
	.byte 3,35,208,1,6
	.asciz "containerAreaSet"

LDIFF_SYM726=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM726
	.byte 3,35,224,1,6
	.asciz "containerArea"

LDIFF_SYM727=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM727
	.byte 3,35,228,1,6
	.asciz "Appearing"

LDIFF_SYM728=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM728
	.byte 3,35,212,1,6
	.asciz "Disappearing"

LDIFF_SYM729=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM729
	.byte 3,35,216,1,6
	.asciz "hasAppeared"

LDIFF_SYM730=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM730
	.byte 3,35,132,2,6
	.asciz "allocatedFlag"

LDIFF_SYM731=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM731
	.byte 3,35,133,2,6
	.asciz "<ToolbarItems>k__BackingField"

LDIFF_SYM732=LTDIE_90_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM732
	.byte 3,35,220,1,0,7
	.asciz "Xamarin_Forms_Page"

LDIFF_SYM733=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM733
LTDIE_75_POINTER:

	.byte 13
LDIFF_SYM734=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM734
LTDIE_75_REFERENCE:

	.byte 14
LDIFF_SYM735=LTDIE_75 - Ldebug_info_start
	.long LDIFF_SYM735
LTDIE_91:

	.byte 17
	.asciz "Sagua_App_Components_Settings_ISettings"

	.byte 8,7
	.asciz "Sagua_App_Components_Settings_ISettings"

LDIFF_SYM736=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM736
LTDIE_91_POINTER:

	.byte 13
LDIFF_SYM737=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM737
LTDIE_91_REFERENCE:

	.byte 14
LDIFF_SYM738=LTDIE_91 - Ldebug_info_start
	.long LDIFF_SYM738
LTDIE_73:

	.byte 5
	.asciz "Sagua_App_Common_BaseViewModel"

	.byte 20,16
LDIFF_SYM739=LTDIE_74 - Ldebug_info_start
	.long LDIFF_SYM739
	.byte 2,35,0,6
	.asciz "<Page>k__BackingField"

LDIFF_SYM740=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM740
	.byte 2,35,12,6
	.asciz "<Settings>k__BackingField"

LDIFF_SYM741=LTDIE_91_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM741
	.byte 2,35,16,0,7
	.asciz "Sagua_App_Common_BaseViewModel"

LDIFF_SYM742=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM742
LTDIE_73_POINTER:

	.byte 13
LDIFF_SYM743=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM743
LTDIE_73_REFERENCE:

	.byte 14
LDIFF_SYM744=LTDIE_73 - Ldebug_info_start
	.long LDIFF_SYM744
	.byte 2
	.asciz "Sagua.App.Common.BaseViewModel:get_Page"
	.long _Sagua_App_Common_BaseViewModel_get_Page
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM745=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM745
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM746=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM746
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM747=Lfde3_end - Lfde3_start
	.long LDIFF_SYM747
Lfde3_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_BaseViewModel_get_Page

LDIFF_SYM748=Lme_3 - _Sagua_App_Common_BaseViewModel_get_Page
	.long LDIFF_SYM748
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.BaseViewModel:set_Page"
	.long _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM749=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM749
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM750=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM750
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM751=Lfde4_end - Lfde4_start
	.long LDIFF_SYM751
Lfde4_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page

LDIFF_SYM752=Lme_4 - _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page
	.long LDIFF_SYM752
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.BaseViewModel:get_Settings"
	.long _Sagua_App_Common_BaseViewModel_get_Settings
	.long Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM753=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM753
	.byte 2,125,8,11
	.asciz ""

LDIFF_SYM754=LTDIE_91_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM754
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM755=Lfde5_end - Lfde5_start
	.long LDIFF_SYM755
Lfde5_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_BaseViewModel_get_Settings

LDIFF_SYM756=Lme_5 - _Sagua_App_Common_BaseViewModel_get_Settings
	.long LDIFF_SYM756
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,32
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.BaseViewModel:set_Settings"
	.long _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM757=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM757
	.byte 2,125,8,3
	.asciz "value"

LDIFF_SYM758=LTDIE_91_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM758
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM759=Lfde6_end - Lfde6_start
	.long LDIFF_SYM759
Lfde6_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings

LDIFF_SYM760=Lme_6 - _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings
	.long LDIFF_SYM760
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.BaseViewModel:.ctor"
	.long _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page
	.long Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM761=LTDIE_73_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM761
	.byte 1,86,3
	.asciz "page"

LDIFF_SYM762=LTDIE_75_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM762
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM763=Lfde7_end - Lfde7_start
	.long LDIFF_SYM763
Lfde7_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page

LDIFF_SYM764=Lme_7 - _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page
	.long LDIFF_SYM764
	.byte 12,13,0,72,14,8,135,2,68,14,16,134,4,136,3,142,1,68,14,40
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_92:

	.byte 5
	.asciz "Sagua_App_Common_InvertedBoolValueConverter"

	.byte 8,16
LDIFF_SYM765=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM765
	.byte 2,35,0,0,7
	.asciz "Sagua_App_Common_InvertedBoolValueConverter"

LDIFF_SYM766=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM766
LTDIE_92_POINTER:

	.byte 13
LDIFF_SYM767=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM767
LTDIE_92_REFERENCE:

	.byte 14
LDIFF_SYM768=LTDIE_92 - Ldebug_info_start
	.long LDIFF_SYM768
	.byte 2
	.asciz "Sagua.App.Common.InvertedBoolValueConverter:.ctor"
	.long _Sagua_App_Common_InvertedBoolValueConverter__ctor
	.long Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM769=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM769
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM770=Lfde8_end - Lfde8_start
	.long LDIFF_SYM770
Lfde8_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_InvertedBoolValueConverter__ctor

LDIFF_SYM771=Lme_8 - _Sagua_App_Common_InvertedBoolValueConverter__ctor
	.long LDIFF_SYM771
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.InvertedBoolValueConverter:Convert"
	.long _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM772=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM772
	.byte 2,123,8,3
	.asciz "value"

LDIFF_SYM773=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM773
	.byte 2,123,12,3
	.asciz "targetType"

LDIFF_SYM774=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM774
	.byte 2,123,16,3
	.asciz "parameter"

LDIFF_SYM775=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM775
	.byte 2,123,20,3
	.asciz "culture"

LDIFF_SYM776=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM776
	.byte 2,123,24,11
	.asciz ""

LDIFF_SYM777=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM777
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM778=Lfde9_end - Lfde9_start
	.long LDIFF_SYM778
Lfde9_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM779=Lme_9 - _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM779
	.byte 12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,139,3,142,1,68,14,64,68,13,11
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.InvertedBoolValueConverter:ConvertBack"
	.long _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM780=LTDIE_92_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM780
	.byte 2,123,8,3
	.asciz "value"

LDIFF_SYM781=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM781
	.byte 2,123,12,3
	.asciz "targetType"

LDIFF_SYM782=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM782
	.byte 2,123,16,3
	.asciz "parameter"

LDIFF_SYM783=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM783
	.byte 2,123,20,3
	.asciz "culture"

LDIFF_SYM784=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM784
	.byte 2,123,24,11
	.asciz ""

LDIFF_SYM785=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM785
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM786=Lfde10_end - Lfde10_start
	.long LDIFF_SYM786
Lfde10_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM787=Lme_a - _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM787
	.byte 12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,139,3,142,1,68,14,64,68,13,11
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_93:

	.byte 5
	.asciz "Sagua_App_Common_EnumToListValueConverter"

	.byte 8,16
LDIFF_SYM788=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM788
	.byte 2,35,0,0,7
	.asciz "Sagua_App_Common_EnumToListValueConverter"

LDIFF_SYM789=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM789
LTDIE_93_POINTER:

	.byte 13
LDIFF_SYM790=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM790
LTDIE_93_REFERENCE:

	.byte 14
LDIFF_SYM791=LTDIE_93 - Ldebug_info_start
	.long LDIFF_SYM791
	.byte 2
	.asciz "Sagua.App.Common.EnumToListValueConverter:.ctor"
	.long _Sagua_App_Common_EnumToListValueConverter__ctor
	.long Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM792=LTDIE_93_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM792
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM793=Lfde11_end - Lfde11_start
	.long LDIFF_SYM793
Lfde11_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_EnumToListValueConverter__ctor

LDIFF_SYM794=Lme_b - _Sagua_App_Common_EnumToListValueConverter__ctor
	.long LDIFF_SYM794
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.EnumToListValueConverter:Convert"
	.long _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM795=LTDIE_93_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM795
	.byte 2,123,8,3
	.asciz "value"

LDIFF_SYM796=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM796
	.byte 2,123,12,3
	.asciz "targetType"

LDIFF_SYM797=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM797
	.byte 2,123,16,3
	.asciz "parameter"

LDIFF_SYM798=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM798
	.byte 2,123,20,3
	.asciz "culture"

LDIFF_SYM799=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM799
	.byte 2,123,24,11
	.asciz ""

LDIFF_SYM800=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM800
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM801=Lfde12_end - Lfde12_start
	.long LDIFF_SYM801
Lfde12_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM802=Lme_c - _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM802
	.byte 12,13,0,72,14,8,135,2,68,14,28,132,7,133,6,134,5,136,4,139,3,142,1,68,14,72,68,13,11
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.EnumToListValueConverter:ConvertBack"
	.long _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM803=LTDIE_93_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM803
	.byte 2,123,8,3
	.asciz "value"

LDIFF_SYM804=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM804
	.byte 2,123,12,3
	.asciz "targetType"

LDIFF_SYM805=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM805
	.byte 2,123,16,3
	.asciz "parameter"

LDIFF_SYM806=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM806
	.byte 2,123,20,3
	.asciz "culture"

LDIFF_SYM807=LTDIE_4_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM807
	.byte 2,123,24,11
	.asciz ""

LDIFF_SYM808=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM808
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM809=Lfde13_end - Lfde13_start
	.long LDIFF_SYM809
Lfde13_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

LDIFF_SYM810=Lme_d - _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo
	.long LDIFF_SYM810
	.byte 12,13,0,72,14,8,135,2,68,14,20,134,5,136,4,139,3,142,1,68,14,56,68,13,11
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.ObservableObject:add_PropertyChanged"
	.long _Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
	.long Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM811=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM811
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM812=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM812
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM813=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM813
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM814=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM814
	.byte 1,84,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM815=Lfde14_end - Lfde14_start
	.long LDIFF_SYM815
Lfde14_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler

LDIFF_SYM816=Lme_e - _Sagua_App_Common_ObservableObject_add_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
	.long LDIFF_SYM816
	.byte 12,13,0,72,14,8,135,2,68,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56
	.align 2
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.ObservableObject:remove_PropertyChanged"
	.long _Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
	.long Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM817=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM817
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM818=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM818
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM819=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM819
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM820=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM820
	.byte 1,84,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM821=Lfde15_end - Lfde15_start
	.long LDIFF_SYM821
Lfde15_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler

LDIFF_SYM822=Lme_f - _Sagua_App_Common_ObservableObject_remove_PropertyChanged_System_ComponentModel_PropertyChangedEventHandler
	.long LDIFF_SYM822
	.byte 12,13,0,72,14,8,135,2,68,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56
	.align 2
Lfde15_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.ObservableObject:.ctor"
	.long _Sagua_App_Common_ObservableObject__ctor
	.long Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM823=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM823
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM824=Lfde16_end - Lfde16_start
	.long LDIFF_SYM824
Lfde16_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_ObservableObject__ctor

LDIFF_SYM825=Lme_10 - _Sagua_App_Common_ObservableObject__ctor
	.long LDIFF_SYM825
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,32
	.align 2
Lfde16_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Sagua.App.Common.ObservableObject:OnPropertyChanged"
	.long _Sagua_App_Common_ObservableObject_OnPropertyChanged_string
	.long Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM826=LTDIE_74_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM826
	.byte 2,125,8,3
	.asciz "propertyName"

LDIFF_SYM827=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM827
	.byte 2,125,12,11
	.asciz "handler"

LDIFF_SYM828=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM828
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM829=Lfde17_end - Lfde17_start
	.long LDIFF_SYM829
Lfde17_start:

	.long 0
	.align 2
	.long _Sagua_App_Common_ObservableObject_OnPropertyChanged_string

LDIFF_SYM830=Lme_11 - _Sagua_App_Common_ObservableObject_OnPropertyChanged_string
	.long LDIFF_SYM830
	.byte 12,13,0,72,14,8,135,2,68,14,16,133,4,136,3,142,1,68,14,48
	.align 2
Lfde17_end:

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
	.asciz "/Users/hai/Desktop/Share/Sagua.App.Framework/Sagua.App.Common/ValueConverters"
	.asciz "/Users/hai/Desktop/Share/Sagua.App.Framework/Sagua.App.Common"

	.byte 0
	.asciz "<unknown>"

	.byte 0,0,0
	.asciz "UrlStringToCacheImageSourceValueConverter.cs"

	.byte 1,0,0
	.asciz "BaseViewModel.cs"

	.byte 2,0,0
	.asciz "InvertedBoolValueConverter.cs"

	.byte 1,0,0
	.asciz "EnumToListValueConverter.cs"

	.byte 1,0,0
	.asciz "ObservableObject.cs"

	.byte 2,0,0,0
Ldebug_line_header_end:
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,8,4,2,1,3,8,2,236,0,1,8,117,3,1,2,212,0,1,3,1,2,56,1,3,1,2,56,1,3,1,2
	.byte 164,1,1,3,1,2,244,0,1,3,1,2,40,1,2,48,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_UrlStringToCacheImageSourceValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,17,4,2,1,3,17,2,220,0,1,8,117,2,196,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_BaseViewModel_get_Page

	.byte 3,11,4,3,1,3,11,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_BaseViewModel_set_Page_Xamarin_Forms_Page

	.byte 3,11,4,3,1,3,11,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_BaseViewModel_get_Settings

	.byte 3,12,4,3,1,3,12,2,200,0,1,2,232,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_BaseViewModel_set_Settings_Sagua_App_Components_Settings_ISettings

	.byte 3,12,4,3,1,3,12,2,200,0,1,2,208,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_BaseViewModel__ctor_Xamarin_Forms_Page

	.byte 3,14,4,3,1,3,14,2,200,0,1,3,1,2,36,1,243,3,1,2,56,1,3,1,2,228,0,1,2,44,1,0
	.byte 1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_InvertedBoolValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,10,4,4,1,3,10,2,224,0,1,8,117,3,1,2,148,1,1,2,196,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_InvertedBoolValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,15,4,4,1,3,15,2,224,0,1,8,117,3,1,2,148,1,1,2,196,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_EnumToListValueConverter_Convert_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,10,4,5,1,3,10,2,224,0,1,8,117,3,1,2,156,1,1,2,52,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_EnumToListValueConverter_ConvertBack_object_System_Type_object_System_Globalization_CultureInfo

	.byte 3,15,4,5,1,3,15,2,224,0,1,8,117,3,1,2,40,1,2,52,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _Sagua_App_Common_ObservableObject_OnPropertyChanged_string

	.byte 3,13,4,6,1,3,13,2,204,0,1,8,117,8,173,8,173,243,3,1,2,248,0,1,243,2,52,1,0,1,1,0
	.byte 1,1
Ldebug_line_end:
.text
	.align 3
mem_end:
