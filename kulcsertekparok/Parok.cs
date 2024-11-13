using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikusok
{
	internal class Parok<K, V>
	{
		List<Entry<K, V>> entries;

		public Parok()
		{
			entries = new List<Entry<K, V>>();
		}

		public Entry<K, V> Kereses(K kulcs)
		{
			Entry<K, V> res = entries.Find(entry => entry.Key.Equals(kulcs));
			return res != default(Entry<K, V>) ? res : null;
		}

		public void Hozzaad(Entry<K, V> entry)
		{
			if (Kereses(entry.Key) != null)
			{
				throw new Exception("Kulcs amit hozza akarunk adni mar letezik!");
			}

			entries.Add(entry);
		}

		public void Torol(K kulcs)
		{
			Entry<K, V> res = Kereses(kulcs);
			if (res == null)
			{
				throw new Exception("A kulcs amit torolni akarunk nem letezik!");
			}

			entries.Remove(res);
		}

		public override string ToString()
		{
			string res = "";
			foreach (Entry<K, V> entry in entries)
			{
				res += (entry.ToString() + "\n");
			}
			return res;
		}
	}
}
