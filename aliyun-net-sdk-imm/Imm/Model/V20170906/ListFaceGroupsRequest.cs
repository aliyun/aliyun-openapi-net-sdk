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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class ListFaceGroupsRequest : RpcAcsRequest<ListFaceGroupsResponse>
    {
        public ListFaceGroupsRequest()
            : base("imm", "2017-09-06", "ListFaceGroups", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string remarksBQuery;

		private string externalId;

		private int? limit;

		private string remarksArrayBQuery;

		private string order;

		private string remarksAQuery;

		private string orderBy;

		private string remarksDQuery;

		private string remarksArrayAQuery;

		private string marker;

		private string setId;

		private string remarksCQuery;

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string RemarksBQuery
		{
			get
			{
				return remarksBQuery;
			}
			set	
			{
				remarksBQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksBQuery", value);
			}
		}

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
				DictionaryUtil.Add(QueryParameters, "ExternalId", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string RemarksArrayBQuery
		{
			get
			{
				return remarksArrayBQuery;
			}
			set	
			{
				remarksArrayBQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayBQuery", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public string RemarksAQuery
		{
			get
			{
				return remarksAQuery;
			}
			set	
			{
				remarksAQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksAQuery", value);
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string RemarksDQuery
		{
			get
			{
				return remarksDQuery;
			}
			set	
			{
				remarksDQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksDQuery", value);
			}
		}

		public string RemarksArrayAQuery
		{
			get
			{
				return remarksArrayAQuery;
			}
			set	
			{
				remarksArrayAQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayAQuery", value);
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
				DictionaryUtil.Add(QueryParameters, "Marker", value);
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
				DictionaryUtil.Add(QueryParameters, "SetId", value);
			}
		}

		public string RemarksCQuery
		{
			get
			{
				return remarksCQuery;
			}
			set	
			{
				remarksCQuery = value;
				DictionaryUtil.Add(QueryParameters, "RemarksCQuery", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListFaceGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFaceGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
