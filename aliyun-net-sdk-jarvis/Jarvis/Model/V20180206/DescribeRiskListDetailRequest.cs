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
using Aliyun.Acs.jarvis.Transform;
using Aliyun.Acs.jarvis.Transform.V20180206;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
    public class DescribeRiskListDetailRequest : RpcAcsRequest<DescribeRiskListDetailResponse>
    {
        public DescribeRiskListDetailRequest()
            : base("jarvis", "2018-02-06", "DescribeRiskListDetail", "jarvis", "openAPI")
        {
        }

		private string riskType;

		private string sourceIp;

		private int? pageSize;

		private string queryProduct;

		private int? currentPage;

		private string riskDescribe;

		private string lang;

		private long? srcUid;

		private string sourceCode;

		private string queryRegionId;

		private string status;

		public string RiskType
		{
			get
			{
				return riskType;
			}
			set	
			{
				riskType = value;
				DictionaryUtil.Add(QueryParameters, "riskType", value);
			}
		}

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public string QueryProduct
		{
			get
			{
				return queryProduct;
			}
			set	
			{
				queryProduct = value;
				DictionaryUtil.Add(QueryParameters, "queryProduct", value);
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
				DictionaryUtil.Add(QueryParameters, "currentPage", value.ToString());
			}
		}

		public string RiskDescribe
		{
			get
			{
				return riskDescribe;
			}
			set	
			{
				riskDescribe = value;
				DictionaryUtil.Add(QueryParameters, "riskDescribe", value);
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

		public long? SrcUid
		{
			get
			{
				return srcUid;
			}
			set	
			{
				srcUid = value;
				DictionaryUtil.Add(QueryParameters, "srcUid", value.ToString());
			}
		}

		public string SourceCode
		{
			get
			{
				return sourceCode;
			}
			set	
			{
				sourceCode = value;
				DictionaryUtil.Add(QueryParameters, "sourceCode", value);
			}
		}

		public string QueryRegionId
		{
			get
			{
				return queryRegionId;
			}
			set	
			{
				queryRegionId = value;
				DictionaryUtil.Add(QueryParameters, "queryRegionId", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeRiskListDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRiskListDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
