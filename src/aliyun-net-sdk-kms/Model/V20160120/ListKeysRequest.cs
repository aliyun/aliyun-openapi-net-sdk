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
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class ListKeysRequest : RpcAcsRequest<ListKeysResponse>
    {
        public ListKeysRequest()
            : base("Kms", "2016-01-20", "ListKeys")
        {
        }

		private int? _pageNumber;

		private int? _pageSize;

		private string _sTsToken;

		public int? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

		public string StsToken
		{
			get
			{
				return _sTsToken;
			}
			set	
			{
				_sTsToken = value;
				DictionaryUtil.Add(QueryParameters, "STSToken", value);
			}
		}

        public override ListKeysResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListKeysResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}