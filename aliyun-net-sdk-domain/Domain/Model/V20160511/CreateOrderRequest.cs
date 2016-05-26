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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class CreateOrderRequest : RpcAcsRequest<CreateOrderResponse>
    {
        public CreateOrderRequest()
            : base("Domain", "2016-05-11", "CreateOrder")
        {
        }

		private List<SubOrderParam> subOrderParams;

		public List<SubOrderParam> SubOrderParams
		{
			get
			{
				return subOrderParams;
			}

			set
			{
				subOrderParams = value;
				for (int i = 0; i < subOrderParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".SaleID", subOrderParams[i].SaleID);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".RelatedName", subOrderParams[i].RelatedName);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".Action", subOrderParams[i].Action);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".Period", subOrderParams[i].Period);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".DomainTemplateID", subOrderParams[i].DomainTemplateID);
				}
			}
		}

		public class SubOrderParam
		{

			private string saleID;

			private string relatedName;

			private string action;

			private int? period;

			private string domainTemplateID;

			public string SaleID
			{
				get
				{
					return saleID;
				}
				set	
				{
					saleID = value;
				}
			}

			public string RelatedName
			{
				get
				{
					return relatedName;
				}
				set	
				{
					relatedName = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string DomainTemplateID
			{
				get
				{
					return domainTemplateID;
				}
				set	
				{
					domainTemplateID = value;
				}
			}
		}

        public override CreateOrderResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}