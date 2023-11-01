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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeAlertsCountResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeAlertsCount_Data data;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public DescribeAlertsCount_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeAlertsCount_Data
		{

			private long? high;

			private long? medium;

			private long? low;

			private long? all;

			private int? productNum;

			public long? High
			{
				get
				{
					return high;
				}
				set	
				{
					high = value;
				}
			}

			public long? Medium
			{
				get
				{
					return medium;
				}
				set	
				{
					medium = value;
				}
			}

			public long? Low
			{
				get
				{
					return low;
				}
				set	
				{
					low = value;
				}
			}

			public long? All
			{
				get
				{
					return all;
				}
				set	
				{
					all = value;
				}
			}

			public int? ProductNum
			{
				get
				{
					return productNum;
				}
				set	
				{
					productNum = value;
				}
			}
		}
	}
}
