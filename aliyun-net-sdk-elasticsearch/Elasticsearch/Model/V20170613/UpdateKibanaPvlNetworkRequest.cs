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
using Aliyun.Acs.elasticsearch.Transform;
using Aliyun.Acs.elasticsearch.Transform.V20170613;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
    public class UpdateKibanaPvlNetworkRequest : RoaAcsRequest<UpdateKibanaPvlNetworkResponse>
    {
        public UpdateKibanaPvlNetworkRequest()
            : base("elasticsearch", "2017-06-13", "UpdateKibanaPvlNetwork", "elasticsearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/openapi/instances/[InstanceId]/actions/update-kibana-private";
			Method = MethodType.POST;
        }

		private string pvlId;

		private string instanceId;

		private string body;

		public string PvlId
		{
			get
			{
				return pvlId;
			}
			set	
			{
				pvlId = value;
				DictionaryUtil.Add(QueryParameters, "pvlId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(PathParameters, "InstanceId", value);
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(BodyParameters, "body", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateKibanaPvlNetworkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateKibanaPvlNetworkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
