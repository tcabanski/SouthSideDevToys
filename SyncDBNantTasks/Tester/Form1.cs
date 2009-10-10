using System;
using System.Windows.Forms;
using SyncDBNantTasks;

namespace Tester {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e) {
            try {
                SyncDatabaseParmsBase sourceParms = SyncDatabaseParmsFactory.CreateParms(
                    sourceScriptsFolderTextBox.Text,
                    sourceServerNameTextBox.Text, sourceDatabaseNameTextBox.Text,
                    sourceDbUserNameTextBox.Text,
                    sourcePasswordTextBox.Text);
                SyncDatabaseParmsBase destinationParms = SyncDatabaseParmsFactory.CreateParms(null,
                                                                                              destinationServerNameTextBox
                                                                                                  .Text,
                                                                                              destinationDbNameTextBox.
                                                                                                  Text,
                                                                                              destinationDbUserNameTextBox
                                                                                                  .Text,
                                                                                              destinationPasswordTextBox
                                                                                                  .Text);
                var sync = new SchemaSyncEngine(sourceParms, destinationParms);
                sync.Execute();
                MessageBox.Show("Completed!");
            }
            catch (Exception err) {
                MessageBox.Show(string.Format("Error occured {0}", err));
            }
        }
    }
}