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
    public class ListInboundOrderPreboxingsResponseUnmarshaller
    {
        public static ListInboundOrderPreboxingsResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrderPreboxingsResponse listInboundOrderPreboxingsResponse = new ListInboundOrderPreboxingsResponse();

			listInboundOrderPreboxingsResponse.HttpResponse = context.HttpResponse;
			listInboundOrderPreboxingsResponse.RequestId = context.StringValue("ListInboundOrderPreboxings.RequestId");
			listInboundOrderPreboxingsResponse.Success = context.BooleanValue("ListInboundOrderPreboxings.Success");

			List<ListInboundOrderPreboxingsResponse.ListInboundOrderPreboxings_InboundOrderPreboxingBiz> listInboundOrderPreboxingsResponse_inboundOrderPreboxings = new List<ListInboundOrderPreboxingsResponse.ListInboundOrderPreboxings_InboundOrderPreboxingBiz>();
			for (int i = 0; i < context.Length("ListInboundOrderPreboxings.InboundOrderPreboxings.Length"); i++) {
				ListInboundOrderPreboxingsResponse.ListInboundOrderPreboxings_InboundOrderPreboxingBiz inboundOrderPreboxingBiz = new ListInboundOrderPreboxingsResponse.ListInboundOrderPreboxings_InboundOrderPreboxingBiz();
				inboundOrderPreboxingBiz.OrderId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].OrderId");
				inboundOrderPreboxingBiz.OrderType = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].OrderType");
				inboundOrderPreboxingBiz.OrderCode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].OrderCode");
				inboundOrderPreboxingBiz.CaseId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].CaseId");
				inboundOrderPreboxingBiz.Barcode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].Barcode");
				inboundOrderPreboxingBiz.TagValue = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].TagValue");
				inboundOrderPreboxingBiz.Quantity = context.IntegerValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].Quantity");
				inboundOrderPreboxingBiz.OperateQuantity = context.IntegerValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].OperateQuantity");
				inboundOrderPreboxingBiz.StyleId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].StyleId");
				inboundOrderPreboxingBiz.StyleCode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].StyleCode");
				inboundOrderPreboxingBiz.StyleName = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].StyleName");
				inboundOrderPreboxingBiz.ColorId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].ColorId");
				inboundOrderPreboxingBiz.ColorCode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].ColorCode");
				inboundOrderPreboxingBiz.ColorName = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].ColorName");
				inboundOrderPreboxingBiz.SizeId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].SizeId");
				inboundOrderPreboxingBiz.SizeCode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].SizeCode");
				inboundOrderPreboxingBiz.SizeName = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].SizeName");
				inboundOrderPreboxingBiz.SKUName = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].SKUName");
				inboundOrderPreboxingBiz.SKUId = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].SKUId");
				inboundOrderPreboxingBiz.CaseCode = context.StringValue("ListInboundOrderPreboxings.InboundOrderPreboxings["+ i +"].CaseCode");

				listInboundOrderPreboxingsResponse_inboundOrderPreboxings.Add(inboundOrderPreboxingBiz);
			}
			listInboundOrderPreboxingsResponse.InboundOrderPreboxings = listInboundOrderPreboxingsResponse_inboundOrderPreboxings;
        
			return listInboundOrderPreboxingsResponse;
        }
    }
}
