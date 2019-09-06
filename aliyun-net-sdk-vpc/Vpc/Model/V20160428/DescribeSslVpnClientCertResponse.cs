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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeSslVpnClientCertResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string sslVpnClientCertId;

		private string name;

		private string sslVpnServerId;

		private string caCert;

		private string clientCert;

		private string clientKey;

		private string clientConfig;

		private long? createTime;

		private long? endTime;

		private string status;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string SslVpnClientCertId
		{
			get
			{
				return sslVpnClientCertId;
			}
			set	
			{
				sslVpnClientCertId = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string SslVpnServerId
		{
			get
			{
				return sslVpnServerId;
			}
			set	
			{
				sslVpnServerId = value;
			}
		}

		public string CaCert
		{
			get
			{
				return caCert;
			}
			set	
			{
				caCert = value;
			}
		}

		public string ClientCert
		{
			get
			{
				return clientCert;
			}
			set	
			{
				clientCert = value;
			}
		}

		public string ClientKey
		{
			get
			{
				return clientKey;
			}
			set	
			{
				clientKey = value;
			}
		}

		public string ClientConfig
		{
			get
			{
				return clientConfig;
			}
			set	
			{
				clientConfig = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}
	}
}
