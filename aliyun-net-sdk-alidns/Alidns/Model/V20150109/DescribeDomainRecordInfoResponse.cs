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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainRecordInfoResponse : AcsResponse
	{

		private string domainId;

		private string domainName;

		private string punyCode;

		private string groupId;

		private string groupName;

		private string recordId;

		private string rR;

		private string type;

		private string value_;

		private long? tTL;

		private long? priority;

		private string line;

		private string status;

		private bool? locked;

		public string DomainId
		{
			get
			{
				return domainId;
			}
			set	
			{
				domainId = value;
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

		public string PunyCode
		{
			get
			{
				return punyCode;
			}
			set	
			{
				punyCode = value;
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
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

		public string RecordId
		{
			get
			{
				return recordId;
			}
			set	
			{
				recordId = value;
			}
		}

		public string RR
		{
			get
			{
				return rR;
			}
			set	
			{
				rR = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string Value
		{
			get
			{
				return value_;
			}
			set	
			{
				value_ = value;
			}
		}

		public long? TTL
		{
			get
			{
				return tTL;
			}
			set	
			{
				tTL = value;
			}
		}

		public long? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
			}
		}

		public string Line
		{
			get
			{
				return line;
			}
			set	
			{
				line = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public bool? Locked
		{
			get
			{
				return locked;
			}
			set	
			{
				locked = value;
			}
		}
	}
}