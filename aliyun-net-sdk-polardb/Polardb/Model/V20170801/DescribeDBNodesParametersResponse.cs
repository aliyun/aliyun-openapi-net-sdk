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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBNodesParametersResponse : AcsResponse
	{

		private string dBVersion;

		private string requestId;

		private string dBType;

		private string engine;

		private List<DescribeDBNodesParameters_DBNodeParameter> dBNodeIds;

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

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

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public List<DescribeDBNodesParameters_DBNodeParameter> DBNodeIds
		{
			get
			{
				return dBNodeIds;
			}
			set	
			{
				dBNodeIds = value;
			}
		}

		public class DescribeDBNodesParameters_DBNodeParameter
		{

			private string dBNodeId;

			private List<DescribeDBNodesParameters_Parameter> runningParameters;

			public string DBNodeId
			{
				get
				{
					return dBNodeId;
				}
				set	
				{
					dBNodeId = value;
				}
			}

			public List<DescribeDBNodesParameters_Parameter> RunningParameters
			{
				get
				{
					return runningParameters;
				}
				set	
				{
					runningParameters = value;
				}
			}

			public class DescribeDBNodesParameters_Parameter
			{

				private string checkingCode;

				private string dataType;

				private string defaultParameterValue;

				private bool? forceRestart;

				private bool? isModifiable;

				private string parameterDescription;

				private string parameterName;

				private string parameterStatus;

				private string parameterValue;

				private string isNodeAvailable;

				private string paramRelyRule;

				public string CheckingCode
				{
					get
					{
						return checkingCode;
					}
					set	
					{
						checkingCode = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string DefaultParameterValue
				{
					get
					{
						return defaultParameterValue;
					}
					set	
					{
						defaultParameterValue = value;
					}
				}

				public bool? ForceRestart
				{
					get
					{
						return forceRestart;
					}
					set	
					{
						forceRestart = value;
					}
				}

				public bool? IsModifiable
				{
					get
					{
						return isModifiable;
					}
					set	
					{
						isModifiable = value;
					}
				}

				public string ParameterDescription
				{
					get
					{
						return parameterDescription;
					}
					set	
					{
						parameterDescription = value;
					}
				}

				public string ParameterName
				{
					get
					{
						return parameterName;
					}
					set	
					{
						parameterName = value;
					}
				}

				public string ParameterStatus
				{
					get
					{
						return parameterStatus;
					}
					set	
					{
						parameterStatus = value;
					}
				}

				public string ParameterValue
				{
					get
					{
						return parameterValue;
					}
					set	
					{
						parameterValue = value;
					}
				}

				public string IsNodeAvailable
				{
					get
					{
						return isNodeAvailable;
					}
					set	
					{
						isNodeAvailable = value;
					}
				}

				public string ParamRelyRule
				{
					get
					{
						return paramRelyRule;
					}
					set	
					{
						paramRelyRule = value;
					}
				}
			}
		}
	}
}
