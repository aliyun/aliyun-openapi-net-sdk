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
    public class SearchTmOnsalesRequest : RpcAcsRequest<SearchTmOnsalesResponse>
    {
        public SearchTmOnsalesRequest()
            : base("Trademark", "2018-07-24", "SearchTmOnsales", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string tmName;

		private string productCode;

		private string topSearch;

		private int? regLeft;

		private string classification;

		private int? pageNum;

		private long? orderPriceLeft;

		private bool? queryAll;

		private string sortName;

		private long? orderPriceRight;

		private int? pageSize;

		private string sortOrder;

		private string tag;

		private string keyword;

		private string registerNumber;

		private int? regRight;

		public string TmName
		{
			get
			{
				return tmName;
			}
			set	
			{
				tmName = value;
				DictionaryUtil.Add(QueryParameters, "TmName", value);
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public string TopSearch
		{
			get
			{
				return topSearch;
			}
			set	
			{
				topSearch = value;
				DictionaryUtil.Add(QueryParameters, "TopSearch", value);
			}
		}

		public int? RegLeft
		{
			get
			{
				return regLeft;
			}
			set	
			{
				regLeft = value;
				DictionaryUtil.Add(QueryParameters, "RegLeft", value.ToString());
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

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public long? OrderPriceLeft
		{
			get
			{
				return orderPriceLeft;
			}
			set	
			{
				orderPriceLeft = value;
				DictionaryUtil.Add(QueryParameters, "OrderPriceLeft", value.ToString());
			}
		}

		public bool? QueryAll
		{
			get
			{
				return queryAll;
			}
			set	
			{
				queryAll = value;
				DictionaryUtil.Add(QueryParameters, "QueryAll", value.ToString());
			}
		}

		public string SortName
		{
			get
			{
				return sortName;
			}
			set	
			{
				sortName = value;
				DictionaryUtil.Add(QueryParameters, "SortName", value);
			}
		}

		public long? OrderPriceRight
		{
			get
			{
				return orderPriceRight;
			}
			set	
			{
				orderPriceRight = value;
				DictionaryUtil.Add(QueryParameters, "OrderPriceRight", value.ToString());
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

		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public string RegisterNumber
		{
			get
			{
				return registerNumber;
			}
			set	
			{
				registerNumber = value;
				DictionaryUtil.Add(QueryParameters, "RegisterNumber", value);
			}
		}

		public int? RegRight
		{
			get
			{
				return regRight;
			}
			set	
			{
				regRight = value;
				DictionaryUtil.Add(QueryParameters, "RegRight", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchTmOnsalesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchTmOnsalesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
