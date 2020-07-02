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
    public class ListBaselineConfigsRequest : RpcAcsRequest<ListBaselineConfigsResponse>
    {
        public ListBaselineConfigsRequest()
            : base("dataworks-public", "2020-05-18", "ListBaselineConfigs", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string owner;

		private string searchText;

		private bool? useflag;

		private string priority;

		private int? pageNumber;

		private int? pageSize;

		private long? projectId;

		private string baselineTypes;

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

		public bool? Useflag
		{
			get
			{
				return useflag;
			}
			set	
			{
				useflag = value;
				DictionaryUtil.Add(BodyParameters, "Useflag", value.ToString());
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

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListBaselineConfigsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListBaselineConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
