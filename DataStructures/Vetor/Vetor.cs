using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{   
    public class Vetor
    {
        private Student[] _arrayStudent = new Student[100];       
        private int _sizeStudent = 0;

        public void Add(Student student)
        {
            EnsureSpaceArrayStudent();

            // Algoritmo 1: Má performance 
            /*
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = aluno;
                    break;
                }
            }*/

            // Algoritmo 2: Godd performance
            _arrayStudent[_sizeStudent] = student;
            _sizeStudent++;
        }

        /// <summary>
        /// Pushes the indexes to the right of the received position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="student"></param>
        public void Add(int position, Student student)
        {
            EnsureSpaceArrayStudent();

            if (!ValidatePosition(position))
            {
                throw new Exception("invalid position");
            }

            for (int index = _sizeStudent; index >= position; index--)
            {
                _arrayStudent[index + 1] = _arrayStudent[index];
            }

            _arrayStudent[position] = student;
            _sizeStudent++;
        }

        public Student Get(int position)
        {
            if (!ValidateBusyPosition(position))
            {
                throw new Exception("invalid position");
            }

            return _arrayStudent[position];
        }

        /// <summary>
        /// Pushes the indexes to the left of the received position
        /// </summary>
        /// <param name="position"></param>
        public void Remove(int position)
        {
            for (int index = position; index < _sizeStudent; index++)
            {
                _arrayStudent[index] = _arrayStudent[index + 1];
            }

            _sizeStudent--;
        }

        public bool Contains(Student student)
        {
            for (int index = 0; index < _sizeStudent; index++)
            {
                if (student.Equals(_arrayStudent[index]))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetSizeStudent()
        {
            return _sizeStudent;
        }

        private bool ValidateBusyPosition(int position)
        {
            return position >= 0 && position < _sizeStudent;
        }

        private bool ValidatePosition(int position)
        {
            return position >= 0 && position <= _sizeStudent;
        }

        private void EnsureSpaceArrayStudent()
        {
            if (_sizeStudent == _arrayStudent.Length)
            {
                var newArrayStudent = new Student[_sizeStudent * 2];

                for (int index = 0; index < _sizeStudent; index++)
                {
                    newArrayStudent[index] = _arrayStudent[index];
                }

                _arrayStudent = newArrayStudent;
            }
        }

        public override string ToString()
        {
            if (_arrayStudent == null)
            {
                return "null";
            }

            int iMax = _arrayStudent.Length - 1;
            if (iMax == -1)
                return "[]";

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            for (int i = 0; ; i++)
            {
                var nome = _arrayStudent[i];
                if (nome != null)
                {
                    sb.Append(nome);
                    sb.Append(", ");
                }
                else
                {
                    sb.Append("null, ");
                }

                if (i == iMax)
                    return sb.Append("]").ToString();                
            }
        }
    }
}
