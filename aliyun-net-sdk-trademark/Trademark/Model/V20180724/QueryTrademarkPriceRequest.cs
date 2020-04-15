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
    public class QueryTrademarkPriceRequest : RpcAcsRequest<QueryTrademarkPriceResponse>
    {
        public QueryTrademarkPriceRequest()
            : base("Trademark", "2018-07-24", "QueryTrademarkPrice", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string tmName;

		private string orderData;

		private int? type;

		private long? userId;

		private string tmIcon;

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

		public string OrderData
		{
			get
			{
				return orderData;
			}
			set	
			{
				orderData = value;
				DictionaryUtil.Add(QueryParameters, "OrderData", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value.ToString());
			}
		}

		public string TmIcon
		{
			get
			{
				return tmIcon;
			}
			set	
			{
				tmIcon = value;
				DictionaryUtil.Add(QueryParameters, "TmIcon", value);
			}
		}

        public override QueryTrademarkPriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTrademarkPriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
