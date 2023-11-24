using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service;

public class FaceService
{
    public string BuildFace(FaceEntity entity)
    {
        string result = string.Empty;

        for (int i = 0; i < 7; i++)
            result += i == 0 ? " " : i == 6 ? " " : entity.Cabello;

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 0 ? entity.DelinearFace
                : i == 6 ? entity.DelinearFace
                : i == 2 ? entity.Ceja1
                : i == 4 ? entity.Ceja2
                : " ";

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 0 ? entity.Oreja1
                : i == 6 ? entity.Oreja2
                : i == 2 ? entity.Ojos
                : i == 4 ? entity.Ojos
                : " ";

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 0 ? entity.DelinearFace
                : i == 6 ? entity.DelinearFace
                : i == 3 ? entity.Nariz
                : " ";

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 0 ? entity.DelinearFace
                : i == 6 ? entity.DelinearFace
                : i == 2 ? entity.Boca1
                : i == 3 ? entity.Boca2
                : i == 4 ? entity.Boca3
                : " ";

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 1 ? entity.DelinearFace
                : i == 5 ? entity.DelinearFace
                : " ";

        result += "\n";

        for (int i = 0; i < 7; i++)
            result += i == 2 ? entity.Menton1
                : i == 3 ? entity.Menton2
                : i == 4 ? entity.Menton3
                : " ";

        result += "\n";

        return result;
    }
}
