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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenAttachedChildInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private string cenId;

		private string childInstanceId;

		private string childInstanceType;

		private string childInstanceRegionId;

		private long? childInstanceOwnerId;

		private string status;

		private string childInstanceName;

		private string childInstanceAttachTime;

		private string ipv6StatusInCen;

		private List<DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable> childInstanceRouteTables;

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

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
			}
		}

		public string ChildInstanceId
		{
			get
			{
				return childInstanceId;
			}
			set	
			{
				childInstanceId = value;
			}
		}

		public string ChildInstanceType
		{
			get
			{
				return childInstanceType;
			}
			set	
			{
				childInstanceType = value;
			}
		}

		public string ChildInstanceRegionId
		{
			get
			{
				return childInstanceRegionId;
			}
			set	
			{
				childInstanceRegionId = value;
			}
		}

		public long? ChildInstanceOwnerId
		{
			get
			{
				return childInstanceOwnerId;
			}
			set	
			{
				childInstanceOwnerId = value;
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

		public string ChildInstanceName
		{
			get
			{
				return childInstanceName;
			}
			set	
			{
				childInstanceName = value;
			}
		}

		public string ChildInstanceAttachTime
		{
			get
			{
				return childInstanceAttachTime;
			}
			set	
			{
				childInstanceAttachTime = value;
			}
		}

		public string Ipv6StatusInCen
		{
			get
			{
				return ipv6StatusInCen;
			}
			set	
			{
				ipv6StatusInCen = value;
			}
		}

		public List<DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable> ChildInstanceRouteTables
		{
			get
			{
				return childInstanceRouteTables;
			}
			set	
			{
				childInstanceRouteTables = value;
			}
		}

		public class DescribeCenAttachedChildInstanceAttribute_ChildInstanceRouteTable
		{

			private string routeTableId;

			private string routeTableType;

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string RouteTableType
			{
				get
				{
					return routeTableType;
				}
				set	
				{
					routeTableType = value;
				}
			}
		}
	}
}
