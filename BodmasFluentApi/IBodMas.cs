using System;

namespace BodmasFluentApi
{
    public interface IBodMas
    {
	    string ToString(Grammer formula);

		string Execute(string formula);
    }
}