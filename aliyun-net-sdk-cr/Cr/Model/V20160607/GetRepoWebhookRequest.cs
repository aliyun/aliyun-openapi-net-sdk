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
using Aliyun.Acs.cr.Transform;
using Aliyun.Acs.cr.Transform.V20160607;

namespace Aliyun.Acs.cr.Model.V20160607
{
    public class GetRepoWebhookRequest : RoaAcsRequest<GetRepoWebhookResponse>
    {
        public GetRepoWebhookRequest()
            : base("cr", "2016-06-07", "GetRepoWebhook", "acr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cr.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/repos/[RepoNamespace]/[RepoName]/webhooks";
			Method = MethodType.GET;
        }

		private string repoNamespace;

		private string repoName;

		public string RepoNamespace
		{
			get
			{
				return repoNamespace;
			}
			set	
			{
				repoNamespace = value;
				DictionaryUtil.Add(PathParameters, "RepoNamespace", value);
			}
		}

		public string RepoName
		{
			get
			{
				return repoName;
			}
			set	
			{
				repoName = value;
				DictionaryUtil.Add(PathParameters, "RepoName", value);
			}
		}

        public override GetRepoWebhookResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetRepoWebhookResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
