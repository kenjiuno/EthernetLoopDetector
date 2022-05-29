; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

Unicode true

!define APP "EthernetLoopDetector"

!system 'DefineAsmVer.exe "bin\x86\DEBUG\${APP}.exe" "!define VER ""[FVER]"" " > Appver.tmp'
!include "Appver.tmp"
!searchreplace APV ${VER} "." "_"

;--------------------------------

; The name of the installer
Name "${APP} ${VER}"

!system 'MySign "bin\x86\DEBUG\${APP}.exe"'
!finalize 'MySign "%1"'

; The file to write
OutFile "Setup_${APP}_${APV}.exe"

; The default installation directory
InstallDir "$APPDATA\${APP}"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

LoadLanguageFile "${NSISDIR}\Contrib\Language files\Japanese.nlf"

XPStyle on

;--------------------------------

; Pages

Page license
Page directory
Page instfiles

LicenseData "README.ja.rtf"

;--------------------------------

; The stuff to install
Section "" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File /r /x "*.vshost.*" "bin\x86\DEBUG\*.*"
  
  Exec '"$INSTDIR\${APP}.exe"'
  
SectionEnd ; end the section
