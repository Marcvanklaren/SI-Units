using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Physics.Mathematics.Datatypes;

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
        
        public enum SolidAngleUnit
        {
            Steradian, 
            Degree2
        }

        #region Constants
        //AngleUnit
        public static Constant Radian = new Constant(1, 0);
        public static Constant Degree = new Constant(2 / PI.val, 0);

        //SolidAngleUnit
        public static Constant Steradian = new Constant(1, 0);
        public static Constant Degree2 = new Constant(4 / (PI.val * PI.val), 0);
        #endregion

        #endregion

        //D1 Units
        #region SIBaseUnits
        public enum DistanceUnit
        {
            Meter, 
            Yard
        }
        
        public enum TimeUnit
        {
            Second, 
            Minute, 
            Hour, 
            Day, 
            Week, 
            Year
        }
        
        public enum MassUnit
        {
            Gram , 
            Dalton
        }
        
        public enum AoSubstanceUnit
        {
            Mole, 
            Grams
        }
        
        public enum ElectricCurrentUnit
        {
            Ampere 
        }
        
        public enum ThermoDynaTempUnit
        {
            Kelvin, 
            Celcius, 
            Fahrenheit
        }
        
        public enum LuminousIntensityUnit
        {
            Candela 
        }

        //DerivedUnits
        public enum FrequencyUnit
        {
            Hertz 
        }
        
        public enum ActivityUnit
        {
            Becquerel 
        }
        
        public enum LuminousFluxUnit
        {
            Lumen 
        }
        
        public enum AngularVelocityUnit
        {
            RadPSecond, 
            DegreePSecond,
        }
        
        #region Constants
        //DistanceUnit
        public static Constant Meter = new Constant(1, 0);
        public static Constant Yard = new Constant((decimal)1.09361329834, 0);

        //TimeUnit
        public static Constant Second = new Constant(1, 0);
        public static Constant Minute = new Constant(6, 1);
        public static Constant Hour = new Constant(36, 2);
        public static Constant Day = new Constant(864, 2);
        public static Constant Week = new Constant(6048, 2);
        public static Constant Year = new Constant(31536, 3);

        //MassUnits
        public static Constant Gram = new Constant(1, 0);
        public static Constant Dalton = new Constant(1 / Avogadro.val, -Avogadro.exponent);

        //AoSubstanceUnit
        public static Constant Mole = new Constant(1, 0);
        public static Constant MoleGram = new Constant(Avogadro.val, Avogadro.exponent);

        //ElectricCurrentUnit
        public static Constant Ampere = new Constant(1, 0);

        //ThermoDynaTempUnit
        public static Constant Kelvin = new Constant(1, 0);

        //LuminousIntensityUnit
        public static Constant Candela = new Constant(1, 0);

        //FrequencyUnit
        public static Constant Hertz = new Constant(1, 0);

        //ActivityUnit
        public static Constant Becquerel = new Constant(1, 0);

        //LuminousFluxUnit
        public static Constant Lumen = new Constant(1, 0);

        //AngularVelocityUnit
        public static Constant RadPSecond = new Constant(1, 0);
        public static Constant DegreePSecond = new Constant(4 / PI.val * PI.val * 324, 2);
        #endregion

        #endregion

        //D2 Units
        #region D2 Units
        public enum AreaUnit
        {
            Meter2 
        }
        
        public enum LinearVelocityUnit
        {
            MeterPSecond, 
            KMeterPHour
        }
        
        public enum ElectricChargeUnit
        {
            Coulomb 
        }
        
        public enum CatalyticActivityUnit
        {
            Katal 
        }
        
        public enum AngularAccelerationUnit
        {
            RadPSecondPSecond, 
            DegreesPSecondPSecond
        }
        
        #region Constants
        //AreaUnit
        public static Constant Meter2 = new Constant(1, 0);

        //LinearVelocityUnit
        public static Constant MeterPSecond = new Constant(1, 0);
        public static Constant KMeterPHour = new Constant((decimal)3.6, 0);

        //ElectriChargeUnit
        public static Constant Coulomb = new Constant(1, 0);

        //CatalyticActivityUnit
        public static Constant Katal = new Constant(1, 0);

        //AngularAccelerationUnit
        public static Constant RadPSecondPSecond = new Constant(1, 0);
        public static Constant DegreePSecondPSecond = new Constant(2 / PI.val, 0);
        #endregion

        #endregion

        //D3 Units
        #region D3 Units
        public enum VolumeUnit
        {
            Meter3, 
            Liter
        }
        
        public enum LinearAccelerationUnit
        {
            MeterPSecond2, 
            KMeterPHourPSecond
        }
        
        public enum IlluminanceUnit
        {
            Lux
        }
        
        #region Constants
        //VolumeUnit
        public static Constant Meter3 = new Constant(1, 0);
        public static Constant Liter = new Constant(1, -3);

        //LinearAccelerationUnit
        public static Constant MeterPSecond2 = new Constant(1, 0);
        public static Constant KMeterPHourPSecond = new Constant(36, -1);

        //IlluminanceUnit
        public static Constant Lux = new Constant(1, 0);
        #endregion

        #endregion

        //D4 Units
        #region D4 Units
        public enum DensityUnit
        {
            GramPCm3, 
            GramPLiter
        }
        
        public enum ForceUnit
        {
            Newton 
        }
        
        public enum PressureUnit
        {
            Pascal
        }
        
        public enum AbsorbedDoseUnit
        {
            Gray 
        }
        
        public enum DoseEquivalentUnit
        {
            Sievert 
        }
        
        public enum MagneticFluxDensityUnit
        {
            Tesla 
        }
        
        #region Constants
        //DensityUnit
        public static Constant GramPCm3 = new Constant(1, 0);
        public static Constant GramPLiter = new Constant(1, -3);

        //ForceUnit
        public static Constant Newton = new Constant(1, 0);

        //PressureUnit
        public static Constant Pascal = new Constant(1, 0);

        //AbsorbedDoseUnit
        public static Constant Gray = new Constant(1, 0);

        //DoseEquivalentUnit
        public static Constant Sievert = new Constant(1, 0);

        //MagneticFluxDensityUnit
        public static Constant Tesla = new Constant(1, 0);
        #endregion

        #endregion

        //D5 Units
        #region D5 Units
        public enum EnergyUnit
        {
            Joule 
        }

        #region Constants
        //ForceUnits
        public static Constant Joule = new Constant(1, 0);
        #endregion

        #endregion

        //D6 Units
        #region D6 Units
        public enum PowerUnit
        {
            Watt 
        }
        
        public enum MagneticFluxUnit
        {
            Weber 
        }

        #region Constants
        //PowerUnit
        public static Constant Watt = new Constant(1, 0);

        //MagneticFluxUnit
        public static Constant Weber = new Constant(1, 0);
        #endregion

        #endregion

        //D7 Units
        #region D7 Units
        public enum PotentialUnit
        {
            Volt 
        }

        #region Constants
        //PotentialUnit
        public static Constant Volt = new Constant(1, 0);
        #endregion

        #endregion

        //D8 Units
        #region D8 Units
        public enum InductanceUnit
        {
            Henry 
        }
        
        public enum ResistanceUnit
        {
            Ohm 
        }
        
        public enum ConductanceUnit
        {
            Siemens 
        }

        #region Constants
        //InductanceUnits
        public static Constant Henry = new Constant(1, 0);

        //ResistanceUnits
        public static Constant Ohm = new Constant(1, 0);

        //ConductanceUnits
        public static Constant Siemens = new Constant(1, 0);
        #endregion

        #endregion

        //D9 Units
        #region D9 Units
        public enum CapacitanceUnit
        {
            Farad 
        }

        #region Constants
        //CapacityUnits
        public static Constant Farad = new Constant(1, 0);
        #endregion

        #endregion

        //Newtonian
        #region Newtonian
        public enum MomentumUnit
        {
            NewtonSecond 
        }
        
        public enum AngularMomentumUnit
        {
            NewtonMeterSecond 
        }
        
        public enum ImpulseUnit
        {
            NewtonSecond 
        }

        #region Constants
        //MomentumUnits, ImpulseUnits
        public static Constant NewtonSecond = new Constant(1, 0);

        //AngularMomentumUnits
        public static Constant NewtonMeterSecond = new Constant(1, 0);
        #endregion

        #endregion
    }
}
