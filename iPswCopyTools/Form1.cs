using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPswCopyTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            tbApstDMG.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%APSTHOME%"), @"PST\Apple\Common\dmg");
            tbiPhonedmg.Text = iPswCopyTools.Properties.Settings.Default.iPhone_DMG;
            tbiPhoneIpsw.Text = iPswCopyTools.Properties.Settings.Default.iPhone_IPSW;
            tbiPadDmg.Text = iPswCopyTools.Properties.Settings.Default.iPad_DMG;
            tbiPadIpsw.Text = iPswCopyTools.Properties.Settings.Default.iPad_IPSW;
            tbiPodDmg.Text = iPswCopyTools.Properties.Settings.Default.iPod_DMG;
            tbiPodIpsw.Text = iPswCopyTools.Properties.Settings.Default.iPod_IPSW;

            // Assign the ImageList to the TreeView control
            //treeView1.ImageList = imageList;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CreateTreeView(string sFileName)
        {
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(sFileName);
            Regex regTitle = new Regex(@"\/\/[-]+(.*?)[-]+$", RegexOptions.Compiled);
            Regex regData = new Regex(@".*?[ ]+(.*?)[ ]+(\d{3}-.*?dmg)[ ]+(i.*?ipsw)[ ]+", RegexOptions.Compiled);
            TreeNode newNode = null;
            DEVICETYPE devType = DEVICETYPE.iPhone;
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line)) continue;
                Match m = regTitle.Match(line);
                if (m.Success)
                {
                    if (String.Compare(m.Groups[1].Value, "iPhone", true) == 0)
                    {
                        devType = DEVICETYPE.iPhone;
                    }
                    else if (String.Compare(m.Groups[1].Value, "iPad", true) == 0)
                    {
                        devType = DEVICETYPE.iPad;
                    }
                    else if (String.Compare(m.Groups[1].Value, "iPod Touch", true) == 0|| String.Compare(m.Groups[1].Value, "iPod", true) == 0)
                    {
                        devType = DEVICETYPE.iPod;
                    }
                    newNode = new TreeNode(m.Groups[1].Value);
                    treeView1.Nodes.Add(newNode);
                }
                else
                {
                    if (newNode != null)
                    {
                        Match itm = regData.Match(line);
                        if (itm.Success)
                        {
                            IPSWInfo ipinfo = new IPSWInfo();
                            ipinfo.DeviceName = itm.Groups[1].Value;
                            ipinfo.SetDMGS(itm.Groups[2].Value);
                            ipinfo.IPSWFileName = itm.Groups[3].Value;
                            ipinfo.DevType = devType;
                            TreeNode newitem = new TreeNode(ipinfo.DeviceName);
                            
                            newitem.Tag = ipinfo;
                            newNode.Nodes.Add(newitem);
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open txt
            //.*?[ ]+(.*?)[ ]+(\d.*?dmg)[ ]+(i.*?ipsw)[ ]+
            DialogResult dlg = openDlgTxt.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                String sFileName = openDlgTxt.FileName;
                tblIPSWInfo.Text = sFileName;
                CreateTreeView(sFileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogNew dialog = new FolderBrowserDialogNew();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                String spath = dialog.DirectoryPath;
                switch (Convert.ToInt32((sender as Button).Tag))
                {
                    case 1:
                        this.tbiPhoneIpsw.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPhone_IPSW = spath;
                        break;
                    case 2:
                        this.tbiPhonedmg.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPhone_DMG = spath;
                        break;
                    case 3:
                        this.tbiPadIpsw.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPad_IPSW = spath;
                        break;
                    case 4:
                        this.tbiPadDmg.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPad_DMG = spath;
                        break;
                    case 5:
                        this.tbiPodIpsw.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPod_IPSW = spath;
                        break;
                    case 6:
                        this.tbiPodDmg.Text = spath;
                        iPswCopyTools.Properties.Settings.Default.iPod_DMG = spath;
                        break;
                    default:
                        MessageBox.Show("button tag not found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                Properties.Settings.Default.Save();
            }
        }

        private int CheckSelect()
        {
            int cnt = 0;
            foreach (TreeNode myparentNode in treeView1.Nodes)
            {
                foreach (TreeNode myNode in myparentNode.Nodes)
                {
                    if (myNode.Checked)
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }

        private CountdownEvent _countdownEvent;

        private void CopyFileTask(object obj)
        {
            IPSWInfo info = (IPSWInfo)obj;
            info.COPY();
            _countdownEvent.Signal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _countdownEvent = new CountdownEvent(CheckSelect());
            foreach (TreeNode myparentNode in treeView1.Nodes)
            {
                foreach (TreeNode myNode in myparentNode.Nodes)
                {
                    if (myNode.Checked)
                    {
                        IPSWInfo info = (IPSWInfo)myNode.Tag;
                        info.LOTDMGFolder = tbApstDMG.Text;
                        if (info.DevType == DEVICETYPE.iPhone)
                        {
                            info.DMGFolder = tbiPhonedmg.Text;
                            info.IPSWFolder = tbiPhoneIpsw.Text;
                        }
                        else if (info.DevType == DEVICETYPE.iPad)
                        {
                            info.DMGFolder = tbiPadDmg.Text;
                            info.IPSWFolder = tbiPadIpsw.Text;

                        }
                        else if (info.DevType == DEVICETYPE.iPod)
                        {
                            info.DMGFolder = tbiPodDmg.Text;
                            info.IPSWFolder = tbiPodIpsw.Text;
                        }
                        ThreadPool.QueueUserWorkItem(new WaitCallback(CopyFileTask), info);
                    }
                }
            }

            _countdownEvent.Wait();
            MessageBox.Show("Copy task finished", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (TreeNode myparentNode in treeView1.Nodes)
            {
                foreach (TreeNode myNode in myparentNode.Nodes)
                {
                    IPSWInfo info = (IPSWInfo)myNode.Tag;
                    info.LOTDMGFolder = tbApstDMG.Text;
                    if (info.DevType == DEVICETYPE.iPhone)
                    {
                        info.DMGFolder = tbiPhonedmg.Text;
                        info.IPSWFolder = tbiPhoneIpsw.Text;
                    }
                    else if (info.DevType == DEVICETYPE.iPad)
                    {
                        info.DMGFolder = tbiPadDmg.Text;
                        info.IPSWFolder = tbiPadIpsw.Text;

                    }
                    else if (info.DevType == DEVICETYPE.iPod)
                    {
                        info.DMGFolder = tbiPodDmg.Text;
                        info.IPSWFolder = tbiPodIpsw.Text;
                    }

                    if (info.CheckDMGFolder())
                    {
                        myNode.BackColor = Color.Green;
                        myNode.Checked = false;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (TreeNode myparentNode in treeView1.Nodes)
            {
                foreach (TreeNode myNode in myparentNode.Nodes)
                {
                    if (myNode.Checked)
                    {
                        IPSWInfo info = (IPSWInfo)myNode.Tag;
                        info.LOTDMGFolder = tbApstDMG.Text;
                        if (info.DeleteDMGFolder())
                        {
                            myNode.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }


        private bool _isUpdatingCheckState = false;

        private void UpdateParentCheckedState(TreeNode node)
        {
            if (_isUpdatingCheckState)
            {
                return;
            }
            _isUpdatingCheckState = true;

            // Traverse up the tree
            while (node.Parent != null)
            {
                bool allChildrenChecked = true;
                bool anyChildrenChecked = false;

                // Check if all children are checked, or if any child is checked
                foreach (TreeNode child in node.Parent.Nodes)
                {
                    if (!child.Checked)
                    {
                        allChildrenChecked = false;
                    }
                    if (child.Checked)
                    {
                        anyChildrenChecked = true;
                    }
                }

                // Update parent node's checked state
                if (allChildrenChecked)
                {
                    node.Parent.Checked = true;
                }
                else if (anyChildrenChecked)
                {
                    node.Parent.Checked = false;
                    node.Parent.StateImageIndex = 1;
                }
                else
                {
                    node.Parent.Checked = false;
                    node.Parent.StateImageIndex = 0;
                }

                node = node.Parent;
            }

            _isUpdatingCheckState = false;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown)
            {
                return;
            }

            TreeNode currentNode = e.Node;

            foreach(TreeNode mynode in currentNode.Nodes)
            {
                mynode.Checked = currentNode.Checked;
            }
            if (currentNode.Nodes.Count > 0) return;
            UpdateParentCheckedState(currentNode);
        }
    }
}
