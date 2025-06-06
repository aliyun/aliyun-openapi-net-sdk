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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterVersionResponse : AcsResponse
	{

		private string isLatestVersion;

		private string isProxyLatestVersion;

		private string dBVersion;

		private string dBRevisionVersion;

		private string requestId;

		private string dBVersionStatus;

		private string dBClusterId;

		private string dBMinorVersion;

		private string proxyRevisionVersion;

		private string proxyVersionStatus;

		private string proxyLatestVersion;

		private string dBLatestVersion;

		private string proxyLatestVersionAfterDBEngineUpgraded;

		private string dBInnerRevisionVersion;

		private List<DescribeDBClusterVersion_DBRevisionVersionListItem> dBRevisionVersionList;

		private List<DescribeDBClusterVersion_ProxyRevisionVersionListItem> proxyRevisionVersionList;

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

		public string IsProxyLatestVersion
		{
			get
			{
				return isProxyLatestVersion;
			}
			set	
			{
				isProxyLatestVersion = value;
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

		public string ProxyLatestVersionAfterDBEngineUpgraded
		{
			get
			{
				return proxyLatestVersionAfterDBEngineUpgraded;
			}
			set	
			{
				proxyLatestVersionAfterDBEngineUpgraded = value;
			}
		}

		public string DBInnerRevisionVersion
		{
			get
			{
				return dBInnerRevisionVersion;
			}
			set	
			{
				dBInnerRevisionVersion = value;
			}
		}

		public List<DescribeDBClusterVersion_DBRevisionVersionListItem> DBRevisionVersionList
		{
			get
			{
				return dBRevisionVersionList;
			}
			set	
			{
				dBRevisionVersionList = value;
			}
		}

		public List<DescribeDBClusterVersion_ProxyRevisionVersionListItem> ProxyRevisionVersionList
		{
			get
			{
				return proxyRevisionVersionList;
			}
			set	
			{
				proxyRevisionVersionList = value;
			}
		}

		public class DescribeDBClusterVersion_DBRevisionVersionListItem
		{

			private string releaseType;

			private string revisionVersionCode;

			private string revisionVersionName;

			private string releaseNote;

			public string ReleaseType
			{
				get
				{
					return releaseType;
				}
				set	
				{
					releaseType = value;
				}
			}

			public string RevisionVersionCode
			{
				get
				{
					return revisionVersionCode;
				}
				set	
				{
					revisionVersionCode = value;
				}
			}

			public string RevisionVersionName
			{
				get
				{
					return revisionVersionName;
				}
				set	
				{
					revisionVersionName = value;
				}
			}

			public string ReleaseNote
			{
				get
				{
					return releaseNote;
				}
				set	
				{
					releaseNote = value;
				}
			}
		}

		public class DescribeDBClusterVersion_ProxyRevisionVersionListItem
		{

			private string releaseType;

			private string revisionVersionCode;

			private string revisionVersionName;

			private string releaseNote;

			public string ReleaseType
			{
				get
				{
					return releaseType;
				}
				set	
				{
					releaseType = value;
				}
			}

			public string RevisionVersionCode
			{
				get
				{
					return revisionVersionCode;
				}
				set	
				{
					revisionVersionCode = value;
				}
			}

			public string RevisionVersionName
			{
				get
				{
					return revisionVersionName;
				}
				set	
				{
					revisionVersionName = value;
				}
			}

			public string ReleaseNote
			{
				get
				{
					return releaseNote;
				}
				set	
				{
					releaseNote = value;
				}
			}
		}
	}
}
