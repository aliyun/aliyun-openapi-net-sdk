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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeParameterGroupResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParameterGroup_ParameterGroupItem> parameterGroup;

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

		public List<DescribeParameterGroup_ParameterGroupItem> ParameterGroup
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

		public class DescribeParameterGroup_ParameterGroupItem
		{

			private string dBVersion;

			private string parameterGroupId;

			private string forceRestart;

			private string parameterGroupName;

			private string createTime;

			private string parameterGroupDesc;

			private string parameterGroupType;

			private int? parameterCounts;

			private string dBType;

			private List<DescribeParameterGroup_ParameterDetailItem> parameterDetail;

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

			public string ForceRestart
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

			public string ParameterGroupType
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

			public int? ParameterCounts
			{
				get
				{
					return parameterCounts;
				}
				set	
				{
					parameterCounts = value;
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

			public List<DescribeParameterGroup_ParameterDetailItem> ParameterDetail
			{
				get
				{
					return parameterDetail;
				}
				set	
				{
					parameterDetail = value;
				}
			}

			public class DescribeParameterGroup_ParameterDetailItem
			{

				private string paramValue;

				private string paramName;

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
			}
		}
	}
}
