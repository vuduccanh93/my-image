using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

public class QueryModel
{
    public String spName;
    public SqlParameter[] arrParam;

    public QueryModel() { }
    public QueryModel(String _SpName, SqlParameter[] _ArrParam)
    {
        this.spName = _SpName;
        this.arrParam = _ArrParam;
    }

    public String SpName
    {
        get { return this.spName; }
        set { this.spName = value; }
    }
    public SqlParameter[] ArrParam
    {
        get { return this.arrParam; }
        set { this.arrParam = value; }
    }
}
