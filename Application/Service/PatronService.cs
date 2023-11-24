using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service;

public class PatronService
{
    public string FindMiddleWord(string word)
    {
        string resultText = string.Empty;
        int index = word.Length / 2;
        if (word.Length % 2 == 0)
            resultText = word.Substring(index - 1, 2);
        else
            resultText = word.Substring(index, 1);
        return resultText;
    }
}
