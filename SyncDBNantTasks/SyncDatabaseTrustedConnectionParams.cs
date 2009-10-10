using System;
using RedGate.Shared.SQL;
using RedGate.SQLCompare.Engine;

namespace SyncDBNantTasks {
    public class SyncDatabaseTrustedConnectionParams : SyncDatabaseParmsBase {
        public SyncDatabaseTrustedConnectionParams(string serverName, string dbName) {
            if (string.IsNullOrEmpty(serverName)) {
                throw new ArgumentException("serverName must be provided");
            }

            if (string.IsNullOrEmpty(dbName)) {
                throw new ArgumentException("dbName must be provided");
            }

            RegisteredDatabase = new Database();
            RegisteredDatabase.Register(new ConnectionProperties(serverName, dbName), Options.Default);
            Connection = new DBConnectionInformation(serverName, dbName);
        }
    }
}