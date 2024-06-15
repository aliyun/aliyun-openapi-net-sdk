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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class DescribeLiveAISubtitleRequest : RpcAcsRequest<DescribeLiveAISubtitleResponse>
    {
        public DescribeLiveAISubtitleRequest()
            : base("live", "2016-11-01", "DescribeLiveAISubtitle", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string subtitleName;

		private string pageNumber;

		private string pageSize;

		private bool? isDefault;

		private long? ownerId;

		private string subtitleId;

		[JsonProperty(PropertyName = "SubtitleName")]
		public string SubtitleName
		{
			get
			{
				return subtitleName;
			}
			set	
			{
				subtitleName = value;
				DictionaryUtil.Add(QueryParameters, "SubtitleName", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		[JsonProperty(PropertyName = "IsDefault")]
		public bool? IsDefault
		{
			get
			{
				return isDefault;
			}
			set	
			{
				isDefault = value;
				DictionaryUtil.Add(QueryParameters, "IsDefault", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SubtitleId")]
		public string SubtitleId
		{
			get
			{
				return subtitleId;
			}
			set	
			{
				subtitleId = value;
				DictionaryUtil.Add(QueryParameters, "SubtitleId", value);
			}
		}

        public override DescribeLiveAISubtitleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLiveAISubtitleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
