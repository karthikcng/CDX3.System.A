using System.Runtime.Serialization;

namespace CDX3.System.A.IO
{
    public class Cl_feature_OP
    {
        [DataMember]
        public string ConcatenatedOutput { get; set; }

        public Cl_feature_OP()
        {
            ConcatenatedOutput = string.Empty;
        }
        public void ConcatenateInputData(Cl_feature_IP ip)
        {
            ConcatenatedOutput = $"{ip.user_id} {ip.tenant_code} {ip.system_code} {ip.name}";
        }
    }
}
