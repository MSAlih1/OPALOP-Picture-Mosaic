﻿using Api._QPR.Type;
using Muuzy.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Api._QPR.abstracts
{
    public class ServerAsyncCallBack
    {
        public Task<SoapServer1.ImageGenerateResponse> _resp1;
        public Task<SoapServer2.ImageGenerateResponse> _resp2;
        public Task<SoapServer3.ImageGenerateResponse> _resp3;
        public Task<SoapServer4.ImageGenerateResponse> _resp4;
        public Task<SoapServer5.ImageGenerateResponse> _resp5;
        public Task<SoapServer6.ImageGenerateResponse> _resp6;
        public Task<SoapServer7.ImageGenerateResponse> _resp7;
        public Task<SoapServer8.ImageGenerateResponse> _resp8;
        public Task<SoapTest.ImageGenerateResponse> _respLocalTest;
        public object resp0, resp1, resp2, resp3, resp4, resp5, resp6, resp7, resp8;
        private SoapServer1.ProcessingSoapClient server1;
        private SoapServer2.ProcessingSoapClient server2;
        private SoapServer3.ProcessingSoapClient server3;
        private SoapServer4.ProcessingSoapClient server4;
        private SoapServer5.ProcessingSoapClient server5;
        private SoapServer6.ProcessingSoapClient server6;
        private SoapServer7.ProcessingSoapClient server7;
        private SoapServer8.ProcessingSoapClient server8;
        private SoapTest.ProcessingSoapClient serverLocalTest;//local
        public ServerAsyncCallBack()
        {
            if (UserProperty.ComputerNumber == 1)
            {
                serverLocalTest = new SoapTest.ProcessingSoapClient();
                serverLocalTest.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
            }
            else
            {
                //
                server1 = new SoapServer1.ProcessingSoapClient();
                server1.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server2 = new SoapServer2.ProcessingSoapClient();
                server2.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server3 = new SoapServer3.ProcessingSoapClient();
                server3.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server4 = new SoapServer4.ProcessingSoapClient();
                server4.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server5 = new SoapServer5.ProcessingSoapClient();
                server5.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server6 = new SoapServer6.ProcessingSoapClient();
                server6.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server7 = new SoapServer7.ProcessingSoapClient();
                server7.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
                //
                server8 = new SoapServer8.ProcessingSoapClient();
                server8.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(90);
            }
        }

        public async void Execute(AsyncCallType typi, params object[] obj)
        {
            switch (typi)
            {
                case AsyncCallType.SelectedInstagramPhotos:
                    if (UserProperty.ComputerNumber == 1)//LOCAL TEST
                    {
                        serverLocalTest.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(),obj[0].ToString());
                        break;
                    }
                    //server1.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server2.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server3.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server4.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server5.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server6.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server7.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    //server8.SelectedInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), obj[0].ToString());
                    break;

                case AsyncCallType.CreateDir:
                    if (UserProperty.ComputerNumber == 1)//LOCAL TEST
                    {
                        serverLocalTest.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                        break;
                    }
                    server1.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server2.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server3.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server4.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server5.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server6.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server7.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server8.CreateDirAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    break;

                case AsyncCallType.CreateXml:
                    if (UserProperty.ComputerNumber == 1)//LOCAL TEST
                    {
                        serverLocalTest.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                        break;
                    }
                    server1.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server2.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server3.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server4.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server5.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server6.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server7.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    server8.CreateXmlAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName());
                    break;

                case AsyncCallType.DownloadInstaPhotos:
                    List<string> potos = (obj[0] as List<string>);
                    if (UserProperty.ComputerNumber == 1)//LOCAL TEST
                    {
                        SoapTest.ArrayOfString tst0 = new SoapTest.ArrayOfString();
                        tst0.AddRange(potos);
                        resp0 = serverLocalTest.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst0);
                        break;
                    }
                    SoapServer1.ArrayOfString tst1 = new SoapServer1.ArrayOfString();
                    tst1.AddRange(potos);
                    resp1 = server1.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst1);
                    //
                    SoapServer2.ArrayOfString tst2 = new SoapServer2.ArrayOfString();
                    tst2.AddRange(potos);
                    resp2 = server2.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst2);
                    //
                    SoapServer3.ArrayOfString tst3 = new SoapServer3.ArrayOfString();
                    tst3.AddRange(potos);
                    resp3 = server3.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst3);
                    //
                    SoapServer4.ArrayOfString tst4 = new SoapServer4.ArrayOfString();
                    tst4.AddRange(potos);
                    resp4 = server4.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst4);
                    //////
                    SoapServer5.ArrayOfString tst5 = new SoapServer5.ArrayOfString();
                    tst5.AddRange(potos);
                    resp5 = server5.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst5);
                    //
                    SoapServer6.ArrayOfString tst6 = new SoapServer6.ArrayOfString();
                    tst6.AddRange(potos);
                    resp6 = server6.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst6);
                    //
                    SoapServer7.ArrayOfString tst7 = new SoapServer7.ArrayOfString();
                    tst7.AddRange(potos);
                    resp7 = server7.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst7);
                    //
                    SoapServer8.ArrayOfString tst8 = new SoapServer8.ArrayOfString();
                    tst8.AddRange(potos);
                    resp8 = server8.DownloadInstaPhotosAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), tst8);
                    break;

                case AsyncCallType.ImageGenerate:
                    List<PartOfImage> Imgs = obj[0] as List<PartOfImage>;
                    int icon = 0;
                    if (UserProperty.ComputerNumber == 1)//LOCAL TEST
                    {
                        _respLocalTest = serverLocalTest.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                        break;
                    }
                    _resp1 = server1.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp2 = server2.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp3 = server3.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp4 = server4.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp5 = server5.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp6 = server6.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp7 = server7.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    icon++;
                    _resp8 = server8.ImageGenerateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), Imgs[icon].Image.ToByteArray(), Imgs[icon].ImagePartInfo.X, Imgs[icon].ImagePartInfo.Y, Imgs[icon].ImagePartInfo.Width, Imgs[icon].ImagePartInfo.Height, int.Parse(obj[1].ToString()));
                    break;

                case AsyncCallType.XmlUpdate:
                    //not necessary
                    //resp1 = server1.XmlUpdateAsync(ImageProperty.GetAccessCode(), ImageProperty.GetUserName(), null, 0, false);
                    break;

                default:
                    break;
            }
        }
    }
}