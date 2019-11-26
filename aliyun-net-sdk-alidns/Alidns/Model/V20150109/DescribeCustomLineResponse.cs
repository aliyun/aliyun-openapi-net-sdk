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
	public class DescribeCustomLineResponse : AcsResponse
	{

		private string requestId;

		private long? id;

		private string name;

		private string domainName;

		private string createTime;

		private long? createTimestamp;

		private string ipSegments;

		private string code;

		private List<DescribeCustomLine_IpSegment> ipSegmentList;

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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
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

		public long? CreateTimestamp
		{
			get
			{
				return createTimestamp;
			}
			set	
			{
				createTimestamp = value;
			}
		}

		public string IpSegments
		{
			get
			{
				return ipSegments;
			}
			set	
			{
				ipSegments = value;
			}
		}

		public string Code
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

		public List<DescribeCustomLine_IpSegment> IpSegmentList
		{
			get
			{
				return ipSegmentList;
			}
			set	
			{
				ipSegmentList = value;
			}
		}

		public class DescribeCustomLine_IpSegment
		{

			private string name;

			private string startIp;

			private string endIp;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string StartIp
			{
				get
				{
					return startIp;
				}
				set	
				{
					startIp = value;
				}
			}

			public string EndIp
			{
				get
				{
					return endIp;
				}
				set	
				{
					endIp = value;
				}
			}
		}
	}
}
