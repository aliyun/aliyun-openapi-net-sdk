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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiStageResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private string stageId;

		private string stageName;

		private string description;

		private string createdTime;

		private string modifiedTime;

		private List<DescribeApiStage_VariableItem> variables;

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

		public string StageId
		{
			get
			{
				return stageId;
			}
			set	
			{
				stageId = value;
			}
		}

		public string StageName
		{
			get
			{
				return stageName;
			}
			set	
			{
				stageName = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
			}
		}

		public string ModifiedTime
		{
			get
			{
				return modifiedTime;
			}
			set	
			{
				modifiedTime = value;
			}
		}

		public List<DescribeApiStage_VariableItem> Variables
		{
			get
			{
				return variables;
			}
			set	
			{
				variables = value;
			}
		}

		public class DescribeApiStage_VariableItem
		{

			private string variableName;

			private string variableValue;

			private bool? supportRoute;

			private DescribeApiStage_StageRouteModel stageRouteModel;

			public string VariableName
			{
				get
				{
					return variableName;
				}
				set	
				{
					variableName = value;
				}
			}

			public string VariableValue
			{
				get
				{
					return variableValue;
				}
				set	
				{
					variableValue = value;
				}
			}

			public bool? SupportRoute
			{
				get
				{
					return supportRoute;
				}
				set	
				{
					supportRoute = value;
				}
			}

			public DescribeApiStage_StageRouteModel StageRouteModel
			{
				get
				{
					return stageRouteModel;
				}
				set	
				{
					stageRouteModel = value;
				}
			}

			public class DescribeApiStage_StageRouteModel
			{

				private string parameterCatalog;

				private string serviceParameterName;

				private string location;

				private string parameterType;

				private string routeMatchSymbol;

				private List<DescribeApiStage_RouteRuleItem> routeRules;

				public string ParameterCatalog
				{
					get
					{
						return parameterCatalog;
					}
					set	
					{
						parameterCatalog = value;
					}
				}

				public string ServiceParameterName
				{
					get
					{
						return serviceParameterName;
					}
					set	
					{
						serviceParameterName = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string ParameterType
				{
					get
					{
						return parameterType;
					}
					set	
					{
						parameterType = value;
					}
				}

				public string RouteMatchSymbol
				{
					get
					{
						return routeMatchSymbol;
					}
					set	
					{
						routeMatchSymbol = value;
					}
				}

				public List<DescribeApiStage_RouteRuleItem> RouteRules
				{
					get
					{
						return routeRules;
					}
					set	
					{
						routeRules = value;
					}
				}

				public class DescribeApiStage_RouteRuleItem
				{

					private long? maxValue;

					private long? minValue;

					private string conditionValue;

					private string resultValue;

					public long? MaxValue
					{
						get
						{
							return maxValue;
						}
						set	
						{
							maxValue = value;
						}
					}

					public long? MinValue
					{
						get
						{
							return minValue;
						}
						set	
						{
							minValue = value;
						}
					}

					public string ConditionValue
					{
						get
						{
							return conditionValue;
						}
						set	
						{
							conditionValue = value;
						}
					}

					public string ResultValue
					{
						get
						{
							return resultValue;
						}
						set	
						{
							resultValue = value;
						}
					}
				}
			}
		}
	}
}
