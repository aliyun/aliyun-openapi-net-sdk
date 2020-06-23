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

namespace Aliyun.Acs.Domain.Model.V20180208
{
	public class QueryDomainTransferStatusResponse : AcsResponse
	{

		private string requestId;

		private List<QueryDomainTransferStatus_DomainTransferStatusItem> domainTransferStatus;

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

		public List<QueryDomainTransferStatus_DomainTransferStatusItem> DomainTransferStatus
		{
			get
			{
				return domainTransferStatus;
			}
			set	
			{
				domainTransferStatus = value;
			}
		}

		public class QueryDomainTransferStatus_DomainTransferStatusItem
		{

			private string domainStatusDescription;

			private string domainName;

			public string DomainStatusDescription
			{
				get
				{
					return domainStatusDescription;
				}
				set	
				{
					domainStatusDescription = value;
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
		}
	}
}
