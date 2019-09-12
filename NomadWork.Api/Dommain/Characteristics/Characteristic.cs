using NomadWork.Domain.Characteristics.Enums;
using NomadWork.Domain.Shared;

namespace NomadWork.Domain.Characteristics
{
    public class Characteristic : AEntite
    {
        protected Characteristic(HasCharacteristc hasNotHas, ServiceOffered serviceOffered, ServiceOfferedQuality serviceOfferedQuality)
        {
            HasNotHas = hasNotHas;
            ServiceOffered = serviceOffered;
            ServiceOfferedQuality = serviceOfferedQuality;
        }

        public static Characteristic Create(HasCharacteristc hasNotHas, ServiceOffered serviceOffered, ServiceOfferedQuality serviceOfferedQuality)
        {
            return new Characteristic(hasNotHas, serviceOffered, serviceOfferedQuality);
        }

        public HasCharacteristc HasNotHas { get; private set; }
        public ServiceOffered ServiceOffered { get; private set; }
        public ServiceOfferedQuality ServiceOfferedQuality { get; private set; }

        protected override bool CheckEntryOk(string[] args)
        {
            // sem necessidade de implementação
            throw new System.NotImplementedException();
        }
    }
}
