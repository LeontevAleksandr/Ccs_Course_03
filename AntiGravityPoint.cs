using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ccs_Course_03.Particle;

namespace Ccs_Course_03
{
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 65; // сила отторжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY -= gY * Power / r2; // и тут


            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы

            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                if (particle is ParticleColorful)
                {
                    var p = (particle as ParticleColorful);
                    p.FromColor = NewFromColor;
                    p.ToColor = NewToColor;
                }

            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(NewToColor),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
            var stringFormat = new StringFormat(); // создаем экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

            g.DrawString(
                $"Я антигравитон\nc силой {Power}",
                new Font("Verdana", 10),
                new SolidBrush(NewToColor),
                X,
                Y,
                stringFormat // передаем инфу о выравнивании
            );
        }
    }
}
