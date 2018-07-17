using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ActivityTable
    {
        private String _username;
        private String _action;
        private String _timestamp;
        public ActivityTable(string argUsername, string argAction, string argTimestamp)
        {
            _username = argUsername;
            _action = argAction;
            _timestamp = argTimestamp;
        }
        public string UserName { get => _username; set => _username = value; }
        public string Action { get => _action; set => _action = value; }
        public string TimeStamp { get => _timestamp; set => _timestamp = value; }
    }
}
