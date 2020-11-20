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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class DescribeWebsiteScanResultRequest : RpcAcsRequest<DescribeWebsiteScanResultResponse>
    {
        public DescribeWebsiteScanResultRequest()
            : base("Green", "2017-08-23", "DescribeWebsiteScanResult", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string subServiceModule;

		private string sourceIp;

		private int? pageSize;

		private string lang;

		private int? totalCount;

		private string siteUrl;

		private string handleStatus;

		private int? currentPage;

		private string label;

		private string domain;

		public string SubServiceModule
		{
			get
			{
				return subServiceModule;
			}
			set	
			{
				subServiceModule = value;
				DictionaryUtil.Add(QueryParameters, "SubServiceModule", value);
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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
				DictionaryUtil.Add(QueryParameters, "TotalCount", value.ToString());
			}
		}

		public string SiteUrl
		{
			get
			{
				return siteUrl;
			}
			set	
			{
				siteUrl = value;
				DictionaryUtil.Add(QueryParameters, "SiteUrl", value);
			}
		}

		public string HandleStatus
		{
			get
			{
				return handleStatus;
			}
			set	
			{
				handleStatus = value;
				DictionaryUtil.Add(QueryParameters, "HandleStatus", value);
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

		public string Label
		{
			get
			{
				return label;
			}
			set	
			{
				label = value;
				DictionaryUtil.Add(QueryParameters, "Label", value);
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeWebsiteScanResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeWebsiteScanResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
