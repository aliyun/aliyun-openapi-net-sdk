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
    public class ListOutboundOrderLinesResponseUnmarshaller
    {
        public static ListOutboundOrderLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundOrderLinesResponse listOutboundOrderLinesResponse = new ListOutboundOrderLinesResponse();

			listOutboundOrderLinesResponse.HttpResponse = context.HttpResponse;
			listOutboundOrderLinesResponse.PageSize = context.IntegerValue("ListOutboundOrderLines.PageSize");
			listOutboundOrderLinesResponse.TotalCount = context.IntegerValue("ListOutboundOrderLines.TotalCount");
			listOutboundOrderLinesResponse.PageNumber = context.IntegerValue("ListOutboundOrderLines.PageNumber");
			listOutboundOrderLinesResponse.RequestId = context.StringValue("ListOutboundOrderLines.RequestId");
			listOutboundOrderLinesResponse.Success = context.BooleanValue("ListOutboundOrderLines.Success");

			List<ListOutboundOrderLinesResponse.ListOutboundOrderLines_OutboundOrderLineBiz> listOutboundOrderLinesResponse_outboundOrderLines = new List<ListOutboundOrderLinesResponse.ListOutboundOrderLines_OutboundOrderLineBiz>();
			for (int i = 0; i < context.Length("ListOutboundOrderLines.OutboundOrderLines.Length"); i++) {
				ListOutboundOrderLinesResponse.ListOutboundOrderLines_OutboundOrderLineBiz outboundOrderLineBiz = new ListOutboundOrderLinesResponse.ListOutboundOrderLines_OutboundOrderLineBiz();
				outboundOrderLineBiz.Barcode = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].Barcode");
				outboundOrderLineBiz.OperateQuantity = context.IntegerValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].OperateQuantity");
				outboundOrderLineBiz.Quantity = context.IntegerValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].Quantity");
				outboundOrderLineBiz.ConfirmQuantity = context.IntegerValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].ConfirmQuantity");
				outboundOrderLineBiz.SKUId = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].SKUId");
				outboundOrderLineBiz.SKUName = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].SKUName");
				outboundOrderLineBiz.StyleId = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].StyleId");
				outboundOrderLineBiz.StyleCode = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].StyleCode");
				outboundOrderLineBiz.StyleName = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].StyleName");
				outboundOrderLineBiz.SizeId = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].SizeId");
				outboundOrderLineBiz.SizeCode = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].SizeCode");
				outboundOrderLineBiz.SizeName = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].SizeName");
				outboundOrderLineBiz.ColorId = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].ColorId");
				outboundOrderLineBiz.ColorCode = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].ColorCode");
				outboundOrderLineBiz.ColorName = context.StringValue("ListOutboundOrderLines.OutboundOrderLines["+ i +"].ColorName");

				listOutboundOrderLinesResponse_outboundOrderLines.Add(outboundOrderLineBiz);
			}
			listOutboundOrderLinesResponse.OutboundOrderLines = listOutboundOrderLinesResponse_outboundOrderLines;
        
			return listOutboundOrderLinesResponse;
        }
    }
}
