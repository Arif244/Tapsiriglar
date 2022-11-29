namespace Dersde_tapsiriglar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string b = Costum("Tural", 2);
            //Console.WriteLine(b);

            //string a = CustomToUpper("Tural", 4);
            // Console.WriteLine(a);


            string sentence = "it must be written with method";
            string filterwold = CapitalizeFirstLetter(sentence);
            Console.WriteLine(filterwold);


            //    string[] arr = { "bu", "bir", "culedir" };
            //    foreach (var item in CustomSplit("bu bir cumledir"))
            //    {
            //        Console.WriteLine(item);

            //    }        
            //}


            //static string[] CustomSplit(string sentence)//bu bir cumledir
            //{
            //    //TODO
            //    string[] splited = new string[0];
            //    string find = string.Empty;
            //    int index =-1;
            //    int lenght = 0;
            //    for (int i = 0; i < sentence.Length; i++)
            //    {
            //        if (sentence[i] == ' ')
            //        {
            //            Array.Resize(ref splited, splited.Length + 1);
            //            find = sentence.Substring(index + 1, lenght);
            //            index = i;
            //            splited[splited.Length - 1] = find;
            //            lenght = 0;
            //        }
            //        else if (i == sentence.Length - 1)
            //        {
            //            Array.Resize(ref splited, splited.Length + 1);
            //            find = sentence.Substring(index + 1, lenght + 1);
            //            index = i;
            //            splited[splited.Length - 1] = find;
            //            lenght = 0;

            //        }


            //        else
            //        {
            //            lenght++;
            //        }
            //    }
            //    return splited;

            //static string Costum(string tema,int index)
            //{
            //    string tab = "";
            //    char x = char.IndexOf(tema[index]);
            //    for (int i = 0; i < tema.Length; i++)
            //    {
            //        if (i= index)
            //        {

            //        }
            //    }


            //    return tab;
            //}












        }
        //static string CustomToUpper(string world, int index)
        //{

        //    string tab = "";
        //    char a = char.ToUpper(world[index]);



        //    for (int i = 0; i < world.Length; i++)
        //    {
        //       if(i == index)
        //        {
        //            tab += a;
        //        }
        //        else
        //        {
        //            tab += world[i];
        //        }
        //    }


        //    return tab;
        //}

        static string CapitalizeFirstLetter(string sentence)
        {

            sentence = sentence.ToLower();
            string[] words = sentence.Split(" ");
            string filterworld = "";


            for (int i = 0; i < words.Length; i++)
            {
                filterworld += char.ToUpper(words[i][0]) + words[i].Substring(1) + " ";
            }
            filterworld = filterworld.TrimEnd();

            return filterworld;
        }




    }

    }

    

    
