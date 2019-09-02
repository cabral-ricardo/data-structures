using System;
using System.Text;

namespace DataStructures
{
    public class DoubleLinkedList
    {
        private Cell _first = null;
        private Cell _last = null;
        private int _sizeItems = 0;

        public void AddBeginning(Object item)
        {
            if (_sizeItems == 0)
            {
                var nova = new Cell(item);
                _first = nova;
                _last = nova;
            }
            else
            {
                var cell = new Cell(item, _first);
                _first.SetBefore(cell);
                _first = cell;
            }

            this._sizeItems++;
        }

        public void Add(Object item)
        {
            if (_sizeItems == 0)
            {
                AddBeginning(item);
            }
            else
            {
                var cell = new Cell(item);
                _last.SetNext(cell);
                cell.SetBefore(_last);
                _last = cell;
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
                var next = before.GetNext();

                Cell cell = new Cell(item, before.GetNext());
                cell.SetBefore(before);
                before.SetNext(cell);
                next.SetBefore(cell);
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

        public void RemoveEnd()
        {
            if (_sizeItems == 1)
            {
                RemoveBeginning();
            }
            else
            {
                Cell penultim = _last.GetBefore();
                penultim.SetNext(null);
                _last = penultim;
                _sizeItems--;
            }
        }

        public void Remove(int position)
        {
            if (position == 0)
            {
                RemoveBeginning();
            }
            else if (position == _sizeItems - 1)
            {
                RemoveEnd();
            }
            else
            {
                var before = GetCell(position - 1);
                var current = before.GetNext();
                var next = current.GetNext();

                before.SetNext(next);
                next.SetBefore(before);

                _sizeItems--;
            }
        }

        public bool Contains(Object item)
        {
            Cell current = _first;

            while (current != null)
            {
                if (current.GetItem().Equals(item))
                {
                    return true;
                }
                current = current.GetNext();
            }
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
                throw new Exception("invalid positipon");
            }

            Cell current = _first;

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

            Cell current = _first;

            var sb = new StringBuilder();

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
