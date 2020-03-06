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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20190801;

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
    public class DescribePlanogramRailsRequest : RpcAcsRequest<DescribePlanogramRailsResponse>
    {
        public DescribePlanogramRailsRequest()
            : base("cloudesl", "2019-08-01", "DescribePlanogramRails", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string storeId;

		private string layer;

		private int? pageNumber;

		private string shelf;

		private string railCode;

		private int? pageSize;

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public string Layer
		{
			get
			{
				return layer;
			}
			set	
			{
				layer = value;
				DictionaryUtil.Add(BodyParameters, "Layer", value);
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

		public string Shelf
		{
			get
			{
				return shelf;
			}
			set	
			{
				shelf = value;
				DictionaryUtil.Add(BodyParameters, "Shelf", value);
			}
		}

		public string RailCode
		{
			get
			{
				return railCode;
			}
			set	
			{
				railCode = value;
				DictionaryUtil.Add(BodyParameters, "RailCode", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribePlanogramRailsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePlanogramRailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
