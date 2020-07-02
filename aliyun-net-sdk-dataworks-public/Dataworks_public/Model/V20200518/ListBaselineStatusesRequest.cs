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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListBaselineStatusesRequest : RpcAcsRequest<ListBaselineStatusesResponse>
    {
        public ListBaselineStatusesRequest()
            : base("dataworks-public", "2020-05-18", "ListBaselineStatuses", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchText;

		private string owner;

		private string priority;

		private int? pageNumber;

		private long? topicId;

		private string bizdate;

		private string finishStatus;

		private int? pageSize;

		private string baselineTypes;

		private string status;

		public string SearchText
		{
			get
			{
				return searchText;
			}
			set	
			{
				searchText = value;
				DictionaryUtil.Add(BodyParameters, "SearchText", value);
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(BodyParameters, "Owner", value);
			}
		}

		public string Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(BodyParameters, "Priority", value);
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

		public long? TopicId
		{
			get
			{
				return topicId;
			}
			set	
			{
				topicId = value;
				DictionaryUtil.Add(BodyParameters, "TopicId", value.ToString());
			}
		}

		public string Bizdate
		{
			get
			{
				return bizdate;
			}
			set	
			{
				bizdate = value;
				DictionaryUtil.Add(BodyParameters, "Bizdate", value);
			}
		}

		public string FinishStatus
		{
			get
			{
				return finishStatus;
			}
			set	
			{
				finishStatus = value;
				DictionaryUtil.Add(BodyParameters, "FinishStatus", value);
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

		public string BaselineTypes
		{
			get
			{
				return baselineTypes;
			}
			set	
			{
				baselineTypes = value;
				DictionaryUtil.Add(BodyParameters, "BaselineTypes", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListBaselineStatusesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListBaselineStatusesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
