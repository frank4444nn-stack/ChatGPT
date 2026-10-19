$ErrorActionPreference = 'Stop'
$raiz = Split-Path $PSScriptRoot -Parent
$proyecto = Join-Path $raiz 'SistemaCarreteras\SistemaCarreteras.csproj'
# Ejecutar desde Developer PowerShell para Visual Studio.
& msbuild $proyecto /t:Build /p:Configuration=Debug /nologo
if ($LASTEXITCODE -ne 0) { throw 'Falló la compilación de la solución.' }
$csc = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
if (!(Test-Path $csc)) { $csc = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v4.0.30319\csc.exe' }
if (!(Test-Path $csc)) { throw 'No se encontró el compilador de .NET Framework.' }
$salida = Join-Path $raiz 'SistemaCarreteras\bin\Debug'
$app = Join-Path $salida 'SistemaCarreteras.exe'
$pruebas = Join-Path $salida 'Pruebas.exe'
& $csc /nologo /target:exe "/out:$pruebas" "/reference:$app" /reference:System.Windows.Forms.dll /reference:System.Drawing.dll /reference:System.Core.dll (Join-Path $PSScriptRoot 'Pruebas.cs')
if ($LASTEXITCODE -ne 0) { throw 'Falló la compilación de las pruebas.' }
& $pruebas
if ($LASTEXITCODE -ne 0) { throw 'Hay pruebas fallidas; revise la salida.' }
