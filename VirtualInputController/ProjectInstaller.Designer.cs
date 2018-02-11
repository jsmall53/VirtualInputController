namespace VirtualInputController
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VirtualInputControllerProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.VirtualInputControllerInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // VirtualInputControllerProcessInstaller
            // 
            this.VirtualInputControllerProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.VirtualInputControllerProcessInstaller.Password = null;
            this.VirtualInputControllerProcessInstaller.Username = null;
            // 
            // VirtualInputControllerInstaller
            // 
            this.VirtualInputControllerInstaller.Description = "Virtual Input Controller";
            this.VirtualInputControllerInstaller.DisplayName = "Virtual Input Controller";
            this.VirtualInputControllerInstaller.ServiceName = "VirtualInputController";
            this.VirtualInputControllerInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.VirtualInputControllerProcessInstaller,
            this.VirtualInputControllerInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller VirtualInputControllerProcessInstaller;
        private System.ServiceProcess.ServiceInstaller VirtualInputControllerInstaller;
    }
}