using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        private Record[] recordArray;
        public PhoneBook()
        {
            recordArray = new Record[0];
        }

        public void Add(Record record)
        {
            Record[] newRec = new Record[recordArray.Length + 1];
            recordArray.CopyTo(newRec, 0);
            newRec[recordArray.Length] = record;
            recordArray = newRec;
        }

        public int IndexOf(Record rec)
        {
            for (int i = 0; i < recordArray.Length; i++)
            {
                if (rec.Equals(recordArray[i]))
                    return i;
            }
            return -1;
        }

        public bool Contain(Record rec)
        {
            for (int i = 0; i < recordArray.Length; i++)
            {
                if (rec.Equals(recordArray[i]))
                    return true;
            }
            return false;
        }

        public void Remove(Record rec)
        {
            if (Contain(rec))
            {
                Record[] newRecord = new Record[recordArray.Length - 1];
                int j = 0;
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (!recordArray[i].Equals(rec) || i != IndexOf(rec))
                        newRecord[j++] = recordArray[i];
                }
                recordArray = newRecord;
            }
            else
                throw new ArgumentException("Item not found");
        }

        public void RemoveAt(int index)
        {
            if (index < recordArray.Length)
            {
                Record[] newRecord = new Record[recordArray.Length - 1];
                int j = 0;
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (i != index)
                        newRecord[j++] = recordArray[i];
                }
                recordArray = newRecord;
            }
            else
                throw new IndexOutOfRangeException("Index out of Range!");
        }

        public Record this[string index]
        {
            get
            {
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (recordArray[i].Name == index)
                        return recordArray[i];
                }
                throw new ArgumentException();
            }
            set
            {
                for (int i = 0; i < recordArray.Length; i++)
                {
                    if (recordArray[i].Name == index)
                        recordArray[i] = value;
                }
            }
        }

        public void Display()
        {
            if (recordArray.Length != 0)
                foreach (Record r in recordArray)
                    Console.WriteLine(r.ToString());
            else
                Console.WriteLine("Empty Bloknot");
        }
    }
}