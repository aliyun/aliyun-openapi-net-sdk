using System;
using System.Threading;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Pipeline
{
    public class RuntimeAsyncResult : IAsyncResult, IDisposable
    {
        private object _lockObj;
        private ManualResetEvent _waitHandle;
        private bool _disposed = false;
        private bool _callbackInvoked = false;

        public RuntimeAsyncResult(AsyncCallback asyncCallback, object asyncState)
        {
            _lockObj = new object();
            _callbackInvoked = false;

            this.AsyncState = asyncState;
            this.IsCompleted = false;
            this.AsyncCallback = asyncCallback;
            this.CompletedSynchronously = false;
        }

        public AsyncCallback AsyncCallback { get; private set; }

        public object AsyncState { get; private set; }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                if (this._waitHandle != null)
                {
                    return this._waitHandle;
                }

                lock (this._lockObj)
                {
                    if (this._waitHandle == null)
                    {
                        this._waitHandle = new ManualResetEvent(this.IsCompleted);
                    }
                }
                return this._waitHandle;
            }
        }

        public bool CompletedSynchronously { get; private set; }

        public bool IsCompleted { get; private set; }

        public Exception Exception { get; set; }

        public WebServiceResponse Response { get; set; }

        internal void SignalWaitHandle()
        {
            this.IsCompleted = true;
            if (this._waitHandle != null)
            {
                this._waitHandle.Set();
            }
        }

        internal void HandleException(Exception exception)
        {
            this.Exception = exception;
            InvokeCallback();
        }

        internal void InvokeCallback()
        {
            this.SignalWaitHandle();
            if (!_callbackInvoked && this.AsyncCallback != null)
            {
                _callbackInvoked = true;
                this.AsyncCallback(this);
            }
        }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing && _waitHandle != null)
                {
#if WIN_RT
                    _waitHandle.Dispose();
#else
                    _waitHandle.Close();
#endif
                    _waitHandle = null;
                }
                this._disposed = true;
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
}
