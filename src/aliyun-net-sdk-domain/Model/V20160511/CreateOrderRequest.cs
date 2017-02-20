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
using Aliyun.Acs.Core.Utils;
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

		private List<SubOrderParam> _subOrderParams;

		public List<SubOrderParam> SubOrderParams
		{
			get
			{
				return _subOrderParams;
			}

			set
			{
				_subOrderParams = value;
				for (int i = 0; i < _subOrderParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".SaleID", _subOrderParams[i].SaleID);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".RelatedName", _subOrderParams[i].RelatedName);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".Action", _subOrderParams[i].Action);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".Period", _subOrderParams[i].Period);
					DictionaryUtil.Add(QueryParameters,"SubOrderParam." + (i + 1) + ".DomainTemplateID", _subOrderParams[i].DomainTemplateID);
				}
			}
		}

		public class SubOrderParam
		{
		    public string SaleID { get; set; }

		    public string RelatedName { get; set; }

		    public string Action { get; set; }

		    public int? Period { get; set; }

		    public string DomainTemplateID { get; set; }
		}

        public override CreateOrderResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}