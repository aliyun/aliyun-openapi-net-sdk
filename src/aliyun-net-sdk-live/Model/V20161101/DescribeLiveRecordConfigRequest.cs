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
using Aliyun.Acs.Live.Transform.V20161101;

namespace Aliyun.Acs.Live.Model.V20161101
{
    public class DescribeLiveRecordConfigRequest : RpcAcsRequest<DescribeLiveRecordConfigResponse>
    {
        public DescribeLiveRecordConfigRequest()
            : base("Live", "2016-11-01", "DescribeLiveRecordConfig")
        {
        }

		private string _securityToken;

		private long? _ownerId;

		private string _domainName;

		private string _appName;

		private int? _pageNum;

		private int? _pageSize;

		private string _order;

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string AppName
		{
			get
			{
				return _appName;
			}
			set	
			{
				_appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return _pageNum;
			}
			set	
			{
				_pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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

		public string Order
		{
			get
			{
				return _order;
			}
			set	
			{
				_order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

        public override DescribeLiveRecordConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeLiveRecordConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}