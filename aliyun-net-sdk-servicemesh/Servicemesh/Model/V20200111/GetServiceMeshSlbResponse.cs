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

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
	public class GetServiceMeshSlbResponse : AcsResponse
	{

		private string requestId;

		private List<GetServiceMeshSlb_SLBInfo> data;

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

		public List<GetServiceMeshSlb_SLBInfo> Data
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

		public class GetServiceMeshSlb_SLBInfo
		{

			private string loadBalancerId;

			private string status;

			private string serverHealthStatus;

			public string LoadBalancerId
			{
				get
				{
					return loadBalancerId;
				}
				set	
				{
					loadBalancerId = value;
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

			public string ServerHealthStatus
			{
				get
				{
					return serverHealthStatus;
				}
				set	
				{
					serverHealthStatus = value;
				}
			}
		}
	}
}
