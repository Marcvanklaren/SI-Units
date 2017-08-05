using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Physics.Mathematics.Constants.MathematicalConstants;
using static Physics.Mathematics.Functions.Entities;

namespace Physics.Mathematics
{
    public class BaseUnits
    {
        //decimal v;
        //int e;
        
        //D0 Units
        #region D0 Units
        public enum AngleUnit
        {
            Radian,
            Degree
        }
        public static Constant Radian = new Constant(1, 0);
        public static Constant Degree = new Constant(2 / PI.val, 0);
        
        public enum SolidAngleUnit
        {
            Steradian, 
            Degree2
        }
        public static Constant Steradian = new Constant(1, 0);
        public static Constant Degree2 = new Constant(4 / (PI.val * PI.val), 0);
        #endregion

        //D1 Units
        #region SIBaseUnits
        public enum DistanceUnit
        {
            Meter, 
            Yard
        }
        public Constant Meter = new Constant(1, 0);
        public Constant Yard = new Constant((decimal)1.09361329834, 0);

        public enum TimeUnit
        {
            Second, 
            Minute, 
            Hour, 
            Day, 
            Week, 
            Year
        }
        public static Constant Second = new Constant(1, 0);
        public static Constant Minute = new Constant(6, 1);
        public static Constant Hour = new Constant(36, 2);
        public static Constant Day = new Constant(864, 2);
        public static Constant Week = new Constant(6048, 2);
        public static Constant Year = new Constant(31536, 3);
        public enum MassUnit
        {
            Gram , 
            Dalton
        }

        public static Constant Gram = new Constant(1, 0);
        public static Constant Dalton = new Constant(1 / Avogadro.val, -Avogadro.exponent);
        public enum AoSubstanceUnit
        {
            Mole, 
            Grams
        }
        public static Constant Mole = new Constant(1, 0);
        public static Constant MoleGram = new Constant(Avogadro.val, Avogadro.exponent);

        public enum ElectricCurrentUnit
        {
            Ampere 
        }
        public static Constant Ampere = new Constant(1, 0);

        public enum ThermoDynaTempUnit
        {
            Kelvin, 
            Celcius, 
            Fahrenheit
        }
        public static Constant Kelvin = new Constant(1, 0);

        public enum LuminousIntensityUnit
        {
            Candela 
        }
        public static Constant Candela = new Constant(1, 0);
            //DerivedUnits
        public enum FrequencyUnit
        {
            Hertz 
        }
        public static Constant Hertz = new Constant(1, 0);

        public enum ActivityUnit
        {
            Becquerel 
        }
        public static Constant Becquerel = new Constant(1, 0);

        public enum LuminousFluxUnit
        {
            Lumen 
        }
        public static Constant Lumen = new Constant(1, 0);

        public enum AngularVelocityUnit
        {
            RadPSecond, 
            DegreePSecond,
        }
        public static Constant RadPSecond = new Constant(1, 0);
        public static Constant DegreePSecond = new Constant(4 / PI.val * PI.val * 324, 2);
        #endregion

        //D2 Units
        #region D2 Units
        public enum AreaUnit
        {
            Meter2 
        }
        public static Constant Meter2 = new Constant(1, 0);

        public enum LinearVelocityUnit
        {
            MeterPSecond, 
            KMeterPHour
        }
        public static Constant MeterPSecond = new Constant(1, 0);
        public static Constant KMeterPHour = new Constant((decimal)3.6, 0);

        public enum ElectricChargeUnit
        {
            Coulomb 
        }
        public static Constant Coulomb = new Constant(1, 0);

        public enum CatalyticActivityUnit
        {
            Katal 
        }
        public static Constant Katal = new Constant(1, 0);
        
        public enum AngularAccelerationUnit
        {
            RadPSecondPSecond, 
            DegreesPSecondPSecond
        }
        public static Constant RadPSecondPSecond = new Constant(1, 0);
        public static Constant DegreePSecondPSecond = new Constant(2 / PI.val, 0);
        #endregion

        //D3 Units
        #region D3 Units
        public enum VolumeUnit
        {
            Meter3, 
            Liter
        }
        public static Constant Meter3 = new Constant(1, 0);
        public static Constant Liter = new Constant(1, -3);

        public enum LinearAccelerationUnit
        {
            MeterPSecond2, 
            KMeterPHourPSecond
        }
        public static Constant MeterPSecond2 = new Constant(1, 0);
        public static Constant KMeterPHourPSecond = new Constant(36, -1);

        public enum IlluminanceUnit
        {
            Lux
        }
        public static Constant Lux = new Constant(1, 0);
        #endregion

        //D4 Units
        #region D4 Units
        public enum DensityUnit
        {
            GramPCm3, 
            GramPLiter
        }
        public static Constant GramPCm3 = new Constant(1, 0);
        public static Constant GramPLiter = new Constant(1, -3);

        public enum ForceUnit
        {
            Newton 
        }
        public static Constant Newton = new Constant(1, 0);

        public enum PressureUnit
        {
            Pascal
        }
        public static Constant Pascal = new Constant(1, 0);

        public enum AbsorbedDoseUnit
        {
            Gray 
        }
        public static Constant Gray = new Constant(1, 0);

        public enum DoseEquivalentUnit
        {
            Sievert 
        }
        public static Constant Sievert = new Constant(1, 0);

        public enum MagneticFluxDensityUnit
        {
            Tesla 
        }
        public static Constant Tesla = new Constant(1, 0);
        #endregion

        //D5 Units
        #region D5 Units
        public enum EnergyUnit
        {
            Joule 
        }
        public static Constant Joule = new Constant(1, 0);
        #endregion

        //D6 Units
        #region D6 Units
        public enum PowerUnit
        {
            Watt 
        }
        public static Constant Watt = new Constant(1, 0);

        public enum MagneticFluxUnit
        {
            Weber 
        }
        public static Constant Weber = new Constant(1, 0);
        #endregion

        //D7 Units
        #region D7 Units
        public enum PotentialUnit
        {
            Volt 
        }
        public static Constant Volt = new Constant(1, 0);
        #endregion

        //D8 Units
        #region D8 Units
        public enum InductanceUnit
        {
            Henry 
        }
        public static Constant Henry = new Constant(1, 0);

        public enum ResistanceUnit
        {
            Ohm 
        }
        public static Constant Ohm = new Constant(1, 0);

        public enum ConductanceUnit
        {
            Siemens 
        }
        public static Constant Siemens = new Constant(1, 0);
        #endregion

        //D9 Units
        #region D9 Units
        public enum CapacitanceUnit
        {
            Farad 
        }
        public static Constant Farad = new Constant(1, 0);
        #endregion

        //Newtonian
        #region Newtonian
        public enum MomentumUnit
        {
            NewtonSecond 
        }
        public static Constant NewtonSecond = new Constant(1, 0);

        public enum AngularMomentumUnit
        {
            NewtonMeterSecond 
        }
        public static Constant NewtonMeterSecond = new Constant(1, 0);

        public enum ImpulseUnit
        {
            NewtonSecond 
        }
        #endregion
    }
}
