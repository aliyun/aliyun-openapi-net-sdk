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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeIPv6TranslatorAclListAttributesResponse : AcsResponse
	{

		private string requestId;

		private string aclId;

		private string aclName;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeIPv6TranslatorAclListAttributes_AclEntry> aclEntries;

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

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
			}
		}

		public string AclName
		{
			get
			{
				return aclName;
			}
			set	
			{
				aclName = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeIPv6TranslatorAclListAttributes_AclEntry> AclEntries
		{
			get
			{
				return aclEntries;
			}
			set	
			{
				aclEntries = value;
			}
		}

		public class DescribeIPv6TranslatorAclListAttributes_AclEntry
		{

			private string aclEntryId;

			private string aclEntryIp;

			private string aclEntryComment;

			public string AclEntryId
			{
				get
				{
					return aclEntryId;
				}
				set	
				{
					aclEntryId = value;
				}
			}

			public string AclEntryIp
			{
				get
				{
					return aclEntryIp;
				}
				set	
				{
					aclEntryIp = value;
				}
			}

			public string AclEntryComment
			{
				get
				{
					return aclEntryComment;
				}
				set	
				{
					aclEntryComment = value;
				}
			}
		}
	}
}
