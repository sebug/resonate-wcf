using System;
using System.ServiceModel.Channels;
using System.Xml;

namespace Resonate.WebClient
{
    public class SoapSecurityHeader : MessageHeader
    {
        public SoapSecurityHeader()
        {
        }

        public override string Name { get; } = "AuthInfo";

        public override string Namespace { get; } = "https://www.sebug.ch/secheader.xsd";

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteStartElement("authMessage", Namespace);
            writer.WriteValue("Hey Hey");
            writer.WriteEndElement();
        }

        protected override void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteStartElement("authouter", Name, Namespace);
            writer.WriteXmlnsAttribute("authouter", Namespace);
        }
    }
}
