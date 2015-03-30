
namespace Scantech.Infrastructure.Models
{
    public class EngineModel
    {
        public enum CylinderArrangement
        {
            V8,
            Inline,
            Boxer
        }

        public enum InductionType
        {
            Turbocharged,
            Supercharged
        }

        public CylinderArrangement CylinderConfiguration { get; set; }
        public int NumberOfCylinders { get; set; }
        public float Displacement { get; set; }
        public bool HasForcedInduction { get; set; }
        public InductionType ForcedInductionType { get; set; }
    }
}
