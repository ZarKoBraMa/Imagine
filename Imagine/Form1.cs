namespace Imagine;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnUpload_Click(object sender, EventArgs e)
    {
        // Open a file dialog to select an image
        using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image
                Image image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;

                // Display the image width, height, and DPI
                lblWidth.Text = image.Width.ToString();
                lblHeight.Text = image.Height.ToString();
                lblDPI.Text = image.HorizontalResolution.ToString();

                // Calculate dimensions in millimeters
                float widthInches = image.Width / image.HorizontalResolution;
                float heightInches = image.Height / image.VerticalResolution;

                float widthMM = widthInches * 25.4f; // 1 inch = 25.4 mm
                float heightMM = heightInches * 25.4f;

                // Display dimensions in millimeters
                lblWidthMM.Text = $"{widthMM:F2}";
                lblHeightMM.Text = $"{heightMM:F2}";

                // Optionally, resize the PictureBox to fit the image
                pictureBox1.Width = image.Width;
                pictureBox1.Height = image.Height;
            }
        }
    }
}
