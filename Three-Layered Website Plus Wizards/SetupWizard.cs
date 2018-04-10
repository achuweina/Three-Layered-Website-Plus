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
            var setupWiz = new SetupWizardForm();
            setupWiz.ShowDialog();
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
