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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListProduceOrderSKUTagsResponseUnmarshaller
    {
        public static ListProduceOrderSKUTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProduceOrderSKUTagsResponse listProduceOrderSKUTagsResponse = new ListProduceOrderSKUTagsResponse();

			listProduceOrderSKUTagsResponse.HttpResponse = context.HttpResponse;
			listProduceOrderSKUTagsResponse.PageSize = context.IntegerValue("ListProduceOrderSKUTags.PageSize");
			listProduceOrderSKUTagsResponse.TotalCount = context.IntegerValue("ListProduceOrderSKUTags.TotalCount");
			listProduceOrderSKUTagsResponse.PageNumber = context.IntegerValue("ListProduceOrderSKUTags.PageNumber");
			listProduceOrderSKUTagsResponse.RequestId = context.StringValue("ListProduceOrderSKUTags.RequestId");
			listProduceOrderSKUTagsResponse.Success = context.BooleanValue("ListProduceOrderSKUTags.Success");

			List<ListProduceOrderSKUTagsResponse.ListProduceOrderSKUTags_ProduceOrderSkuTagBiz> listProduceOrderSKUTagsResponse_skuTags = new List<ListProduceOrderSKUTagsResponse.ListProduceOrderSKUTags_ProduceOrderSkuTagBiz>();
			for (int i = 0; i < context.Length("ListProduceOrderSKUTags.SkuTags.Length"); i++) {
				ListProduceOrderSKUTagsResponse.ListProduceOrderSKUTags_ProduceOrderSkuTagBiz produceOrderSkuTagBiz = new ListProduceOrderSKUTagsResponse.ListProduceOrderSKUTags_ProduceOrderSkuTagBiz();
				produceOrderSkuTagBiz.Barcode = context.StringValue("ListProduceOrderSKUTags.SkuTags["+ i +"].Barcode");
				produceOrderSkuTagBiz.CaseId = context.StringValue("ListProduceOrderSKUTags.SkuTags["+ i +"].CaseId");
				produceOrderSkuTagBiz.TagValue = context.StringValue("ListProduceOrderSKUTags.SkuTags["+ i +"].TagValue");
				produceOrderSkuTagBiz.CaseCode = context.StringValue("ListProduceOrderSKUTags.SkuTags["+ i +"].CaseCode");

				listProduceOrderSKUTagsResponse_skuTags.Add(produceOrderSkuTagBiz);
			}
			listProduceOrderSKUTagsResponse.SkuTags = listProduceOrderSKUTagsResponse_skuTags;
        
			return listProduceOrderSKUTagsResponse;
        }
    }
}
