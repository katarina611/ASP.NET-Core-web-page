using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
namespace Telefonski_imenik__Katarina_Jankovic_4_8
{
    public partial class imenik
    {
        private string id;
        private string ime;
        private string prez;
        private string adr;
        private string mesto;
        private string br;
        private string meil;
        public string Id { get { return id; } set { id = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prez; } set { prez = value; } }
        public string Adresa { get { return adr; } set { adr = value; } }
        public string Broj { get { return br; } set { br = value; } }
        public string Mesto { get { return mesto; } set { mesto = value; } }
        public string Mail { get { return meil; } set { meil = value; } }
         public imenik (string id,string ime,string prez,string adr,string mesto, string br,string meil)
        {
            this.id = id;
            this.ime = ime;
            this.prez = prez;
            this.adr = adr;
            this.mesto = mesto;
            this.br = br;
            this.meil = meil;


        }

      
    }
    public partial class Imenik : System.Web.UI.Page
    {
        List<imenik> lista = new List<imenik>();
        List<string> gradovi = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(MapPath(@"~\imenik.txt"), true);
            string s = sr.ReadLine();
            string id, ime, prezime, adresa, mesto, broj, mail;
            while (s != null)
            {
                int p = s.IndexOf("|");
                id = s.Substring(0, p - 1);
                s = s.Substring(p + 2);
                int p2 = s.IndexOf("|");
                ime = s.Substring(0, p2 - 1);
                s = s.Substring(p2 + 2);
                int p3 = s.IndexOf("|");
                prezime = s.Substring(0, p3 - 1);
                s = s.Substring(p3 + 2);
                int p4 = s.IndexOf("|");
                adresa = s.Substring(0, p4 - 1);
                s = s.Substring(p4 + 2);
                int p5 = s.IndexOf("|");
                mesto = s.Substring(0, p5 - 1);
                s = s.Substring(p5 + 2);
                int p6 = s.IndexOf('|');
                broj = s.Substring(0, p6 - 1);

                mail = s.Substring(p6 + 2);
                imenik im = new imenik(id, ime, prezime, adresa, mesto, broj, mail);
                lista.Add(im);


                s = sr.ReadLine();
            }
            if (!Page.IsPostBack)
            {
                foreach (var a in lista)
                {
                    gradovi.Add(a.Mesto);
                }
                foreach (var b in gradovi.Distinct()) DropDownList1.Items.Add(b);

            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string k = TextBox3.Text;
            PlaceHolder1.Controls.Add(new LiteralControl("<table id='korisnici'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr><th>Id</th><th>Ime</th><th>Prezime</th><th>Adresa</th><th>Mesto</th><th>Broj</th><th>E-mail</th></tr>"));
            foreach (var a in lista)
            {
                if (a.Ime.Contains(k))
                {
                    PlaceHolder1.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", a.Id, a.Ime, a.Prezime, a.Adresa, a.Mesto, a.Broj, a.Mail)));
                }
                TextBox3.Focus();
                TextBox3.Attributes["onfocus"] = "javascript:this.setSelectionRange(this.value.length,this.value.length);";
              
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            string k = TextBox4.Text;
            PlaceHolder1.Controls.Add(new LiteralControl("<table id='korisnici'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr><th>Id</th><th>Ime</th><th>Prezime</th><th>Adresa</th><th>Mesto</th><th>Broj</th><th>E-mail</th></tr>"));
            foreach (var a in lista)
            {
                if (a.Prezime.Contains(k))
                {

                    PlaceHolder1.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", a.Id, a.Ime, a.Prezime, a.Adresa, a.Mesto, a.Broj, a.Mail)));
                }
                TextBox3.Focus();
                TextBox3.Attributes["onfocus"] = "javascript:this.setSelectionRange(this.value.length,this.value.length);";
                
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            string k = TextBox5.Text;
            PlaceHolder1.Controls.Add(new LiteralControl("<table id='korisnici'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr><th>Id</th><th>Ime</th><th>Prezime</th><th>Adresa</th><th>Mesto</th><th>Broj</th><th>E-mail</th></tr>"));
                foreach (var a in lista)
            {
                if (a.Adresa.Contains(k))
                {

                    PlaceHolder1.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", a.Id, a.Ime, a.Prezime, a.Adresa, a.Mesto, a.Broj, a.Mail)));
                }
                TextBox3.Focus();
                TextBox3.Attributes["onfocus"] = "javascript:this.setSelectionRange(this.value.length,this.value.length);";
              
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {
            string k = TextBox7.Text;
            PlaceHolder1.Controls.Add(new LiteralControl("<table id='korisnici'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr><th>Id</th><th>Ime</th><th>Prezime</th><th>Adresa</th><th>Mesto</th><th>Broj</th><th>E-mail</th></tr>"));
            foreach (var a in lista)
            {
                if (a.Broj.Contains(k))
                {

                    PlaceHolder1.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", a.Id, a.Ime, a.Prezime, a.Adresa, a.Mesto, a.Broj, a.Mail)));
                }
                TextBox3.Focus();
                TextBox3.Attributes["onfocus"] = "javascript:this.setSelectionRange(this.value.length,this.value.length);";
               
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string k = DropDownList1.SelectedValue.ToString();
            PlaceHolder1.Controls.Add(new LiteralControl("<table id='korisnici'>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<tr><th>Id</th><th>Ime</th><th>Prezime</th><th>Adresa</th><th>Mesto</th><th>Broj</th><th>E-mail</th></tr>"));
            foreach (var a in lista)
            {
                if (a.Mesto.Contains(k))
                {

                    PlaceHolder1.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", a.Id, a.Ime, a.Prezime, a.Adresa, a.Mesto, a.Broj, a.Mail)));
                }
              
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Vazni telefoni.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Korisnicko uputsvo.aspx");
        }
    }
}