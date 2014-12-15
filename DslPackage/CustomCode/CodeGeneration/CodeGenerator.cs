using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TextTemplating.VSHost;
using BrainTec.NHibernateDesigner.CustomCode.CodeGeneration;
      
namespace BrainTec.NHibernateDesigner
{
    [global::System.Runtime.InteropServices.Guid("CC198948-572D-41E2-BF33-FF3CB24AF5EA")]
    public class CodeGenerator : TemplatedCodeGenerator
    {
        protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
        {
            inputFileContent = Encoding.UTF8.GetString(GeneratorRes.Generator);

            var fi = new FileInfo(inputFileName);
            inputFileContent = inputFileContent.Replace("Diagramm1.nh", fi.Name);
            inputFileContent = inputFileContent.Replace("namespace Diagramm1", "namespace " + FileNamespace);

            var data = base.GenerateCode(inputFileName, inputFileContent);
            var ascii = new byte[data.Length - 3];
            Array.Copy(data, 3, ascii, 0, data.Length - 3);

            return ascii;
        }
    }
}
