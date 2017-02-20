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
    public class QueryDeviceRequest : RpcAcsRequest<QueryDeviceResponse>
    {
        public QueryDeviceRequest()
            : base("Iot", "2016-05-30", "QueryDevice")
        {
        }

		private string _productKey;

		private int? _pageSize;

		private int? _currentPage;

		public string ProductKey
		{
			get
			{
				return _productKey;
			}
			set	
			{
				_productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
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

		public int? CurrentPage
		{
			get
			{
				return _currentPage;
			}
			set	
			{
				_currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

        public override QueryDeviceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}