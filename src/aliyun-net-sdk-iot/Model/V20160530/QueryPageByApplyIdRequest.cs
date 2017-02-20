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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform.V20160530;

namespace Aliyun.Acs.Iot.Model.V20160530
{
    public class QueryPageByApplyIdRequest : RpcAcsRequest<QueryPageByApplyIdResponse>
    {
        public QueryPageByApplyIdRequest()
            : base("Iot", "2016-05-30", "QueryPageByApplyId")
        {
        }

		private int? _currenPage;

		private int? _pageSize;

		private long? _applyId;

		public int? CurrenPage
		{
			get
			{
				return _currenPage;
			}
			set	
			{
				_currenPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrenPage", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? ApplyId
		{
			get
			{
				return _applyId;
			}
			set	
			{
				_applyId = value;
				DictionaryUtil.Add(QueryParameters, "ApplyId", value.ToString());
			}
		}

        public override QueryPageByApplyIdResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryPageByApplyIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}