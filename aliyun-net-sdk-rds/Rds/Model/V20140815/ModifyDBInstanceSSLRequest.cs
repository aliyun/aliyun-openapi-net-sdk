/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyDBInstanceSSLRequest : RpcAcsRequest<ModifyDBInstanceSSLResponse>
    {
        public ModifyDBInstanceSSLRequest()
            : base("Rds", "2014-08-15", "ModifyDBInstanceSSL", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string connectionString;

		private string serverKey;

		private int? clientCrlEnabled;

		private string certificate;

		private string aCL;

		private string passWord;

		private string clientCertRevocationList;

		private string serverCert;

		private string dBInstanceId;

		private string forceEncryption;

		private int? clientCAEnabled;

		private string clientCACert;

		private string replicationACL;

		private string resourceOwnerAccount;

		private string cAType;

		private string ownerAccount;

		private long? ownerId;

		private int? sSLEnabled;

		private string tlsVersion;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ConnectionString")]
		public string ConnectionString
		{
			get
			{
				return connectionString;
			}
			set	
			{
				connectionString = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionString", value);
			}
		}

		[JsonProperty(PropertyName = "ServerKey")]
		public string ServerKey
		{
			get
			{
				return serverKey;
			}
			set	
			{
				serverKey = value;
				DictionaryUtil.Add(QueryParameters, "ServerKey", value);
			}
		}

		[JsonProperty(PropertyName = "ClientCrlEnabled")]
		public int? ClientCrlEnabled
		{
			get
			{
				return clientCrlEnabled;
			}
			set	
			{
				clientCrlEnabled = value;
				DictionaryUtil.Add(QueryParameters, "ClientCrlEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Certificate")]
		public string Certificate
		{
			get
			{
				return certificate;
			}
			set	
			{
				certificate = value;
				DictionaryUtil.Add(QueryParameters, "Certificate", value);
			}
		}

		[JsonProperty(PropertyName = "ACL")]
		public string ACL
		{
			get
			{
				return aCL;
			}
			set	
			{
				aCL = value;
				DictionaryUtil.Add(QueryParameters, "ACL", value);
			}
		}

		[JsonProperty(PropertyName = "PassWord")]
		public string PassWord
		{
			get
			{
				return passWord;
			}
			set	
			{
				passWord = value;
				DictionaryUtil.Add(QueryParameters, "PassWord", value);
			}
		}

		[JsonProperty(PropertyName = "ClientCertRevocationList")]
		public string ClientCertRevocationList
		{
			get
			{
				return clientCertRevocationList;
			}
			set	
			{
				clientCertRevocationList = value;
				DictionaryUtil.Add(QueryParameters, "ClientCertRevocationList", value);
			}
		}

		[JsonProperty(PropertyName = "ServerCert")]
		public string ServerCert
		{
			get
			{
				return serverCert;
			}
			set	
			{
				serverCert = value;
				DictionaryUtil.Add(QueryParameters, "ServerCert", value);
			}
		}

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "ForceEncryption")]
		public string ForceEncryption
		{
			get
			{
				return forceEncryption;
			}
			set	
			{
				forceEncryption = value;
				DictionaryUtil.Add(QueryParameters, "ForceEncryption", value);
			}
		}

		[JsonProperty(PropertyName = "ClientCAEnabled")]
		public int? ClientCAEnabled
		{
			get
			{
				return clientCAEnabled;
			}
			set	
			{
				clientCAEnabled = value;
				DictionaryUtil.Add(QueryParameters, "ClientCAEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ClientCACert")]
		public string ClientCACert
		{
			get
			{
				return clientCACert;
			}
			set	
			{
				clientCACert = value;
				DictionaryUtil.Add(QueryParameters, "ClientCACert", value);
			}
		}

		[JsonProperty(PropertyName = "ReplicationACL")]
		public string ReplicationACL
		{
			get
			{
				return replicationACL;
			}
			set	
			{
				replicationACL = value;
				DictionaryUtil.Add(QueryParameters, "ReplicationACL", value);
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "CAType")]
		public string CAType
		{
			get
			{
				return cAType;
			}
			set	
			{
				cAType = value;
				DictionaryUtil.Add(QueryParameters, "CAType", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerAccount")]
		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SSLEnabled")]
		public int? SSLEnabled
		{
			get
			{
				return sSLEnabled;
			}
			set	
			{
				sSLEnabled = value;
				DictionaryUtil.Add(QueryParameters, "SSLEnabled", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TlsVersion")]
		public string TlsVersion
		{
			get
			{
				return tlsVersion;
			}
			set	
			{
				tlsVersion = value;
				DictionaryUtil.Add(QueryParameters, "TlsVersion", value);
			}
		}

        public override ModifyDBInstanceSSLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBInstanceSSLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
