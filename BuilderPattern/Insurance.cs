namespace BuilderPattern
{
    public class Insurance
    {
        private readonly List<string> _coverages = new List<string>();
        private readonly string _insuranceType;

        public Insurance(string insuranceType)
        {
            _insuranceType = insuranceType;
        }

        public void AddCoverage(string coverage)
        {
            _coverages.Add(coverage);
        }

        public int ComputeCost(int cost)
        {
            return cost;
        }
    }

    public abstract class InsuranceBuilder
    {
        public Insurance Insurance { get; private set; }

        public InsuranceBuilder(string insuranceType)
        {
            Insurance = new Insurance(insuranceType);
        }
        public abstract void BuildPackage();

        public abstract int ComputeInstallmentAmount();
    }

    public class CarInsuranceBuilder: InsuranceBuilder
    {
        public CarInsuranceBuilder(): base("car")
        {
        }

        public override void BuildPackage()
        {
            Insurance.AddCoverage("Motorist Coverage");
        }

        public override int ComputeInstallmentAmount()
        {
            return Insurance.ComputeCost(2000);
        }
    }

    public class HomeOwnerInsuranceBuilder : InsuranceBuilder
    {
        public HomeOwnerInsuranceBuilder() : base("home")
        {
        }

        public override void BuildPackage()
        {
            Insurance.AddCoverage("Fire Coverage");
        }

        public override int ComputeInstallmentAmount()
        {
            return Insurance.ComputeCost(4000);
        }
    }

    public class Client
    {
        private InsuranceBuilder? _builder;

        public int Construct(InsuranceBuilder builder)
        {
            _builder = builder;
            _builder.BuildPackage();
            return _builder.ComputeInstallmentAmount();
        }
    }
}
