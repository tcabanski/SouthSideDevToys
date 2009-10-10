using System;
using NAnt.Core;
using NAnt.Core.Attributes;

namespace SyncDBNantTasks {
    [TaskName("schemaSync")]
    public class SchemaSyncTask : Task {
        [TaskAttribute("sourceServerName", Required = false)]
        public string SourceServerName { get; set; }

        [TaskAttribute("sourceDbName", Required = false)]
        public string SourceDbName { get; set; }

        [TaskAttribute("sourceDbUserName", Required = false)]
        public string SourceDbUserName { get; set; }

        [TaskAttribute("sourceDbPassword", Required = false)]
        public string SourceDbPassword { get; set; }

        [TaskAttribute("sourceScriptsPath", Required = false)]
        public string SourceScriptsPath { get; set; }

        [TaskAttribute("destinationServerName", Required = true)]
        public string DestinationServerName { get; set; }

        [TaskAttribute("destinationDbName", Required = true)]
        public string DestinationDbName { get; set; }

        [TaskAttribute("destinationDbUserName", Required = false)]
        public string DestinationDbUserName { get; set; }

        [TaskAttribute("destinationDbPassword", Required = false)]
        public string DestinationDbPassword { get; set; }

        protected override void ExecuteTask() {
            try {
                SyncDB();
            }
            catch (Exception e) {
                Log(Level.Error, "Sync failed");
                throw new BuildException(e.Message);
            }
        }

        private void SyncDB() {
            Log(Level.Info, "Processing Parameters");
            Log(Level.Info, "Source Parameters");
            Log(Level.Info, "\tServer Name: {0}", SourceServerName ?? "NULL");
            Log(Level.Info, "\tDB Name: {0}", SourceDbName ?? "NULL");
            Log(Level.Info, "\tDB User Name: {0}", SourceDbUserName ?? "NULL");
            Log(Level.Info, "\tDB Password: {0}", SourceDbPassword ?? "NULL");
            Log(Level.Info, "\tScripts Path: {0}", SourceScriptsPath ?? "NULL");
            Log(Level.Info, "");
            Log(Level.Info, "Destination Parameters");
            Log(Level.Info, "\tServer Name: {0}", DestinationServerName ?? "NULL");
            Log(Level.Info, "\tDB Name: {0}", DestinationDbName ?? "NULL");
            Log(Level.Info, "\tDB User Name: {0}", DestinationDbUserName ?? "NULL");
            Log(Level.Info, "\tDB Password: {0}", DestinationDbPassword ?? "NULL");
            try {
                SyncDatabaseParmsBase sourceParms = SyncDatabaseParmsFactory.CreateParms(SourceScriptsPath,
                                                                                         SourceServerName, SourceDbName,
                                                                                         SourceDbUserName,
                                                                                         SourceDbPassword);
                SyncDatabaseParmsBase destinationParms = SyncDatabaseParmsFactory.CreateParms(null,
                                                                                              DestinationServerName,
                                                                                              DestinationDbName,
                                                                                              DestinationDbUserName,
                                                                                              DestinationDbPassword);
                var sync = new SchemaSyncEngine(sourceParms, destinationParms);
                sync.Execute();
                Log(Level.Info, "Sync complete");
            }
            catch (Exception e) {
                throw new BuildException(e.Message);
            }
        }
    }
}