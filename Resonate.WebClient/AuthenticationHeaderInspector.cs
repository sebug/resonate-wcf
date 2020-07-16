using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Resonate.WebClient
{
    public class AuthenticationHeaderInspector : IClientMessageInspector
    {
        public AuthenticationHeaderInspector()
        {
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            request.Headers.Add(new SoapSecurityHeader());

            return null;
        }
    }
}
