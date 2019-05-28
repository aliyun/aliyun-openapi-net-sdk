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

namespace Aliyun.Acs.ARMS.Model.V20181219
{
	public class GetServicesResponse : AcsResponse
	{

		private string requestId;

		private GetServices_Data data;

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

		public GetServices_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetServices_Data
		{

			private List<GetServices_DetailsItem> details;

			private List<string> services;

			public List<GetServices_DetailsItem> Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public List<string> Services
			{
				get
				{
					return services;
				}
				set	
				{
					services = value;
				}
			}

			public class GetServices_DetailsItem
			{

				private string serviceName;

				private string pid;

				private string regionId;

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

				public string Pid
				{
					get
					{
						return pid;
					}
					set	
					{
						pid = value;
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
			}
		}
	}
}
