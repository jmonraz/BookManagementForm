﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class LibraryManagementForm : Form
    {
        public LibraryManagementForm()
        {
            FileFunctions.LoadBooks();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();

            ab.ShowDialog();
        }

        private void displayAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBooks db = new DisplayBooks();

            if (Book.mBooks.Count == 0)
            {
                MessageBox.Show("No books in library");
                db.Close();
            }
            else
            {
                db.ShowDialog();
            }
            
            
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook eb = new EditBook();
            if (Book.mBooks.Count == 0)
            {
                MessageBox.Show("No books in library");
                eb.Close();
            }
            else
            {
                eb.ShowDialog();
            }
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBookForm dbf = new DeleteBookForm();
            if(Book.mBooks.Count == 0)
            {
                MessageBox.Show("No books in library");
                dbf.Close();
            }
            else
            {
                dbf.ShowDialog();
            }
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void writeReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewForm rf = new ReviewForm();
            rf.ShowDialog();
        }

        private void progressByBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressByBookForm pbbf = new ProgressByBookForm();
            pbbf.ShowDialog();
        }

        private void addPhraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhraseForm apf = new AddPhraseForm();
            apf.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm muf = new ManageUsersForm();
            muf.ShowDialog();
        }

        private void updateToolstrip_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }
    }
}
