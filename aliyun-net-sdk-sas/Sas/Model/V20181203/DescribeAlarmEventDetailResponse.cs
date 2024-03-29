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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeAlarmEventDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeAlarmEventDetail_Data data;

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

		public DescribeAlarmEventDetail_Data Data
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

		public class DescribeAlarmEventDetail_Data
		{

			private string type;

			private string internetIp;

			private string k8sClusterName;

			private string containerImageId;

			private string alarmEventDesc;

			private string alarmUniqueInfo;

			private bool? canCancelFault;

			private string appName;

			private bool? canBeDealOnLine;

			private string containerImageName;

			private string k8sClusterId;

			private bool? containHwMode;

			private string instanceName;

			private string k8sNodeId;

			private string solution;

			private string dataSource;

			private string intranetIp;

			private string alarmEventAliasName;

			private long? endTime;

			private string uuid;

			private long? startTime;

			private string containerId;

			private string k8sPodName;

			private string k8sNamespace;

			private string k8sNodeName;

			private string level;

			private List<DescribeAlarmEventDetail_CauseDetail> causeDetails;

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

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string K8sClusterName
			{
				get
				{
					return k8sClusterName;
				}
				set	
				{
					k8sClusterName = value;
				}
			}

			public string ContainerImageId
			{
				get
				{
					return containerImageId;
				}
				set	
				{
					containerImageId = value;
				}
			}

			public string AlarmEventDesc
			{
				get
				{
					return alarmEventDesc;
				}
				set	
				{
					alarmEventDesc = value;
				}
			}

			public string AlarmUniqueInfo
			{
				get
				{
					return alarmUniqueInfo;
				}
				set	
				{
					alarmUniqueInfo = value;
				}
			}

			public bool? CanCancelFault
			{
				get
				{
					return canCancelFault;
				}
				set	
				{
					canCancelFault = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public bool? CanBeDealOnLine
			{
				get
				{
					return canBeDealOnLine;
				}
				set	
				{
					canBeDealOnLine = value;
				}
			}

			public string ContainerImageName
			{
				get
				{
					return containerImageName;
				}
				set	
				{
					containerImageName = value;
				}
			}

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
				}
			}

			public bool? ContainHwMode
			{
				get
				{
					return containHwMode;
				}
				set	
				{
					containHwMode = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string K8sNodeId
			{
				get
				{
					return k8sNodeId;
				}
				set	
				{
					k8sNodeId = value;
				}
			}

			public string Solution
			{
				get
				{
					return solution;
				}
				set	
				{
					solution = value;
				}
			}

			public string DataSource
			{
				get
				{
					return dataSource;
				}
				set	
				{
					dataSource = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string AlarmEventAliasName
			{
				get
				{
					return alarmEventAliasName;
				}
				set	
				{
					alarmEventAliasName = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string ContainerId
			{
				get
				{
					return containerId;
				}
				set	
				{
					containerId = value;
				}
			}

			public string K8sPodName
			{
				get
				{
					return k8sPodName;
				}
				set	
				{
					k8sPodName = value;
				}
			}

			public string K8sNamespace
			{
				get
				{
					return k8sNamespace;
				}
				set	
				{
					k8sNamespace = value;
				}
			}

			public string K8sNodeName
			{
				get
				{
					return k8sNodeName;
				}
				set	
				{
					k8sNodeName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public List<DescribeAlarmEventDetail_CauseDetail> CauseDetails
			{
				get
				{
					return causeDetails;
				}
				set	
				{
					causeDetails = value;
				}
			}

			public class DescribeAlarmEventDetail_CauseDetail
			{

				private string key;

				private List<DescribeAlarmEventDetail_ValueItem> _value;

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

				public List<DescribeAlarmEventDetail_ValueItem> _Value
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

				public class DescribeAlarmEventDetail_ValueItem
				{

					private string type;

					private string _value;

					private string name;

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

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}
				}
			}
		}
	}
}
