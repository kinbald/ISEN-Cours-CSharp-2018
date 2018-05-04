using System;

namespace Isen.Cs.Library
{
    public class MyCollection : IMyCollection
    {
        // Tableau de persistance de la collection
        private string[] _values;

        // Ctor
        public MyCollection()
        {
            _values = new string[0];
        }

        // Getter avec syntaxe expression-body
        public int Count => _values.Length;

        // pareil (accès au tableau des valeurs)
        public string[] Values => _values;

        /*public void Add(string item)
        {
            // Tableau temporaire de taille taille+1
            var tmp = new string[Count + 1];
            // Copier les valeurs existantes
            for (var i = 0; i < Count; i++)
            {
                tmp[i] = _values[i];
            }

            // Ajouter la nouvelle  valeur dans la dernière case
            tmp[tmp.Length - 1] = item;
            _values = tmp;
        }*/

        public void Add(string item)
        {
            InsertAt(Count, item);
        }

        public void InsertAt(int index, string item)
        {
            // Tester les limites d'index
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            // Tableau temporaire de taille taille+1
            var tmp = new string[Count + 1];
            // Parcourir avant la césure
            for (var i = 0; i < index; i++)
            {
                tmp[i] = _values[i];
            }

            // A la césure : nouvelle valeur
            tmp[index] = item;
            for (var i = index + 1; i < tmp.Length; i++)
            {
                tmp[i] = _values[i - 1];
            }

            // Réaffecter le tableau
            _values = tmp;
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }
    }

    #region Explication des propriétés, getter, setter

    //public void Test()
    //{
    //    var mc = new MyClass();
    //    var i = mc.MyInt;
    //    mc.MyInt = 12;
    //}

    //public class MyClass
    //{
    //    private int _myInt;
    //    // getter / setter #c# explicite
    //    public int MyInt
    //    {
    //        get { return _myInt > 0 ? _myInt : 0; }
    //        private set { _myInt = value; }
    //    }

    //    // get / set implicite
    //    public string MyString { get; set; }

    //    // getter / setter #java
    //    public int getMyInt()
    //    {
    //        return _myInt;
    //    }
    //    private void setMyInt(int value)
    //    {
    //        _myInt = value;
    //    }
    //}

    #endregion
}