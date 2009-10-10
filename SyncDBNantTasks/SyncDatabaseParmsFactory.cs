namespace SyncDBNantTasks {
    public static class SyncDatabaseParmsFactory {
        public static SyncDatabaseParmsBase CreateParms(string scriptsPath, string serverName, string dbName,
                                                        string dbUserName, string dbPassword) {
            SyncDatabaseParmsBase sourceParms;
            if (!string.IsNullOrEmpty(scriptsPath)) {
                sourceParms = new SyncDatabaseScriptParms(scriptsPath);
            }
            else if (!string.IsNullOrEmpty(dbUserName)) {
                sourceParms = new SyncDatabaseSqlSecurityParms(serverName, dbName, dbUserName,
                                                               dbPassword);
            }
            else {
                sourceParms =
                    new SyncDatabaseTrustedConnectionParams(serverName,
                                                            dbName);
            }
            return sourceParms;
        }
    }
}