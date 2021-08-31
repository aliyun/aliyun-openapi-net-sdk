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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class InsertClusterMemberRequest : RoaAcsRequest<InsertClusterMemberResponse>
    {
        public InsertClusterMemberRequest()
            : base("Edas", "2017-08-01", "InsertClusterMember", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/resource/cluster_member";
			Method = MethodType.POST;
        }

		private string password;

		private string instanceIds;

		private string clusterId;

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "password", value);
			}
		}

		public string InstanceIds
		{
			get
			{
				return instanceIds;
			}
			set	
			{
				instanceIds = value;
				DictionaryUtil.Add(QueryParameters, "instanceIds", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "clusterId", value);
			}
		}

        public override InsertClusterMemberResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertClusterMemberResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
