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
    public class ListJournalsResponseUnmarshaller
    {
        public static ListJournalsResponse Unmarshall(UnmarshallerContext context)
        {
			ListJournalsResponse listJournalsResponse = new ListJournalsResponse();

			listJournalsResponse.HttpResponse = context.HttpResponse;
			listJournalsResponse.RequestId = context.StringValue("ListJournals.RequestId");
			listJournalsResponse.NextToken = context.StringValue("ListJournals.NextToken");
			listJournalsResponse.MaxResults = context.IntegerValue("ListJournals.MaxResults");

			List<ListJournalsResponse.ListJournals_Journal> listJournalsResponse_journals = new List<ListJournalsResponse.ListJournals_Journal>();
			for (int i = 0; i < context.Length("ListJournals.Journals.Length"); i++) {
				ListJournalsResponse.ListJournals_Journal journal = new ListJournalsResponse.ListJournals_Journal();
				journal.JournalId = context.StringValue("ListJournals.Journals["+ i +"].JournalId");
				journal.LedgerId = context.StringValue("ListJournals.Journals["+ i +"].LedgerId");
				journal.PayloadType = context.StringValue("ListJournals.Journals["+ i +"].PayloadType");
				journal.PayloadJsonString = context.StringValue("ListJournals.Journals["+ i +"].PayloadJsonString");
				journal.MemberId = context.StringValue("ListJournals.Journals["+ i +"].MemberId");
				journal.ClientId = context.StringValue("ListJournals.Journals["+ i +"].ClientId");
				journal.JournalHash = context.StringValue("ListJournals.Journals["+ i +"].JournalHash");
				journal.Timestamp = context.LongValue("ListJournals.Journals["+ i +"].Timestamp");

				List<string> journal_clues = new List<string>();
				for (int j = 0; j < context.Length("ListJournals.Journals["+ i +"].Clues.Length"); j++) {
					journal_clues.Add(context.StringValue("ListJournals.Journals["+ i +"].Clues["+ j +"]"));
				}
				journal.Clues = journal_clues;

				listJournalsResponse_journals.Add(journal);
			}
			listJournalsResponse.Journals = listJournalsResponse_journals;
        
			return listJournalsResponse;
        }
    }
}
