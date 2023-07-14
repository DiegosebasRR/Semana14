using System;
using semana14.Droid;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace semana14.Droid
{
	public class ConfigDataBase: IConfigDataBase
	{
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}

