using System;
using System.Collections.Generic;
using System.Text;

namespace Common.FileReader
{
    public interface ITableFileReader
    {
        void SetCurrentLine(int lineNumber);
        void ContinueToNextLine();


        string GetCellValue(int cellNumber);
    }
}
