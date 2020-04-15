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
	public class DescribePbrInterfacesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribePbrInterfaces_PbrInterface> pbrInterfaces;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribePbrInterfaces_PbrInterface> PbrInterfaces
		{
			get
			{
				return pbrInterfaces;
			}
			set	
			{
				pbrInterfaces = value;
			}
		}

		public class DescribePbrInterfaces_PbrInterface
		{

			private string interfaceName;

			private string healthCheckInstanceId;

			private int? priority;

			private string action;

			public string InterfaceName
			{
				get
				{
					return interfaceName;
				}
				set	
				{
					interfaceName = value;
				}
			}

			public string HealthCheckInstanceId
			{
				get
				{
					return healthCheckInstanceId;
				}
				set	
				{
					healthCheckInstanceId = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}
		}
	}
}
