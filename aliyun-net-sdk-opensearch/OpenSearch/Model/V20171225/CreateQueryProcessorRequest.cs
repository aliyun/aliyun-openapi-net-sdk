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
using Aliyun.Acs.OpenSearch;
using Aliyun.Acs.OpenSearch.Transform;
using Aliyun.Acs.OpenSearch.Transform.V20171225;

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
    public class CreateQueryProcessorRequest : RoaAcsRequest<CreateQueryProcessorResponse>
    {
        public CreateQueryProcessorRequest()
            : base("OpenSearch", "2017-12-25", "CreateQueryProcessor")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OpenSearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/v4/openapi/app-groups/[appGroupIdentity]/apps/[appId]/query-processors";
			Method = MethodType.POST;
        }

		private bool? dryRun;

		private int? appId;

		private string appGroupIdentity;

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "dryRun", value.ToString());
			}
		}

		public int? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(PathParameters, "appId", value.ToString());
			}
		}

		public string AppGroupIdentity
		{
			get
			{
				return appGroupIdentity;
			}
			set	
			{
				appGroupIdentity = value;
				DictionaryUtil.Add(PathParameters, "appGroupIdentity", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateQueryProcessorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQueryProcessorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
