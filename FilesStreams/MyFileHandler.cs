using System;
using System.IO;
using System.Text;

namespace FilesStreams
{
    class MyFileHandler
    {
        public void ReadAllContent(string text)
        {    
            FileStream fs = File.OpenRead(text);
            
            StreamReader sr = new StreamReader(fs);
            try
            {
                //Console.WriteLine(sr.ReadToEnd());
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sr.Close();

            }
;        }
        public void WriteContentToFile(string inputText)
        {

            string text = @"C:\Users\sildo\Desktop\FilesStreams\FilesStreams\testfile2.txt";
            if (File.Exists(text) == false)
            {
                using (FileStream fs = File.Create(text))
                {

                }
            }
           
            using(FileStream fs = File.OpenWrite(text))
            {
                Byte[] newText = new UTF8Encoding(true).GetBytes(inputText);
                fs.Write(newText);
            }

            //using (StreamWriter wr = new StreamWriter(text))
            //{
            //    wr.Write(inputText);
                
            //}
               



        }
        public void UpperCaseContent(string file1 , string file2)
        {
            FileStream fs = File.OpenRead(file1);
            using (StreamReader sr = new StreamReader(fs))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    line += "\n";
                    File.AppendAllText(file2, line);
                }


            }
        }
        public void ReadLAtinEncodedContent()
        {

            try
            {
                FileStream fs = File.OpenRead(@"C:\Users\sildo\Desktop\FilesStreams\FilesStreams\latin1.txt");
                for (int i = 0; i < fs.Length; i++)
                {
                    Console.WriteLine(fs.ReadByte());
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File is not found");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
           


        }
    }
}
