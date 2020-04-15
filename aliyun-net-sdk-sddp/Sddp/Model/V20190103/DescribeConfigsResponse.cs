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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeConfigsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeConfigs_Config> configList;

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

		public List<DescribeConfigs_Config> ConfigList
		{
			get
			{
				return configList;
			}
			set	
			{
				configList = value;
			}
		}

		public class DescribeConfigs_Config
		{

			private long? id;

			private int? code;

			private string description;

			private long? _value;

			private string defaultValue;

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

			public long? _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
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
		}
	}
}
