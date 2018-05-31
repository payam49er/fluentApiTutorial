using System.Data;

namespace BodmasFluentApi
{
	public class BodMas:IBodMas
    {
		public string Execute(string formula)
	    {
		    DataTable dt = new DataTable();
		    var computed = dt.Compute(formula, "");
		    return computed.ToString();
	    }

	    public string ToString(Grammer formula)
	    {
		    return formula.Formula;
	    }
	}
}