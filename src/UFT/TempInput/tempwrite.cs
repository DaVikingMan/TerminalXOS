using System;
using System.Diagnostics;
using System.IO;

namespace Inputstream
{
	class TempWrite
	{
		public void WriteTemp(string readwrite, bool ifwritepermanent)
		{
                         string read = readwrite;
						 if(ifwritepermanent == true)
						 {
                               File.WriteAllText($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream", read);
						 }else if(ifwritepermanent == false)
						 {
							 File.WriteAllText($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream", read);
							 

						 }
                         
						 
			 
		}
		public void TempSignal(bool istrue)
		{
			if(istrue == true)
			{
				File.WriteAllText("../FalconXOS/data/TempInputstream/main.inputstream", null);
			}
		}

	}
}
