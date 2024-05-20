using System.Diagnostics.Metrics;
using static Ccs_Course_03.Particle;


namespace Ccs_Course_03
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // тут убрали явное создание

        GravityPoint point1;
        GravityPoint point2;
        GravityPoint point5;
        GravityPoint point6;
        GravityPoint point11;
        AntiGravityPoint point3;
        AntiGravityPoint point7;
        AntiGravityPoint point8;
        AntiGravityPoint point9;
        AntiGravityPoint point10;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 90,
                Spreading = 100,
                SpeedMin = 0,
                SpeedMax = 10,
                ColorFrom = Color.HotPink,
                ColorTo = Color.FromArgb(0, Color.White),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height - 100,
            };

            emitters.Add(this.emitter);

            point3 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 + 300,
                Y = picDisplay.Height - 50,
                NewFromColor = Color.FromArgb(255, Color.Azure),
                NewToColor = Color.FromArgb(255, Color.Azure)
            };
            point7 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 - 300,
                Y = picDisplay.Height - 50,
                NewFromColor = Color.FromArgb(255, Color.White),
                NewToColor = Color.FromArgb(255, Color.Gray)
            };
            point8 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 - 150,
                Y = picDisplay.Height - 50,
                NewFromColor = Color.FromArgb(255, Color.Cornsilk),
                NewToColor = Color.FromArgb(255, Color.Cornsilk)
            };
            point9 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 + 150,
                Y = picDisplay.Height - 50,
                NewFromColor = Color.FromArgb(255, Color.Crimson),
                NewToColor = Color.FromArgb(255, Color.Crimson)
            };
            point10 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height - 50,
                NewFromColor = Color.FromArgb(255, Color.DarkSeaGreen),
                NewToColor = Color.FromArgb(255, Color.DarkSeaGreen)
            };
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 300,
                Y = picDisplay.Height - 350,
                NewFromColor = Color.FromArgb(255, Color.Green),
                NewToColor = Color.FromArgb(255, Color.GreenYellow)
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 300,
                Y = picDisplay.Height - 350,
                NewFromColor = Color.FromArgb(255, Color.CadetBlue),
                NewToColor = Color.FromArgb(255, Color.Blue)
            };
            point5 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 150,
                Y = picDisplay.Height - 350,
                NewFromColor = Color.FromArgb(255, Color.Red),
                NewToColor = Color.FromArgb(255, Color.DarkRed)
            };
            point6 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 150,
                Y = picDisplay.Height - 350,
                NewFromColor = Color.FromArgb(255, Color.Gainsboro),
                NewToColor = Color.FromArgb(255, Color.LightSlateGray)
            };
            point11 = new GravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height - 350,
                NewFromColor = Color.FromArgb(255, Color.Indigo),
                NewToColor = Color.FromArgb(255, Color.MediumVioletRed)
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point5);
            emitter.impactPoints.Add(point6);
            emitter.impactPoints.Add(point7);
            emitter.impactPoints.Add(point8);
            emitter.impactPoints.Add(point9);
            emitter.impactPoints.Add(point10);
            emitter.impactPoints.Add(point11);
        }
        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // рендерим систему
            }

            lblCountParticle.Text = $"Количество частиц: {emitter.ParticlesCount}";
            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            // а тут передаем положение мыши, в положение гравитона
            //point2.X = e.X;
            //point2.Y = e.Y;
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMax = tbSpeed.Value + 3;
            if (emitter.SpeedMax <= emitter.SpeedMin)
            {
                emitter.SpeedMax += 10;
            }
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMin = tbLife.Value + 20;
            emitter.LifeMax = tbLife.Value + 100;
        }

        private void tbRadius_Scroll(object sender, EventArgs e)
        {
            emitter.RadiusMin = tbRadius.Value + 2;
            emitter.RadiusMax = tbRadius.Value + 10;
        }

        private void cbSpeedVector_CheckedChanged(object sender, EventArgs e)
        {
            emitter.SpeedVector = (cbSpeedVector.Checked);
        }
    }
}
