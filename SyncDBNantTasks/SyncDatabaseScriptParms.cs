using System;
using System.IO;
using RedGate.SQLCompare.Engine;

namespace SyncDBNantTasks {
    public class SyncDatabaseScriptParms : SyncDatabaseParmsBase {
        public SyncDatabaseScriptParms(string scriptsPath) {
            if (string.IsNullOrEmpty(scriptsPath)) {
                throw new ArgumentException("scriptsPath must be provided");
            }
            if (!Directory.Exists(scriptsPath)) {
                throw new ArgumentException(string.Format("scriptsPath {0} does not exist", scriptsPath));
            }
            string infoFilePath = Path.Combine(scriptsPath, "SqlCompareDatabaseInfo.xml");
            if (!File.Exists(infoFilePath)) {
                throw new ArgumentException(string.Format("Expected script info file {0} not found", infoFilePath));
            }

            RegisteredDatabase = new Database();
            RegisteredDatabase.Register(scriptsPath, null, Options.Default);
        }
    }
}