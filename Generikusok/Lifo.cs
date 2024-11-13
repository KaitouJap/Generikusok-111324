using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generikusok
{
	public class Verem<T>
	{
		T[] array;
		int size;

		public int Count
		{
			get
			{
				return size;
			}
		}

		public bool IsEmpty
		{
			get
			{
				return size == 0;
			}
		}

		public Verem()
		{
			array = new T[0];
			size = 0;
		}

		public void Push(T item)
		{
			if(size == array.Length)
			{
				T[] array = new T[(this.array.Length==0?4:(2*this.array.Length))];
				Array.Copy(this.array, 0, array, 0, size);
				this.array = array;
			}
			array[size++] = item;
		}

		public T Pop() 
		{
			if(IsEmpty)
			{
				throw new InvalidOperationException("Üres stack");
			}

			T res = array[--size];
			array[size] = default(T);
			return res;
		}

		public T Peek()
		{
			if(IsEmpty)
			{
				throw new InvalidOperationException("Üres stack");
			}

			return array[size - 1];
		}

		public override string ToString()
		{
			string res = "";
			foreach(T item in array)
			{
				res += (item + " ");
            }

			return res;
		}
	}
}
