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
using Aliyun.Acs.imgsearch.Transform;
using Aliyun.Acs.imgsearch.Transform.V20200320;

namespace Aliyun.Acs.imgsearch.Model.V20200320
{
    public class AddImageRequest : RpcAcsRequest<AddImageResponse>
    {
        public AddImageRequest()
            : base("imgsearch", "2020-03-20", "AddImage", "imgsearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imgsearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imgsearch.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string entityId;

		private string dbName;

		private string imageUrl;

		private string extraData;

		public string EntityId
		{
			get
			{
				return entityId;
			}
			set	
			{
				entityId = value;
				DictionaryUtil.Add(BodyParameters, "EntityId", value);
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(BodyParameters, "DbName", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(BodyParameters, "ImageUrl", value);
			}
		}

		public string ExtraData
		{
			get
			{
				return extraData;
			}
			set	
			{
				extraData = value;
				DictionaryUtil.Add(BodyParameters, "ExtraData", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
