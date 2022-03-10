using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace WinAkPlugin
{
    class BandizipHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourcePath">E:\xxx\Debug\apktool\com.schunshang.bij.qbkjzhuan.apk</param>
        /// <param name="targetDir">E:\xxx\Debug\tmp\</param>
        /// <returns></returns>
        public static bool UnZip(string sourcePath, string targetDir)
        {
            try
            {
                // Bandizip.exe x -o:c:\dest\ c:\sample.zip
                string bandizipPath = ConfigurationManager.AppSettings["bandizip"];
                //ProcessTool.ProecssCmd(bandizipPath, "x \"" + sourcePath + "\" \"" + targetDir + "\"");
                ProcessTool.ProecssCmd(bandizipPath, "x -o:" + targetDir + "\\ " + "\"" + sourcePath + "\"");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
