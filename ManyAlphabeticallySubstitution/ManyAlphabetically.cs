using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyAlphabeticallySubstitution
{
    class ManyAlphabetically
    {
        private string text, key, cryptogram;
        private string[] keys = { "МОНИТОР", "КРЕДИТ", "СПЕЦИАЛНОСТ", "КОМПЮТЪР", "СТЕНА" };
        private string M_alphabet;
        private int[] M_digits = new int[70];

        public ManyAlphabetically()
        {
            int i;

            text = "";
            key = "";
            cryptogram = "";

            M_alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 \"-*";
            for (i = 0; i < M_alphabet.Length; i++)
                M_digits[i] = i + 1;
        }

        public void set_values_e(string orig_message, int i)
        {
            text = orig_message;
            key = keys[i];
        }
        public void make_cryptogram(int message_len)
        {
            int i, j, k, x=0, y=0, i1, i2;
            char a, b;
            char[] chars = text.ToCharArray();
    
            for(i=0, j=0; i<message_len; i++, j++)
            {
                if(j==key.Length)
                    j %= key.Length;

                a = text[i];
                
                for(i1 = 0; i1 < M_alphabet.Length; i1++)
			      if(a == M_alphabet[i1])
			      {
 				    x = M_digits[i1];
				    break;
			      }

                b = key[j];
		
		        for(i2 = 0; i2 < M_alphabet.Length; i2++)
			      if(b == M_alphabet[i2])
			      {
				    y = M_digits[i2];
				    break;
			      }

                k = (x + y) % M_alphabet.Length;

                if (k!=0)
                    chars[i] = M_alphabet[k-1];
                else
                    chars[i] = M_alphabet[M_alphabet.Length-1];

            }
            cryptogram = new string(chars);            
        }
        public string get_cryptogram()
        {
            return cryptogram;
        }

        public void set_values_d(string crypto, int i)
        {
            cryptogram = crypto;
            key = keys[i];
        }
        public void make_text(int cryptogram_len)
        {
            int i, j, k, x=0, y=0, i1, i2;
            char a, b;
            char[] chars = cryptogram.ToCharArray();
                
            for(i=0, j=0; i<cryptogram_len; i++, j++)
            {
                if(j==key.Length)
                    j %= key.Length;

                a = cryptogram[i];
                
                for(i1 = 0; i1 < M_alphabet.Length; i1++)
			      if(a == M_alphabet[i1])
			      {
 				    x = M_digits[i1];
				    break;
			      }

                b = key[j];
		
		        for(i2 = 0; i2 < M_alphabet.Length; i2++)
			      if(b == M_alphabet[i2])
			      {
				    y = M_digits[i2];
				    break;
			      }

                k = x - y;
                if(k < 0)
                    k+=M_alphabet.Length;

                if (k!=0)
                    chars[i] = M_alphabet[k-1];
                else
                    chars[i] = M_alphabet[M_alphabet.Length-1];

            }
            text = new string(chars);
        }
        public string get_text()
        {
            return text;
        }

        public bool check_message(string s)
        {
            int i;
            
            for(i=0; i<s.Length; i++)
                if(!check_letter(s[i]))
                    return false;
            return true;
        }
        public bool check_letter(char ch)
        {
            bool flag = false;
            int i;

            for (i = 0; i < M_alphabet.Length; i++)
            {
                if (ch == M_alphabet[i])
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        
    }
}
