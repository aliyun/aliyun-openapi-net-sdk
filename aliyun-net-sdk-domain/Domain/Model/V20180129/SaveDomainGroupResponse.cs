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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class SaveDomainGroupResponse : AcsResponse
	{

		private bool? beingDeleted;

		private string creationDate;

		private string requestId;

		private string domainGroupName;

		private string modificationDate;

		private string domainGroupStatus;

		private long? domainGroupId;

		private int? totalNumber;

		public bool? BeingDeleted
		{
			get
			{
				return beingDeleted;
			}
			set	
			{
				beingDeleted = value;
			}
		}

		public string CreationDate
		{
			get
			{
				return creationDate;
			}
			set	
			{
				creationDate = value;
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

		public string DomainGroupName
		{
			get
			{
				return domainGroupName;
			}
			set	
			{
				domainGroupName = value;
			}
		}

		public string ModificationDate
		{
			get
			{
				return modificationDate;
			}
			set	
			{
				modificationDate = value;
			}
		}

		public string DomainGroupStatus
		{
			get
			{
				return domainGroupStatus;
			}
			set	
			{
				domainGroupStatus = value;
			}
		}

		public long? DomainGroupId
		{
			get
			{
				return domainGroupId;
			}
			set	
			{
				domainGroupId = value;
			}
		}

		public int? TotalNumber
		{
			get
			{
				return totalNumber;
			}
			set	
			{
				totalNumber = value;
			}
		}
	}
}
