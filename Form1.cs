using System.Diagnostics.Metrics;


namespace Ccs_Course_03
{
    public partial class Form1 : Form
    {
        // ���������� ������, ���� ������
        List<Particle> particles = new List<Particle>();

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState(); // ������ ��� ��������� �������

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                Render(g); // �������� �������
            }

            picDisplay.Invalidate();
        }

        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; // �������� ��������
                                    // ���� �������� ���������
                if (particle.Life < 0)
                {
                    // �������������� ��������
                    particle.Life = 20 + Particle.rand.Next(100);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;

                    // ��������� ������� � �����
                    particle.X = picDisplay.Image.Width / 2;
                    particle.Y = picDisplay.Image.Height / 2;

                    // ����� ��������� �����������, �������� � ������
                    particle.Direction = Particle.rand.Next(360);
                    particle.Speed = 1 + Particle.rand.Next(10);
                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    // � ��� ��� ������ ���
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500) // ���� ������ ������ 500 ���������� �����
                {
                    var particle = new Particle();
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else
                {
                    break; // � ���� ������ ��� 500 ����, �� ������ �� ���������
                }
            }
        }

        private void Render(Graphics g)
        {
            // ������� ���� ��������� ������
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}
