namespace Modul007c_AbstractSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DocumentBase> documentBases = new List<DocumentBase>();

            documentBases.Add(new WordDocument() { FileName = "Person.doc"});
            documentBases.Add(new PDFDocument() { FileName = "Ability.pdf", CompressRate = 1024, Watermark = "PDF GmbH" });
            documentBases.Add(new WordDocument() { FileName = "Produkte.doc" });
            documentBases.Add(new PDFDocument() { FileName = "Portfolio.pdf", CompressRate = 512, Watermark = "Marketing GmbH" });
        
            
            foreach(DocumentBase currentDoc in documentBases)
            {
                Console.WriteLine($"verwende aktuell: {currentDoc.FileName}" );

                //Dokument wird gedruckt 
                currentDoc.Print();

                if(currentDoc is WordDocument wordDoc)
                {
                    Console.WriteLine("Word Dokument gefunden");

                    wordDoc.Backup();
                }
                else if (currentDoc is PDFDocument pdfDoc)
                {
                    Console.WriteLine("PDF Dokument gefunden");
                    Console.WriteLine($"Compressrate {pdfDoc.CompressRate}");
                    Console.WriteLine($"Compressrate {pdfDoc.Watermark}");
                }
            }
        }


    }

    public abstract class DocumentBase
    {
        public string FileName { get; set; }

        public abstract void Print();

        
    }

    public class WordDocument : DocumentBase
    {
        public void Backup()
        {
            Console.WriteLine("Worddokument macht ein Backup");
        }
        public override void Print()
        {
            Console.WriteLine("Word Document wird gedruckt");
        }

        public override bool Equals(object? obj)
        {
            //Gibt es ein Objekt, dass mir als Parameter übergeben wurde
            if (obj == null)
                throw new Exception("obj is null");

            // Validieren obj nach WordDocument
            if (obj is not WordDocument)
                throw new ArgumentException("Es wurde kein WordDoc-Object gefunden");


            WordDocument otherWordDoc = (WordDocument)obj;

            if (this.FileName != otherWordDoc.FileName)
                return false;

            return true;
        }
    }

    public sealed class PDFDocument : DocumentBase
    {
        public int CompressRate { get; set; }
        public string Watermark { get; set; }

        public override void Print()
        {
            Console.WriteLine("PDF wird gedruckt");
        }
    }
}