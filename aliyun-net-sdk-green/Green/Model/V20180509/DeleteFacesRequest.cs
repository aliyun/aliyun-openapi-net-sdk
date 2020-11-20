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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20180509;

namespace Aliyun.Acs.Green.Model.V20180509
{
    public class DeleteFacesRequest : RoaAcsRequest<DeleteFacesResponse>
    {
        public DeleteFacesRequest()
            : base("Green", "2018-05-09", "DeleteFaces", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/green/sface/face/delete";
			Method = MethodType.POST;
        }

		private string clientInfo;

		public string ClientInfo
		{
			get
			{
				return clientInfo;
			}
			set	
			{
				clientInfo = value;
				DictionaryUtil.Add(QueryParameters, "ClientInfo", value);
			}
		}

        public override DeleteFacesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteFacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
