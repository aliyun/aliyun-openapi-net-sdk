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
	public class DescribeLogStoreResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string errCode;

		private string requestId;

		private string dyCode;

		private string dyMessage;

		private DescribeLogStore_Data data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
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

		public string DyCode
		{
			get
			{
				return dyCode;
			}
			set	
			{
				dyCode = value;
			}
		}

		public string DyMessage
		{
			get
			{
				return dyMessage;
			}
			set	
			{
				dyMessage = value;
			}
		}

		public DescribeLogStore_Data Data
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

		public class DescribeLogStore_Data
		{

			private string logStoreName;

			private int? ttl;

			private int? shardCount;

			private bool? enableTracking;

			private bool? autoSplit;

			private int? maxSplitShard;

			private bool? appendMeta;

			public string LogStoreName
			{
				get
				{
					return logStoreName;
				}
				set	
				{
					logStoreName = value;
				}
			}

			public int? Ttl
			{
				get
				{
					return ttl;
				}
				set	
				{
					ttl = value;
				}
			}

			public int? ShardCount
			{
				get
				{
					return shardCount;
				}
				set	
				{
					shardCount = value;
				}
			}

			public bool? EnableTracking
			{
				get
				{
					return enableTracking;
				}
				set	
				{
					enableTracking = value;
				}
			}

			public bool? AutoSplit
			{
				get
				{
					return autoSplit;
				}
				set	
				{
					autoSplit = value;
				}
			}

			public int? MaxSplitShard
			{
				get
				{
					return maxSplitShard;
				}
				set	
				{
					maxSplitShard = value;
				}
			}

			public bool? AppendMeta
			{
				get
				{
					return appendMeta;
				}
				set	
				{
					appendMeta = value;
				}
			}
		}
	}
}
