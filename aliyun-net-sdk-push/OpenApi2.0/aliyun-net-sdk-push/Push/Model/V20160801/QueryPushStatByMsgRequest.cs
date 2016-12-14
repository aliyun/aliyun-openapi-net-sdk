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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class QueryPushStatByMsgRequest : RpcAcsRequest<QueryPushStatByMsgResponse>
    {
        public QueryPushStatByMsgRequest()
            : base("Push", "2016-08-01", "QueryPushStatByMsg")
        {
        }

		private long? appKey;

		private string messageId;

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string MessageId
		{
			get
			{
				return messageId;
			}
			set	
			{
				messageId = value;
				DictionaryUtil.Add(QueryParameters, "MessageId", value);
			}
		}

        public override QueryPushStatByMsgResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryPushStatByMsgResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}