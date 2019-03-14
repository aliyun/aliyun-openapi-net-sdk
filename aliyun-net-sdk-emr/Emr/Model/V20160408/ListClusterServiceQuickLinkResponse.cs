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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListClusterServiceQuickLinkResponse : AcsResponse
	{

		private string requestId;

		private List<ListClusterServiceQuickLink_QuickLink> quickLinkList;

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

		public List<ListClusterServiceQuickLink_QuickLink> QuickLinkList
		{
			get
			{
				return quickLinkList;
			}
			set	
			{
				quickLinkList = value;
			}
		}

		public class ListClusterServiceQuickLink_QuickLink
		{

			private string serviceName;

			private string serviceDisplayName;

			private string quickLinkAddress;

			private string protocol;

			private string port;

			private string type;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ServiceDisplayName
			{
				get
				{
					return serviceDisplayName;
				}
				set	
				{
					serviceDisplayName = value;
				}
			}

			public string QuickLinkAddress
			{
				get
				{
					return quickLinkAddress;
				}
				set	
				{
					quickLinkAddress = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}
	}
}
