using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using FallasI.Src;

namespace FallasI
{

  
    public partial class Simulation : Form
    {
        private Simulator simulador = Simulator.Instance;
        private const Int32 BallMove = 3;

        //Variables que determinaran la simulacion
        public Int32 ServerPower { set; get; }
        public Int32 ServerEffect { set; get; }
        public Int32 ServerDirection { set; get; }
        public Int32 ServerHilt { set; get; }
        public Int32 ServerHiltType { set; get; }
        public Int32 ServerShotType { set; get; }
       
        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private System.Threading.Thread graficar;
     
        //enums de carga
        public enum ServePower
        {
            Alta = 1,
            Media = 2,
            Baja = 3
        }

        public enum ServeEffect
        {
            Si = 1,
            No = 2
        }

        public enum ServeDirection
        {
            Izquierda = 1,
            Centro = 2,
            Derecha = 3
        }

        public enum ServeHilt
        {
            Este = 1,
            Oeste = 2,
            Continental = 3,
            Australiana = 4
        }

        public enum ServeHiltType
        {
            Liftado = 1,
            Cortado = 2,
            Plano = 3,
            Efecto_lateral = 4,
            Efecto_retroceso = 5,
            Globo = 6
        }

        public enum ServeShotType
        {
            Corto = 1,
            Medio = 2,
            Largo = 3
        }

        public Simulation()
        {
            InitializeComponent();

            //Cargo los valores Por defecto:
            ServerPower = (ServerPower == 0) ? 1 : ServerPower;
            ServerEffect = (ServerEffect == 0) ? 2 : ServerEffect;
            ServerDirection = (ServerDirection == 0) ? 2 : ServerDirection;
            ServerHilt = (ServerHilt == 0) ? 3 : ServerHilt;
            ServerHiltType = (ServerHiltType == 0) ? 3 : ServerHiltType;
            ServerShotType = (ServerShotType == 0) ? 2 : ServerShotType;

            CheckForIllegalCrossThreadCalls = false;
            SimulationDebug formDebug = new SimulationDebug();
            simulador.Simulate(this,formDebug);
        }

        private String GetServerShotType(int value)
        {
            switch (value)
            {
                case 1:
                    return "Short";
                
                case 2:
                    return "Middle";

                case 3:
                    return "Long";
                default:
                    return String.Empty;
            }
        }

        private String GetServerHiltType(int value)
        {
            switch (value)
            {
                case 1:
                    return "Lift";
                    
                case 2:
                    return "Cut";
                   
                case 3:
                    return "Plain";
                   
                case 4:
                    return "Lateal Effect";
                   
                case 5:
                    return "Backward Effect";
                   
                case 6:
                    return "Lob";
                default:
                    return String.Empty;
             }
        }

        private String GetServerHilt(int value)
        {
            switch (value)
            {
                case 1:
                    return "Est";
                    
                case 2:
                    return "West";
                  
                case 3:
                    return "Continental";
                   
                case 4:
                    return "Australian";
                default:
                    return String.Empty;
            }
        }

        private String GetServerDirection(int value)
        {
            switch (value)
            {
                case 1:
                    return "Left";
                   
                case 2:
                    return "Center";
                   
                case 3:
                    return "Right";
                default:
                    return String.Empty; 
            }
        }

        private String GetServerEffect(int value)
        {
            switch (value)
            {
                case 1:
                    return "Yes";
                   
                case 2:
                    return "No";

                default:
                    return String.Empty;
            }
        }

        private String GetServerPower(int value)
        {
            switch (value)
            {
                case 1:
                    return "High";
              
                case 2:
                    return "Average";
                case 3:
                    return "Low";
                default:
                    return String.Empty;
            }
        }
      
        public void DibujarSimulacion()
        {
            
            //cargo los labels
            lblserverpower.Text = "Serve Power: " + GetServerPower(ServerPower);
            lblservereffect.Text = "Effect: " + GetServerEffect(ServerEffect);
            lblserverdirection.Text = "Direction: " + GetServerDirection(ServerDirection);
            lblserverhilt.Text = "Serve Hilt: " + GetServerHilt(ServerHilt);
            lblserverhilttype.Text = "Serve Hilt Type: " + GetServerHiltType(ServerHilt);
            lblservershottype.Text = "Serve Shot Type:" + GetServerShotType(ServerShotType);

            //Posiciono los jugadores y la bola
            ResetBallRight();
            ResetServerPosition();
            ResetReceptorPosition();
            
            VideoSample video = new VideoSample();
            String tipoSaque = VideoSample.SaquePlano;
            if (ServerEffect == 1) {tipoSaque = VideoSample.SaqueConEfecto; }


            video.PlayVideo(tipoSaque);
            video.Show();

            
            Show();
            graficar = new Thread(new ThreadStart(this.MoveBall));
            graficar.Start();
       }

        private void MoveBall()
        {
            Int32 i = 0;
            Int32 j = 0;
            Int32 potencia = 0;
            
            //veo la si es saque de alta media o baja potencia
            if (ServerPower == 1 )
            {
                potencia = 2;
            }
            else if (ServerPower == 3)
            {
                    potencia = -2;
            }

            //veo el lugar del pique
            if (ServerShotType == 1) //corto
            {
                SetControlPropertyValue(Pique, "Left", 363);
            }
            else if (ServerShotType == 1) //medio
            {
                SetControlPropertyValue(Pique, "Left", 310);
            }
            else if (ServerShotType == 3) //largo
            {
                SetControlPropertyValue(Pique, "Left", 248);
            }


            while (!BallAtLimitX())
            {
                SetControlPropertyValue(Ball, "Left", (Ball.Left - BallMove - potencia));

                //veo la dirección de la bola
                if (i == 20)
                {
                    if (ServerDirection == 1 && !BallAtLimitUp()) //voy a izquierda
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top - BallMove));
                    }
                    else if (ServerDirection == 3 && !BallAtLimitDown()) //voy a izquierda
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top + BallMove));
                    }
                    i = 0;  
                }

                //veo si va con o sin efecto
                if (ServerEffect == 1 && j >= 10 )
                {
                    if (ServerDirection == 1 && !BallAtLimitUp()) //voy a izquierda
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top - BallMove));
                    }
                    else if (ServerDirection == 3 && !BallAtLimitDown()) //voy a derecha
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top + BallMove));
                    }
                    else if (ServerDirection == 2 && !BallAtLimitDown() && !BallAtLimitUp() && Ball.Left < 245 && Receptor.Top == 261) //voy a centro y abajo
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top + BallMove));
                    }
                    else if (ServerDirection == 2 && !BallAtLimitDown() && !BallAtLimitUp() && Ball.Left < 245 && Receptor.Top == 328) //voy a centro y arriba
                    {
                        SetControlPropertyValue(Ball, "Top", (Ball.Top - BallMove));
                    }
                    j = 0;  
                }

                if ( !Pique.Visible && (Ball.Left <= Pique.Left))
                {
                    SetControlPropertyValue(Pique, "Top", Ball.Top);
                    SetControlPropertyValue(Pique, "Visible", true);
                }

                if (Ball.Left > 516 && Ball.Left < 585)
                {
                    j += 1;
                }
                if (Ball.Left > 280 && Ball.Left < 516)
                {
                    j += 3;
                }
                if (Ball.Left < 280)
                {
                    j += 5;
                }

                i++;
                j++;
                System.Threading.Thread.Sleep(5);
            }
        }

        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        private Boolean BallAtLimitX()
        {
            if (Ball.Left <= 100)
            {
                return true;
            }
            return false;
        }

        private Boolean BallAtLimitUp()
        {
            if (Ball.Top <= 80)
            {
                return true;
            }
            return false;
        }

        private Boolean BallAtLimitDown()
        {
            if (Ball.Left >= 385)
            {
                return true;
            }
            return false;
        }

        private void ResetReceptorPosition()
        {
            //Left  = 0, Middle = 1, Right = 2
            //Border Line = 0 ,Middle =1 , Far = 2
           
            //Posicion X
            if (Simulator.Instance.ReceptorPositionX == 0)
            {
                this.Receptor.Top = 227;
            }
            else if (Simulator.Instance.ReceptorPositionX == 1 || Simulator.Instance.ReceptorPositionX == -1)
            {
                this.Receptor.Top = 261;
            }
            else if (Simulator.Instance.ReceptorPositionX == 2)
            {
                this.Receptor.Top = 328;
            }

            //Posicion Y
            if (Simulator.Instance.ReceptorPositionY == 0 || Simulator.Instance.ReceptorPositionY == -1)
            {
                this.Receptor.Left = 38;
            }
            else if (Simulator.Instance.ReceptorPositionY == 1)
            {
                this.Receptor.Left = 22;
            }
            else if (Simulator.Instance.ReceptorPositionY == 2)
            {
                this.Receptor.Left = 1;
            }





           
            
        }

        private void ResetServerPosition()
        {
            Server.Left = 744;
            Server.Top = 252;
        }

        public void ResetBallRight()
        {
            Ball.Left = 705;
            Ball.Top = 252;
        }

        public void ResetBallMiddle()
        {
            Ball.Left = 675;
            Ball.Top = 300;
        }

        public void ResetBallLeft()
        {
            Ball.Left = 675;
            Ball.Top = 380;
        }

       

       
  
    }
}
