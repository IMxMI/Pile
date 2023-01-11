using System;

namespace Pile
{
    class Program
    {
        struct Pile
        {
            public int maxElt; //nombre maximum d'éléments de la pile
            public int sommet; //indice du sommet (dernier élément empiler)
            public int[] tabElem; //tableau [0..maxElt] de caractères
        }


        static void Main(string[] args)
        {
            TestePileVidePleine();
            TestEmpilerDepiler();
        }

        ///<summary>
        ///initialise une nouvelle variable de type Pile
        ///cette méthode :
        ///     crée le tableau de pNbElement
        ///     initialise la variable maxElt
        ///     initialise la variable sommet
        ///</summary>
        ///<param name="=pUnePile">variable de type Pile à initialiser</param>
        ///<param name="=PNbElemnt">Nombre d'élément maxi de la Pile</param>
        static void InitPile(ref Pile pUnePile, int PNbElemnt)
        {
            pUnePile.maxElt =PNbElemnt;
            pUnePile.sommet = 0 ;
            pUnePile.tabElem =new int[PNbElemnt];
        }

        ///<summary>
        ///retourne un booléeen indiquant si la pile est vide.
        ///Une pile est vide si la valeur du sommet est égale à-1
        ///</summary>
        ///<param name="pUnePile"></param>
        ///<returns></returns>
        static bool PileVide(Pile pUnePile)
        {
            return pUnePile.sommet == 0;
        }

        ///<summary>
        ///retourne un booléeen indiquant si la pile est pleine
        ///Une pile est pleinne si la valeur du sommet est égal à la valeur maximal
        ///</summary>
        ///<param name="pUnePile"></param>
        ///<returns></returns>
        static bool PilePleine(Pile pUnePile)
        {
            return pUnePile.sommet == pUnePile.maxElt;
        }

        ///<summary>
        ///Cette méthode ajoute la valeur passé en paramètre au sommet de la pile
        ///passée en paramètre si toutefois la pile n'est pas pleine.
        ///Elle modifie la valeur du sommet de la pile
        ///</summary>
        ///<param name="pUnePile">pile sur laquelle il faut empiler</param>
        ///<param name="PNb">Nombre à empiler</param>
        static void Empiler(ref Pile pUnePile, int PNb)
        {
            if(!PilePleine(pUnePile))
            {
                pUnePile.tabElem[pUnePile.sommet] = PNb;
                pUnePile.sommet++;
            }
        }

        ///<summary>
        ///Renvoie la valeur située au sommet de la pile
        ///met à jour la variable sommet.
        ///Si le pile est vide, renvoie -999
        ///</summary>
        ///<param name="pUnePile">Pile à partir de laquelle il faut dépiler</param>
        ///<returns>Valut dépilée ou -999</returns>
        static int Depiler(ref Pile pUnePile)
        {
            if (!PileVide(pUnePile))
            {
                return pUnePile.tabElem[pUnePile.sommet];
            }
            else
            {
                return -999;
            }
        }
        static void TestePileVidePleine()
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, 5);
            if (PileVide(unePile))
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (PilePleine(unePile))
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }
        static void TestEmpilerDepiler()
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, 5);
            Empiler(ref unePile, 2);
            Empiler(ref unePile, 14);
            Empiler(ref unePile, 6);
            Empiler(ref unePile, 22);
            int valeurDepilee = Depiler(ref unePile);
            Console.WriteLine("valeur dépilée : " + valeurDepilee);
            Empiler(ref unePile, 17);
            Empiler(ref unePile, 81);
            Empiler(ref unePile, 34);
        }
    }
}
