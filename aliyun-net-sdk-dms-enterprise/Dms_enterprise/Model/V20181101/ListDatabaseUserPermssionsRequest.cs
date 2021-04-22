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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class ListDatabaseUserPermssionsRequest : RpcAcsRequest<ListDatabaseUserPermssionsResponse>
    {
        public ListDatabaseUserPermssionsRequest()
            : base("dms-enterprise", "2018-11-01", "ListDatabaseUserPermssions", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? tid;

		private int? pageNumber;

		private string permType;

		private string dbId;

		private int? pageSize;

		private bool? logic;

		private string userName;

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

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

		[JsonProperty(PropertyName = "PermType")]
		public string PermType
		{
			get
			{
				return permType;
			}
			set	
			{
				permType = value;
				DictionaryUtil.Add(QueryParameters, "PermType", value);
			}
		}

		[JsonProperty(PropertyName = "DbId")]
		public string DbId
		{
			get
			{
				return dbId;
			}
			set	
			{
				dbId = value;
				DictionaryUtil.Add(QueryParameters, "DbId", value);
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

		[JsonProperty(PropertyName = "Logic")]
		public bool? Logic
		{
			get
			{
				return logic;
			}
			set	
			{
				logic = value;
				DictionaryUtil.Add(QueryParameters, "Logic", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserName")]
		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

        public override ListDatabaseUserPermssionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDatabaseUserPermssionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
