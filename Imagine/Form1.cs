namespace Imagine;

public partial class Form1 : Form
{
    private float _dpi { get; set; } = 96;

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

                _dpi = image.HorizontalResolution;

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

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        // Get mouse position relative to the image
        int mouseX = e.X;
        int mouseY = e.Y;

        lblOffsetPX.Text = $"({mouseX}, {mouseY})";

        // Convert the mouse position to millimeters
        float mouseXMM = (mouseX / _dpi) * 25.4f;
        float mouseYMM = (mouseY / _dpi) * 25.4f;

        lblOffsetMM.Text = $"({mouseXMM:F2}, {mouseYMM:F2})";

        // Calculate Distance
        double distancePX = Math.Sqrt(mouseX * mouseX + mouseY * mouseY);
        double dispanceMM = (distancePX / _dpi) * 25.4f;

        lblDistancePX.Text = $"{distancePX:F2}";
        lblDistanceMM.Text = $"{dispanceMM:F2}";
    }
}
