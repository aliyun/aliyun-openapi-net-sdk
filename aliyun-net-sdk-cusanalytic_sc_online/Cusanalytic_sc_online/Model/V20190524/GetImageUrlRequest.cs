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
using Aliyun.Acs.cusanalytic_sc_online;
using Aliyun.Acs.cusanalytic_sc_online.Transform;
using Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
    public class GetImageUrlRequest : RpcAcsRequest<GetImageUrlResponse>
    {
        public GetImageUrlRequest()
            : base("cusanalytic_sc_online", "2019-05-24", "GetImageUrl")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string originUrls;

		private string storeId;

		private string objectKeys;

		public string OriginUrls
		{
			get
			{
				return originUrls;
			}
			set	
			{
				originUrls = value;
				DictionaryUtil.Add(BodyParameters, "OriginUrls", value);
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public string ObjectKeys
		{
			get
			{
				return objectKeys;
			}
			set	
			{
				objectKeys = value;
				DictionaryUtil.Add(BodyParameters, "ObjectKeys", value);
			}
		}

        public override GetImageUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetImageUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
