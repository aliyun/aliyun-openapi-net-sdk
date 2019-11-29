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
using Aliyun.Acs.cloudesl.Transform.V20190801;

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
    public class UpdateStoreRequest : RpcAcsRequest<UpdateStoreResponse>
    {
        public UpdateStoreRequest()
            : base("cloudesl", "2019-08-01", "UpdateStore", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string comments;

		private string storeName;

		private string groups;

		private string storeId;

		private string phone;

		private string outId;

		private string brand;

		public string Comments
		{
			get
			{
				return comments;
			}
			set	
			{
				comments = value;
				DictionaryUtil.Add(BodyParameters, "Comments", value);
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(BodyParameters, "StoreName", value);
			}
		}

		public string Groups
		{
			get
			{
				return groups;
			}
			set	
			{
				groups = value;
				DictionaryUtil.Add(BodyParameters, "Groups", value);
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

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(BodyParameters, "Phone", value);
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(BodyParameters, "OutId", value);
			}
		}

		public string Brand
		{
			get
			{
				return brand;
			}
			set	
			{
				brand = value;
				DictionaryUtil.Add(BodyParameters, "Brand", value);
			}
		}

        public override UpdateStoreResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateStoreResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
