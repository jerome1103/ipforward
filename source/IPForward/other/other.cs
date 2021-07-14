//擷取網路
/*
        if (adapter.NetworkInterfaceType.ToString().Equals("Ethernet"))
                {
                    //取得IPInterfaceProperties(可提供網路介面相關資訊)
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                    if (ipProperties.UnicastAddresses.Count > 0)
                    {
                        //PhysicalAddress mac = adapter.GetPhysicalAddress();                     //取得Mac Address
                        string name = adapter.Name;                                             //網路介面名稱
                        string description = adapter.Description;                               //網路介面描述
                        //string ip = ipProperties.UnicastAddresses[0].Address.ToString();        //取得IP
                        //string netmask = ipProperties.UnicastAddresses[0].IPv4Mask.ToString();  //取得遮罩
                        //MessageBox.Show("name:" + name + "\r" + "description:" + description + "\r"+ "ip:" + ip + "\r" + "netmask:" + netmask);
                        if (description.IndexOf("Microsoft KM-TEST Loopback Adapter") == 0)
                        {
                            loopbackAdapter.Add(name);
                        }
                    }
                }
    }

*/