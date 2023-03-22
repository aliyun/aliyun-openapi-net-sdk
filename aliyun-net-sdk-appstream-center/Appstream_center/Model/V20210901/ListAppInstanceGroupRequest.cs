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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ListAppInstanceGroupRequest : RpcAcsRequest<ListAppInstanceGroupResponse>
    {
        public ListAppInstanceGroupRequest()
            : base("appstream-center", "2021-09-01", "ListAppInstanceGroup")
        {
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private string productType;

		private string appCenterImageId;

		private int? pageSize;

		private string nodeInstanceType;

		private string appInstanceGroupName;

		private string appInstanceGroupId;

		private List<string> statuss = new List<string>(){ };

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "AppCenterImageId")]
		public string AppCenterImageId
		{
			get
			{
				return appCenterImageId;
			}
			set	
			{
				appCenterImageId = value;
				DictionaryUtil.Add(QueryParameters, "AppCenterImageId", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NodeInstanceType")]
		public string NodeInstanceType
		{
			get
			{
				return nodeInstanceType;
			}
			set	
			{
				nodeInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "NodeInstanceType", value);
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupName")]
		public string AppInstanceGroupName
		{
			get
			{
				return appInstanceGroupName;
			}
			set	
			{
				appInstanceGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AppInstanceGroupName", value);
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupId")]
		public string AppInstanceGroupId
		{
			get
			{
				return appInstanceGroupId;
			}
			set	
			{
				appInstanceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "AppInstanceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "Status")]
		public List<string> Statuss
		{
			get
			{
				return statuss;
			}

			set
			{
				statuss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAppInstanceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAppInstanceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
