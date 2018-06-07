using System;
namespace MyProject
{
    class CodeGeneratorTest
    {
        public void TestMethod()
        {
            Catalog catalog = new Catalog(@"D:\documents\INSA\maidis\vs\test\TemplateT4Test\TemplateT4Test\Generated Codes\exampleXml.xml");
            foreach (Artist artist in catalog.Artist)
            {
                Console.WriteLine(artist.name);
                foreach (Song song in artist.Song)
                {
                    Console.WriteLine("   " + song.Text);
                }
            }
        }
    }
}