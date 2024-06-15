﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminAddTenant : UserControl
    {
        public adminAddTenant()
        {
            InitializeComponent();
        }
        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void addTenant()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tenant (firstName, lastName, email, phoneNumber, moveInDate, roomID, rentPayment) VALUES (@firstName, @lastName, @email, @phoneNumber, @moveInDate, @roomNumber, @rentPayment)", Connection.conn);
                if (Regex.IsMatch(numBox.Text, @"^[0-9]+$"))
                {

                }
                else
                {
                    MessageBox.Show("Please input number only.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", numBox.Text);
                cmd.Parameters.AddWithValue("@moveInDate", moveInBox.Value.ToString());
                cmd.Parameters.AddWithValue("@roomNumber", int.Parse(unitBox.Text));
                cmd.Parameters.AddWithValue("@rentPayment", rentBox.Text);
                MessageBox.Show("Add Tenant Success.", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand checkRoomCmd = new SqlCommand("SELECT status FROM Room WHERE roomID = @roomID", Connection.conn);
                checkRoomCmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));

                SqlDataReader read = checkRoomCmd.ExecuteReader();

                while (read.Read())
                {
                    if (read.GetValue(0).ToString() == "Vacant")
                    {
                        read.Close();

                        SqlCommand updateRoomCmd = new SqlCommand("UPDATE Room SET status = 'Occupied' WHERE roomID = @roomID", Connection.conn);
                        updateRoomCmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
                        updateRoomCmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        if (rentBox.Text.ToLower() == "quarterly")
                        {
                            addTransactionQuarterly();
                        }else if (rentBox.Text.ToLower() == "monthly")
                        {
                            addTransactionMonthly();
                        }

                        MessageBox.Show("Adding tenant success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        firstNameBox.Text = "";
                        lastNameBox.Text = "";
                        emailBox.Text = "";
                        numBox.Text = "";
                        moveInBox.Value = DateTime.Now;
                        unitBox.Text = "";
                        rentBox.Text = "";
                        statusBox.Text = "";

                        return;
                    }
                    else if (read.GetValue(0).ToString() == "Occupied")
                    {
                        MessageBox.Show("This room is occupied! Please find another room.", "Occupied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        read.Close();
                        return;
                    }
                    else if (read.GetValue(0).ToString() == "Not Available")
                    {
                        MessageBox.Show("This room is not available! Please find another room.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        read.Close();
                        return;
                    }
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding tenant: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
}

        private void addTransactionQuarterly()
        {
            int tenantID = 0;
            decimal price = 0;
            decimal quarterPrice = 4;
            SqlCommand cmd = new SqlCommand("SELECT roomPrice FROM Room WHERE roomID = @roomID", Connection.conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                price = Convert.ToDecimal(read.GetValue(0).ToString());
                read.Close();
            }
            cmd = new SqlCommand("SELECT tenantID FROM Tenant WHERE firstName = @firstName", Connection.conn);
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                tenantID = int.Parse(read.GetValue(0).ToString());
                read.Close();
            }
            for (int i = 1; i <= 3; i++)
            {
                cmd = new SqlCommand("INSERT INTO [Transaction] (tenantID, transactionDate, roomID, totalPrice, status) VALUES (@tenantID, @transactionDate, @roomID, @totalPrice, @status)", Connection.conn);
                cmd.Parameters.AddWithValue("@tenantID", tenantID);
                int totalMonths = i * 3;

                cmd.Parameters.AddWithValue("@transactionDate", moveInBox.Value.AddMonths(totalMonths));

                cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
                decimal totalPrice = price * quarterPrice;
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.ExecuteNonQuery();
            }
        }

        private void addTransactionMonthly()
        {
            int tenantID = 0;
            decimal price = 0;
            SqlCommand cmd = new SqlCommand("SELECT roomPrice FROM Room WHERE roomID = @roomID", Connection.conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                price = Convert.ToDecimal(read.GetValue(0).ToString());
                read.Close();
            }
            cmd = new SqlCommand("SELECT tenantID FROM Tenant WHERE firstName = @firstName", Connection.conn);
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                tenantID = int.Parse(read.GetValue(0).ToString());
                read.Close();
            }
            for (int i = 1; i <= 12; i++)
            {
                cmd = new SqlCommand("INSERT INTO [Transaction] (tenantID, transactionDate, roomID, totalPrice, status) VALUES (@tenantID, @transactionDate, @roomID, @totalPrice, @status)", Connection.conn);
                cmd.Parameters.AddWithValue("@tenantID", tenantID);

                cmd.Parameters.AddWithValue("@transactionDate", moveInBox.Value.AddMonths(i));

                cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
                cmd.Parameters.AddWithValue("@totalPrice", price);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.ExecuteNonQuery();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminTenantScreen tenant = new adminTenantScreen(); 
                Connection.conn.Open();
                addTenant();
                tenant.displayTenant();
                Connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding Tenant failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }

        }
        private void generateContract_Click(object sender, EventArgs e)
        {
            try
            {
                string lessorName = firstNameBox.Text + " " + lastNameBox.Text;
            string leaseStartDate = moveInBox.Value.ToString();
            string leaseEndDate = moveInBox.Value.AddYears(1).ToString();

            string lesseeName = "Arsenia Gonzales";

            Connection.conn.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT tenantID FROM Tenant WHERE firstName = @firstName", Connection.conn);
            cmd3.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            SqlDataReader read = cmd3.ExecuteReader();
            int tenantID = 0;
            if (read.Read())
            {
                tenantID = int.Parse(read.GetValue(0).ToString());
            }
            read.Close();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Agreement_Form (fileName, roomID, tenantID, startOfContract, endOfContract) VALUES (@fileName, @roomID, @tenantID, @startOfContract, @endOfContract)", Connection.conn);
            cmd2.Parameters.AddWithValue("@fileName", lessorName + ".pdf");
            cmd2.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
            cmd2.Parameters.AddWithValue("@tenantID", tenantID);
            cmd2.Parameters.AddWithValue("@startOfContract", moveInBox.Value);
            cmd2.Parameters.AddWithValue("@endOfContract", moveInBox.Value.AddYears(1));
            cmd2.ExecuteNonQuery();


            int leaseTerm = 12;
            SqlCommand cmd = new SqlCommand("SELECT roomPrice FROM Room WHERE roomID = @roomID", Connection.conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            decimal rent = Convert.ToDecimal(0);
            if (reader.Read())
            {
                if (rentBox.Text.ToLower() == "monthly")
                {
                    rent = reader.GetDecimal(0);
                        reader.Close();
                }else if (rentBox.Text.ToLower() == "quarterly")
                {
                    rent = (reader.GetDecimal(0) * 3);
                        reader.Close();
                    }
            }
                reader.Close();
            decimal monthlyRent = rent;

            if (firstNameBox.Text == null && lastNameBox.Text == null && unitBox.Text == null)
            {
                MessageBox.Show("Generate Conract Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string leaseAgreementContent = $@"This CONTRACT OF LEASE made and executed by and between:
          {lesseeName}, of legal age, (Civil Status) Married, Filipino national and a resident of Lambakin, Marilao, Bulacan, Philippines, here in after referred to as the LANDLORD / LESSOR. -
            and -
        {lessorName}, of legal age, (Civil Status) ________, Filipino national and a resident of[Lessee Address] __________________, here in after referred to as the LESSEE / TENANT.
          ";

            Document document = new Document(PageSize.A4);
            document.SetMargins(72f, 72f, 72f, 72f);

            
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"C:\\pdf\\{lessorName}.pdf", FileMode.Create));
                document.Open();

                Paragraph title = new Paragraph("CONTRACT OF LEASE", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 27));
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                Paragraph knownMen = new Paragraph("KNOWN ALL MEN BY THESE PRESENTS:", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                knownMen.Alignment = Element.ALIGN_LEFT;
                document.Add(knownMen);

                Paragraph leaseAgreement = new Paragraph(leaseAgreementContent, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                leaseAgreement.Alignment = Element.ALIGN_LEFT;
                document.Add(leaseAgreement);

                Paragraph witnessText = new Paragraph(@"The LESSOR is the owner of a residential house situated at Lambakin, Marilao, Bulacan. The LESSOR hereby lease unto the LESSEE the above-mentioned residential building, and the latter agree to lease the same under the following terms and conditions:",
                FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                witnessText.Alignment = Element.ALIGN_LEFT;
                document.Add(witnessText);

                Paragraph leaseTermPara = new Paragraph("\n1.   That the term of this lease shall be for a period of (" + leaseTerm + ") months and will start on __________ upon signing of this contract and renewable for another period;", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                leaseTermPara.Alignment = Element.ALIGN_LEFT;
                document.Add(leaseTermPara);

                Paragraph monthlyRentPara = new Paragraph($"\n2.   That the monthly rental of the lease shall be  PESOS (P{monthlyRent.ToString()}, per month; payable in every {moveInBox.Value.Day.ToString()} of the month. It does not include the monthly homeowner’s dues; Upon signing this contract, the LESSEE shall pay an advance rental equivalent to one (1) month deposit and one (1) month advance deposit;", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                monthlyRentPara.Alignment = Element.ALIGN_LEFT;
                document.Add(monthlyRentPara);

                Paragraph latePaymentPara = new Paragraph("\n3.  Late Payment. In the event that any monthly rent payment is late, a grace period of 3 days will be granted. However, a late payment penalty of One Thousand Pesos (P1,000.00) per day shall be imposed starting on the fourth (4th) day after the due date, in addition to the full rent amount owed. This penalty shall accrue daily until the rent and penalty are paid in full.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                latePaymentPara.Alignment = Element.ALIGN_LEFT;
                document.Add(latePaymentPara);

                Paragraph securityDepositPara = new Paragraph("\n4.  Security Deposit. The security deposit paid by the Lessee is intended to cover any damages beyond normal wear and tear to the property, or unpaid rent upon lease termination. The security deposit cannot be used by the Lessee in lieu of monthly rental payments.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                securityDepositPara.Alignment = Element.ALIGN_LEFT;
                document.Add(securityDepositPara);

                Paragraph exclusiveUsePara = new Paragraph("\n5.  Exclusive Residential Use. The LESSEE expressly agrees and warrants that the leased premises shall be exclusively utilised for residential purposes only.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                exclusiveUsePara.Alignment = Element.ALIGN_LEFT;
                document.Add(exclusiveUsePara);

                Paragraph maintainPremisesPara = new Paragraph("\n6.  Lessee Responsibility for Maintenance. The LESSEE shall keep the leased premises in good and habitable condition and any damages caused by the LESSEE in the said premises shall be to his/her account.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                maintainPremisesPara.Alignment = Element.ALIGN_LEFT;
                document.Add(maintainPremisesPara);

                Paragraph utilityBillsPara = new Paragraph("\n7.  Utility Bills. The LESSEE shall pay promptly the electrical, water and internet bills used in the leased premises so that the same could not be disrupted for this purpose. The LESSOR is hereby authorized by the LESSEE to inspect the corresponding billing of the above-mentioned services.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                utilityBillsPara.Alignment = Element.ALIGN_LEFT;
                document.Add(utilityBillsPara);

                Paragraph lessorEntryPara = new Paragraph("\n8.  Lessee's Obligation to Permit Entry. The LESSEE shall permit the LESSOR to enter and view the leased premises at reasonable hours and with reasonable notice given.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                lessorEntryPara.Alignment = Element.ALIGN_LEFT;
                document.Add(lessorEntryPara);

                Paragraph flammableMaterialsPara = new Paragraph("\n9.  Lessee's Restriction on Flammable Materials. The LESSEE shall not bring into or store in the leased premises anything of a highly inflammable nature or explosive material that may expose the leased premises to fire.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                flammableMaterialsPara.Alignment = Element.ALIGN_LEFT;
                document.Add(flammableMaterialsPara);

                Paragraph autoTerminationPara = new Paragraph("\n10.  Automatic Termination for Non-Payment. It is understood that the LESSOR has the option to automatically rescind this contract if the LESSEE fails to pay the rent for one (1) month.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                autoTerminationPara.Alignment = Element.ALIGN_LEFT;
                document.Add(autoTerminationPara);

                Paragraph preTerminationPara = new Paragraph("\n11.  Lessee Pre-Termination and Liquidated Damages. In the event of LESSEE pre-termination of this agreement for any reason whatsoever, the LESSOR shall automatically forfeit the advance rental and deposit paid by the LESSEE as liquidated damages.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                preTerminationPara.Alignment = Element.ALIGN_LEFT;
                document.Add(preTerminationPara);

                Paragraph subLeasingPara = new Paragraph("\n12.  Lessee Prohibition on Sub-Leasing. The LESSEE is expressly prohibited to sub-lease the lease premises to anybody, without the express consent of the LESSOR in writing.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                subLeasingPara.Alignment = Element.ALIGN_LEFT;
                document.Add(subLeasingPara);

                Paragraph sanitaryElectricalPara = new Paragraph("\n13.  Lessee Responsibility for Regulations. The LESSEE shall be responsible for the observance of sanitary and electrical regulations required or imposed by the City Government or authorities.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                sanitaryElectricalPara.Alignment = Element.ALIGN_LEFT;
                document.Add(sanitaryElectricalPara);

                Paragraph lesseeImprovementsPara = new Paragraph("\n14.  Lessee Improvements. The improvements introduced by the LESSE shall be for his/her own account.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                lesseeImprovementsPara.Alignment = Element.ALIGN_LEFT;
                document.Add(lesseeImprovementsPara);

                Paragraph airConditioningPara = new Paragraph("\n15.  Air Conditioning Unit. The LESSEE will be responsible for returning a fully functioning and recently cleaned air conditioning unit to the LESSOR. The lessor will provide the receipt for the air conditioning cleaning upon house turnover. The lessee will also provide proof of recent cleaning to the lessor upon return of the house at the end of the lease.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                airConditioningPara.Alignment = Element.ALIGN_LEFT;
                document.Add(airConditioningPara);

                Paragraph airConditioningRepairPara = new Paragraph("\n16.  Lessee Responsibility for Air Conditioning Repair. The LESSEE is responsible for any repairs of the air conditioning unit during the lease period, excluding normal wear and tear.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                airConditioningRepairPara.Alignment = Element.ALIGN_LEFT;
                document.Add(airConditioningRepairPara);

                Paragraph disputeResolutionPara = new Paragraph("\n17.  Dispute Resolution. All actions that may arise from this contract shall be instituted in the proper courts of [Insert Jurisdiction Here] only.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                disputeResolutionPara.Alignment = Element.ALIGN_LEFT;
                document.Add(disputeResolutionPara);

                Paragraph witnessPara = new Paragraph("IN WITNESS WHEREOF, we have hereunto set our hands on this __________ in the City/Province of __________, Philippines.\n" +
                  "\n" +
                  "(Signed) LESSOR'S FULL NAME\n" +
                  "\n" +
                  "(Signed) LESSEE'S FULL NAME\n" +
                  "\n" +
                  "SIGNED IN THE PRESENCE OF:\n" +
                  "\n" +
                  "(Witness' complete name and signature)  \n" +
                  "\n" +
                  "(Witness' complete name and signature)", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                witnessPara.Alignment = Element.ALIGN_CENTER;
                document.Add(witnessPara);
                Paragraph acknowledgementPara = new Paragraph("ACKNOWLEDGMENT\n" +
                  "REPUBLIC OF THE PHILIPPINES)\n" +
                  "CITY OF ______________________) S.S.\n" +
                  "x---------------------------------------x\n" +
                  "BEFORE ME, a Notary Public for the City and Province of ________, on this day __________, personally appeared the above mentioned persons identified with their competent evidence of identity written below their respective names known to me to be the same persons who executed the foregoing instrument and they acknowledged to me that the same is their own free and voluntary act and deed.  This instrument consists of three (3) pages including the acknowledgement, which have been signed on each and every page by the parties and their instrumental witnesses including the page on which this acknowledgment is written.  \n" +
                  " WITNESS MY HAND AND SEAL.\n" +
                  "\n" +
                  "Doc. No. _______;\n" +
                  "Page No. _______;                                   NOTARY PUBLIC\n" +
                  "Book No._______;\n" +
                  "Series of 202__.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12));
                acknowledgementPara.Alignment = Element.ALIGN_LEFT;
                document.Add(acknowledgementPara);

                document.Close();
                MessageBox.Show("PDF created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(numBox.Text, @"^[0-9]+$"))
            {

            }
            else
            {
                MessageBox.Show("Please input number only.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
