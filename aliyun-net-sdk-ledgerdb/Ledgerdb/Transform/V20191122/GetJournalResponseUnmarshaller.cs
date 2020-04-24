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
    public class GetJournalResponseUnmarshaller
    {
        public static GetJournalResponse Unmarshall(UnmarshallerContext context)
        {
			GetJournalResponse getJournalResponse = new GetJournalResponse();

			getJournalResponse.HttpResponse = context.HttpResponse;
			getJournalResponse.RequestId = context.StringValue("GetJournal.RequestId");

			GetJournalResponse.GetJournal_Journal journal = new GetJournalResponse.GetJournal_Journal();
			journal.JournalId = context.StringValue("GetJournal.Journal.JournalId");
			journal.LedgerId = context.StringValue("GetJournal.Journal.LedgerId");
			journal.PayloadType = context.StringValue("GetJournal.Journal.PayloadType");
			journal.PayloadJsonString = context.StringValue("GetJournal.Journal.PayloadJsonString");
			journal.MemberId = context.StringValue("GetJournal.Journal.MemberId");
			journal.ClientId = context.StringValue("GetJournal.Journal.ClientId");
			journal.JournalHash = context.StringValue("GetJournal.Journal.JournalHash");
			journal.Timestamp = context.LongValue("GetJournal.Journal.Timestamp");

			List<string> journal_clues = new List<string>();
			for (int i = 0; i < context.Length("GetJournal.Journal.Clues.Length"); i++) {
				journal_clues.Add(context.StringValue("GetJournal.Journal.Clues["+ i +"]"));
			}
			journal.Clues = journal_clues;
			getJournalResponse.Journal = journal;
        
			return getJournalResponse;
        }
    }
}
