using System;
using RedGate.Shared.SQL;
using RedGate.SQLCompare.Engine;

namespace SyncDBNantTasks {
    public class SyncDatabaseSqlSecurityParms : SyncDatabaseParmsBase {
        public SyncDatabaseSqlSecurityParms(string serverName, string dbName, string dbUserName, string dbPassword) {
            if (string.IsNullOrEmpty(serverName)) {
                throw new ArgumentException("serverName must be provided");
            }

            if (string.IsNullOrEmpty(dbName)) {
                throw new ArgumentException("dbName must be provided");
            }

            if (string.IsNullOrEmpty(dbUserName)) {
                throw new ArgumentException("dbUserName must be provided");
            }

            if (string.IsNullOrEmpty(dbUserName)) {
                throw new ArgumentException("dbUserName must be provided");
            }

            RegisteredDatabase = new Database();
            RegisteredDatabase.Register(new ConnectionProperties(serverName, dbName, dbUserName, dbPassword),
                                        Options.Default);
            Connection = new DBConnectionInformation(serverName, dbName, dbUserName, dbPassword);
        }
    }
}