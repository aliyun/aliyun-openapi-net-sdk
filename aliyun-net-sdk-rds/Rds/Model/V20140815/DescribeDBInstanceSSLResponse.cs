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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceSSLResponse : AcsResponse
	{

		private string requestId;

		private string connectionString;

		private string sSLExpireTime;

		private string sSLEnabled;

		private string requireUpdateReason;

		private string cAType;

		private string serverCert;

		private string serverKey;

		private string sSLCreateTime;

		private string clientCACert;

		private string clientCACertExpireTime;

		private string clientCertRevocationList;

		private string aCL;

		private string replicationACL;

		private string serverCAUrl;

		private string requireUpdate;

		private string requireUpdateItem;

		private string lastModifyStatus;

		private string modifyStatusReason;

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
	}
}
