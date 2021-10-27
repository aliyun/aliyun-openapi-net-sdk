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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class DescribeWhitelistRequest : RpcAcsRequest<DescribeWhitelistResponse>
    {
        public DescribeWhitelistRequest()
            : base("Cloudauth", "2019-03-07", "DescribeWhitelist", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string validEndDate;

		private string valid;

		private string sourceIp;

		private int? pageSize;

		private string lang;

		private int? currentPage;

		private string bizType;

		private string idCardNum;

		private string bizId;

		private string validStartDate;

		public string ValidEndDate
		{
			get
			{
				return validEndDate;
			}
			set	
			{
				validEndDate = value;
				DictionaryUtil.Add(QueryParameters, "ValidEndDate", value);
			}
		}

		public string Valid
		{
			get
			{
				return valid;
			}
			set	
			{
				valid = value;
				DictionaryUtil.Add(QueryParameters, "Valid", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string IdCardNum
		{
			get
			{
				return idCardNum;
			}
			set	
			{
				idCardNum = value;
				DictionaryUtil.Add(QueryParameters, "IdCardNum", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string ValidStartDate
		{
			get
			{
				return validStartDate;
			}
			set	
			{
				validStartDate = value;
				DictionaryUtil.Add(QueryParameters, "ValidStartDate", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeWhitelistResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeWhitelistResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
