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
using Aliyun.Acs.Actiontrail.Transform;
using Aliyun.Acs.Actiontrail.Transform.V20200706;

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
    public class DescribeTrailsRequest : RpcAcsRequest<DescribeTrailsResponse>
    {
        public DescribeTrailsRequest()
            : base("Actiontrail", "2020-07-06", "DescribeTrails", "actiontrail", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Actiontrail.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? includeOrganizationTrail;

		private bool? includeShadowTrails;

		private string nameList;

		public bool? IncludeOrganizationTrail
		{
			get
			{
				return includeOrganizationTrail;
			}
			set	
			{
				includeOrganizationTrail = value;
				DictionaryUtil.Add(QueryParameters, "IncludeOrganizationTrail", value.ToString());
			}
		}

		public bool? IncludeShadowTrails
		{
			get
			{
				return includeShadowTrails;
			}
			set	
			{
				includeShadowTrails = value;
				DictionaryUtil.Add(QueryParameters, "IncludeShadowTrails", value.ToString());
			}
		}

		public string NameList
		{
			get
			{
				return nameList;
			}
			set	
			{
				nameList = value;
				DictionaryUtil.Add(QueryParameters, "NameList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeTrailsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeTrailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
