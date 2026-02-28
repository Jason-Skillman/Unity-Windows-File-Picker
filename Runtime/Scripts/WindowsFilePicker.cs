namespace JasonSkillman.UnityWindowsFilePicker
{
	using System;
	using System.Runtime.InteropServices;

	public static class WindowsFilePicker
	{
		[DllImport("WindowsFilePickerPlugin", CharSet = CharSet.Unicode)]
		private static extern bool OpenFilePickerNative([Out] char[] outPath, int maxLength, string initialDirectory, string filter);
		
		public static bool OpenFilePicker(out string path, string initialDirectory = null, string filter = null)
		{
			if(string.IsNullOrEmpty(initialDirectory))
			{
				initialDirectory = Environment.CurrentDirectory;
			}
			
			if(string.IsNullOrEmpty(filter))
			{
				filter = "All Files\0*.*\0\0";
			}
			
			char[] buffer = new char[1024];
			if(OpenFilePickerNative(buffer, buffer.Length, initialDirectory, filter))
			{
				path = new string(buffer).TrimEnd('\0');
				return true;
			}

			path = string.Empty;
			return false;
		}
	}
}
