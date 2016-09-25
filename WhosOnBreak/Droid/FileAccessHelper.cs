﻿using System;
namespace WhosOnBreak.Droid
{
	public class FileAccessHelper
	{
		public FileAccessHelper()
		{
		}

		public static string GetLocalFilePath(string filename)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return System.IO.Path.Combine(path, filename);
		}
	}
}