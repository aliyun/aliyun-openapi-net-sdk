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
    public class ListInboundOrderSKUTagsResponseUnmarshaller
    {
        public static ListInboundOrderSKUTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrderSKUTagsResponse listInboundOrderSKUTagsResponse = new ListInboundOrderSKUTagsResponse();

			listInboundOrderSKUTagsResponse.HttpResponse = context.HttpResponse;
			listInboundOrderSKUTagsResponse.PageSize = context.IntegerValue("ListInboundOrderSKUTags.PageSize");
			listInboundOrderSKUTagsResponse.TotalCount = context.IntegerValue("ListInboundOrderSKUTags.TotalCount");
			listInboundOrderSKUTagsResponse.PageNumber = context.IntegerValue("ListInboundOrderSKUTags.PageNumber");
			listInboundOrderSKUTagsResponse.RequestId = context.StringValue("ListInboundOrderSKUTags.RequestId");
			listInboundOrderSKUTagsResponse.Success = context.BooleanValue("ListInboundOrderSKUTags.Success");

			List<ListInboundOrderSKUTagsResponse.ListInboundOrderSKUTags_InboundOrderSkuTagBiz> listInboundOrderSKUTagsResponse_skuTags = new List<ListInboundOrderSKUTagsResponse.ListInboundOrderSKUTags_InboundOrderSkuTagBiz>();
			for (int i = 0; i < context.Length("ListInboundOrderSKUTags.SkuTags.Length"); i++) {
				ListInboundOrderSKUTagsResponse.ListInboundOrderSKUTags_InboundOrderSkuTagBiz inboundOrderSkuTagBiz = new ListInboundOrderSKUTagsResponse.ListInboundOrderSKUTags_InboundOrderSkuTagBiz();
				inboundOrderSkuTagBiz.Barcode = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].Barcode");
				inboundOrderSkuTagBiz.CaseId = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].CaseId");
				inboundOrderSkuTagBiz.TagValue = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].TagValue");
				inboundOrderSkuTagBiz.CaseCode = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].CaseCode");
				inboundOrderSkuTagBiz.SKUId = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].SKUId");
				inboundOrderSkuTagBiz.SKUName = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].SKUName");
				inboundOrderSkuTagBiz.StyleId = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].StyleId");
				inboundOrderSkuTagBiz.StyleCode = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].StyleCode");
				inboundOrderSkuTagBiz.StyleName = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].StyleName");
				inboundOrderSkuTagBiz.SizeId = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].SizeId");
				inboundOrderSkuTagBiz.SizeCode = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].SizeCode");
				inboundOrderSkuTagBiz.SizeName = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].SizeName");
				inboundOrderSkuTagBiz.ColorId = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].ColorId");
				inboundOrderSkuTagBiz.ColorCode = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].ColorCode");
				inboundOrderSkuTagBiz.ColorName = context.StringValue("ListInboundOrderSKUTags.SkuTags["+ i +"].ColorName");

				listInboundOrderSKUTagsResponse_skuTags.Add(inboundOrderSkuTagBiz);
			}
			listInboundOrderSKUTagsResponse.SkuTags = listInboundOrderSKUTagsResponse_skuTags;
        
			return listInboundOrderSKUTagsResponse;
        }
    }
}
