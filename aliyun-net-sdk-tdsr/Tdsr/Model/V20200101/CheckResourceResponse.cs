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

namespace Aliyun.Acs.tdsr.Model.V20200101
{
	public class CheckResourceResponse : AcsResponse
	{

		private bool? interrupt;

		private string invoker;

		private string pk;

		private string bid;

		private long? hid;

		private string country;

		private string taskIdentifier;

		private string taskExtraData;

		private string gmtWakeup;

		private bool? success;

		private string message;

		private long? level;

		private string url;

		private string prompt;

		private string requestId;

		public bool? Interrupt
		{
			get
			{
				return interrupt;
			}
			set	
			{
				interrupt = value;
			}
		}

		public string Invoker
		{
			get
			{
				return invoker;
			}
			set	
			{
				invoker = value;
			}
		}

		public string Pk
		{
			get
			{
				return pk;
			}
			set	
			{
				pk = value;
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
			}
		}

		public long? Hid
		{
			get
			{
				return hid;
			}
			set	
			{
				hid = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
			}
		}

		public string TaskIdentifier
		{
			get
			{
				return taskIdentifier;
			}
			set	
			{
				taskIdentifier = value;
			}
		}

		public string TaskExtraData
		{
			get
			{
				return taskExtraData;
			}
			set	
			{
				taskExtraData = value;
			}
		}

		public string GmtWakeup
		{
			get
			{
				return gmtWakeup;
			}
			set	
			{
				gmtWakeup = value;
			}
		}

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

		public long? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
			}
		}

		public string Prompt
		{
			get
			{
				return prompt;
			}
			set	
			{
				prompt = value;
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
	}
}
