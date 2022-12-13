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
using Aliyun.Acs.viapi_regen.Transform;
using Aliyun.Acs.viapi_regen.Transform.V20211119;

namespace Aliyun.Acs.viapi_regen.Model.V20211119
{
    public class ListDataReflowDatasRequest : RpcAcsRequest<ListDataReflowDatasResponse>
    {
        public ListDataReflowDatasRequest()
            : base("viapi-regen", "2021-11-19", "ListDataReflowDatas", "selflearning", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.viapi_regen.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? startTime;

		private string imageName;

		private long? pageSize;

		private long? endTime;

		private long? currentPage;

		private long? serviceId;

		private string category;

		[JsonProperty(PropertyName = "StartTime")]
		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ImageName")]
		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(BodyParameters, "ImageName", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CurrentPage")]
		public long? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(BodyParameters, "CurrentPage", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ServiceId")]
		public long? ServiceId
		{
			get
			{
				return serviceId;
			}
			set	
			{
				serviceId = value;
				DictionaryUtil.Add(BodyParameters, "ServiceId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Category")]
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

        public override ListDataReflowDatasResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDataReflowDatasResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
