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
	public class ListLocalDiskComponentInfoResponse : AcsResponse
	{

		private string requestId;

		private List<ListLocalDiskComponentInfo_ComponentInfo> componentInfoList;

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

		public List<ListLocalDiskComponentInfo_ComponentInfo> ComponentInfoList
		{
			get
			{
				return componentInfoList;
			}
			set	
			{
				componentInfoList = value;
			}
		}

		public class ListLocalDiskComponentInfo_ComponentInfo
		{

			private string serviceName;

			private string serviceDisplayName;

			private string componentName;

			private string componentDisplayName;

			private string isolateWarningMsg;

			private string mountWarningMsg;

			private string rebootWarningMsg;

			private bool? supportDiskHotSwap;

			private List<ListLocalDiskComponentInfo_MountParam> mountParams;

			private List<string> apmMetrics;

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

			public string IsolateWarningMsg
			{
				get
				{
					return isolateWarningMsg;
				}
				set	
				{
					isolateWarningMsg = value;
				}
			}

			public string MountWarningMsg
			{
				get
				{
					return mountWarningMsg;
				}
				set	
				{
					mountWarningMsg = value;
				}
			}

			public string RebootWarningMsg
			{
				get
				{
					return rebootWarningMsg;
				}
				set	
				{
					rebootWarningMsg = value;
				}
			}

			public bool? SupportDiskHotSwap
			{
				get
				{
					return supportDiskHotSwap;
				}
				set	
				{
					supportDiskHotSwap = value;
				}
			}

			public List<ListLocalDiskComponentInfo_MountParam> MountParams
			{
				get
				{
					return mountParams;
				}
				set	
				{
					mountParams = value;
				}
			}

			public List<string> ApmMetrics
			{
				get
				{
					return apmMetrics;
				}
				set	
				{
					apmMetrics = value;
				}
			}

			public class ListLocalDiskComponentInfo_MountParam
			{

				private string name;

				private string key;

				private string valueType;

				private string defaultValue;

				private string tips;

				private string unit;

				private int? min;

				private int? max;

				private List<string> options;

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

				public string ValueType
				{
					get
					{
						return valueType;
					}
					set	
					{
						valueType = value;
					}
				}

				public string DefaultValue
				{
					get
					{
						return defaultValue;
					}
					set	
					{
						defaultValue = value;
					}
				}

				public string Tips
				{
					get
					{
						return tips;
					}
					set	
					{
						tips = value;
					}
				}

				public string Unit
				{
					get
					{
						return unit;
					}
					set	
					{
						unit = value;
					}
				}

				public int? Min
				{
					get
					{
						return min;
					}
					set	
					{
						min = value;
					}
				}

				public int? Max
				{
					get
					{
						return max;
					}
					set	
					{
						max = value;
					}
				}

				public List<string> Options
				{
					get
					{
						return options;
					}
					set	
					{
						options = value;
					}
				}
			}
		}
	}
}
