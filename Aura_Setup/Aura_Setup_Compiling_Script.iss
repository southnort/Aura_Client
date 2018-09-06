; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{86A855DB-F691-42D6-921D-1AA53CD13814}
AppName=Aura
AppVersion=1.0.1.4
;AppVerName=Aura 1.0.1.4
AppPublisher=ASTIKS
DefaultDirName={pf}\Aura
DefaultGroupName=Aura
AllowNoIcons=yes
OutputBaseFilename=Setup.exe
SetupIconFile=C:\Users\User\Documents\Projects\Aura_Client\Aura_Client\Icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\User\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\Aura_Client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\Aura_DLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\Documents\Projects\Aura_Client\Aura_Client\bin\Debug\connect settings.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\User\Documents\Projects\Aura_Client\Aura_Client\Icon.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Aura"; Filename: "{app}\Aura_Client.exe"
Name: "{group}\{cm:UninstallProgram,Aura}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Aura"; Filename: "{app}\Aura_Client.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Aura_Client.exe"; Description: "{cm:LaunchProgram,Aura}"; Flags: nowait postinstall skipifsilent

