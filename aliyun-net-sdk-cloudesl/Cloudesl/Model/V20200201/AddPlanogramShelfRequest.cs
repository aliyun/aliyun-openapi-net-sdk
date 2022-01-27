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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class AddPlanogramShelfRequest : RpcAcsRequest<AddPlanogramShelfResponse>
    {
        public AddPlanogramShelfRequest()
            : base("cloudesl", "2020-02-01", "AddPlanogramShelf", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string clientToken;

		private string shelfType;

		private string storeId;

		private string zone;

		private string shelf;

		private string category;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string ShelfType
		{
			get
			{
				return shelfType;
			}
			set	
			{
				shelfType = value;
				DictionaryUtil.Add(BodyParameters, "ShelfType", value);
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

		public string Zone
		{
			get
			{
				return zone;
			}
			set	
			{
				zone = value;
				DictionaryUtil.Add(BodyParameters, "Zone", value);
			}
		}

		public string Shelf
		{
			get
			{
				return shelf;
			}
			set	
			{
				shelf = value;
				DictionaryUtil.Add(BodyParameters, "Shelf", value);
			}
		}

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(BodyParameters, "Category", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddPlanogramShelfResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddPlanogramShelfResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
