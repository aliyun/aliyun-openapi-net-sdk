using System;
using System.IO;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// Base class for the UnmarshallerContext objects that are used
    /// to unmarshall a web-service response.
    /// </summary>
    public abstract class UnmarshallerContext : IDisposable
    {
        private bool disposed = false;
        protected IWebResponseData WebResponseData { get; set; }

        public Stream ResponseStream { get; set; }

        public IWebResponseData ResponseData
        {
            get { return WebResponseData; }
        }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.ResponseStream != null)
                    {
                        ResponseStream.Dispose();
                        ResponseStream = null;
                    }
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class XmlUnmarshallerContext : UnmarshallerContext
    {

        #region Constructors

        public XmlUnmarshallerContext(Stream responseStream, IWebResponseData responseData)
        {
            this.ResponseStream = responseStream;
            this.WebResponseData = responseData;
        }

        #endregion
    }
}
