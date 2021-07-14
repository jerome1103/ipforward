using System.Net.NetworkInformation;

namespace IPForward
{
    class IPdetail
    {
        PhysicalAddress mac;   //取得Mac Address
        string name;            //網路介面名稱
        string description;    //網路介面描述
        string ip;              //取得IP
        string netmask;         //取得遮罩

        public void nic_into(PhysicalAddress input_mac, string input_name, string input_description, string input_ip, string input_netmask) {
            mac = input_mac;
            name = input_name;
            description = input_description;
            ip = input_ip;
            netmask = input_netmask;
        }
        public string get_value(){
            return "";
        }

    }
}
