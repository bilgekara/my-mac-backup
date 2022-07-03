using P.I.Works;

bool asalSayiMi(string parca)
{
    int kontrol = 0;
    int sayi = int.Parse(parca);
    int i = 2;
    while (i < sayi)
    {
        if (sayi % i == 0)
            kontrol++;

        i++;
    }

    if (kontrol != 0 || sayi == 1)
        return false; //asal degil
    else
        return true;
}


string dosya_yolu = "Ucgen.txt";

FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
StreamReader sw = new StreamReader(fs);

string yazi = sw.ReadLine();


BinaryTree binaryTree = new BinaryTree();

/*binaryTree.Add(1);
binaryTree.Add(2);
binaryTree.Add(7);
binaryTree.Add(3);
binaryTree.Add(10);
binaryTree.Add(5);
binaryTree.Add(8);*/

int temp = 0; int bakbusoldugun = 0; int bakbusagci = 0;
binaryTree.Add(1, 0, 0);
binaryTree.Add(8, 0, 0);
binaryTree.Add(4, 1, 1);
temp = 1; bakbusoldugun = 0; bakbusagci = 1;
int asalak = 0;
while (yazi != null)
{
    if(asalak>1)
    {
        // sol dugumun neresinde kalıyor, asg dugumun neresinde kalıyor
        char ayrac = ' ';
        string[] parcalar = yazi.Split(ayrac);
        int yandiBuralar = 0;


        for (int i = temp; i < parcalar.Length - 1; i++)
        {
            if (!asalSayiMi(parcalar[i]))
            {
                if (i == temp)
                {
                    if (bakbusoldugun == i) binaryTree.Add(int.Parse(parcalar[i]), 0, 0); //left node

                    if (bakbusoldugun + 1 == i) binaryTree.Add(int.Parse(parcalar[i]), 0, 1); //left node

                    if (bakbusagci == i) binaryTree.Add(int.Parse(parcalar[i]), 1, 0);
                    if (bakbusagci + 1 == i) binaryTree.Add(int.Parse(parcalar[i]), 1, 1);

                    bakbusoldugun = i;
                }
                if (i != temp)
                {
                    binaryTree.Add(int.Parse(parcalar[i]), 1, 1);
                    bakbusagci = i;
                }
            }
            else
            {
                yandiBuralar = 1;
                temp++;
                continue;
            }

        }

    }
    asalak++;
    yazi = sw.ReadLine();

}

Node node = binaryTree.Find(5);
int depth = binaryTree.GetTreeDepth();

Console.WriteLine("PreOrder Traversal:");
binaryTree.TraversePreOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("InOrder Traversal:");
binaryTree.TraverseInOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("PostOrder Traversal:");
binaryTree.TraversePostOrder(binaryTree.Root);
Console.WriteLine();

binaryTree.Remove(7);
binaryTree.Remove(8);

Console.WriteLine("PreOrder Traversal After Removing Operation:");
binaryTree.TraversePreOrder(binaryTree.Root);

/*int toplam = 0; int temp = 0; int nerdeyiz = 0;
int bottom = 3; int right = 3; int degisken = 0;
List<int> tree = new List<int>();

while (yazi != null)
{
    char ayrac = ' ';
    string[] parcalar = yazi.Split(ayrac);
    
    for(int i = temp; i<parcalar.Length ; i++)
    {
        if (parcalar.Length >= 2)
        {
            bottom = int.Parse(parcalar[temp]); right = int.Parse(parcalar[temp + 1]);
        }

        if (!asalSayiMi(bottom))
        {
            degisken = toplam;
            //degisken +=
            degisken += bottom;
            tree[nerdeyiz] = degisken;
        }
        if (!asalSayiMi(right))
        {
            nerdeyiz++;
            degisken += right;
        }
        else
        {
            toplam += int.Parse(parcalar[i]);
            
            if (i != 0) { temp++; }
            break; 
        }
    }


    yazi = sw.ReadLine();
}*/

sw.Close();
fs.Close();

//Console.WriteLine("Toplam->"+toplam);



/*while (yazi != null)
{
    char ayrac = ' ';
    string[] parcalar = yazi.Split(ayrac);

    for (int i = temp; i < parcalar.Length; i++)
    {
        if (asalSayiMi(parcalar[i]))
        {
            if (i == parcalar.Length - 1) { temp++; }
            continue;
        }
        else
        {
            toplam += int.Parse(parcalar[i]);
            if (i != 0) { temp++; }
            break;
        }
    }


    yazi = sw.ReadLine();
}*/