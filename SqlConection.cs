using System;
using System.Data;

namespace esbocoProjeto2
{
    public class SqlConection
    {
        private string v;

        public SqlConection(string v)
        {
            this.v = v;
        }

        public string ConnectionString { get; internal set; }
        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}