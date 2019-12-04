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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeParameterGroupResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParameterGroup_ParameterGroup> paramGroup;

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

		public List<DescribeParameterGroup_ParameterGroup> ParamGroup
		{
			get
			{
				return paramGroup;
			}
			set	
			{
				paramGroup = value;
			}
		}

		public class DescribeParameterGroup_ParameterGroup
		{

			private int? parameterGroupType;

			private string parameterGroupName;

			private int? paramCounts;

			private string parameterGroupDesc;

			private int? forceRestart;

			private string engine;

			private string engineVersion;

			private string parameterGroupId;

			private string createTime;

			private string updateTime;

			private List<DescribeParameterGroup_ParameterDetail> paramDetail;

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

			public List<DescribeParameterGroup_ParameterDetail> ParamDetail
			{
				get
				{
					return paramDetail;
				}
				set	
				{
					paramDetail = value;
				}
			}

			public class DescribeParameterGroup_ParameterDetail
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
