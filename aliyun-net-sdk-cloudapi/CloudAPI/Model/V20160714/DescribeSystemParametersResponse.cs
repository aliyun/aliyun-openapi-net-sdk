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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeSystemParametersResponse : AcsResponse
	{

		private List<SystemParamItem> systemParams;

		public List<SystemParamItem> SystemParams
		{
			get
			{
				return systemParams;
			}
			set	
			{
				systemParams = value;
			}
		}

		public class SystemParamItem{

			private string paramName;

			private string paramType;

			private string demoValue;

			private string description;

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

			public string ParamType
			{
				get
				{
					return paramType;
				}
				set	
				{
					paramType = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
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
		}
	}
}