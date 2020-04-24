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
	public class ListJournalsResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private int? maxResults;

		private List<ListJournals_Journal> journals;

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

		public List<ListJournals_Journal> Journals
		{
			get
			{
				return journals;
			}
			set	
			{
				journals = value;
			}
		}

		public class ListJournals_Journal
		{

			private string journalId;

			private string ledgerId;

			private string payloadType;

			private string payloadJsonString;

			private string memberId;

			private string clientId;

			private string journalHash;

			private long? timestamp;

			private List<string> clues;

			public string JournalId
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

			public string LedgerId
			{
				get
				{
					return ledgerId;
				}
				set	
				{
					ledgerId = value;
				}
			}

			public string PayloadType
			{
				get
				{
					return payloadType;
				}
				set	
				{
					payloadType = value;
				}
			}

			public string PayloadJsonString
			{
				get
				{
					return payloadJsonString;
				}
				set	
				{
					payloadJsonString = value;
				}
			}

			public string MemberId
			{
				get
				{
					return memberId;
				}
				set	
				{
					memberId = value;
				}
			}

			public string ClientId
			{
				get
				{
					return clientId;
				}
				set	
				{
					clientId = value;
				}
			}

			public string JournalHash
			{
				get
				{
					return journalHash;
				}
				set	
				{
					journalHash = value;
				}
			}

			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public List<string> Clues
			{
				get
				{
					return clues;
				}
				set	
				{
					clues = value;
				}
			}
		}
	}
}
