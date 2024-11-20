namespace fullStackOops.Indexer
{
    internal class StringIndexerType
    {
        private string[] strArray = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArray.Length)
                {

                    throw new ArgumentException("Index is out of range");
                }

                return strArray[index];
            }

            set
            {
                if (index < 0 || index >= strArray.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                strArray[index] = value;
            }
        }

        /*static void Main(string[] args)
        { 
            StringIndexerType index = new StringIndexerType();
            index[0] = "string one";
            index[1] = "string two";
            index[2] = "string three";
            index[3] = "string four";
        
            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine(i + ": " + index[i]);
            }
        }*/
    }
}
