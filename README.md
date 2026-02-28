# Unity-Windows-File-Picker
Plugin for Unity to open the Windows File Explorer at runtime. Supports x32, x64, Mono, and IL2CPP.

## How to install
This package can be installed through the Unity `Package Manager`.

`https://github.com/Jason-Skillman/Unity-Windows-File-Picker.git`

Tested Unity version:
- 6.3

## Examples

How to open the Windows file picker.

```csharp
if(WindowsFilePicker.OpenFilePicker(out string path))
{
	// Your logic here.
}
```

Open file picker with an inital directory.

```csharp
if(WindowsFilePicker.OpenFilePicker(out string path, @"C:\Users\"))
{
	// Your logic here.
}
```

Open file picker with an inital directory and a file filter.

```csharp
if(WindowsFilePicker.OpenFilePicker(out string path, @"C:\Users\", "Image Files (*.png;*.jpg;*.tga;*tif)\0*.png;*.jpg;*.tga;*tif\0\0"))
{
	// Your logic here.
}
```
