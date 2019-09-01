using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Cell
    {
        private Object _item;
        private Cell _next;
        private Cell _before;


        public Cell(object elemento, Cell proximo)
        {
            this._item = elemento;
            this._next = proximo;
        }

        public Cell(Object item) : this(item, null) 
        {            
        }

        public Cell GetNext()
        {
            return _next;
        }

        public Cell GetBefore()
        {
            return _before;
        }

        public void SetNext(Cell next)
        {
            this._next = next;
        }

        public void SetBefore(Cell itemNew)
        {
            this._before = itemNew;
        }

        public Object GetItem()
        {
            return _item;
        }
    }
}
