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
    public class ListTimeAnchorsResponseUnmarshaller
    {
        public static ListTimeAnchorsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTimeAnchorsResponse listTimeAnchorsResponse = new ListTimeAnchorsResponse();

			listTimeAnchorsResponse.HttpResponse = context.HttpResponse;
			listTimeAnchorsResponse.RequestId = context.StringValue("ListTimeAnchors.RequestId");
			listTimeAnchorsResponse.NextToken = context.StringValue("ListTimeAnchors.NextToken");
			listTimeAnchorsResponse.MaxResults = context.IntegerValue("ListTimeAnchors.MaxResults");

			List<ListTimeAnchorsResponse.ListTimeAnchors_TimeAnchor> listTimeAnchorsResponse_timeAnchors = new List<ListTimeAnchorsResponse.ListTimeAnchors_TimeAnchor>();
			for (int i = 0; i < context.Length("ListTimeAnchors.TimeAnchors.Length"); i++) {
				ListTimeAnchorsResponse.ListTimeAnchors_TimeAnchor timeAnchor = new ListTimeAnchorsResponse.ListTimeAnchors_TimeAnchor();
				timeAnchor.JournalId = context.LongValue("ListTimeAnchors.TimeAnchors["+ i +"].JournalId");
				timeAnchor.LedgerVersion = context.LongValue("ListTimeAnchors.TimeAnchors["+ i +"].LedgerVersion");
				timeAnchor.LedgerDigest = context.StringValue("ListTimeAnchors.TimeAnchors["+ i +"].LedgerDigest");
				timeAnchor.LedgerDigestType = context.StringValue("ListTimeAnchors.TimeAnchors["+ i +"].LedgerDigestType");
				timeAnchor.TimeStamp = context.LongValue("ListTimeAnchors.TimeAnchors["+ i +"].TimeStamp");
				timeAnchor.Proof = context.StringValue("ListTimeAnchors.TimeAnchors["+ i +"].Proof");

				listTimeAnchorsResponse_timeAnchors.Add(timeAnchor);
			}
			listTimeAnchorsResponse.TimeAnchors = listTimeAnchorsResponse_timeAnchors;
        
			return listTimeAnchorsResponse;
        }
    }
}
