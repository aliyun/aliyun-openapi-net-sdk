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
    public class ListGoodsStylesResponseUnmarshaller
    {
        public static ListGoodsStylesResponse Unmarshall(UnmarshallerContext context)
        {
			ListGoodsStylesResponse listGoodsStylesResponse = new ListGoodsStylesResponse();

			listGoodsStylesResponse.HttpResponse = context.HttpResponse;
			listGoodsStylesResponse.PageSize = context.IntegerValue("ListGoodsStyles.PageSize");
			listGoodsStylesResponse.PageNumber = context.IntegerValue("ListGoodsStyles.PageNumber");
			listGoodsStylesResponse.RequestId = context.StringValue("ListGoodsStyles.RequestId");
			listGoodsStylesResponse.Success = context.BooleanValue("ListGoodsStyles.Success");
			listGoodsStylesResponse.TotalCount = context.IntegerValue("ListGoodsStyles.TotalCount");

			List<ListGoodsStylesResponse.ListGoodsStyles_GoodsStyleModel> listGoodsStylesResponse_goodsStyles = new List<ListGoodsStylesResponse.ListGoodsStyles_GoodsStyleModel>();
			for (int i = 0; i < context.Length("ListGoodsStyles.GoodsStyles.Length"); i++) {
				ListGoodsStylesResponse.ListGoodsStyles_GoodsStyleModel goodsStyleModel = new ListGoodsStylesResponse.ListGoodsStyles_GoodsStyleModel();
				goodsStyleModel.SizeGroupName = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].SizeGroupName");
				goodsStyleModel.Disable = context.IntegerValue("ListGoodsStyles.GoodsStyles["+ i +"].Disable");
				goodsStyleModel.Name = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].Name");
				goodsStyleModel.SizeGroupCode = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].SizeGroupCode");
				goodsStyleModel.RetailPrice = context.FloatValue("ListGoodsStyles.GoodsStyles["+ i +"].RetailPrice");
				goodsStyleModel.SizeGroupId = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].SizeGroupId");
				goodsStyleModel.Code = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].Code");
				goodsStyleModel.UpdateDate = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].UpdateDate");
				goodsStyleModel.UseSkuColor = context.IntegerValue("ListGoodsStyles.GoodsStyles["+ i +"].UseSkuColor");
				goodsStyleModel.Description = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].Description");
				goodsStyleModel.CurrentPrice = context.FloatValue("ListGoodsStyles.GoodsStyles["+ i +"].CurrentPrice");
				goodsStyleModel.UseSkuSize = context.IntegerValue("ListGoodsStyles.GoodsStyles["+ i +"].UseSkuSize");
				goodsStyleModel.CreateDate = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].CreateDate");
				goodsStyleModel.StyleId = context.StringValue("ListGoodsStyles.GoodsStyles["+ i +"].StyleId");

				listGoodsStylesResponse_goodsStyles.Add(goodsStyleModel);
			}
			listGoodsStylesResponse.GoodsStyles = listGoodsStylesResponse_goodsStyles;
        
			return listGoodsStylesResponse;
        }
    }
}
