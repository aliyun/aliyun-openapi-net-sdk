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
    public class UpdateInstanceRequest : RoaAcsRequest<UpdateInstanceResponse>
    {
        public UpdateInstanceRequest()
            : base("elasticsearch", "2017-06-13", "UpdateInstance", "elasticsearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/openapi/instances/[InstanceId]";
			Method = MethodType.PUT;
        }

		private bool? ignoreStatus;

		private string instanceId;

		private string clientToken;

		private string orderActionType;

		public bool? IgnoreStatus
		{
			get
			{
				return ignoreStatus;
			}
			set	
			{
				ignoreStatus = value;
				DictionaryUtil.Add(QueryParameters, "ignoreStatus", value.ToString());
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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "clientToken", value);
			}
		}

		public string OrderActionType
		{
			get
			{
				return orderActionType;
			}
			set	
			{
				orderActionType = value;
				DictionaryUtil.Add(QueryParameters, "orderActionType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
