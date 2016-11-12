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