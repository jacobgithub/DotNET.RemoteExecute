namespace DotNET.RemoteExecute
{
    public class StartAsRemote
    {
        private string procName;
        public string ProcName
        {
            get { return procName; }
            set { procName = value; }
        }
        public StartAsRemote(string procName)
        {
            this.procName = procName;
        }
        public void WithAll()
        {
            // Try WMI
            // Try PSExec
            // Try Scheduled Task API
        }
        public void WithWMI()
        {
        }
        public void WithPSExec()
        {
        }
        public void WithSchTaskAPI()
        {
        }
    }
}
