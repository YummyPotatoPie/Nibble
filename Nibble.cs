namespace NibbleType
{
    public class Nibble
    {
        private int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if(value < 0)
                {
                    this.value = -value % 16;
                }
                else
                {
                    this.value = value % 16;
                }
            }
        }

        public static Nibble operator +(Nibble nib1, Nibble nib2)
        {
            return new Nibble((nib1.Value + nib2.Value) % 16);
        }

        public static Nibble operator +(Nibble nib, int num)
        {
            return new Nibble((nib.Value + num) % 16);
        }

        public static int operator +(int num, Nibble nib)
        {
            return nib.Value + num;
        }

        public static Nibble operator ++(Nibble nib)
        {
            return new Nibble((nib.Value + 1) % 16);
        }

        public static bool operator <(Nibble nib1, Nibble nib2)
        {
            return nib1.Value < nib2.Value;
        }

        public static bool operator >(Nibble nib1, Nibble nib2)
        {
            return nib1.Value < nib2.Value;
        }

        public static explicit operator int(Nibble nib)
        {
            return nib.Value;
        }

        public static explicit operator Nibble(int num)
        {
            return new Nibble(num % 16);
        }

        public Nibble(int value)
        {
            if(value < 0)
            {
                this.value = -value % 16;
            }
            else
            {
                this.value = value % 16;
            }
        }

        public Nibble()
        {
            value = 0;
        }
    }
}
