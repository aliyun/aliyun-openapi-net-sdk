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
using Aliyun.Acs.cas.Transform;
using Aliyun.Acs.cas.Transform.V20180813;

namespace Aliyun.Acs.cas.Model.V20180813
{
    public class DescribeSignatureTradeListRequest : RpcAcsRequest<DescribeSignatureTradeListResponse>
    {
        public DescribeSignatureTradeListRequest()
            : base("cas", "2018-08-13", "DescribeSignatureTradeList", "cas_esign_fdd", "openAPI")
        {
        }

		private string sourceIp;

		private int? showSize;

		private string searchType;

		private int? currentPage;

		private string lang;

		private string searchValue;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public int? ShowSize
		{
			get
			{
				return showSize;
			}
			set	
			{
				showSize = value;
				DictionaryUtil.Add(QueryParameters, "ShowSize", value.ToString());
			}
		}

		public string SearchType
		{
			get
			{
				return searchType;
			}
			set	
			{
				searchType = value;
				DictionaryUtil.Add(QueryParameters, "SearchType", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string SearchValue
		{
			get
			{
				return searchValue;
			}
			set	
			{
				searchValue = value;
				DictionaryUtil.Add(QueryParameters, "SearchValue", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSignatureTradeListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSignatureTradeListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
