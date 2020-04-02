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
using Aliyun.Acs.CSB;
using Aliyun.Acs.CSB.Transform;
using Aliyun.Acs.CSB.Transform.V20171118;

namespace Aliyun.Acs.CSB.Model.V20171118
{
    public class FindApproveServiceListRequest : RpcAcsRequest<FindApproveServiceListResponse>
    {
        public FindApproveServiceListRequest()
            : base("CSB", "2017-11-18", "FindApproveServiceList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private string projectName;

		private string approveLevel;

		private bool? showDelService;

		private long? csbId;

		private string alias;

		private string serviceName;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(QueryParameters, "ProjectName", value);
			}
		}

		public string ApproveLevel
		{
			get
			{
				return approveLevel;
			}
			set	
			{
				approveLevel = value;
				DictionaryUtil.Add(QueryParameters, "ApproveLevel", value);
			}
		}

		public bool? ShowDelService
		{
			get
			{
				return showDelService;
			}
			set	
			{
				showDelService = value;
				DictionaryUtil.Add(QueryParameters, "ShowDelService", value.ToString());
			}
		}

		public long? CsbId
		{
			get
			{
				return csbId;
			}
			set	
			{
				csbId = value;
				DictionaryUtil.Add(QueryParameters, "CsbId", value.ToString());
			}
		}

		public string Alias
		{
			get
			{
				return alias;
			}
			set	
			{
				alias = value;
				DictionaryUtil.Add(QueryParameters, "Alias", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FindApproveServiceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FindApproveServiceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
