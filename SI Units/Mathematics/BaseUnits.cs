using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Mathematics
{
    public class BaseUnits
    {
        //D0 Units
        public enum AngleUnit
        {
            Radian = 0
        }
        public enum SolidAngleUnit
        {
            Steradian = 0
        }

        //D1 Units
        #region SIBaseUnits
        public enum DistanceUnit
        {
            Meter = 0
        }
        public enum TimeUnit
        {
            Second = 0
        }
        public enum MassUnit
        {
            Gram = 0
        }
        public enum AoSubstanceUnit
        {
            Mole = 0
        }
        public enum ElectricCurrentUnit
        {
            Ampere = 0
        }
        public enum ThermoDynaTempUnit
        {
            Kelvin = 0
        }
        public enum LuminousIntensityUnit
        {
            Candela = 0
        }
            //DerivedUnits
        public enum FrequencyUnit
        {
            Hertz = 0
        }
        public enum ActivityUnit
        {
            Becquerel = 0
        }
        public enum LuminousFluxUnit
        {
            Lumen = 0
        }
        public enum AngularVelocityUnit
        {
            RadPSecond = 0
        }
        #endregion

        //D2 Units
        #region D2 Units
        public enum AreaUnit
        {
            Meter2 = 0
        }
        public enum LinearVelocityUnit
        {
            MeterPSecond = 0
        }
        public enum ElectricChargeUnit
        {
            Coulomb = 0
        }
        public enum CatalyticActivityUnit
        {
            Katal = 0
        }
        public enum IlluminanceUnit
        {
            Lux = 0
        }
        public enum AngularAccelerationUnit
        {
            RadPSecondPSecond = 0
        }
        #endregion

        //D3 Units
        #region D3 Units
        public enum VolumeUnit
        {
            Meter3 = 0
        }
        public enum LinearAccelerationUnit
        {
            MeterPSecond2 = 0
        }
        #endregion

        //D4 Units
        #region D4 Units
        public enum DensityUnit
        {
            GramPcm3 = 0
        }
        public enum ForceUnit
        {
            Newton = 0
        }
        public enum AbsorbedDoseUnit
        {
            Gray = 0
        }
        public enum DoseEquivalentUnit
        {
            Sievert = 0
        }
        public enum MagneticFluxDensityUnit
        {
            Tesla = 0
        }
        #endregion

        //D5 Units
        #region D5 Units
        public enum EnergyUnit
        {
            Joule = 0
        }
        #endregion

        //D6 Units
        #region D6 Units
        public enum PressureUnit
        {
            Pascal = 0
        }
        public enum PowerUnit
        {
            Watt = 0
        }
        public enum MagneticFluxUnit
        {
            Weber = 0
        }
        #endregion

        //D7 Units
        #region D7 Units
        public enum ElectricPotentialUnit
        {
            Volt = 0
        }
        #endregion

        //D8 Units
        #region D8 Units
        public enum InductanceUnit
        {
            Henry = 0
        }
        public enum ResistanceUnit
        {
            Ohm = 0
        }
        public enum ConductanceUnit
        {
            Siemens = 0
        }
        #endregion

        //D9 Units
        #region D9 Units
        public enum CapacitanceUnit
        {
            Farad = 0
        }
        #endregion

        //Newtonian
        #region Newtonian
        public enum MomentumUnit
        {
            NewtonSecond = 0
        }
        public enum AngularMomentumUnit
        {
            NewtonMeterSecond = 0
        }
        public enum ImpulseUnit
        {
            NewtonSecond = 0
        }
        #endregion
    }
}
