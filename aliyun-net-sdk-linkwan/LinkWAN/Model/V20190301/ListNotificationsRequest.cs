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
using Aliyun.Acs.LinkWAN.Transform;
using Aliyun.Acs.LinkWAN.Transform.V20190301;

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
    public class ListNotificationsRequest : RpcAcsRequest<ListNotificationsResponse>
    {
        public ListNotificationsRequest()
            : base("LinkWAN", "2019-03-01", "ListNotifications", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private long? endMillis;

		private long? limit;

		private long? offset;

		private bool? ascending;

		private string handleState;

		private List<string> categorys = new List<string>(){ };

		private long? beginMillis;

		private string sortingField;

		public long? EndMillis
		{
			get
			{
				return endMillis;
			}
			set	
			{
				endMillis = value;
				DictionaryUtil.Add(QueryParameters, "EndMillis", value.ToString());
			}
		}

		public long? Limit
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

		public long? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value.ToString());
			}
		}

		public bool? Ascending
		{
			get
			{
				return ascending;
			}
			set	
			{
				ascending = value;
				DictionaryUtil.Add(QueryParameters, "Ascending", value.ToString());
			}
		}

		public string HandleState
		{
			get
			{
				return handleState;
			}
			set	
			{
				handleState = value;
				DictionaryUtil.Add(QueryParameters, "HandleState", value);
			}
		}

		public List<string> Categorys
		{
			get
			{
				return categorys;
			}

			set
			{
				categorys = value;
				for (int i = 0; i < categorys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Category." + (i + 1) , categorys[i]);
				}
			}
		}

		public long? BeginMillis
		{
			get
			{
				return beginMillis;
			}
			set	
			{
				beginMillis = value;
				DictionaryUtil.Add(QueryParameters, "BeginMillis", value.ToString());
			}
		}

		public string SortingField
		{
			get
			{
				return sortingField;
			}
			set	
			{
				sortingField = value;
				DictionaryUtil.Add(QueryParameters, "SortingField", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListNotificationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListNotificationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
