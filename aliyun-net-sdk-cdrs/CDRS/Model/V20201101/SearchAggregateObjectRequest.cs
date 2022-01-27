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
using Aliyun.Acs.CDRS;
using Aliyun.Acs.CDRS.Transform;
using Aliyun.Acs.CDRS.Transform.V20201101;

namespace Aliyun.Acs.CDRS.Model.V20201101
{
    public class SearchAggregateObjectRequest : RpcAcsRequest<SearchAggregateObjectResponse>
    {
        public SearchAggregateObjectRequest()
            : base("CDRS", "2020-11-01", "SearchAggregateObject")
        {
			Method = MethodType.POST;
        }

		private string shotTimeEnd;

		private string corpId;

		private int? pageNumber;

		private string feature;

		private string vendor;

		private bool? requireTotalCount;

		private int? pageSize;

		private string imageContent;

		private string objectType;

		private string deviceList;

		private string imageUrl;

		private string attributes;

		private string shotTimeStart;

		public string ShotTimeEnd
		{
			get
			{
				return shotTimeEnd;
			}
			set	
			{
				shotTimeEnd = value;
				DictionaryUtil.Add(BodyParameters, "ShotTimeEnd", value);
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string Feature
		{
			get
			{
				return feature;
			}
			set	
			{
				feature = value;
				DictionaryUtil.Add(BodyParameters, "Feature", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(BodyParameters, "Vendor", value);
			}
		}

		public bool? RequireTotalCount
		{
			get
			{
				return requireTotalCount;
			}
			set	
			{
				requireTotalCount = value;
				DictionaryUtil.Add(BodyParameters, "RequireTotalCount", value.ToString());
			}
		}

		public int? PageSize
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

		public string ImageContent
		{
			get
			{
				return imageContent;
			}
			set	
			{
				imageContent = value;
				DictionaryUtil.Add(BodyParameters, "ImageContent", value);
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
				DictionaryUtil.Add(BodyParameters, "ObjectType", value);
			}
		}

		public string DeviceList
		{
			get
			{
				return deviceList;
			}
			set	
			{
				deviceList = value;
				DictionaryUtil.Add(BodyParameters, "DeviceList", value);
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

		public string Attributes
		{
			get
			{
				return attributes;
			}
			set	
			{
				attributes = value;
				DictionaryUtil.Add(BodyParameters, "Attributes", value);
			}
		}

		public string ShotTimeStart
		{
			get
			{
				return shotTimeStart;
			}
			set	
			{
				shotTimeStart = value;
				DictionaryUtil.Add(BodyParameters, "ShotTimeStart", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchAggregateObjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchAggregateObjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
