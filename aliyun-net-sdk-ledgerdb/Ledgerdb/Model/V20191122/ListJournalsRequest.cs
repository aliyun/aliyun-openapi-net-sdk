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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ledgerdb.Transform;
using Aliyun.Acs.ledgerdb.Transform.V20191122;

namespace Aliyun.Acs.ledgerdb.Model.V20191122
{
    public class ListJournalsRequest : RpcAcsRequest<ListJournalsResponse>
    {
        public ListJournalsRequest()
            : base("ledgerdb", "2019-11-22", "ListJournals", "ledgerdb", "openAPI")
        {
        }

		private string ledgerId;

		private string nextToken;

		private string clue;

		private int? maxResults;

		private string memberId;

		public string LedgerId
		{
			get
			{
				return ledgerId;
			}
			set	
			{
				ledgerId = value;
				DictionaryUtil.Add(QueryParameters, "LedgerId", value);
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
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string Clue
		{
			get
			{
				return clue;
			}
			set	
			{
				clue = value;
				DictionaryUtil.Add(QueryParameters, "Clue", value);
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
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "MemberId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListJournalsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListJournalsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
