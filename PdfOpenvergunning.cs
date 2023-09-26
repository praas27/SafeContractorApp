using MySql.Data.MySqlClient;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeContractorApp
{
    internal class PdfOpenvergunning
    {
        public static void GenDoc(int vergunningId)
        {
            int open_vergunning_id = 0;
            string datum = string.Empty;
            string start_time = string.Empty;
            string end_time = string.Empty;
            string afdeling = string.Empty;
            string leiding = string.Empty;
            string product = string.Empty;
            string werkbeschrijving = string.Empty;
            string kopie = string.Empty;
            string uitvoerder = string.Empty;
            int werknemer_id = 0;

            string query = "SELECT open_vergunning_open_vergunning_id,werknemers_werknemer_id FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", vergunningId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    open_vergunning_id = int.Parse(reader["open_vergunning_open_vergunning_id"].ToString());
                    werknemer_id = int.Parse(reader["werknemers_werknemer_id"].ToString());
                }
                connection.Close();
            }

            query = "SELECT * FROM open_vergunning where open_vergunning_id=@open_vergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@open_vergunning_id", open_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    datum = reader["datum"].ToString();
                    start_time = reader["start_time"].ToString();
                    end_time = reader["eind_time"].ToString();
                    afdeling = reader["afdeling"].ToString();
                    leiding = reader["leiding"].ToString();
                    product = reader["product"].ToString();
                    werkbeschrijving = reader["werkbeschrijving"].ToString();
                    kopie = reader["kopie"].ToString();
                    uitvoerder = reader["uitvoerder"].ToString();
                    datum = datum.Length > 9 ? datum.Substring(0, 10) : datum;
                    start_time = start_time.Length > 4 ? start_time.Substring(0, 5) : start_time;
                    end_time = end_time.Length > 4 ? end_time.Substring(0, 5) : end_time;
                }
                connection.Close();
            }

            //crete page
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            page.Orientation = PageOrientation.Landscape;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            //
            int margeX = 30;
            int margeY = 30;
            XFont titele = new XFont("Calibri", 25);
            XFont font_antw = new XFont("Calibri", 11);
            XFont font_sub = new XFont("Calibri", 11, XFontStyle.Bold);
            XFont font3 = new XFont("Calibri", 15, XFontStyle.Bold);
            XFont font_Titel = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont font5 = new XFont("Bodoni MT", 11);
            XPen line = new XPen(XColors.Black, 0.5);
            XPen darkLine = new XPen(XColors.Black, 2);

            //box 1
            gfx.DrawLine(darkLine, margeX, margeY, margeX+300, margeY);
            gfx.DrawLine(darkLine, margeX, margeY+60, margeX + 300, margeY+60);
            gfx.DrawLine(darkLine, margeX, margeY, margeX, margeY+60);
            gfx.DrawLine(darkLine, margeX + 300, margeY, margeX + 300, margeY + 60);
            //
            gfx.DrawLine(line, margeX+60, margeY, margeX+60, margeY + 60);
            gfx.DrawLine(line, margeX + 300-60, margeY, margeX + 300-60, margeY + 60);
            //text 1
            gfx.DrawString("1", titele, XBrushes.Black, margeX + 20, margeY+40);
            gfx.DrawString("OPENEN VAN", font_Titel, XBrushes.Black, margeX + 87, margeY+25);
            gfx.DrawString("LEIDINGEN", font_Titel, XBrushes.Black, margeX + 100, margeY+45);


            //box2
            gfx.DrawLine(darkLine, margeX, margeY+80, margeX+300, margeY+80);
            gfx.DrawLine(darkLine, margeX, margeY + 120, margeX + 300, margeY + 120);
            gfx.DrawLine(darkLine, margeX, margeY+80, margeX, margeY + 120);
            gfx.DrawLine(darkLine, margeX + 300, margeY+80, margeX + 300, margeY + 120);
            //
            gfx.DrawLine(line, margeX + 150, margeY+80, margeX + 150, margeY + 120);
            //text 2
            gfx.DrawString("Naam van de uitvoerder: ", font_sub, XBrushes.Black, margeX+5, 130);
            gfx.DrawString(Globaal.uitvoerder, font_antw, XBrushes.Black, margeX +5, 140);
            gfx.DrawString("datum: ", font_sub, XBrushes.Black, margeX + 155, 130);
            gfx.DrawString(datum, font_antw, XBrushes.Black, margeX + 195, 130);
            gfx.DrawString("Start: ", font_sub, XBrushes.Black, margeX + 155, 140);
            gfx.DrawString(start_time, font_antw, XBrushes.Black, margeX + 185, 140);
            gfx.DrawString("Stop: ", font_sub, XBrushes.Black, margeX + 215, 140);
            gfx.DrawString(end_time, font_antw, XBrushes.Black, margeX + 245, 140);

            //box3
            gfx.DrawLine(darkLine, margeX, margeY + 140, margeX + 300, margeY + 140);
            gfx.DrawLine(darkLine, margeX, margeY + 400, margeX + 300, margeY + 400);
            gfx.DrawLine(darkLine, margeX, margeY + 140, margeX, margeY + 400);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 140, margeX + 300, margeY + 400);
            //
            gfx.DrawLine(line, margeX, margeY + 160, margeX + 300, margeY + 160);
            gfx.DrawLine(line, margeX, margeY + 275, margeX + 300, margeY + 275);
            gfx.DrawLine(line, margeX, margeY + 350, margeX + 300, margeY + 350);
            gfx.DrawLine(line, margeX + 150, margeY + 350, margeX + 150, margeY + 400);
            //text 3
            gfx.DrawString("OMSCHRIJVING", font3, XBrushes.Black, margeX + 110, 185);
            gfx.DrawString("Afdeling : ", font_sub, XBrushes.Black, margeX + 5, 210);
            gfx.DrawString("Leiding : ", font_sub, XBrushes.Black, margeX + 5, 230);
            gfx.DrawString("Product : ", font_sub, XBrushes.Black, margeX + 5, 250);
            gfx.DrawString(afdeling, font_antw, XBrushes.Black, margeX + 100, 210);
            gfx.DrawString(leiding, font_antw, XBrushes.Black, margeX + 100, 230);
            char[] productNr = product.ToCharArray();
            int x = 100;
            int y = 250;
            for (int i = 0; i < productNr.Length; i++)
            {
                if (productNr[i] == '1')
                {
                    gfx.DrawString("Ontvlambaar", font_antw, XBrushes.Black, margeX + x, y);
                    y = y + 10;
                }
                if (productNr[i] == '2')
                {
                    gfx.DrawString("Bijtend voor huid", font_antw, XBrushes.Black, margeX + x, y);
                    y = y + 10;
                }
                if (productNr[i] == '3')
                {
                    gfx.DrawString("Risico voor gezondheid", font_antw, XBrushes.Black, margeX + x, y);
                    y = y + 10;
                }
                if (productNr[i] == '4')
                {
                    gfx.DrawString("Risico voor geurhinder", font_antw, XBrushes.Black, margeX + x, y);
                    y = y + 10;
                }
            }
            gfx.DrawString("Werkbeschrijving :", font_sub, XBrushes.Black, margeX + 5, 320);
            string[] werkbeschrij = Globaal.FormatTextTwo($"{werkbeschrijving}", font_antw, 290);
            int werkStat = 330;
            for (int i = 0; i < werkbeschrij.Length; i++)
            {
                gfx.DrawString(werkbeschrij[i], font_antw, XBrushes.Black, margeX + 5, werkStat);
                werkStat = werkStat + 10;
            }
            //
            gfx.DrawString("Origineel bestemd voor :", font_sub, XBrushes.Black, margeX + 5, 400);
            if (uitvoerder == "1")
            {
                gfx.DrawString("Uitvoerder", font_antw, XBrushes.Black, margeX + 5, 410);
            }
            gfx.DrawString("Kopie aan :", font_sub, XBrushes.Black, margeX + 155, 400);
            char[] kopeNr = kopie.ToCharArray();
            y = 410;
            for (int i = 0; i < kopeNr.Length; i++)
            {
                if (kopeNr[i] == '1')
                {
                    gfx.DrawString("Preventiedienst", font_antw, XBrushes.Black, margeX + 155, y);
                    y = y + 10;
                }
                if (kopeNr[i] == '2')
                {
                    gfx.DrawString("Betrokken controlekamer", font_antw, XBrushes.Black, margeX + 155, y);
                    y = y + 10;
                }
            }

            //box4
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX + 300, margeY + 420);
            gfx.DrawLine(darkLine, margeX, margeY + 490, margeX + 300, margeY + 490);
            gfx.DrawLine(darkLine, margeX, margeY + 420, margeX, margeY + 490);
            gfx.DrawLine(darkLine, margeX + 300, margeY + 420, margeX + 300, margeY + 490);
            //
            gfx.DrawLine(line, margeX + 100, margeY + 420, margeX + 100, margeY + 490);
            gfx.DrawLine(line, margeX + 200, margeY + 420, margeX + 200, margeY + 490);
            gfx.DrawLine(line, margeX + 300, margeY + 420, margeX + 300, margeY + 490);
            //text 4
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 5, 460);
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 105, 460);
            gfx.DrawString("Handtekening", font_sub, XBrushes.Black, margeX + 205, 460);
            gfx.DrawString("UITVOERDER", font_sub, XBrushes.Black, margeX + 5, 470);
            gfx.DrawString("OPDRACHTGEVER", font_sub, XBrushes.Black, margeX + 105, 470);
            gfx.DrawString("PREVENTIEDIENST", font_sub, XBrushes.Black, margeX + 205, 470);

            //box5
            gfx.DrawLine(darkLine, margeX+300+margeX, margeY, page.Width - margeX, margeY);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 400, page.Width - margeX, margeY + 400);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY, margeX + 300 + margeX, margeY + 400);
            gfx.DrawLine(darkLine, page.Width - margeX, margeY, page.Width - margeX, margeY + 400);
            //
            gfx.DrawLine(line, margeX + 300 + margeX, margeY+20, page.Width - margeX, margeY+20);
            //text 5
            gfx.DrawString("TE NEMEN MAATREGELEN", font3, XBrushes.Black, margeX + 460, margeY+15);
            int maatStart = 70; ;
            query = "select maatregel,extra from maatregelen_has_open_vergunning " +
                "inner join maatregelen on maatregelen_has_open_vergunning_id=maatregelen_id " +
                "where open_vergunning_open_vergunning_id=@open_vergunning_open_vergunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@open_vergunning_open_vergunning_id", open_vergunning_id);
                MySqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                    string[] schrijf = Globaal.FormatTextTwo($"{count}. {reader["maatregel"].ToString()} {reader["extra"].ToString()}", font_antw, 447);
                    for (int i = 0; i < schrijf.Length; i++)
                    {
                        gfx.DrawString(schrijf[i], font_antw, XBrushes.Black, margeX + 335, maatStart);
                        if(i+1< schrijf.Length)maatStart = maatStart + 10;
                    }
                    maatStart = maatStart + 20;
                }
                connection.Close();
            }

            //box6
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 420, page.Width - margeX, margeY + 420);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY + 490, page.Width - margeX, margeY + 490);
            gfx.DrawLine(darkLine, margeX + 300 + margeX, margeY+420, margeX + 300 + margeX, margeY + 490);
            gfx.DrawLine(darkLine, page.Width - margeX, margeY+420, page.Width - margeX, margeY + 490);
            gfx.DrawString("ONGEVAL                 Preventiedienst", font_Titel, XBrushes.Black, margeX + 355, 480);
            gfx.DrawString($"BRAND                      {Globaal.noodnummer}", font_Titel, XBrushes.Black, margeX + 355, 500);

            doc.Save($"{Properties.Settings.Default.Work}/open_vergunning_{open_vergunning_id}.pdf");
        }
    }
}
