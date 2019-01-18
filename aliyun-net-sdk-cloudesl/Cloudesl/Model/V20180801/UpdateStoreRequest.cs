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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20180801;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class UpdateStoreRequest : RpcAcsRequest<UpdateStoreResponse>
    {
        public UpdateStoreRequest()
            : base("cloudesl", "2018-08-01", "UpdateStore")
        {
        }

		private string comments;

		private string phone;

		private string storeName;

		private string groups;

		private string outId;

		private string storeId;

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
				DictionaryUtil.Add(QueryParameters, "Comments", value);
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
				DictionaryUtil.Add(QueryParameters, "Phone", value);
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
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
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
				DictionaryUtil.Add(QueryParameters, "Groups", value);
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
				DictionaryUtil.Add(QueryParameters, "OutId", value);
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
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
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
				DictionaryUtil.Add(QueryParameters, "Brand", value);
			}
		}

        public override UpdateStoreResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateStoreResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}