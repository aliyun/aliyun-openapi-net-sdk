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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeSagRouteListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSagRouteList_Route> routes;

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

		public List<DescribeSagRouteList_Route> Routes
		{
			get
			{
				return routes;
			}
			set	
			{
				routes = value;
			}
		}

		public class DescribeSagRouteList_Route
		{

			private string portName;

			private string routeProtocol;

			private string destinationCidr;

			private string nextHop;

			private string cost;

			private List<string> conflictCidrs;

			public string PortName
			{
				get
				{
					return portName;
				}
				set	
				{
					portName = value;
				}
			}

			public string RouteProtocol
			{
				get
				{
					return routeProtocol;
				}
				set	
				{
					routeProtocol = value;
				}
			}

			public string DestinationCidr
			{
				get
				{
					return destinationCidr;
				}
				set	
				{
					destinationCidr = value;
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

			public string Cost
			{
				get
				{
					return cost;
				}
				set	
				{
					cost = value;
				}
			}

			public List<string> ConflictCidrs
			{
				get
				{
					return conflictCidrs;
				}
				set	
				{
					conflictCidrs = value;
				}
			}
		}
	}
}
