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
            Console.WriteLine("Hello World!");
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
        ///Une pile est vide si la valeur du sillet est égale à-1
        ///</summary>
        ///<param name="pUnePile"></param>
        ///<returns></returns>
        static bool PileVide(Pile pUnePile)
        {

        }
    }
}
