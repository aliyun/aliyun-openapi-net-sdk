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
    public class ListNodesByOwnedJoinPermissionIdRequest : RpcAcsRequest<ListNodesByOwnedJoinPermissionIdResponse>
    {
        public ListNodesByOwnedJoinPermissionIdRequest()
            : base("LinkWAN", "2019-03-01", "ListNodesByOwnedJoinPermissionId", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string joinPermissionId;

		private string iotInstanceId;

		private string fuzzyDevEui;

		private long? limit;

		private long? offset;

		private bool? ascending;

		private string sortingField;

		public string JoinPermissionId
		{
			get
			{
				return joinPermissionId;
			}
			set	
			{
				joinPermissionId = value;
				DictionaryUtil.Add(QueryParameters, "JoinPermissionId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string FuzzyDevEui
		{
			get
			{
				return fuzzyDevEui;
			}
			set	
			{
				fuzzyDevEui = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyDevEui", value);
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

        public override ListNodesByOwnedJoinPermissionIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListNodesByOwnedJoinPermissionIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
