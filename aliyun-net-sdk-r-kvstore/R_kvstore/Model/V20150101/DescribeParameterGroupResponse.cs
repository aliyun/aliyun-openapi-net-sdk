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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeParameterGroupResponse : AcsResponse
	{

		private string requestId;

		private DescribeParameterGroup_ParameterGroup parameterGroup;

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

		public DescribeParameterGroup_ParameterGroup ParameterGroup
		{
			get
			{
				return parameterGroup;
			}
			set	
			{
				parameterGroup = value;
			}
		}

		public class DescribeParameterGroup_ParameterGroup
		{

			private string engineVersion;

			private string modified;

			private string parameterGroupName;

			private string parameterGroupDesc;

			private string engine;

			private string paramGroupId;

			private string created;

			private long? category;

			private List<DescribeParameterGroup_ParamGroupDetail> paramGroupsDetails;

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

			public string Modified
			{
				get
				{
					return modified;
				}
				set	
				{
					modified = value;
				}
			}

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

			public string ParamGroupId
			{
				get
				{
					return paramGroupId;
				}
				set	
				{
					paramGroupId = value;
				}
			}

			public string Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public long? Category
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

			public List<DescribeParameterGroup_ParamGroupDetail> ParamGroupsDetails
			{
				get
				{
					return paramGroupsDetails;
				}
				set	
				{
					paramGroupsDetails = value;
				}
			}

			public class DescribeParameterGroup_ParamGroupDetail
			{

				private string paramName;

				private string paramValue;

				public string ParamName
				{
					get
					{
						return paramName;
					}
					set	
					{
						paramName = value;
					}
				}

				public string ParamValue
				{
					get
					{
						return paramValue;
					}
					set	
					{
						paramValue = value;
					}
				}
			}
		}
	}
}
