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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SetResellerUserStatusRequest : RpcAcsRequest<SetResellerUserStatusResponse>
    {
        public SetResellerUserStatusRequest()
            : base("BssOpenApi", "2017-12-14", "SetResellerUserStatus", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string stopMode;

		private string ownerId;

		private string businessType;

		private string status;

		[JsonProperty(PropertyName = "StopMode")]
		public string StopMode
		{
			get
			{
				return stopMode;
			}
			set	
			{
				stopMode = value;
				DictionaryUtil.Add(QueryParameters, "StopMode", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "BusinessType")]
		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override SetResellerUserStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetResellerUserStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
