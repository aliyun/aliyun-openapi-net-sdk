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
using Aliyun.Acs.Workorder.Model.V20200326;

namespace Aliyun.Acs.Workorder.Transform.V20200326
{
    public class ListProductsResponseUnmarshaller
    {
        public static ListProductsResponse Unmarshall(UnmarshallerContext context)
        {
			ListProductsResponse listProductsResponse = new ListProductsResponse();

			listProductsResponse.HttpResponse = context.HttpResponse;
			listProductsResponse.Code = context.IntegerValue("ListProducts.Code");
			listProductsResponse.Success = context.BooleanValue("ListProducts.Success");
			listProductsResponse.Message = context.StringValue("ListProducts.Message");
			listProductsResponse.RequestId = context.StringValue("ListProducts.RequestId");

			ListProductsResponse.ListProducts_Data data = new ListProductsResponse.ListProducts_Data();

			List<ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem> data_techMore = new List<ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem>();
			for (int i = 0; i < context.Length("ListProducts.Data.TechMore.Length"); i++) {
				ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem techMoreItem = new ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem();
				techMoreItem.GroupName = context.StringValue("ListProducts.Data.TechMore["+ i +"].GroupName");

				List<ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem.ListProducts_ProductListItem> techMoreItem_productList = new List<ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem.ListProducts_ProductListItem>();
				for (int j = 0; j < context.Length("ListProducts.Data.TechMore["+ i +"].ProductList.Length"); j++) {
					ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem.ListProducts_ProductListItem productListItem = new ListProductsResponse.ListProducts_Data.ListProducts_TechMoreItem.ListProducts_ProductListItem();
					productListItem.Name = context.StringValue("ListProducts.Data.TechMore["+ i +"].ProductList["+ j +"].Name");
					productListItem.ProductCode = context.StringValue("ListProducts.Data.TechMore["+ i +"].ProductList["+ j +"].ProductCode");
					productListItem.Description = context.StringValue("ListProducts.Data.TechMore["+ i +"].ProductList["+ j +"].Description");

					techMoreItem_productList.Add(productListItem);
				}
				techMoreItem.ProductList = techMoreItem_productList;

				data_techMore.Add(techMoreItem);
			}
			data.TechMore = data_techMore;

			List<ListProductsResponse.ListProducts_Data.ListProducts_HotConsultationItem> data_hotConsultation = new List<ListProductsResponse.ListProducts_Data.ListProducts_HotConsultationItem>();
			for (int i = 0; i < context.Length("ListProducts.Data.HotConsultation.Length"); i++) {
				ListProductsResponse.ListProducts_Data.ListProducts_HotConsultationItem hotConsultationItem = new ListProductsResponse.ListProducts_Data.ListProducts_HotConsultationItem();
				hotConsultationItem.Name = context.StringValue("ListProducts.Data.HotConsultation["+ i +"].Name");
				hotConsultationItem.ProductCode = context.StringValue("ListProducts.Data.HotConsultation["+ i +"].ProductCode");
				hotConsultationItem.Description = context.StringValue("ListProducts.Data.HotConsultation["+ i +"].Description");

				data_hotConsultation.Add(hotConsultationItem);
			}
			data.HotConsultation = data_hotConsultation;

			List<ListProductsResponse.ListProducts_Data.ListProducts_ConsultationMoreItem> data_consultationMore = new List<ListProductsResponse.ListProducts_Data.ListProducts_ConsultationMoreItem>();
			for (int i = 0; i < context.Length("ListProducts.Data.ConsultationMore.Length"); i++) {
				ListProductsResponse.ListProducts_Data.ListProducts_ConsultationMoreItem consultationMoreItem = new ListProductsResponse.ListProducts_Data.ListProducts_ConsultationMoreItem();
				consultationMoreItem.Name = context.StringValue("ListProducts.Data.ConsultationMore["+ i +"].Name");
				consultationMoreItem.ProductCode = context.StringValue("ListProducts.Data.ConsultationMore["+ i +"].ProductCode");
				consultationMoreItem.Description = context.StringValue("ListProducts.Data.ConsultationMore["+ i +"].Description");

				data_consultationMore.Add(consultationMoreItem);
			}
			data.ConsultationMore = data_consultationMore;

			List<ListProductsResponse.ListProducts_Data.ListProducts_HotTechItem> data_hotTech = new List<ListProductsResponse.ListProducts_Data.ListProducts_HotTechItem>();
			for (int i = 0; i < context.Length("ListProducts.Data.HotTech.Length"); i++) {
				ListProductsResponse.ListProducts_Data.ListProducts_HotTechItem hotTechItem = new ListProductsResponse.ListProducts_Data.ListProducts_HotTechItem();
				hotTechItem.Name = context.StringValue("ListProducts.Data.HotTech["+ i +"].Name");
				hotTechItem.ProductCode = context.StringValue("ListProducts.Data.HotTech["+ i +"].ProductCode");
				hotTechItem.Description = context.StringValue("ListProducts.Data.HotTech["+ i +"].Description");

				data_hotTech.Add(hotTechItem);
			}
			data.HotTech = data_hotTech;
			listProductsResponse.Data = data;
        
			return listProductsResponse;
        }
    }
}
