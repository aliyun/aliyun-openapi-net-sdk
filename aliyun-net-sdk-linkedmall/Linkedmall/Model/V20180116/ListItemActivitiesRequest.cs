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
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class ListItemActivitiesRequest : RpcAcsRequest<ListItemActivitiesResponse>
    {
        public ListItemActivitiesRequest()
            : base("linkedmall", "2018-01-16", "ListItemActivities", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<object> lmItemIds;

		private List<object> itemIds;

		private string bizId;

		public List<object> LmItemIds
		{
			get
			{
				return lmItemIds;
			}
			set	
			{
				lmItemIds = value;
				DictionaryUtil.Add(QueryParameters, "LmItemIds", JsonConvert.SerializeObject(value));
			}
		}

		public List<object> ItemIds
		{
			get
			{
				return itemIds;
			}
			set	
			{
				itemIds = value;
				DictionaryUtil.Add(QueryParameters, "ItemIds", JsonConvert.SerializeObject(value));
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

        public override ListItemActivitiesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListItemActivitiesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
