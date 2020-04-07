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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ListPhoneTagsRequest : RpcAcsRequest<ListPhoneTagsResponse>
    {
        public ListPhoneTagsRequest()
            : base("CCC", "2017-07-05", "ListPhoneTags")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> numberGroupIdss = new List<string>(){ };

		private int? currentPage;

		private bool? outboundOnly;

		private string number;

		private string instanceId;

		private int? pageSize;

		public List<string> NumberGroupIdss
		{
			get
			{
				return numberGroupIdss;
			}

			set
			{
				numberGroupIdss = value;
				for (int i = 0; i < numberGroupIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NumberGroupIds." + (i + 1) , numberGroupIdss[i]);
				}
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public bool? OutboundOnly
		{
			get
			{
				return outboundOnly;
			}
			set	
			{
				outboundOnly = value;
				DictionaryUtil.Add(QueryParameters, "OutboundOnly", value.ToString());
			}
		}

		public string Number
		{
			get
			{
				return number;
			}
			set	
			{
				number = value;
				DictionaryUtil.Add(QueryParameters, "Number", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPhoneTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPhoneTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
