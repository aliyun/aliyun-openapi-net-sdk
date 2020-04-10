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
    public class ListBarcodesResponseUnmarshaller
    {
        public static ListBarcodesResponse Unmarshall(UnmarshallerContext context)
        {
			ListBarcodesResponse listBarcodesResponse = new ListBarcodesResponse();

			listBarcodesResponse.HttpResponse = context.HttpResponse;
			listBarcodesResponse.PageSize = context.IntegerValue("ListBarcodes.PageSize");
			listBarcodesResponse.PageNumber = context.IntegerValue("ListBarcodes.PageNumber");
			listBarcodesResponse.RequestId = context.StringValue("ListBarcodes.RequestId");
			listBarcodesResponse.Success = context.BooleanValue("ListBarcodes.Success");
			listBarcodesResponse.TotalCount = context.IntegerValue("ListBarcodes.TotalCount");

			List<ListBarcodesResponse.ListBarcodes_BarcodeModel> listBarcodesResponse_barcodes = new List<ListBarcodesResponse.ListBarcodes_BarcodeModel>();
			for (int i = 0; i < context.Length("ListBarcodes.Barcodes.Length"); i++) {
				ListBarcodesResponse.ListBarcodes_BarcodeModel barcodeModel = new ListBarcodesResponse.ListBarcodes_BarcodeModel();
				barcodeModel.Disable = context.IntegerValue("ListBarcodes.Barcodes["+ i +"].Disable");
				barcodeModel.StyleId = context.StringValue("ListBarcodes.Barcodes["+ i +"].StyleId");
				barcodeModel.SizeName = context.StringValue("ListBarcodes.Barcodes["+ i +"].SizeName");
				barcodeModel.RetailPrice = context.FloatValue("ListBarcodes.Barcodes["+ i +"].RetailPrice");
				barcodeModel.SizeCode = context.StringValue("ListBarcodes.Barcodes["+ i +"].SizeCode");
				barcodeModel.ColorCode = context.StringValue("ListBarcodes.Barcodes["+ i +"].ColorCode");
				barcodeModel.Name = context.StringValue("ListBarcodes.Barcodes["+ i +"].Name");
				barcodeModel.ColorId = context.StringValue("ListBarcodes.Barcodes["+ i +"].ColorId");
				barcodeModel.Code = context.StringValue("ListBarcodes.Barcodes["+ i +"].Code");
				barcodeModel.UpdateDate = context.StringValue("ListBarcodes.Barcodes["+ i +"].UpdateDate");
				barcodeModel.SizeId = context.StringValue("ListBarcodes.Barcodes["+ i +"].SizeId");
				barcodeModel.ColorName = context.StringValue("ListBarcodes.Barcodes["+ i +"].ColorName");
				barcodeModel.CreateDate = context.StringValue("ListBarcodes.Barcodes["+ i +"].CreateDate");
				barcodeModel.StyleCode = context.StringValue("ListBarcodes.Barcodes["+ i +"].StyleCode");
				barcodeModel.StyleName = context.StringValue("ListBarcodes.Barcodes["+ i +"].StyleName");
				barcodeModel.Description = context.StringValue("ListBarcodes.Barcodes["+ i +"].Description");
				barcodeModel.CurrentPrice = context.FloatValue("ListBarcodes.Barcodes["+ i +"].CurrentPrice");
				barcodeModel.BarcodeId = context.StringValue("ListBarcodes.Barcodes["+ i +"].BarcodeId");

				listBarcodesResponse_barcodes.Add(barcodeModel);
			}
			listBarcodesResponse.Barcodes = listBarcodesResponse_barcodes;
        
			return listBarcodesResponse;
        }
    }
}
