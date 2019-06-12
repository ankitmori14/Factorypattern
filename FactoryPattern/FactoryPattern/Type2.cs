using System;

namespace FactoryPattern
{
    public class ElectronicHandler
    {
        /// <summary>
        /// Gets the ElectronicDetail.
        /// </summary>
        /// <param name="ElectronicDetail">The GetElectronicDetail.</param>
        /// <returns>ElectronicDetail.</returns>
        public ElectronicDetail GetElectronicDetail(string electronicDeviceDetail)
        {
            switch (electronicDeviceDetail)
            {
                case "MOBILE":
                    return new MobileDetail();
                case "Television":
                    return new TelevisionDetail();
                default:
                    throw new NotImplementedException();
            }
        }

    }
    public abstract class ElectronicDetail
    {
        /// <summary>
        /// get device detail
        /// </summary>
        /// <returns>GetDeviceDetail.</returns>
        public abstract string GetDeviceDetail();

    }

    /// <summary>
    /// Class MobileDetail.
    /// </summary>
    public class MobileDetail : ElectronicDetail
    {
        /// <summary>
        /// get mobile detail
        /// </summary>
        /// <returns>GetDeviceDetail.</returns>
        public override string GetDeviceDetail()
        {
            return "Mobile";
        }
    }

    /// <summary>
    /// Class TelevisionDetail.
    /// </summary>
    public class TelevisionDetail : ElectronicDetail
    {
        /// <summary>
        /// Get television detail
        /// </summary>
        /// <returns>GetDeviceDetail.</returns>
        public override string GetDeviceDetail()
        {
            return "Television";
        }
    }
}
