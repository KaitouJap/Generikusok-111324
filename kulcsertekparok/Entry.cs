using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikusok
{
	public class Entry<K, V>
	{
		K key;
		V value;

		public Entry(K key, V value)
		{
			this.key = key;
			this.value = value;
		}

		public K Key { get => key;}
		public V Value { get => value; set => this.value = value; }

		public override string ToString()
		{
			return key.ToString() + "=" + value.ToString();
		}
	}
}
