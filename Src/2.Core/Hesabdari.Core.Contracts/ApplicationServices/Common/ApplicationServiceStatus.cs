namespace Hesabdari.Core.Contracts.ApplicationServices.Common
{
    public enum ApplicationServiceStatus:byte
    {
        Ok = 1,
        NotFound = 2 , 
        ValidationError = 3 , 
        InvalidDomainState = 4 , 
        Exception = 5 ,
    }
}
