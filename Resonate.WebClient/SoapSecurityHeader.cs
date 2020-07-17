using System;
using System.ServiceModel.Channels;
using System.Xml;

namespace Resonate.WebClient
{
    public class SoapSecurityHeader : MessageHeader
    {
        public override string Name { get; } = "AuthInfo";

        public override string Namespace { get; } = "https://www.sebug.ch/secheader.xsd";

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteElementString("authMessage", Namespace, "Hey hey");
        }
    }
}
