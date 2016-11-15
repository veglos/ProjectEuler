using System.Text;

public class BigNumbers
{
    public string Multiply(string a, string b)
    {
        string c = "0";
        for (string i = "0"; !i.Equals(b); i = Add(i, "1"))
        {
            c = Add(c, a);
        }
        return c;
    }

    public string Add(string a, string b)
    {
        string number1 = a;
        string number2 = b;
        if (a.Length < b.Length)
        {
            number1 = b;
            number2 = a;
        }

        int carry = 0;
        StringBuilder result = new StringBuilder();
        for (int i = number1.Length - 1, j = number2.Length - 1; i >= 0; i--, j--)
        {
            int sum = int.Parse(number1[i].ToString()) + carry;
            if (j >= 0) sum += int.Parse(number2[j].ToString());

            if (sum >= 10)
            {
                carry = 1;
                result.Append(sum.ToString()[1]);
            }
            else
            {
                carry = 0;
                result.Append(sum);
            }
        }
        if (carry == 1) result.Append(1);

        return ReverseNumber(result.ToString());
    }

    private string Substract(string a, string b)
    {
        StringBuilder sb = new StringBuilder();
        int borrow = 0;

        int i, j;
        for (i = a.Length - 1, j = b.Length - 1; j >= 0; i--, j--)
        {
            int n1 = int.Parse(a[i].ToString());
            int n2 = int.Parse(b[j].ToString());
            n1 -= borrow;

            if (n1 == -1) n1 = 9;
            if (n1 < n2)
            {
                borrow = 1;
                sb.Append(n1 + 10 - n2);
            }
            else
            {
                borrow = 0;
                sb.Append(n1 - n2);
            }
        }

        while (i >= 0)
        {
            int n1 = int.Parse(a[i].ToString());
            n1 -= borrow;
            if (n1 == -1) n1 = 9;
            if (borrow == 1) borrow = 0;
            sb.Append(n1);
            i--;
        }

        return ReverseNumber(sb.ToString());
    }

    private string ReverseNumber(string number)
    {
        StringBuilder result = new StringBuilder();
        for (int i = number.Length - 1; i >= 0; i--)
        {
            result.Append(number[i]);
        }
        return result.ToString();
    }

}