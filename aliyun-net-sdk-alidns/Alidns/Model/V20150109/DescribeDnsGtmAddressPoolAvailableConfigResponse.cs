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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsGtmAddressPoolAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo> attributeInfos;

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

		public List<DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo> AttributeInfos
		{
			get
			{
				return attributeInfos;
			}
			set	
			{
				attributeInfos = value;
			}
		}

		public class DescribeDnsGtmAddressPoolAvailableConfig_AttributeInfo
		{

			private string lineCode;

			private string lineName;

			private string groupCode;

			private string groupName;

			private string fatherCode;

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string LineName
			{
				get
				{
					return lineName;
				}
				set	
				{
					lineName = value;
				}
			}

			public string GroupCode
			{
				get
				{
					return groupCode;
				}
				set	
				{
					groupCode = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string FatherCode
			{
				get
				{
					return fatherCode;
				}
				set	
				{
					fatherCode = value;
				}
			}
		}
	}
}
