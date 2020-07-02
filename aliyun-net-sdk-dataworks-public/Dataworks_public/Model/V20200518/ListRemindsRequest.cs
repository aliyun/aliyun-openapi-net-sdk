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
    public class ListRemindsRequest : RpcAcsRequest<ListRemindsResponse>
    {
        public ListRemindsRequest()
            : base("dataworks-public", "2020-05-18", "ListReminds", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchText;

		private string founder;

		private string remindTypes;

		private int? pageNumber;

		private string alertTarget;

		private int? pageSize;

		private long? nodeId;

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

		public string Founder
		{
			get
			{
				return founder;
			}
			set	
			{
				founder = value;
				DictionaryUtil.Add(BodyParameters, "Founder", value);
			}
		}

		public string RemindTypes
		{
			get
			{
				return remindTypes;
			}
			set	
			{
				remindTypes = value;
				DictionaryUtil.Add(BodyParameters, "RemindTypes", value);
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

		public string AlertTarget
		{
			get
			{
				return alertTarget;
			}
			set	
			{
				alertTarget = value;
				DictionaryUtil.Add(BodyParameters, "AlertTarget", value);
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

		public long? NodeId
		{
			get
			{
				return nodeId;
			}
			set	
			{
				nodeId = value;
				DictionaryUtil.Add(BodyParameters, "NodeId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListRemindsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListRemindsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
