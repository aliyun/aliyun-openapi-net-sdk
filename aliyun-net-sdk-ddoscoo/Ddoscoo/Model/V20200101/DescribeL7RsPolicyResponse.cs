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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeL7RsPolicyResponse : AcsResponse
	{

		private string requestId;

		private string proxyMode;

		private List<DescribeL7RsPolicy_AttributeItem> attributes;

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

		public string ProxyMode
		{
			get
			{
				return proxyMode;
			}
			set	
			{
				proxyMode = value;
			}
		}

		public List<DescribeL7RsPolicy_AttributeItem> Attributes
		{
			get
			{
				return attributes;
			}
			set	
			{
				attributes = value;
			}
		}

		public class DescribeL7RsPolicy_AttributeItem
		{

			private int? rsType;

			private string realServer;

			private DescribeL7RsPolicy_Attribute attribute;

			public int? RsType
			{
				get
				{
					return rsType;
				}
				set	
				{
					rsType = value;
				}
			}

			public string RealServer
			{
				get
				{
					return realServer;
				}
				set	
				{
					realServer = value;
				}
			}

			public DescribeL7RsPolicy_Attribute Attribute
			{
				get
				{
					return attribute;
				}
				set	
				{
					attribute = value;
				}
			}

			public class DescribeL7RsPolicy_Attribute
			{

				private int? weight;

				public int? Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}
			}
		}
	}
}
