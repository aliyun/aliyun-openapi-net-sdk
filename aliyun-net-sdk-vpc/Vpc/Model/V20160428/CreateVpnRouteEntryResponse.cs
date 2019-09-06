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
	public class CreateVpnRouteEntryResponse : AcsResponse
	{

		private string requestId;

		private string vpnInstanceId;

		private string routeDest;

		private string nextHop;

		private int? weight;

		private string overlayMode;

		private string description;

		private string state;

		private long? createTime;

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

		public string VpnInstanceId
		{
			get
			{
				return vpnInstanceId;
			}
			set	
			{
				vpnInstanceId = value;
			}
		}

		public string RouteDest
		{
			get
			{
				return routeDest;
			}
			set	
			{
				routeDest = value;
			}
		}

		public string NextHop
		{
			get
			{
				return nextHop;
			}
			set	
			{
				nextHop = value;
			}
		}

		public int? Weight
		{
			get
			{
				return weight;
			}
			set	
			{
				weight = value;
			}
		}

		public string OverlayMode
		{
			get
			{
				return overlayMode;
			}
			set	
			{
				overlayMode = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
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
	}
}
