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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class ShrinkClusterRequest : RoaAcsRequest<ShrinkClusterResponse>
    {
        public ShrinkClusterRequest()
            : base("foas", "2018-11-11", "ShrinkCluster", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/clusters/[clusterId]/shrink";
			Method = MethodType.PUT;
        }

		private string instanceIds;

		private string clusterId;

		private string modelTargetCount;

		public string InstanceIds
		{
			get
			{
				return instanceIds;
			}
			set	
			{
				instanceIds = value;
				DictionaryUtil.Add(BodyParameters, "instanceIds", value);
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
				DictionaryUtil.Add(PathParameters, "clusterId", value);
			}
		}

		public string ModelTargetCount
		{
			get
			{
				return modelTargetCount;
			}
			set	
			{
				modelTargetCount = value;
				DictionaryUtil.Add(BodyParameters, "modelTargetCount", value);
			}
		}

        public override ShrinkClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ShrinkClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
