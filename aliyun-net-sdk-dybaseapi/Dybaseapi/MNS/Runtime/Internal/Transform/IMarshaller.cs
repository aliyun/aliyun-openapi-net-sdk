namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    public interface IMarshaller<T, R>
    {
        T Marshall(R input);
    }
}
