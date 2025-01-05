using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Hospital_Presentation.GlobalClasses
{
    class Util
    {
        private static string _GenerateGUID()
        {
            return Guid.NewGuid().ToString();


        }

        private static string _ReplaceFileNameWithGuid(string sourceFile)
        {
            FileInfo fileInfo = new FileInfo(sourceFile);

            return _GenerateGUID() + fileInfo.Extension;

        }

        private static bool _CreatePathIfNotEwists(string destinationDirectory)
        {
            
            try
            {
                if (Directory.Exists(destinationDirectory))
                    return true;

                Directory.CreateDirectory(destinationDirectory);

                return true;

            }
            catch
            {
                MessageBox.Show("Cannot Create Folder " + destinationDirectory);
                return false;
            }

        }
        
        public static bool SaveImageToPeopleFolderImages(ref string sourceFile)
        {
            string destinationDirectory = "C:\\visual projects\\Hospital_Project\\People_Images\\";


            if (!_CreatePathIfNotEwists(destinationDirectory))
                return false;


            string destinationFile = destinationDirectory + _ReplaceFileNameWithGuid(sourceFile); ;
        
            try
            {
                File.Copy(sourceFile, destinationFile,true);


            }
            catch(IOException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            sourceFile = destinationFile;

            return true;

        }
    }
}
