namespace getTotalX
{
    public class PDFViewer
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            int totalChars = word.Count();
            int maxHeight = 0;

            foreach (char letter in word)
            {

                int index = Convert.ToChar(Char.ToLower(letter)) - 97;

                if (h[index] > maxHeight)
                {

                    maxHeight = h[index];
                }

            }

            return maxHeight * totalChars;

        }
    }
}
