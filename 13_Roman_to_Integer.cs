public class Solution {
    public int RomanToInt(string s) {
        int i = 0;
        int sum = 0;
        while (i<s.Length){
            char current = s[i];
            char next;
            if (i < s.Length - 1){ //if there is a letter after the current
                next = s[i+1];
            } else {next = 'O';}
            // list one by one (brute force)
            switch (current){
                case 'I':
                    if (next  == 'V'){
                        sum += 4;
                        i++;
                    } else if (next == 'X'){
                        sum += 9;
                        i++;
                    } else {
                        sum++;
                    }
                    break;
                case 'V':
                    sum+=5;
                    break;
                case 'X':
                    if (next == 'L'){
                        sum+= 40;
                        i++;
                    } else if (next == 'C'){
                        sum+=90;
                        i++;
                    } else {
                        sum+=10;
                    }
                    break;
                case 'L':
                    sum +=50;
                    break;
                case 'C':
                    if (next == 'D'){
                        sum += 400;
                        i++;
                    } else if (next == 'M') {
                        sum += 900;
                        i++;
                    } else {
                        sum += 100;
                    }
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'M':
                    sum += 1000;
                    break;
            }
            i++;
        }
        return sum;
    }
}