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
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class QueryMessageCountRequest : RpcAcsRequest<QueryMessageCountResponse>
    {
        public QueryMessageCountRequest()
            : base("Push", "2015-08-27", "QueryMessageCount")
        {
        }

		private long? appKey;

		private string start;

		private string end;

		private int? level;

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

		public string Start
		{
			get
			{
				return start;
			}
			set	
			{
				start = value;
				DictionaryUtil.Add(QueryParameters, "start", value);
			}
		}

		public string End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
				DictionaryUtil.Add(QueryParameters, "end", value);
			}
		}

		public int? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "level", value.ToString());
			}
		}

        public override QueryMessageCountResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryMessageCountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}