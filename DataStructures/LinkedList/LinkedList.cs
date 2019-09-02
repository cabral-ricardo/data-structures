using System;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        private Cell _first = null;
        private Cell _last = null;
        private int _sizeItems = 0;
        
        public void AddBeginning(Object item)
        {
            var itemNew = new Cell(item, _first);
            this._first = itemNew;

            if (_sizeItems == 0)
            {
                _last = _first;
            }

            this._sizeItems++;
        }

        public void Add(Object item)
        {
            if (_sizeItems == 0)
            {
                AddBeginning(item);
            }
            else { 
                var newItem = new Cell(item, null);
                _last.SetNext(newItem);
                _last = newItem;
                _sizeItems++;
            }
        }

        public void Add(int position, Object item)
        {
            if (position == 0)
            {
                AddBeginning(item);
            }
            else if (position == _sizeItems)
            {
                Add(item);
            }
            else
            {
                var before = GetCell(position - 1);
                Cell newItem = new Cell(item, before.GetNext());
                before.SetNext(newItem);
                _sizeItems++;
            }
        }

        public Object Get(int position)
        {
            return GetCell(position).GetItem();
        }

        public void RemoveBeginning()
        {
            if (_sizeItems == 0)
            {
                throw new Exception("empty list");
            }

            _first = _first.GetNext();
            _sizeItems--;

            if (_sizeItems == 0)
            {
                _last = null;
            }
        }
        
        public bool Contais(Object item)
        {
            return false;
        }

        public int GetSizeItems()
        {
            return _sizeItems;
        }

        private Cell GetCell(int position)
        {

            if (!BusyPosition(position))
            {
                throw new Exception("invalid position");
            }

            var current = _first;

            for (int i = 0; i < position; i++)
            {
                current = current.GetNext();
            }

            return current;
        }

        private bool BusyPosition(int position)
        {
            return position >= 0 && position < _sizeItems;
        }

        public override string ToString()
        {
            if (_sizeItems == 0)
            {
                return "[]";
            }

            var current = _first;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _sizeItems; i++)
            {
                sb.Append(current.GetItem().ToString());
                sb.Append(",");

                current = current.GetNext();
            }

            sb.Append("]");
            return sb.ToString();
        }
    }
}
