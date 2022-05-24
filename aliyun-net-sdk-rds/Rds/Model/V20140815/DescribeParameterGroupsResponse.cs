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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeParameterGroupsResponse : AcsResponse
	{

		private bool? signalForOptimizeParams;

		private string requestId;

		private List<DescribeParameterGroups_ParameterGroup> parameterGroups;

		[JsonProperty(PropertyName = "SignalForOptimizeParams")]
		public bool? SignalForOptimizeParams
		{
			get
			{
				return signalForOptimizeParams;
			}
			set	
			{
				signalForOptimizeParams = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ParameterGroups")]
		public List<DescribeParameterGroups_ParameterGroup> ParameterGroups
		{
			get
			{
				return parameterGroups;
			}
			set	
			{
				parameterGroups = value;
			}
		}

		public class DescribeParameterGroups_ParameterGroup
		{

			private string updateTime;

			private string parameterGroupDesc;

			private string createTime;

			private int? forceRestart;

			private string parameterGroupId;

			private string parameterGroupName;

			private string engine;

			private int? paramCounts;

			private string engineVersion;

			private int? parameterGroupType;

			[JsonProperty(PropertyName = "UpdateTime")]
			public string UpdateTime
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

			[JsonProperty(PropertyName = "ParameterGroupDesc")]
			public string ParameterGroupDesc
			{
				get
				{
					return parameterGroupDesc;
				}
				set	
				{
					parameterGroupDesc = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
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

			[JsonProperty(PropertyName = "ForceRestart")]
			public int? ForceRestart
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

			[JsonProperty(PropertyName = "ParameterGroupId")]
			public string ParameterGroupId
			{
				get
				{
					return parameterGroupId;
				}
				set	
				{
					parameterGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterGroupName")]
			public string ParameterGroupName
			{
				get
				{
					return parameterGroupName;
				}
				set	
				{
					parameterGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
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

			[JsonProperty(PropertyName = "ParamCounts")]
			public int? ParamCounts
			{
				get
				{
					return paramCounts;
				}
				set	
				{
					paramCounts = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			[JsonProperty(PropertyName = "ParameterGroupType")]
			public int? ParameterGroupType
			{
				get
				{
					return parameterGroupType;
				}
				set	
				{
					parameterGroupType = value;
				}
			}
		}
	}
}
