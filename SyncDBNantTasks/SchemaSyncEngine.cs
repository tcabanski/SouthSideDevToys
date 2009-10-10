using System;
using System.Linq;
using RedGate.Shared.SQL.ExecutionBlock;
using RedGate.SQLCompare.Engine;

namespace SyncDBNantTasks {
    public class SchemaSyncEngine {
        private readonly SyncDatabaseParmsBase destinationParms;
        private readonly SyncDatabaseParmsBase sourceParms;

        public SchemaSyncEngine(SyncDatabaseParmsBase sourceParms, SyncDatabaseParmsBase destinationParms) {
            if (sourceParms == null) {
                throw new ArgumentNullException("sourceParms");
            }
            if (destinationParms == null) {
                throw new ArgumentNullException("destinationParms");
            }
            this.sourceParms = sourceParms;
            this.destinationParms = destinationParms;
        }

        private Differences GetDifferences() {
            Differences differences = sourceParms.RegisteredDatabase.CompareWith(destinationParms.RegisteredDatabase,
                                                                                 Options.Default);
            differences.Select(x =>
                                   {
                                       x.Selected = true;
                                       return x;
                                   });
            return differences;
        }

        private ExecutionBlock ScriptDifferences(Differences differences) {
            var work = new Work();
            work.BuildFromDifferences(differences, Options.Default, true);
            ExecutionBlock block = work.ExecutionBlock;
            return block;
        }

        private void SyncDifferences(ExecutionBlock block) {
            var executor = new BlockExecutor();
            executor.ExecuteBlock(block, destinationParms.Connection);
        }


        public void Execute() {
            using (sourceParms.RegisteredDatabase) {
                using (destinationParms.RegisteredDatabase) {
                    Differences diff = GetDifferences();
                    ExecutionBlock script = ScriptDifferences(diff);
                    SyncDifferences(script);
                }
            }
        }
    }
}