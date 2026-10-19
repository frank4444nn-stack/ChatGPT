# Sistema de gestión de carreteras

Proyecto C# Windows Forms con .NET Framework 4.7.2, varias listas de objetos y LINQ.

## Descargar

- [Proyecto completo en ZIP](SistemaCarreteras_Completo.zip)
- [Documento Word: explicación y código](Documentos/SistemaCarreteras_Documento.docx)
- [Documento PDF: explicación y código](Documentos/SistemaCarreteras_Documento.pdf)

Para descargar todo el repositorio, usa **Code → Download ZIP**.
Para descargar un documento individual, ábrelo y pulsa **Download raw file**.

## Ejecutar

1. Descomprime la descarga.
2. Abre `SistemaCarreteras/SistemaCarreteras.sln` en Visual Studio 2022.
3. Instala Desarrollo de escritorio de .NET y el Developer Pack de .NET Framework 4.7.2 si hace falta.
4. Compila y pulsa F5.

No requiere base de datos ni paquetes NuGet. Los datos viven en memoria y se reinician al cerrar.

Se completaron los formularios conservando Entidades, Controladores TLista y Formularios.
El PDF original solo detalla dos consultas; las otras tres se documentan como complementarias.

## Validación

85 comprobaciones aprobadas con Mono en Linux y pantalla virtual, incluida la apertura de 14 formularios.
La compilación completa terminó sin errores y con una advertencia del toolset sobre .NET Framework 4.7.2.
Queda pendiente comprobar la ejecución final en Windows/Visual Studio.
Los resultados y el código de las pruebas están en `SistemaCarreteras/Pruebas`.
