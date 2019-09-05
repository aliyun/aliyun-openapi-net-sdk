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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class DescribeIpControlsRequest : RpcAcsRequest<DescribeIpControlsResponse>
    {
        public DescribeIpControlsRequest()
            : base("CloudAPI", "2016-07-14", "DescribeIpControls", "apigateway", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string ipControlName;

		private int? pageNumber;

		private string ipControlId;

		private string securityToken;

		private string ipControlType;

		private int? pageSize;

		public string IpControlName
		{
			get
			{
				return ipControlName;
			}
			set	
			{
				ipControlName = value;
				DictionaryUtil.Add(QueryParameters, "IpControlName", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string IpControlId
		{
			get
			{
				return ipControlId;
			}
			set	
			{
				ipControlId = value;
				DictionaryUtil.Add(QueryParameters, "IpControlId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string IpControlType
		{
			get
			{
				return ipControlType;
			}
			set	
			{
				ipControlType = value;
				DictionaryUtil.Add(QueryParameters, "IpControlType", value);
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

        public override DescribeIpControlsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeIpControlsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
