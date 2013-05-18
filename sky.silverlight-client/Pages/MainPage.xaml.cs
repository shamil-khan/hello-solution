using Sky.ServiceReference1;
using Sky.ServiceReference2;
using Sky.Services;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows;
using System.Windows.Controls;

namespace Sky.Pages
{
    public partial class MainPage : Page
    {
        string _Responses;

        EchoRiaContext _EchoRiaService;
        EchoWcfServiceClient _EchoWcfService;
        EchoDuplexServiceClient _EchoDuplexService;
        const string _DuplexServicePath = "../services/echo-duplex-service.svc";

        public MainPage()
        {
            InitializeComponent();

            ShowExceptionInWindow(() =>
                {
                    _EchoRiaService = new EchoRiaContext();
                    ButtonEchoRiaService.Click += (s, e) => ShowExceptionInWindow( () => _EchoRiaService.Echo(TextRequest.Text, a => UpdateResponse(a.Value), null));

                    _EchoWcfService = new EchoWcfServiceClient("BasicRelative");
                    _EchoWcfService.EchoCompleted += (s, e) => UpdateResponse(e.Result);
                    ButtonEchoWcfService.Click += (s, e) => _EchoWcfService.EchoAsync(TextRequest.Text);

                    _EchoDuplexService = new EchoDuplexServiceClient(new PollingDuplexHttpBinding(PollingDuplexMode.MultipleMessagesPerPoll), new EndpointAddress(new Uri(_DuplexServicePath, UriKind.Relative)));
                    _EchoDuplexService.ReceiveReceived += (s, e) => UpdateResponse(e.value);
                    _EchoDuplexService.EchoCompleted += (s, e) => UpdateResponse(e.Result);
                    _EchoDuplexService.RegisterCompleted += (s, e) => UpdateResponse("Echo Duplex Service Register Status : " + e.Result.ToString());
                    _EchoDuplexService.UnRegisterCompleted += (s, e) => UpdateResponse("Echo Duplex Service Un-Register Status : " + e.Result.ToString());
                    ButtonEchoDuplexService.Click += (s, e) => ShowExceptionInWindow(() => _EchoDuplexService.EchoAsync(TextRequest.Text));
                    ButtonEchoDuplexServiceRegister.Click += (s, e) => ShowExceptionInWindow(() => _EchoDuplexService.RegisterAsync(TextRequest.Text));
                    ButtonEchoDuplexServiceUnRegister.Click += (s, e) => ShowExceptionInWindow(() => _EchoDuplexService.UnRegisterAsync(TextRequest.Text));
                });
        }

        public void UpdateResponse(string value)
        {
            _Responses = string.Format("<Response>{0}</Response>{1}{2}", value, Environment.NewLine, _Responses);
            TextResponse.Text = string.Format("<Responses>{1}{0}</Responses>", _Responses, Environment.NewLine);
        }

        static void ShowExceptionInWindow(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
