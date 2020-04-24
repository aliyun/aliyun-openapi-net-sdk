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
    public class DescribeLedgerResponseUnmarshaller
    {
        public static DescribeLedgerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLedgerResponse describeLedgerResponse = new DescribeLedgerResponse();

			describeLedgerResponse.HttpResponse = context.HttpResponse;
			describeLedgerResponse.RequestId = context.StringValue("DescribeLedger.RequestId");

			DescribeLedgerResponse.DescribeLedger_Ledger ledger = new DescribeLedgerResponse.DescribeLedger_Ledger();
			ledger.LedgerId = context.StringValue("DescribeLedger.Ledger.LedgerId");
			ledger.LedgerName = context.StringValue("DescribeLedger.Ledger.LedgerName");
			ledger.LedgerDescription = context.StringValue("DescribeLedger.Ledger.LedgerDescription");
			ledger.LedgerType = context.StringValue("DescribeLedger.Ledger.LedgerType");
			ledger.OwnerAliUid = context.StringValue("DescribeLedger.Ledger.OwnerAliUid");
			ledger.RegionId = context.StringValue("DescribeLedger.Ledger.RegionId");
			ledger.ZoneId = context.StringValue("DescribeLedger.Ledger.ZoneId");
			ledger.CreateTime = context.StringValue("DescribeLedger.Ledger.CreateTime");
			ledger.UpdateTime = context.StringValue("DescribeLedger.Ledger.UpdateTime");
			ledger.LedgerStatus = context.StringValue("DescribeLedger.Ledger.LedgerStatus");
			ledger.JournalCount = context.LongValue("DescribeLedger.Ledger.JournalCount");
			ledger.MemberCount = context.LongValue("DescribeLedger.Ledger.MemberCount");
			ledger.TimeAnchorCount = context.LongValue("DescribeLedger.Ledger.TimeAnchorCount");

			DescribeLedgerResponse.DescribeLedger_Ledger.DescribeLedger_LastTimeAnchor lastTimeAnchor = new DescribeLedgerResponse.DescribeLedger_Ledger.DescribeLedger_LastTimeAnchor();
			lastTimeAnchor.JournalId = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.JournalId");
			lastTimeAnchor.LedgerDigest = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.LedgerDigest");
			lastTimeAnchor.LedgerDigestType = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.LedgerDigestType");
			lastTimeAnchor.LedgerVersion = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.LedgerVersion");
			lastTimeAnchor.Proof = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.Proof");
			lastTimeAnchor.TimeStamp = context.StringValue("DescribeLedger.Ledger.LastTimeAnchor.TimeStamp");
			ledger.LastTimeAnchor = lastTimeAnchor;
			describeLedgerResponse.Ledger = ledger;
        
			return describeLedgerResponse;
        }
    }
}
