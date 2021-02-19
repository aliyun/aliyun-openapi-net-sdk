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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeBindersResponseUnmarshaller
    {
        public static DescribeBindersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBindersResponse describeBindersResponse = new DescribeBindersResponse();

			describeBindersResponse.HttpResponse = _ctx.HttpResponse;
			describeBindersResponse.ErrorMessage = _ctx.StringValue("DescribeBinders.ErrorMessage");
			describeBindersResponse.ErrorCode = _ctx.StringValue("DescribeBinders.ErrorCode");
			describeBindersResponse.TotalCount = _ctx.IntegerValue("DescribeBinders.TotalCount");
			describeBindersResponse.Message = _ctx.StringValue("DescribeBinders.Message");
			describeBindersResponse.PageSize = _ctx.IntegerValue("DescribeBinders.PageSize");
			describeBindersResponse.DynamicCode = _ctx.StringValue("DescribeBinders.DynamicCode");
			describeBindersResponse.Code = _ctx.StringValue("DescribeBinders.Code");
			describeBindersResponse.DynamicMessage = _ctx.StringValue("DescribeBinders.DynamicMessage");
			describeBindersResponse.PageNumber = _ctx.IntegerValue("DescribeBinders.PageNumber");
			describeBindersResponse.RequestId = _ctx.StringValue("DescribeBinders.RequestId");
			describeBindersResponse.Success = _ctx.BooleanValue("DescribeBinders.Success");

			List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo> describeBindersResponse_eslItemBindInfos = new List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo>();
			for (int i = 0; i < _ctx.Length("DescribeBinders.EslItemBindInfos.Length"); i++) {
				DescribeBindersResponse.DescribeBinders_EslItemBindInfo eslItemBindInfo = new DescribeBindersResponse.DescribeBinders_EslItemBindInfo();
				eslItemBindInfo.PromotionText = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionText");
				eslItemBindInfo.BindId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].BindId");
				eslItemBindInfo.StoreId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].StoreId");
				eslItemBindInfo.TemplateId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateId");
				eslItemBindInfo.EslPic = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslPic");
				eslItemBindInfo.EslStatus = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslStatus");
				eslItemBindInfo.ItemTitle = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemTitle");
				eslItemBindInfo.OriginalPrice = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].OriginalPrice");
				eslItemBindInfo.TemplateSceneId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateSceneId");
				eslItemBindInfo.GmtModified = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].GmtModified");
				eslItemBindInfo.ActionPrice = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ActionPrice");
				eslItemBindInfo.PriceUnit = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PriceUnit");
				eslItemBindInfo.EslConnectAp = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslConnectAp");
				eslItemBindInfo.SkuId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].SkuId");
				eslItemBindInfo.EslBarCode = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslBarCode");
				eslItemBindInfo.ItemShortTitle = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemShortTitle");
				eslItemBindInfo.BePromotion = _ctx.BooleanValue("DescribeBinders.EslItemBindInfos["+ i +"].BePromotion");
				eslItemBindInfo.EslModel = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslModel");
				eslItemBindInfo.ItemBarCode = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemBarCode");
				eslItemBindInfo.ItemId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemId");
				eslItemBindInfo.PromotionStart = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionStart");
				eslItemBindInfo.PromotionEnd = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionEnd");

				describeBindersResponse_eslItemBindInfos.Add(eslItemBindInfo);
			}
			describeBindersResponse.EslItemBindInfos = describeBindersResponse_eslItemBindInfos;
        
			return describeBindersResponse;
        }
    }
}
