using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Exceptions
{
    public class ExitCodeException : Exception
    {
        public int ExitCode { get; }

        public ExitCodeException(int exitCode, Exception? inner = null)
            : base($"An exit-code exception occurred", inner)
        {
            ExitCode = exitCode;
        }
    }
}
