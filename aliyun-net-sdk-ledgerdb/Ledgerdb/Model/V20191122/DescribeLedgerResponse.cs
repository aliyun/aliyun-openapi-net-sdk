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
	public class DescribeLedgerResponse : AcsResponse
	{

		private string requestId;

		private DescribeLedger_Ledger ledger;

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

		public DescribeLedger_Ledger Ledger
		{
			get
			{
				return ledger;
			}
			set	
			{
				ledger = value;
			}
		}

		public class DescribeLedger_Ledger
		{

			private string ledgerId;

			private string ledgerName;

			private string ledgerDescription;

			private string ledgerType;

			private string ownerAliUid;

			private string regionId;

			private string zoneId;

			private string createTime;

			private string updateTime;

			private string ledgerStatus;

			private long? journalCount;

			private long? memberCount;

			private long? timeAnchorCount;

			private DescribeLedger_LastTimeAnchor lastTimeAnchor;

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

			public string LedgerName
			{
				get
				{
					return ledgerName;
				}
				set	
				{
					ledgerName = value;
				}
			}

			public string LedgerDescription
			{
				get
				{
					return ledgerDescription;
				}
				set	
				{
					ledgerDescription = value;
				}
			}

			public string LedgerType
			{
				get
				{
					return ledgerType;
				}
				set	
				{
					ledgerType = value;
				}
			}

			public string OwnerAliUid
			{
				get
				{
					return ownerAliUid;
				}
				set	
				{
					ownerAliUid = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string LedgerStatus
			{
				get
				{
					return ledgerStatus;
				}
				set	
				{
					ledgerStatus = value;
				}
			}

			public long? JournalCount
			{
				get
				{
					return journalCount;
				}
				set	
				{
					journalCount = value;
				}
			}

			public long? MemberCount
			{
				get
				{
					return memberCount;
				}
				set	
				{
					memberCount = value;
				}
			}

			public long? TimeAnchorCount
			{
				get
				{
					return timeAnchorCount;
				}
				set	
				{
					timeAnchorCount = value;
				}
			}

			public DescribeLedger_LastTimeAnchor LastTimeAnchor
			{
				get
				{
					return lastTimeAnchor;
				}
				set	
				{
					lastTimeAnchor = value;
				}
			}

			public class DescribeLedger_LastTimeAnchor
			{

				private string journalId;

				private string ledgerDigest;

				private string ledgerDigestType;

				private string ledgerVersion;

				private string proof;

				private string timeStamp;

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

				public string LedgerVersion
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

				public string TimeStamp
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
			}
		}
	}
}
