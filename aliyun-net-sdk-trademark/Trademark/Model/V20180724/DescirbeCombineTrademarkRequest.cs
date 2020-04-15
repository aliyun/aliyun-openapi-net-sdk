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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class DescirbeCombineTrademarkRequest : RpcAcsRequest<DescirbeCombineTrademarkResponse>
    {
        public DescirbeCombineTrademarkRequest()
            : base("Trademark", "2018-07-24", "DescirbeCombineTrademark", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string ownerName;

		private string classification;

		private string registrationNumber;

		private bool? accurateMatch;

		private int? pageNumber;

		private string products;

		private string similarGroups;

		private string name;

		private int? pageSize;

		public string OwnerName
		{
			get
			{
				return ownerName;
			}
			set	
			{
				ownerName = value;
				DictionaryUtil.Add(QueryParameters, "OwnerName", value);
			}
		}

		public string Classification
		{
			get
			{
				return classification;
			}
			set	
			{
				classification = value;
				DictionaryUtil.Add(QueryParameters, "Classification", value);
			}
		}

		public string RegistrationNumber
		{
			get
			{
				return registrationNumber;
			}
			set	
			{
				registrationNumber = value;
				DictionaryUtil.Add(QueryParameters, "RegistrationNumber", value);
			}
		}

		public bool? AccurateMatch
		{
			get
			{
				return accurateMatch;
			}
			set	
			{
				accurateMatch = value;
				DictionaryUtil.Add(QueryParameters, "AccurateMatch", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string Products
		{
			get
			{
				return products;
			}
			set	
			{
				products = value;
				DictionaryUtil.Add(QueryParameters, "Products", value);
			}
		}

		public string SimilarGroups
		{
			get
			{
				return similarGroups;
			}
			set	
			{
				similarGroups = value;
				DictionaryUtil.Add(QueryParameters, "SimilarGroups", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

        public override DescirbeCombineTrademarkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescirbeCombineTrademarkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
