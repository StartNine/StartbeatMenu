//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartbeatMenu.Adapters
{
    
    public class MessageReceivedEventArgsViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageReceivedEventArgsContract
    {
        private StartbeatMenu.Views.MessageReceivedEventArgs _view;
        public MessageReceivedEventArgsViewToContractAddInAdapter(StartbeatMenu.Views.MessageReceivedEventArgs view)
        {
            _view = view;
        }
        public Start9.Api.Contracts.IMessageContract Message
        {
            get
            {
                return StartbeatMenu.Adapters.IMessageAddInAdapter.ViewToContractAdapter(_view.Message);
            }
        }
        internal StartbeatMenu.Views.MessageReceivedEventArgs GetSourceView()
        {
            return _view;
        }
    }
}
