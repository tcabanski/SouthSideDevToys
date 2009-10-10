using System;
using RedGate.Shared.SQL;
using RedGate.SQLCompare.Engine;

namespace SyncDBNantTasks {
    public abstract class SyncDatabaseParmsBase {
        private DBConnectionInformation connection;

        public Database RegisteredDatabase { get; protected set; }

        public DBConnectionInformation Connection {
            get {
                if (connection == null) {
                    throw new NotImplementedException("Connection not supported");
                }
                else {
                    return connection;
                }
            }
            set { connection = value; }
        }
    }
}