using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

using org.drools.dotnet.compiler;
using org.drools.dotnet.rule;
using org.drools.dotnet; 

namespace FallasI
{
    public class Simulator
    {
        //make this a singleton
        private static Simulator _instance;

        //public properties
        public Int32 GameSurfaceType { set; get; }
        public Int32 GameSurface { set; get; }
        public Int32 ServerType { set; get; }
        public Int32 ServerHeight { set; get; }
        public Int32 ReceptorHeight { set; get; }
        public Int32 ReceptorType { set; get; }
        public Int32 ReceptorPositionX { set; get; }
        public Int32 ReceptorPositionY { set; get; }
        private Int32 _serverEffect = 2; // por default hacemos un saque sin efecto

        public Int32 ServerEffect {
            set { _serverEffect = value; }
            get { return _serverEffect; }
        }

        public static Simulator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Simulator();
                }
                return _instance;
            }
        }

        public RuleBase ruleBase = null;
        public WorkingMemory workingMemory = null;
        public Simulator workingObj = null;
        public org.drools.FactHandle _currentCust = null;
        public static SimulationDebug _formDebug = null;
        public static Simulation _formSimulation;

        public void Simulate(Simulation formSimulation, SimulationDebug formDebug)
        {
            _formDebug = formDebug;
            _formSimulation = formSimulation;
            formDebug.Show();

            //Imprimo this para saber sobre que objeto operaran las reglas
            FallasI.Simulator.ImprimirEnDebug(this);

            //Inicio la carga de drools
            formDebug.debugTxtBox.Text += "\nLoading Rule Base: ";
            formDebug.debugTxtBox.Refresh();
            PackageBuilder builder = new PackageBuilder();
            Stream stream = new FileStream(FallasI.Src.App.Default.PATH_ARCHIVO_REGLAS, FileMode.Open);
            formDebug.debugTxtBox.Text += "\nStream Set ";
            formDebug.debugTxtBox.Refresh();
            formDebug.debugTxtBox.Text += "\nReading DRL (Please wait... this may take a few moments...) ";
            formDebug.debugTxtBox.Refresh();

            builder.AddPackageFromDrl("FallasI.Rules.drl", stream);
            formDebug.debugTxtBox.Text += "... Finished ";
            formDebug.debugTxtBox.Refresh();
            Package pkg = builder.GetPackage();
            formDebug.debugTxtBox.Text += "\nPackage Added ";
            formDebug.debugTxtBox.Refresh();

            ruleBase = RuleBaseFactory.NewRuleBase();
            ruleBase.AddPackage(pkg);
            formDebug.debugTxtBox.Text += "\nRule Base Set ";
            formDebug.debugTxtBox.Refresh();

            workingMemory = ruleBase.NewWorkingMemory();
            workingObj = this;
            formDebug.debugTxtBox.Text += "\nWorking Object Set ";
            formDebug.debugTxtBox.Refresh();

            //Inicio la ejecucion de drool
            formDebug.debugTxtBox.Text += "\nRule Runing... ";
            formDebug.debugTxtBox.Refresh();

            if (_currentCust == null)
            {
                _currentCust = workingMemory.assertObject(workingObj);
            }
            else
            {
                workingMemory.modifyObject(_currentCust, workingObj);
            }

            workingMemory.fireAllRules();

            formDebug.debugTxtBox.Text += "\nFin ";
            formDebug.debugTxtBox.Refresh();

             // llamo a simular
            _formSimulation.DibujarSimulacion();
            //formDebug.Close();
        }

        public static void ImprimirEnDebug(Simulator sim)
        {
            if (_formDebug != null)
            {
                _formDebug.debugTxtBox.Text += "\n--------------------------------------------------------------------------------------:";
                _formDebug.debugTxtBox.Text += "\n\tSimulator:";
                _formDebug.debugTxtBox.Text += "\n\t\tGameSurfaceType: " + sim.GameSurfaceType;             
                _formDebug.debugTxtBox.Text += "\n\t\tGameSurface: " + sim.GameSurface;               
                _formDebug.debugTxtBox.Text += "\n\t\tServerType: " + sim.ServerType;
                _formDebug.debugTxtBox.Text += "\n\t\tServerHeight: " + sim.ServerHeight;             
                _formDebug.debugTxtBox.Text += "\n\t\tReceptorHeight: " + sim.ReceptorHeight;
                _formDebug.debugTxtBox.Text += "\n\t\tReceptorType: " + sim.ReceptorType;
                _formDebug.debugTxtBox.Text += "\n\t\tReceptorPositionX: " + sim.ReceptorPositionX;
                _formDebug.debugTxtBox.Text += "\n\t\tReceptorPositionY: " + sim.ReceptorPositionY;
                _formDebug.debugTxtBox.Text += "\n--------------------------------------------------------------------------------------:";
                _formDebug.debugTxtBox.Refresh();
            }
        }
        
        public static void EfectoDeReglas(int reglaEjecutada)
        {
            switch (reglaEjecutada)
            {
                case 1:
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Alta.GetHashCode();
                    break;
                case 2:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Izquierda.GetHashCode();
                    _formSimulation.ServerEffect = FallasI.Simulation.ServeEffect.Si.GetHashCode();
                    _formSimulation.ServerHiltType = FallasI.Simulation.ServeHiltType.Efecto_lateral.GetHashCode();                    
                    _formSimulation.ServerShotType = FallasI.Simulation.ServeShotType.Corto.GetHashCode();
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Media.GetHashCode();
                    break;
               case 3:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Izquierda.GetHashCode();
                    _formSimulation.ServerEffect = FallasI.Simulation.ServeEffect.Si.GetHashCode();
                    _formSimulation.ServerHiltType = FallasI.Simulation.ServeHiltType.Efecto_lateral.GetHashCode();
                    _formSimulation.ServerShotType = FallasI.Simulation.ServeShotType.Corto.GetHashCode();
                    break;
                case 4:
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Media.GetHashCode();
                    break;
                case 5:
                    _formSimulation.ServerHiltType = FallasI.Simulation.ServeHiltType.Efecto_lateral.GetHashCode();
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Alta.GetHashCode();
                    break;
                case 6:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Centro.GetHashCode();
                    break;
                case 7:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Derecha.GetHashCode();
                    break;
                case 8:
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Alta.GetHashCode();
                    break;
                case 9:
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Alta.GetHashCode();
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Centro.GetHashCode();
                    _formSimulation.ServerEffect = FallasI.Simulation.ServeEffect.No.GetHashCode();
                    _formSimulation.ServerHiltType = FallasI.Simulation.ServeHiltType.Plano.GetHashCode();   
                    break;
                case 10:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Izquierda.GetHashCode();
                    break;
                case 11:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Derecha.GetHashCode();
                    break;
                case 12:
                    _formSimulation.ServerDirection = FallasI.Simulation.ServeDirection.Derecha.GetHashCode();
                    break;
                case 13:
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Alta.GetHashCode();
                    break;
                case 14:
                    _formSimulation.ServerEffect = FallasI.Simulation.ServeEffect.Si.GetHashCode();
                    _formSimulation.ServerHiltType = FallasI.Simulation.ServeHiltType.Efecto_lateral.GetHashCode();
                    _formSimulation.ServerPower = FallasI.Simulation.ServePower.Media.GetHashCode();
                    break;
                case 15:
                    _formSimulation.ServerHilt = FallasI.Simulation.ServeHilt.Continental.GetHashCode();
                    break;
                case 16:
                    _formSimulation.ServerHilt = FallasI.Simulation.ServeHilt.Este.GetHashCode();
                    break;
            }
        }
    }
}
