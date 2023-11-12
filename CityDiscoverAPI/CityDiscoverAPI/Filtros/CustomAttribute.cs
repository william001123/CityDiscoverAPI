namespace CityDiscoverAPI.Filtros
{
    public class CustomAttribute
    {
        public readonly bool ContainsAttribute;
        public readonly bool Mandatory;

        public CustomAttribute(bool _ContainsAttribute, bool _Mandatory)
        {
            ContainsAttribute = _ContainsAttribute;
            Mandatory = _Mandatory;
        }
    }
}
