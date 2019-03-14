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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterServiceConfigTagResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeClusterServiceConfigTag_ConfigTag> configTagList;

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

		public List<DescribeClusterServiceConfigTag_ConfigTag> ConfigTagList
		{
			get
			{
				return configTagList;
			}
			set	
			{
				configTagList = value;
			}
		}

		public class DescribeClusterServiceConfigTag_ConfigTag
		{

			private string tag;

			private string tagDesc;

			private List<DescribeClusterServiceConfigTag__Value> valueList;

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string TagDesc
			{
				get
				{
					return tagDesc;
				}
				set	
				{
					tagDesc = value;
				}
			}

			public List<DescribeClusterServiceConfigTag__Value> ValueList
			{
				get
				{
					return valueList;
				}
				set	
				{
					valueList = value;
				}
			}

			public class DescribeClusterServiceConfigTag__Value
			{

				private string _value;

				private string valueDesc;

				public string _Value
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

				public string ValueDesc
				{
					get
					{
						return valueDesc;
					}
					set	
					{
						valueDesc = value;
					}
				}
			}
		}
	}
}
