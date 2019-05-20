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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class QueryTradeIntentionUserListRequest : RpcAcsRequest<QueryTradeIntentionUserListResponse>
    {
        public QueryTradeIntentionUserListRequest()
            : base("Trademark", "2018-07-24", "QueryTradeIntentionUserList", "trademark", "openAPI")
        {
        }

		private long? end;

		private long? begin;

		public long? End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
				DictionaryUtil.Add(QueryParameters, "End", value.ToString());
			}
		}

		public long? Begin
		{
			get
			{
				return begin;
			}
			set	
			{
				begin = value;
				DictionaryUtil.Add(QueryParameters, "Begin", value.ToString());
			}
		}

        public override QueryTradeIntentionUserListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTradeIntentionUserListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
