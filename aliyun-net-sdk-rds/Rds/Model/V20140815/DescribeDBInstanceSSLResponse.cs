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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceSSLResponse : AcsResponse
	{

		private string serverCert;

		private string clientCACertExpireTime;

		private string requireUpdateItem;

		private string serverCAUrl;

		private string requireUpdate;

		private string clientCertRevocationList;

		private string sSLExpireTime;

		private string cAType;

		private string sSLCreateTime;

		private string replicationACL;

		private string aCL;

		private string requestId;

		private string lastModifyStatus;

		private string sSLEnabled;

		private string connectionString;

		private string requireUpdateReason;

		private string clientCACert;

		private string serverKey;

		private string modifyStatusReason;

		private string forceEncryption;

		private string tlsVersion;

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
			}
		}

		[JsonProperty(PropertyName = "ClientCACertExpireTime")]
		public string ClientCACertExpireTime
		{
			get
			{
				return clientCACertExpireTime;
			}
			set	
			{
				clientCACertExpireTime = value;
			}
		}

		[JsonProperty(PropertyName = "RequireUpdateItem")]
		public string RequireUpdateItem
		{
			get
			{
				return requireUpdateItem;
			}
			set	
			{
				requireUpdateItem = value;
			}
		}

		[JsonProperty(PropertyName = "ServerCAUrl")]
		public string ServerCAUrl
		{
			get
			{
				return serverCAUrl;
			}
			set	
			{
				serverCAUrl = value;
			}
		}

		[JsonProperty(PropertyName = "RequireUpdate")]
		public string RequireUpdate
		{
			get
			{
				return requireUpdate;
			}
			set	
			{
				requireUpdate = value;
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
			}
		}

		[JsonProperty(PropertyName = "SSLExpireTime")]
		public string SSLExpireTime
		{
			get
			{
				return sSLExpireTime;
			}
			set	
			{
				sSLExpireTime = value;
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
			}
		}

		[JsonProperty(PropertyName = "SSLCreateTime")]
		public string SSLCreateTime
		{
			get
			{
				return sSLCreateTime;
			}
			set	
			{
				sSLCreateTime = value;
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
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "LastModifyStatus")]
		public string LastModifyStatus
		{
			get
			{
				return lastModifyStatus;
			}
			set	
			{
				lastModifyStatus = value;
			}
		}

		[JsonProperty(PropertyName = "SSLEnabled")]
		public string SSLEnabled
		{
			get
			{
				return sSLEnabled;
			}
			set	
			{
				sSLEnabled = value;
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
			}
		}

		[JsonProperty(PropertyName = "RequireUpdateReason")]
		public string RequireUpdateReason
		{
			get
			{
				return requireUpdateReason;
			}
			set	
			{
				requireUpdateReason = value;
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
			}
		}

		[JsonProperty(PropertyName = "ModifyStatusReason")]
		public string ModifyStatusReason
		{
			get
			{
				return modifyStatusReason;
			}
			set	
			{
				modifyStatusReason = value;
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
			}
		}
	}
}
