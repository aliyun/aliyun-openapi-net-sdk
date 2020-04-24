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

namespace Aliyun.Acs.ledgerdb.Model.V20191122
{
	public class ListTimeAnchorsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListTimeAnchors_TimeAnchor> timeAnchors;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListTimeAnchors_TimeAnchor> TimeAnchors
		{
			get
			{
				return timeAnchors;
			}
			set	
			{
				timeAnchors = value;
			}
		}

		public class ListTimeAnchors_TimeAnchor
		{

			private long? journalId;

			private long? ledgerVersion;

			private string ledgerDigest;

			private string ledgerDigestType;

			private long? timeStamp;

			private string proof;

			public long? JournalId
			{
				get
				{
					return journalId;
				}
				set	
				{
					journalId = value;
				}
			}

			public long? LedgerVersion
			{
				get
				{
					return ledgerVersion;
				}
				set	
				{
					ledgerVersion = value;
				}
			}

			public string LedgerDigest
			{
				get
				{
					return ledgerDigest;
				}
				set	
				{
					ledgerDigest = value;
				}
			}

			public string LedgerDigestType
			{
				get
				{
					return ledgerDigestType;
				}
				set	
				{
					ledgerDigestType = value;
				}
			}

			public long? TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string Proof
			{
				get
				{
					return proof;
				}
				set	
				{
					proof = value;
				}
			}
		}
	}
}
