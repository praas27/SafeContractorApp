using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SafeContractorApp.Properties;

namespace SafeContractorApp
{
    internal class PdfVergunning
    {
        public static void GenDoc(int vergunningId)
        {
            string korte_omschrijving = "";
            string gedetaileerde_omschrijving = "";
            string optie = "";
            string extra_uitrustingen = "";
            string start_datum = "";
            string eind_datum = "";
            int aantal_peronen = 0;

            int firma_id = 0;
            string firma_naam = "";

            int werknemer_id = 0;
            string werknemer_naam = "";
            string datum_examen = "";
            string gsm_nummer_werknemer = "";

            int opdrachtgever_id = 0;
            string opdrachtgever_naam = "";
            string gsm_nummer_opdrachtgever = "";

            int voertuig_id = 0;
            string voertuig_naam = "";
            string merk = "";

            int site_id = 0;
            string site_naam = "";
            string siteverantwoordelijke = "";
            string gsm_nummer_site = "";
            string noodnummer = "";

            string query = "SELECT * FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", vergunningId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    korte_omschrijving = reader["korte_omschrijving"].ToString();
                    start_datum = reader["start_datum"].ToString().Substring(0,10);
                    eind_datum = reader["eind_datum"].ToString().Substring(0,10);
                    optie = reader["optie"].ToString();
                    extra_uitrustingen = reader["extra_uitrustingen"].ToString();
                    gedetaileerde_omschrijving = reader["gedetaileerde_omschrijving"].ToString();
                    aantal_peronen = int.Parse(reader["aantal_personen"].ToString());
                    firma_id = int.Parse(reader["firma_firma_id"].ToString());
                    werknemer_id = int.Parse(reader["werknemers_werknemer_id"].ToString());
                    opdrachtgever_id = int.Parse(reader["opdrachtgevers_opdrachtgever_id"].ToString());
                    voertuig_id = int.Parse(reader["voertuigen_voertuig_id"].ToString());
                    site_id = int.Parse(reader["sites_site_id"].ToString());
                    
                }
                connection.Close();
            }

            query = "SELECT * FROM firma where firma_id=@firma_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firma_id", firma_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    firma_naam = reader["firma_naam"].ToString();
                }
                connection.Close();
            }

            query = "SELECT * FROM werknemers where werknemer_id=@werknemer_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werknemer_id", werknemer_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    werknemer_naam = reader["werknemer_naam"].ToString();
                    datum_examen = reader["datum_examen"].ToString().Substring(0,10);
                    gsm_nummer_werknemer = reader["gsm_nummer"].ToString();
                    Globaal.uitvoerder = werknemer_naam;
                }
                connection.Close();
            }

            query = "SELECT * FROM opdrachtgevers where opdrachtgever_id=@opdrachtgever_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@opdrachtgever_id", opdrachtgever_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    opdrachtgever_naam = reader["opdrachtgever_naam"].ToString();
                    gsm_nummer_opdrachtgever = reader["gsm_nummer"].ToString();
                    Globaal.opdrachtgever = opdrachtgever_naam;
                }
                connection.Close();
            }

            query = "SELECT * FROM voertuigen where voertuig_id=@voertuig_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@voertuig_id", voertuig_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    voertuig_naam = reader["voertuig_naam"].ToString();
                    merk = reader["merk"].ToString();
                }
                connection.Close();
            }

            query = "SELECT * FROM sites where site_id=@site_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@site_id", site_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    site_naam = reader["site_naam"].ToString();
                    siteverantwoordelijke = reader["siteverantwoordelijke"].ToString();
                    gsm_nummer_site = reader["gsm_nummer"].ToString();
                    noodnummer = reader["noodnummer"].ToString();
                    Globaal.noodnummer = noodnummer;
                }
                connection.Close();
            }

            //crete page
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //
            int marge = 30;
            XFont titele = new XFont("Calibri", 25);
            XFont font_antw = new XFont("Calibri", 11);
            XFont font_sub = new XFont("Calibri", 11, XFontStyle.Bold);
            XFont font_Titel = new XFont("Calibri", 20, XFontStyle.Bold);
            XPen line = new XPen(XColors.Black, 0.5);

            XImage logo = XImage.FromFile($@"{Properties.Settings.Default.Images}\logo.png");
            XImage belgium = XImage.FromFile($@"{Properties.Settings.Default.Images}\belgium.png");
            XImage france = XImage.FromFile($@"{Properties.Settings.Default.Images}\france.png");
            XImage germany = XImage.FromFile($@"{Properties.Settings.Default.Images}\germany.png");
            XImage uk = XImage.FromFile($@"{Properties.Settings.Default.Images}\united-kingdom.png");
            XImage parking = XImage.FromFile($@"{Properties.Settings.Default.Images}\parking.png");
            XImage telephone = XImage.FromFile($@"{Properties.Settings.Default.Images}\telephone.png");
            XImage aid = XImage.FromFile($@"{Properties.Settings.Default.Images}\first-aid.png");

            gfx.DrawString("DESOTEC WERKVERGUNNING", titele, XBrushes.Black, marge, 50);
            gfx.DrawImage(logo, new XRect(400, -5,logo.Width/6, logo.Height/6));

            gfx.DrawImage(belgium, new XRect(marge, 80, belgium.Width, belgium.Height));
            gfx.DrawString("Detailomschrijving", font_sub, XBrushes.Black, marge,160);
            gfx.DrawString("van de uit te voeren", font_sub, XBrushes.Black, marge,170);
            gfx.DrawString("werken", font_sub, XBrushes.Black, marge, 180);

            double f = 133.75;
            gfx.DrawImage(france, new XRect(marge+f, 80, france.Width, france.Height));
            gfx.DrawString("Description détaillée", font_sub, XBrushes.Black, marge+f, 160);
            gfx.DrawString("des travaux à", font_sub, XBrushes.Black, marge+f, 170);
            gfx.DrawString("effecteur", font_sub, XBrushes.Black, marge+f, 180);

            double g = 267.5;
            gfx.DrawImage(germany, new XRect(marge+g, 80, germany.Width, germany.Height));
            gfx.DrawString("Detailbeschreibung", font_sub, XBrushes.Black, marge+g, 160);
            gfx.DrawString("der auszufuhrenden", font_sub, XBrushes.Black, marge+g, 170);
            gfx.DrawString("airbeiten", font_sub, XBrushes.Black, marge+g, 180);

            double u = 401.25;
            gfx.DrawImage(uk, new XRect(marge+u, 80, uk.Width, uk.Height));
            gfx.DrawString("Detail description of", font_sub, XBrushes.Black, marge+u, 160);
            gfx.DrawString("the works to be", font_sub, XBrushes.Black, marge+u, 170);
            gfx.DrawString("performed", font_sub, XBrushes.Black, marge+u, 180);


            gfx.DrawString("Korte Omschrijving:", font_sub, XBrushes.Black, marge+20, 250);

            gfx.DrawString(korte_omschrijving, font_antw, XBrushes.Black, marge + 120, 250);

            gfx.DrawString("Uitvoerder", font_sub, XBrushes.Black, marge, 280);
            gfx.DrawString("Bedrijfsnaam", font_sub, XBrushes.Black, marge, 300);
            gfx.DrawString("Nummerplaat", font_sub, XBrushes.Black, marge, 320);
            gfx.DrawString("Plaats", font_sub, XBrushes.Black, marge, 340);
            gfx.DrawString("Verantwoordelijke", font_sub, XBrushes.Black, marge, 360);
            gfx.DrawString("Start datum", font_sub, XBrushes.Black, marge, 380);
            gfx.DrawString("Eind datum", font_sub, XBrushes.Black, marge, 400);
            gfx.DrawString("Aantal_peronen", font_sub, XBrushes.Black, marge, 420);

            int lsd = 120;
            gfx.DrawString(werknemer_naam, font_antw, XBrushes.Black, marge+lsd, 280);
            gfx.DrawString(firma_naam, font_antw, XBrushes.Black, marge+lsd, 300);
            gfx.DrawString(voertuig_naam, font_antw, XBrushes.Black, marge+lsd, 320);
            gfx.DrawString(site_naam, font_antw, XBrushes.Black, marge+lsd, 340);
            gfx.DrawString(siteverantwoordelijke, font_antw, XBrushes.Black, marge+lsd, 360);
            gfx.DrawString(start_datum, font_antw, XBrushes.Black, marge+lsd, 380);
            gfx.DrawString(eind_datum, font_antw, XBrushes.Black, marge + lsd, 400);
            gfx.DrawString(""+aantal_peronen, font_antw, XBrushes.Black, marge + lsd, 420);

            gfx.DrawString("Mogelijke gevaren / voorzorgmaatregelen / toelatingen:", font_sub, XBrushes.Black, marge, 440);
            gfx.DrawString("Extra uitrustingen: ", font_sub, XBrushes.Black, marge,540);
            gfx.DrawString("Gedetailleerde Omschrijving", font_sub, XBrushes.Black, marge,640);


            string[] mogelijk = Globaal.FormatText(optie, font_antw, marge);
            int mogelijkStart = 460;
            for (int i = 0; i < mogelijk.Length; i++)
            {
                gfx.DrawString(mogelijk[i], font_antw, XBrushes.Black, marge, mogelijkStart);
                mogelijkStart= mogelijkStart + 10;
            }
            string[] extra = Globaal.FormatText(extra_uitrustingen, font_antw, marge);
            int extraStart = 560;
            for (int i = 0;i < extra.Length;i++)
            {
                gfx.DrawString(extra[i], font_antw, XBrushes.Black, marge, extraStart);
                extraStart= extraStart + 10;
            }
            string[] omscheijving = Globaal.FormatText(gedetaileerde_omschrijving, font_antw, marge);
            int omscheijvingStart = 660;
            for (int i = 0; i<omscheijving.Length; i++) 
            {
                gfx.DrawString(omscheijving[i], font_antw, XBrushes.Black, marge, omscheijvingStart);
                omscheijvingStart = omscheijvingStart + 10;
            }

            gfx.DrawString("Handtekening opdrachtgever:", font_sub, XBrushes.Black, marge, 750);
            gfx.DrawString("Handtekening uitvoerder:", font_sub, XBrushes.Black, marge+170, 750);
            gfx.DrawString("Handtekening preventieadviseur:", font_sub, XBrushes.Black, marge+320, 750);

            PdfPage page2 = doc.AddPage();
            XGraphics gfx2 = XGraphics.FromPdfPage(page2);

            gfx2.DrawLine(line, 100, 120, page.Width-100, 120);

            gfx2.DrawLine(line, 100, 140, page.Width - 100, 140);
            gfx2.DrawLine(line, 100, 160, page.Width - 100, 160);

            gfx2.DrawLine(line, 100, 200, page.Width - 100, 200);
            gfx2.DrawLine(line, 100, 240, page.Width - 100, 240);

            gfx2.DrawLine(line, 100, 320, page.Width - 100, 320);

            gfx2.DrawLine(line, 220, 120, 220, 240);

            gfx2.DrawLine(line, 100, 120,100, 500);
            gfx2.DrawLine(line, page.Width - 100, 120, page.Width - 100, 500);

            gfx2.DrawLine(line, 100, 500, page.Width - 100, 500);

            gfx2.DrawImage(logo, new XRect(400, -5, logo.Width / 6, logo.Height / 6));

            gfx2.DrawImage(parking, new XRect(20, 20, parking.Width, parking.Height));

            gfx2.DrawImage(aid, new XRect(105, 245, aid.Width, aid.Height));
            gfx2.DrawImage(telephone, new XRect(page.Width - 170, 245, telephone.Width, telephone.Height));

            gfx2.DrawString("Datum geldig", font_antw, XBrushes.Black, 120, 135);
            gfx2.DrawString("Firma", font_antw, XBrushes.Black, 120, 155);
            gfx2.DrawString("GSM nummer", font_antw, XBrushes.Black, 120, 180);
            gfx2.DrawString("Contractor", font_antw, XBrushes.Black, 120, 190);
            gfx2.DrawString("Telefoonnummer en", font_antw, XBrushes.Black, 120, 215);
            gfx2.DrawString("Contactpersoon", font_antw, XBrushes.Black, 120, 225);
            gfx2.DrawString("Desotec", font_antw, XBrushes.Black, 120, 235);
            gfx2.DrawString("Itern noodnummer", font_sub, XBrushes.Black, 260, 250);
            gfx2.DrawString("Desotec Divsie panels", font_sub, XBrushes.Black, 260, 260);

            gfx2.DrawString(start_datum +" tot "+eind_datum, font_antw, XBrushes.Black, 250, 135);
            gfx2.DrawString(firma_naam, font_antw, XBrushes.Black, 250, 155);
            gfx2.DrawString(werknemer_naam, font_antw, XBrushes.Black, 250, 180);
            gfx2.DrawString(gsm_nummer_werknemer, font_antw, XBrushes.Black, 250, 190);
            gfx2.DrawString(gsm_nummer_opdrachtgever, font_antw, XBrushes.Black, 250, 215);
            gfx2.DrawString(opdrachtgever_naam, font_antw, XBrushes.Black, 250, 225);
            gfx2.DrawString(site_naam, font_antw, XBrushes.Black, 260, 270);
            gfx2.DrawString(gsm_nummer_site, font_Titel, XBrushes.Red, 260, 290);

            gfx2.DrawString("1. Het voertuig dient binnen de aangeduide parkeervakken te worden", font_antw, XBrushes.Black, 125, 330);
            gfx2.DrawString("   geplaatst.", font_antw, XBrushes.Black, 125, 340);
            gfx2.DrawString("2. Indien bij uitzondering geen duidelijke parkeervakken aanwezig zijn, moet", font_antw, XBrushes.Black, 125, 360);
            gfx2.DrawString("   het voertuig zo geplaatst wordendat het geen gevaar of hinder vormt voor", font_antw, XBrushes.Black, 125, 370);
            gfx2.DrawString("   andere voertuigen of de werking/doorgang van personeelsleden.", font_antw, XBrushes.Black, 125, 380);
            gfx2.DrawString("3. Laden en lossen aan poorten en ingangen is toegestaan, mits minimaliseren", font_antw, XBrushes.Black, 125, 400);
            gfx2.DrawString("   voertuig op de parkeerplaats wordt gezet.", font_antw, XBrushes.Black, 125, 410);
            gfx2.DrawString("4. Deze P-kaart moet goed zichtbaar aan de vooruit van het voertuig worden ", font_antw, XBrushes.Black, 125, 430);
            gfx2.DrawString("   geplaatst.", font_antw, XBrushes.Black, 125, 440);
            gfx2.DrawString("5. Telefoonummer moet door bestuurder worden ingevuld.", font_antw, XBrushes.Black, 125, 460);
            gfx2.DrawString("6. Bij X aantal waarschuwingen kan de toegang met het voertuig geweigerd", font_antw, XBrushes.Black, 125, 480);
            gfx2.DrawString("   worden.", font_antw, XBrushes.Black, 125, 490);

            doc.Save($"{Properties.Settings.Default.Work}/vergunning_{vergunningId}.pdf");
        }
    }
}
