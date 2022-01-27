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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterVersionResponse : AcsResponse
	{

		private string proxyVersionStatus;

		private string isLatestVersion;

		private string dBVersion;

		private string requestId;

		private string dBRevisionVersion;

		private string dBVersionStatus;

		private string dBClusterId;

		private string dBLatestVersion;

		private string proxyRevisionVersion;

		private string dBMinorVersion;

		private string proxyLatestVersion;

		public string ProxyVersionStatus
		{
			get
			{
				return proxyVersionStatus;
			}
			set	
			{
				proxyVersionStatus = value;
			}
		}

		public string IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

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

		public string DBRevisionVersion
		{
			get
			{
				return dBRevisionVersion;
			}
			set	
			{
				dBRevisionVersion = value;
			}
		}

		public string DBVersionStatus
		{
			get
			{
				return dBVersionStatus;
			}
			set	
			{
				dBVersionStatus = value;
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string DBLatestVersion
		{
			get
			{
				return dBLatestVersion;
			}
			set	
			{
				dBLatestVersion = value;
			}
		}

		public string ProxyRevisionVersion
		{
			get
			{
				return proxyRevisionVersion;
			}
			set	
			{
				proxyRevisionVersion = value;
			}
		}

		public string DBMinorVersion
		{
			get
			{
				return dBMinorVersion;
			}
			set	
			{
				dBMinorVersion = value;
			}
		}

		public string ProxyLatestVersion
		{
			get
			{
				return proxyLatestVersion;
			}
			set	
			{
				proxyLatestVersion = value;
			}
		}
	}
}
