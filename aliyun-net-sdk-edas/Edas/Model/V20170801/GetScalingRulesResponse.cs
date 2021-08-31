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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetScalingRulesResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private long? updateTime;

		private GetScalingRules_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public long? UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public GetScalingRules_Data Data
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

		public class GetScalingRules_Data
		{

			private int? clusterType;

			private int? oversoldFactor;

			private string vpcId;

			private long? updateTime;

			private List<GetScalingRules_Rule> ruleList;

			public int? ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public int? OversoldFactor
			{
				get
				{
					return oversoldFactor;
				}
				set	
				{
					oversoldFactor = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public List<GetScalingRules_Rule> RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class GetScalingRules_Rule
			{

				private string appId;

				private string groupId;

				private bool? enable;

				private string mode;

				private string cond;

				private int? cpu;

				private int? rt;

				private string resourceFrom;

				private int? step;

				private int? instNum;

				private int? loadNum;

				private string templateId;

				private int? templateVersion;

				private string vpcId;

				private string metricType;

				private string vSwitchIds;

				private string multiAzPolicy;

				private string specId;

				private int? duration;

				private long? createTime;

				private long? updateTime;

				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				public string Cond
				{
					get
					{
						return cond;
					}
					set	
					{
						cond = value;
					}
				}

				public int? Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				public int? Rt
				{
					get
					{
						return rt;
					}
					set	
					{
						rt = value;
					}
				}

				public string ResourceFrom
				{
					get
					{
						return resourceFrom;
					}
					set	
					{
						resourceFrom = value;
					}
				}

				public int? Step
				{
					get
					{
						return step;
					}
					set	
					{
						step = value;
					}
				}

				public int? InstNum
				{
					get
					{
						return instNum;
					}
					set	
					{
						instNum = value;
					}
				}

				public int? LoadNum
				{
					get
					{
						return loadNum;
					}
					set	
					{
						loadNum = value;
					}
				}

				public string TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
					}
				}

				public int? TemplateVersion
				{
					get
					{
						return templateVersion;
					}
					set	
					{
						templateVersion = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string MetricType
				{
					get
					{
						return metricType;
					}
					set	
					{
						metricType = value;
					}
				}

				public string VSwitchIds
				{
					get
					{
						return vSwitchIds;
					}
					set	
					{
						vSwitchIds = value;
					}
				}

				public string MultiAzPolicy
				{
					get
					{
						return multiAzPolicy;
					}
					set	
					{
						multiAzPolicy = value;
					}
				}

				public string SpecId
				{
					get
					{
						return specId;
					}
					set	
					{
						specId = value;
					}
				}

				public int? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
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

				public long? UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}
			}
		}
	}
}
