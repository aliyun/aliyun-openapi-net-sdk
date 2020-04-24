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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ledgerdb.Model.V20191122;

namespace Aliyun.Acs.ledgerdb.Transform.V20191122
{
    public class DescribeLedgersResponseUnmarshaller
    {
        public static DescribeLedgersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLedgersResponse describeLedgersResponse = new DescribeLedgersResponse();

			describeLedgersResponse.HttpResponse = context.HttpResponse;
			describeLedgersResponse.RequestId = context.StringValue("DescribeLedgers.RequestId");
			describeLedgersResponse.NextToken = context.StringValue("DescribeLedgers.NextToken");
			describeLedgersResponse.MaxResults = context.IntegerValue("DescribeLedgers.MaxResults");

			List<DescribeLedgersResponse.DescribeLedgers_Ledger> describeLedgersResponse_ledgers = new List<DescribeLedgersResponse.DescribeLedgers_Ledger>();
			for (int i = 0; i < context.Length("DescribeLedgers.Ledgers.Length"); i++) {
				DescribeLedgersResponse.DescribeLedgers_Ledger ledger = new DescribeLedgersResponse.DescribeLedgers_Ledger();
				ledger.LedgerId = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LedgerId");
				ledger.LedgerName = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LedgerName");
				ledger.LedgerDescription = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LedgerDescription");
				ledger.LedgerType = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LedgerType");
				ledger.OwnerAliUid = context.StringValue("DescribeLedgers.Ledgers["+ i +"].OwnerAliUid");
				ledger.RegionId = context.StringValue("DescribeLedgers.Ledgers["+ i +"].RegionId");
				ledger.ZoneId = context.StringValue("DescribeLedgers.Ledgers["+ i +"].ZoneId");
				ledger.CreateTime = context.StringValue("DescribeLedgers.Ledgers["+ i +"].CreateTime");
				ledger.UpdateTime = context.StringValue("DescribeLedgers.Ledgers["+ i +"].UpdateTime");
				ledger.LedgerStatus = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LedgerStatus");
				ledger.JournalCount = context.LongValue("DescribeLedgers.Ledgers["+ i +"].JournalCount");
				ledger.MemberCount = context.LongValue("DescribeLedgers.Ledgers["+ i +"].MemberCount");
				ledger.TimeAnchorCount = context.LongValue("DescribeLedgers.Ledgers["+ i +"].TimeAnchorCount");

				DescribeLedgersResponse.DescribeLedgers_Ledger.DescribeLedgers_LastTimeAnchor lastTimeAnchor = new DescribeLedgersResponse.DescribeLedgers_Ledger.DescribeLedgers_LastTimeAnchor();
				lastTimeAnchor.JournalId = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.JournalId");
				lastTimeAnchor.LedgerDigest = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.LedgerDigest");
				lastTimeAnchor.LedgerDigestType = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.LedgerDigestType");
				lastTimeAnchor.LedgerVersion = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.LedgerVersion");
				lastTimeAnchor.Proof = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.Proof");
				lastTimeAnchor.TimeStamp = context.StringValue("DescribeLedgers.Ledgers["+ i +"].LastTimeAnchor.TimeStamp");
				ledger.LastTimeAnchor = lastTimeAnchor;

				describeLedgersResponse_ledgers.Add(ledger);
			}
			describeLedgersResponse.Ledgers = describeLedgersResponse_ledgers;
        
			return describeLedgersResponse;
        }
    }
}
