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
	public class DescribeClusterServiceResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterService_ServiceInfo serviceInfo;

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

		public DescribeClusterService_ServiceInfo ServiceInfo
		{
			get
			{
				return serviceInfo;
			}
			set	
			{
				serviceInfo = value;
			}
		}

		public class DescribeClusterService_ServiceInfo
		{

			private string serviceName;

			private string serviceVersion;

			private string serviceStatus;

			private string needRestartInfo;

			private int? needRestartNum;

			private List<DescribeClusterService_ServiceAction> serviceActionList;

			private List<DescribeClusterService_ClusterServiceSummary> clusterServiceSummaryList;

			private List<string> needRestartHostIdList;

			private List<string> needRestartComponentNameList;

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

			public string ServiceVersion
			{
				get
				{
					return serviceVersion;
				}
				set	
				{
					serviceVersion = value;
				}
			}

			public string ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}

			public string NeedRestartInfo
			{
				get
				{
					return needRestartInfo;
				}
				set	
				{
					needRestartInfo = value;
				}
			}

			public int? NeedRestartNum
			{
				get
				{
					return needRestartNum;
				}
				set	
				{
					needRestartNum = value;
				}
			}

			public List<DescribeClusterService_ServiceAction> ServiceActionList
			{
				get
				{
					return serviceActionList;
				}
				set	
				{
					serviceActionList = value;
				}
			}

			public List<DescribeClusterService_ClusterServiceSummary> ClusterServiceSummaryList
			{
				get
				{
					return clusterServiceSummaryList;
				}
				set	
				{
					clusterServiceSummaryList = value;
				}
			}

			public List<string> NeedRestartHostIdList
			{
				get
				{
					return needRestartHostIdList;
				}
				set	
				{
					needRestartHostIdList = value;
				}
			}

			public List<string> NeedRestartComponentNameList
			{
				get
				{
					return needRestartComponentNameList;
				}
				set	
				{
					needRestartComponentNameList = value;
				}
			}

			public class DescribeClusterService_ServiceAction
			{

				private string serviceName;

				private string componentName;

				private string actionName;

				private string command;

				private string displayName;

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

				public string ActionName
				{
					get
					{
						return actionName;
					}
					set	
					{
						actionName = value;
					}
				}

				public string Command
				{
					get
					{
						return command;
					}
					set	
					{
						command = value;
					}
				}

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}
			}

			public class DescribeClusterService_ClusterServiceSummary
			{

				private string key;

				private string displayName;

				private string _value;

				private int? desiredStoppedValue;

				private string status;

				private string type;

				private string category;

				private string alertInfo;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public int? DesiredStoppedValue
				{
					get
					{
						return desiredStoppedValue;
					}
					set	
					{
						desiredStoppedValue = value;
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

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string AlertInfo
				{
					get
					{
						return alertInfo;
					}
					set	
					{
						alertInfo = value;
					}
				}
			}
		}
	}
}
