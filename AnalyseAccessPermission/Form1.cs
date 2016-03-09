using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Collections;

namespace AnalyseAccessPermission
{
    public partial class Form1 : Form
    {

        ArrayList filtered = new ArrayList();
        ArrayList tmpList = new ArrayList();
        Boolean error = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void getgroupsBtn_Click(object sender, EventArgs e)
        {
            addUsers();

            if (error == false)
            {
                if (filtered.Count == 0)
                {
                    foreach (String user in tmpList)
                    {
                        filteredLst.Items.Add(user);
                        filtered.Add(user);
                    }
                }
                else
                {
                    ArrayList same = new ArrayList();
                    ArrayList diff = new ArrayList();

                    foreach (String obj in tmpList)
                    {
                        if (filtered.Contains(obj))
                        {
                            same.Add(obj);
                        }
                        else
                        {
                            diff.Add(obj);
                        }
                    }

                    foreach (String obj in filtered)
                    {
                        if ((!tmpList.Contains(obj)) && (!diff.Contains(obj)))
                        {
                            diff.Add(obj);
                        }
                    }

                    foreach (String obj in diff)
                    {
                        debugLst.Items.Add(DateTime.Now + " - Removed " + obj);
                    }

                    filtered = same;
                    filteredLst.Items.Clear();

                    foreach (String obj in same)
                    {
                        filteredLst.Items.Add(obj);
                    }
                }

                tmpList.Clear();
            }

            error = false;

        }

        private void addUsers()
        {
            if (lsGroup1.Text != "") { addUsers(lsGroup1.Text.ToString()); }
            if (lsGroup2.Text != "") { addUsers(lsGroup2.Text.ToString()); }
            if (lsGroup3.Text != "") { addUsers(lsGroup3.Text.ToString()); }
            if (lsGroup4.Text != "") { addUsers(lsGroup4.Text.ToString()); }
        }

        private void addUsers(string group)
        {
            PrincipalContext pc = new PrincipalContext(ContextType.Domain);
            GroupPrincipal groupObj = GroupPrincipal.FindByIdentity(pc, group);

            if (groupObj == null)
            {
                errorLst.Items.Add(DateTime.Now + " - Cannot find group " + group);
                error = true;
            }
            else
            {
                debugLst.Items.Add(DateTime.Now + " - searched " + group);

                foreach (Principal p in groupObj.GetMembers())
                {
                    UserPrincipal theUser = p as UserPrincipal;
                    GroupPrincipal theGroup = p as GroupPrincipal;

                    if (theUser != null)
                    {
                        if (!(theUser.IsAccountLockedOut()))
                        {
                            if (!tmpList.Contains(p.DisplayName.ToString()))
                            {
                                tmpList.Add(p.DisplayName.ToString());
                            }
                        }
                        else
                        {
                            errorLst.Items.Add(DateTime.Now + " - User " + p.DisplayName + " is locked out");
                        }
                    }
                    if (theGroup != null)
                    {
                        addUsers(theGroup.Name);
                    }
                    
                    if (theGroup == null && theUser == null)
                    {
                        errorLst.Items.Add(DateTime.Now + " - User not found");
                    }
                }
            }
        }
    }
}
