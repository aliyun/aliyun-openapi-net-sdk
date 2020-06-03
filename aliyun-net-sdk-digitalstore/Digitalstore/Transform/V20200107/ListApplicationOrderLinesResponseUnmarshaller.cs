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
    public class ListApplicationOrderLinesResponseUnmarshaller
    {
        public static ListApplicationOrderLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationOrderLinesResponse listApplicationOrderLinesResponse = new ListApplicationOrderLinesResponse();

			listApplicationOrderLinesResponse.HttpResponse = context.HttpResponse;
			listApplicationOrderLinesResponse.PageSize = context.IntegerValue("ListApplicationOrderLines.PageSize");
			listApplicationOrderLinesResponse.TotalCount = context.IntegerValue("ListApplicationOrderLines.TotalCount");
			listApplicationOrderLinesResponse.PageNumber = context.IntegerValue("ListApplicationOrderLines.PageNumber");
			listApplicationOrderLinesResponse.RequestId = context.StringValue("ListApplicationOrderLines.RequestId");
			listApplicationOrderLinesResponse.Success = context.BooleanValue("ListApplicationOrderLines.Success");

			List<ListApplicationOrderLinesResponse.ListApplicationOrderLines_ApplyOrderLineBiz> listApplicationOrderLinesResponse_applyOrderLines = new List<ListApplicationOrderLinesResponse.ListApplicationOrderLines_ApplyOrderLineBiz>();
			for (int i = 0; i < context.Length("ListApplicationOrderLines.ApplyOrderLines.Length"); i++) {
				ListApplicationOrderLinesResponse.ListApplicationOrderLines_ApplyOrderLineBiz applyOrderLineBiz = new ListApplicationOrderLinesResponse.ListApplicationOrderLines_ApplyOrderLineBiz();
				applyOrderLineBiz.Barcode = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].Barcode");
				applyOrderLineBiz.OperateQuantity = context.IntegerValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].OperateQuantity");
				applyOrderLineBiz.InboundQuantity = context.IntegerValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].InboundQuantity");
				applyOrderLineBiz.SKUId = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].SKUId");
				applyOrderLineBiz.SKUName = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].SKUName");
				applyOrderLineBiz.StyleId = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].StyleId");
				applyOrderLineBiz.StyleCode = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].StyleCode");
				applyOrderLineBiz.StyleName = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].StyleName");
				applyOrderLineBiz.SizeId = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].SizeId");
				applyOrderLineBiz.SizeCode = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].SizeCode");
				applyOrderLineBiz.SizeName = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].SizeName");
				applyOrderLineBiz.ColorId = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].ColorId");
				applyOrderLineBiz.ColorCode = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].ColorCode");
				applyOrderLineBiz.ColorName = context.StringValue("ListApplicationOrderLines.ApplyOrderLines["+ i +"].ColorName");

				listApplicationOrderLinesResponse_applyOrderLines.Add(applyOrderLineBiz);
			}
			listApplicationOrderLinesResponse.ApplyOrderLines = listApplicationOrderLinesResponse_applyOrderLines;
        
			return listApplicationOrderLinesResponse;
        }
    }
}
