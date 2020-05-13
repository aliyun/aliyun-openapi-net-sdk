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
    public class ListOutboundOrderSKUTagsResponseUnmarshaller
    {
        public static ListOutboundOrderSKUTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundOrderSKUTagsResponse listOutboundOrderSKUTagsResponse = new ListOutboundOrderSKUTagsResponse();

			listOutboundOrderSKUTagsResponse.HttpResponse = context.HttpResponse;
			listOutboundOrderSKUTagsResponse.PageSize = context.IntegerValue("ListOutboundOrderSKUTags.PageSize");
			listOutboundOrderSKUTagsResponse.TotalCount = context.IntegerValue("ListOutboundOrderSKUTags.TotalCount");
			listOutboundOrderSKUTagsResponse.PageNumber = context.IntegerValue("ListOutboundOrderSKUTags.PageNumber");
			listOutboundOrderSKUTagsResponse.RequestId = context.StringValue("ListOutboundOrderSKUTags.RequestId");
			listOutboundOrderSKUTagsResponse.Success = context.BooleanValue("ListOutboundOrderSKUTags.Success");

			List<ListOutboundOrderSKUTagsResponse.ListOutboundOrderSKUTags_OutboundOrderSkuTagBiz> listOutboundOrderSKUTagsResponse_skuTags = new List<ListOutboundOrderSKUTagsResponse.ListOutboundOrderSKUTags_OutboundOrderSkuTagBiz>();
			for (int i = 0; i < context.Length("ListOutboundOrderSKUTags.SkuTags.Length"); i++) {
				ListOutboundOrderSKUTagsResponse.ListOutboundOrderSKUTags_OutboundOrderSkuTagBiz outboundOrderSkuTagBiz = new ListOutboundOrderSKUTagsResponse.ListOutboundOrderSKUTags_OutboundOrderSkuTagBiz();
				outboundOrderSkuTagBiz.Barcode = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].Barcode");
				outboundOrderSkuTagBiz.CaseId = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].CaseId");
				outboundOrderSkuTagBiz.TagValue = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].TagValue");
				outboundOrderSkuTagBiz.CaseCode = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].CaseCode");
				outboundOrderSkuTagBiz.SKUId = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].SKUId");
				outboundOrderSkuTagBiz.SKUName = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].SKUName");
				outboundOrderSkuTagBiz.StyleId = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].StyleId");
				outboundOrderSkuTagBiz.StyleCode = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].StyleCode");
				outboundOrderSkuTagBiz.StyleName = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].StyleName");
				outboundOrderSkuTagBiz.SizeId = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].SizeId");
				outboundOrderSkuTagBiz.SizeCode = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].SizeCode");
				outboundOrderSkuTagBiz.SizeName = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].SizeName");
				outboundOrderSkuTagBiz.ColorId = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].ColorId");
				outboundOrderSkuTagBiz.ColorCode = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].ColorCode");
				outboundOrderSkuTagBiz.ColorName = context.StringValue("ListOutboundOrderSKUTags.SkuTags["+ i +"].ColorName");

				listOutboundOrderSKUTagsResponse_skuTags.Add(outboundOrderSkuTagBiz);
			}
			listOutboundOrderSKUTagsResponse.SkuTags = listOutboundOrderSKUTagsResponse_skuTags;
        
			return listOutboundOrderSKUTagsResponse;
        }
    }
}
