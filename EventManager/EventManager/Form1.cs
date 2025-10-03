using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QRCoder;

public partial class Form1 : Form
{
    // Register වෙන හැම Attendee කෙනෙක්ම මේ List එකේ අපි තියාගමු
    private List<Attendee> attendeeList = new List<Attendee>();

    public Form1()
    {
        InitializeComponent();
    }

    // මෙතන තමයි ඔයා double-click කලාම හැදෙන function එක
    private void btnRegister_Click(object sender, EventArgs e)
    {
        private void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            // 1. Textbox වලින් දත්ත අරගන්නවා
            string name = txtName.Text;
            string city = txtCity.Text;
            int age = int.Parse(txtAge.Text); // Text එක number එකකට හරවනවා
            string business = txtBusiness.Text;
            string position = txtPosition.Text;
            string seatNumber = txtSeatNumber.Text;

            // 2. අලුත් Attendee object එකක් හදනවා
            Attendee newAttendee = new Attendee(name, city, age, business, position, seatNumber);

            // 3. ඒ කෙනාව අපේ ප්‍රධාන List එකට එකතු කරනවා
            attendeeList.Add(newAttendee);

            // 4. QR Code එක හදනවා
            // QR code එකට අපි seat number එක විතරක් දාමු. ඒක unique නිසා
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(seatNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // 5. PictureBox එකේ QR code එක පෙන්නනවා
            picQRCode.Image = qrCodeImage;

            MessageBox.Show("Registration Successful! QR Code Generated.");

            // 6. ඊළඟ කෙනාට register වෙන්න Textbox ටික clear කරනවා
            txtName.Clear();
            txtCity.Clear();
            txtAge.Clear();
            txtBusiness.Clear();
            txtPosition.Clear();
            txtSeatNumber.Clear();
        }
        catch (Exception ex)
        {
            // වයසට අකුරු වගේ දෙයක් දැම්මොත් error එකක් එනවා, ඒක මෙතනින් අල්ලගන්නවා
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
}

namespace EventManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picQRCode_Click(object sender, EventArgs e)
        {

        }
    }
}
