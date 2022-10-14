namespace RomanNumeral {

    public class RomanNum {

            public int RomanToInt(string s) {
                s.ToUpper();
                char[] charArray = s.ToCharArray();
                int Total = 0;
                char previous = 'Z';
                foreach(char c in charArray) {
                        switch(c) {
                                case 'I':
                                Total += 1;
                                previous = c;
                                break;

                                case 'V': 
                                if(previous == 'I') {
                                Total += 3;
                                } else Total += 5;
                                previous = c;
                                break;
                                case 'X':
                                if(previous == 'I') {
                                Total += 8;
                                } else Total += 10;
                                previous = c;
                                break;

                                case 'L':
                                if(previous == 'X') {
                                Total += 30;
                                } else Total += 50;
                                previous = c;
                                break;

                                case 'C':
                                if(previous == 'X') {
                                Total += 80;
                                } else Total += 100;
                                previous = c;
                                break;

                                case 'D': 
                                if(previous == 'C') {
                                Total += 300;
                                } else Total += 500;
                                previous = c;
                                break;

                                case 'M':
                                if(previous == 'C') {
                                Total += 800;
                                } else Total += 1000;
                                previous = c;
                                break;

                        }

                }
                return Total;
            }
    }
}