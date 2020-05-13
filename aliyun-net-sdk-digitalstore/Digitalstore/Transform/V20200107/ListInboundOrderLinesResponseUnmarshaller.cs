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
    public class ListInboundOrderLinesResponseUnmarshaller
    {
        public static ListInboundOrderLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrderLinesResponse listInboundOrderLinesResponse = new ListInboundOrderLinesResponse();

			listInboundOrderLinesResponse.HttpResponse = context.HttpResponse;
			listInboundOrderLinesResponse.TotalCount = context.IntegerValue("ListInboundOrderLines.TotalCount");
			listInboundOrderLinesResponse.PageSize = context.IntegerValue("ListInboundOrderLines.PageSize");
			listInboundOrderLinesResponse.PageNumber = context.IntegerValue("ListInboundOrderLines.PageNumber");
			listInboundOrderLinesResponse.RequestId = context.StringValue("ListInboundOrderLines.RequestId");
			listInboundOrderLinesResponse.Success = context.BooleanValue("ListInboundOrderLines.Success");

			List<ListInboundOrderLinesResponse.ListInboundOrderLines_InboundOrderLineBiz> listInboundOrderLinesResponse_inboundOrderLines = new List<ListInboundOrderLinesResponse.ListInboundOrderLines_InboundOrderLineBiz>();
			for (int i = 0; i < context.Length("ListInboundOrderLines.InboundOrderLines.Length"); i++) {
				ListInboundOrderLinesResponse.ListInboundOrderLines_InboundOrderLineBiz inboundOrderLineBiz = new ListInboundOrderLinesResponse.ListInboundOrderLines_InboundOrderLineBiz();
				inboundOrderLineBiz.Barcode = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].Barcode");
				inboundOrderLineBiz.OperateQuantity = context.IntegerValue("ListInboundOrderLines.InboundOrderLines["+ i +"].OperateQuantity");
				inboundOrderLineBiz.Quantity = context.IntegerValue("ListInboundOrderLines.InboundOrderLines["+ i +"].Quantity");
				inboundOrderLineBiz.ConfirmQuantity = context.IntegerValue("ListInboundOrderLines.InboundOrderLines["+ i +"].ConfirmQuantity");
				inboundOrderLineBiz.SKUId = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].SKUId");
				inboundOrderLineBiz.SKUName = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].SKUName");
				inboundOrderLineBiz.StyleId = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].StyleId");
				inboundOrderLineBiz.StyleCode = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].StyleCode");
				inboundOrderLineBiz.StyleName = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].StyleName");
				inboundOrderLineBiz.SizeId = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].SizeId");
				inboundOrderLineBiz.SizeCode = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].SizeCode");
				inboundOrderLineBiz.SizeName = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].SizeName");
				inboundOrderLineBiz.ColorId = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].ColorId");
				inboundOrderLineBiz.ColorCode = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].ColorCode");
				inboundOrderLineBiz.ColorName = context.StringValue("ListInboundOrderLines.InboundOrderLines["+ i +"].ColorName");

				listInboundOrderLinesResponse_inboundOrderLines.Add(inboundOrderLineBiz);
			}
			listInboundOrderLinesResponse.InboundOrderLines = listInboundOrderLinesResponse_inboundOrderLines;
        
			return listInboundOrderLinesResponse;
        }
    }
}
