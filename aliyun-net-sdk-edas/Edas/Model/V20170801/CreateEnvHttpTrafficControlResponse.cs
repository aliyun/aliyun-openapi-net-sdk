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
	public class CreateEnvHttpTrafficControlResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private CreateEnvHttpTrafficControl_Data data;

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

		public CreateEnvHttpTrafficControl_Data Data
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

		public class CreateEnvHttpTrafficControl_Data
		{

			private string accountId;

			private string appId;

			private string envName;

			private long? labelAdviceId;

			private string labelType;

			private long? pointcutId;

			private string regionId;

			private string tenantId;

			private CreateEnvHttpTrafficControl_Spec spec;

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

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

			public string EnvName
			{
				get
				{
					return envName;
				}
				set	
				{
					envName = value;
				}
			}

			public long? LabelAdviceId
			{
				get
				{
					return labelAdviceId;
				}
				set	
				{
					labelAdviceId = value;
				}
			}

			public string LabelType
			{
				get
				{
					return labelType;
				}
				set	
				{
					labelType = value;
				}
			}

			public long? PointcutId
			{
				get
				{
					return pointcutId;
				}
				set	
				{
					pointcutId = value;
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

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public CreateEnvHttpTrafficControl_Spec Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public class CreateEnvHttpTrafficControl_Spec
			{

				private string conditionType;

				private long? order;

				private int? percent;

				private string triggerPolicy;

				private string type;

				private string url;

				private string selector;

				private string serviceName;

				private string group;

				private string version;

				private string methodName;

				private string className;

				private bool? transmitSwitch;

				private int? transmitLevel;

				private List<CreateEnvHttpTrafficControl_ConditionsItem> conditions;

				private List<CreateEnvHttpTrafficControl_PurposesItem> purposes;

				private List<string> paramTypes;

				public string ConditionType
				{
					get
					{
						return conditionType;
					}
					set	
					{
						conditionType = value;
					}
				}

				public long? Order
				{
					get
					{
						return order;
					}
					set	
					{
						order = value;
					}
				}

				public int? Percent
				{
					get
					{
						return percent;
					}
					set	
					{
						percent = value;
					}
				}

				public string TriggerPolicy
				{
					get
					{
						return triggerPolicy;
					}
					set	
					{
						triggerPolicy = value;
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

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string Selector
				{
					get
					{
						return selector;
					}
					set	
					{
						selector = value;
					}
				}

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

				public string Group
				{
					get
					{
						return group;
					}
					set	
					{
						group = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string MethodName
				{
					get
					{
						return methodName;
					}
					set	
					{
						methodName = value;
					}
				}

				public string ClassName
				{
					get
					{
						return className;
					}
					set	
					{
						className = value;
					}
				}

				public bool? TransmitSwitch
				{
					get
					{
						return transmitSwitch;
					}
					set	
					{
						transmitSwitch = value;
					}
				}

				public int? TransmitLevel
				{
					get
					{
						return transmitLevel;
					}
					set	
					{
						transmitLevel = value;
					}
				}

				public List<CreateEnvHttpTrafficControl_ConditionsItem> Conditions
				{
					get
					{
						return conditions;
					}
					set	
					{
						conditions = value;
					}
				}

				public List<CreateEnvHttpTrafficControl_PurposesItem> Purposes
				{
					get
					{
						return purposes;
					}
					set	
					{
						purposes = value;
					}
				}

				public List<string> ParamTypes
				{
					get
					{
						return paramTypes;
					}
					set	
					{
						paramTypes = value;
					}
				}

				public class CreateEnvHttpTrafficControl_ConditionsItem
				{

					private long? id;

					private string strategy;

					private string type;

					private int? index;

					private string key;

					private string _operator;

					private List<string> values;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string Strategy
					{
						get
						{
							return strategy;
						}
						set	
						{
							strategy = value;
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

					public int? Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
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

					public string _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public List<string> Values
					{
						get
						{
							return values;
						}
						set	
						{
							values = value;
						}
					}
				}

				public class CreateEnvHttpTrafficControl_PurposesItem
				{

					private string type;

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
				}
			}
		}
	}
}
