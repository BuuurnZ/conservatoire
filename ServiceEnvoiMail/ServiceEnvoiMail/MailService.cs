using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading;

namespace ServiceEnvoiMail
{
    public partial class MailService : ServiceBase
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        public MailService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
          
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 60000; //very important!
                                    //(60 seconds with minutes and 60 minutes with hours)params
            timer.Enabled = true;


        }

        protected override void OnStop()
        {
            this.Stop();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            DateTime d = DateTime.Now;
            if (d.Month == 4 && d.Day == 12 && d.Hour == 11 && d.Minute == 20)
            {
                MailMessage message = new MailMessage("@mailExpediteur", "@mailDestinataire", "objet", "message");

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                NetworkCredential nc = new NetworkCredential("tonAdresseMail", "tonMotDePasse");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
        


    }
}
