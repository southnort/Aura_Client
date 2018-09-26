; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4F11F8E2-978C-46EB-B68F-34EF706331E7}
AppName=Aura
AppVersion=1.0.2.2
;AppVerName=Aura 1.0.2.2
AppPublisher=ASTIKS
DefaultDirName={pf}\Aura
DefaultGroupName=Aura
AllowNoIcons=yes
OutputBaseFilename=Setup
SetupIconFile=C:\Users\����\Documents\Projects\Aura_Client\Aura_Client\Icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\����\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\Aura_Client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\����\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\Aura_DLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\����\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\connect settings.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\����\Documents\Projects\Aura_Client\Aura_Client\Icon.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Aura"; Filename: "{app}\Aura_Client.exe"
Name: "{group}\{cm:UninstallProgram,Aura}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Aura"; Filename: "{app}\Aura_Client.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Aura_Client.exe"; Description: "{cm:LaunchProgram,Aura}"; Flags: nowait postinstall skipifsilent

