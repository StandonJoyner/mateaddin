using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration.Rtd;

namespace mateaddin.RTD
{
    [ComVisible(true)]
    [ProgId(RTDServer.ProgId)]
    internal class RTDServer : ExcelRtdServer
    {
        public const string ProgId = "mate.q";
        protected override bool ServerStart()
        {
            return true;
        }
        protected override void ServerTerminate()
        {
        }
        protected override object ConnectData(Topic topic, IList<string> topicInfo, ref bool newValues)
        {
            return "Hello " + topicInfo[1];
        }
        protected override void DisconnectData(Topic topic)
        {
        }
        protected override int Heartbeat()
        {
            return 1;
        }
    }
}
