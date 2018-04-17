using System.Collections.Generic;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace Three_Layered_Website_Plus_Wizards
{
    class SetupWizard : IWizard
    {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            var solutionName = replacementsDictionary["$projectname$"];
            var registeredOrganizationName = replacementsDictionary["$registeredorganization$"];
            var setupWiz = new SetupWizardForm(solutionName,registeredOrganizationName);
            var result = setupWiz.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                throw new WizardCancelledException();
            }
            foreach (var setupWizSetupReplacement in setupWiz.SetupReplacements)
            {
                MessageBox.Show(setupWizSetupReplacement.Key + ": " + setupWizSetupReplacement.Value);
                replacementsDictionary.Add(setupWizSetupReplacement.Key,setupWizSetupReplacement.Value);
            }
        }

        public void ProjectFinishedGenerating(Project project)
        {

        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            //This is not called
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            //This is not called
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            //This is not used
        }

        public void RunFinished()
        {

        }
    }
}
