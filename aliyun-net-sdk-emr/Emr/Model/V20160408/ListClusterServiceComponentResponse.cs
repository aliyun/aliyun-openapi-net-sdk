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
	public class ListClusterServiceComponentResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListClusterServiceComponent_Component> componentList;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListClusterServiceComponent_Component> ComponentList
		{
			get
			{
				return componentList;
			}
			set	
			{
				componentList = value;
			}
		}

		public class ListClusterServiceComponent_Component
		{

			private string serviceName;

			private string serviceDisplayName;

			private string componentName;

			private string componentDisplayName;

			private string status;

			private bool? needRestart;

			private string serverStatus;

			private string podName;

			private string publicIp;

			private string privateIp;

			private string role;

			private string commissionStatus;

			private int? desiredCount;

			private string _namespace;

			private string workloadType;

			private string workloadName;

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

			public string ComponentName
			{
				get
				{
					return componentName;
				}
				set	
				{
					componentName = value;
				}
			}

			public string ComponentDisplayName
			{
				get
				{
					return componentDisplayName;
				}
				set	
				{
					componentDisplayName = value;
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

			public bool? NeedRestart
			{
				get
				{
					return needRestart;
				}
				set	
				{
					needRestart = value;
				}
			}

			public string ServerStatus
			{
				get
				{
					return serverStatus;
				}
				set	
				{
					serverStatus = value;
				}
			}

			public string PodName
			{
				get
				{
					return podName;
				}
				set	
				{
					podName = value;
				}
			}

			public string PublicIp
			{
				get
				{
					return publicIp;
				}
				set	
				{
					publicIp = value;
				}
			}

			public string PrivateIp
			{
				get
				{
					return privateIp;
				}
				set	
				{
					privateIp = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public string CommissionStatus
			{
				get
				{
					return commissionStatus;
				}
				set	
				{
					commissionStatus = value;
				}
			}

			public int? DesiredCount
			{
				get
				{
					return desiredCount;
				}
				set	
				{
					desiredCount = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public string WorkloadType
			{
				get
				{
					return workloadType;
				}
				set	
				{
					workloadType = value;
				}
			}

			public string WorkloadName
			{
				get
				{
					return workloadName;
				}
				set	
				{
					workloadName = value;
				}
			}
		}
	}
}
