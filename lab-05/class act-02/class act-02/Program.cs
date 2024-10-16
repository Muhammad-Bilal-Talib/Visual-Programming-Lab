using System;
using System.Linq;

namespace act2
{
    class new1
    {
        static void Main(string[] args)
        {

            testcatch();
        }

        static void testcatch()
        {
            System.IO.StreamWriter sw=null;
            try
            {
               sw = new System.IO.StreamWriter($"C:/txtfiles/gest.txt");
                sw.WriteLine("Hello,How are You!");
            }
            catch(System.IO.FileNotFoundException ex)
            {
              Console.WriteLine(ex.ToString);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            Console.WriteLine("Done");

        }

        

    }


}

