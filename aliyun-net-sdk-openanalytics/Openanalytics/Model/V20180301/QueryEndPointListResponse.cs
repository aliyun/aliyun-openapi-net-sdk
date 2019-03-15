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

namespace Aliyun.Acs.openanalytics.Model.V20180301
{
	public class QueryEndPointListResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<QueryEndPointList_EndPointListItem> endPointList;

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

		public List<QueryEndPointList_EndPointListItem> EndPointList
		{
			get
			{
				return endPointList;
			}
			set	
			{
				endPointList = value;
			}
		}

		public class QueryEndPointList_EndPointListItem
		{

			private string endPointID;

			private string zone;

			private string vSwitch;

			private string status;

			private string vpcID;

			private string host;

			private string domainURL;

			private string networkType;

			private string allowIP;

			private string port;

			private string cloudInstanceID;

			public string EndPointID
			{
				get
				{
					return endPointID;
				}
				set	
				{
					endPointID = value;
				}
			}

			public string Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}

			public string VSwitch
			{
				get
				{
					return vSwitch;
				}
				set	
				{
					vSwitch = value;
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

			public string VpcID
			{
				get
				{
					return vpcID;
				}
				set	
				{
					vpcID = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}

			public string DomainURL
			{
				get
				{
					return domainURL;
				}
				set	
				{
					domainURL = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string AllowIP
			{
				get
				{
					return allowIP;
				}
				set	
				{
					allowIP = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string CloudInstanceID
			{
				get
				{
					return cloudInstanceID;
				}
				set	
				{
					cloudInstanceID = value;
				}
			}
		}
	}
}
