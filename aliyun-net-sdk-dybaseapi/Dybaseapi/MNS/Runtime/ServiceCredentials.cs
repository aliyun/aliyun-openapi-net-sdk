using System;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    /// <summary>
    /// Immutable representation of Aliyun service credentials.
    /// </summary>
    public class ImmutableCredentials
    {
        #region Properties

        /// <summary>
        /// Gets the AccessKey property for the current credentials.
        /// </summary>
        public string AccessKey { get; private set; }

        /// <summary>
        /// Gets the SecretKey property for the current credentials.
        /// </summary>
        public string SecretKey { get; private set; }

		public string SecurityToken { get; private set;}

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        public ImmutableCredentials(string accessKeyId, string secretAccessKey, string stsToken)
        {
            if (string.IsNullOrEmpty(accessKeyId)) throw new ArgumentNullException("accessKeyId");
            if (string.IsNullOrEmpty(secretAccessKey)) throw new ArgumentNullException("secretAccessKey");
			if (string.IsNullOrEmpty(stsToken))
			{
				SecurityToken = null;
			}
			else {
				SecurityToken = stsToken;
			}


            AccessKey = accessKeyId;
            SecretKey = secretAccessKey;
        }

        private ImmutableCredentials() { }

        #endregion


        #region Public methods

        /// <summary>
        /// Returns a copy of the current credentials.
        /// </summary>
        /// <returns></returns>
        public ImmutableCredentials Copy()
        {
			ImmutableCredentials credentials = new ImmutableCredentials
			{
				AccessKey = this.AccessKey,
				SecretKey = this.SecretKey,
				SecurityToken = this.SecurityToken,
            };
            return credentials;
        }

        #endregion
    }

    /// <summary>
    /// Abstract class that represents a credentials object for Aliyun Services.
    /// </summary>
    public abstract class ServiceCredentials
    {
        /// <summary>
        /// Returns a copy of ImmutableCredentials
        /// </summary>
        /// <returns></returns>
        public abstract ImmutableCredentials GetCredentials();
    }

    /// <summary>
    /// Basic set of credentials consisting of an AccessKey and SecretKey
    /// </summary>
    public class BasicServiceCredentials : ServiceCredentials
    {
        #region Private members

        private ImmutableCredentials _credentials;

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs a BasicServiceCredentials object for the specified accessKey and secretKey.
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        public BasicServiceCredentials(string accessKey, string secretKey, string stsToken)
        {
            if (!string.IsNullOrEmpty(accessKey))
            {
				_credentials = new ImmutableCredentials(accessKey, secretKey, stsToken);
            }
        }

        #endregion


        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            if (this._credentials == null)
                return null;

            return _credentials.Copy();
        }

        #endregion

    }
}
