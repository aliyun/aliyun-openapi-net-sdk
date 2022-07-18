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
			describeBindersResponse.RequestId = _ctx.StringValue("DescribeBinders.RequestId");
			describeBindersResponse.ErrorMessage = _ctx.StringValue("DescribeBinders.ErrorMessage");
			describeBindersResponse.Success = _ctx.BooleanValue("DescribeBinders.Success");
			describeBindersResponse.ErrorCode = _ctx.StringValue("DescribeBinders.ErrorCode");
			describeBindersResponse.Code = _ctx.StringValue("DescribeBinders.Code");
			describeBindersResponse.Message = _ctx.StringValue("DescribeBinders.Message");
			describeBindersResponse.DynamicMessage = _ctx.StringValue("DescribeBinders.DynamicMessage");
			describeBindersResponse.PageNumber = _ctx.IntegerValue("DescribeBinders.PageNumber");
			describeBindersResponse.PageSize = _ctx.IntegerValue("DescribeBinders.PageSize");
			describeBindersResponse.TotalCount = _ctx.IntegerValue("DescribeBinders.TotalCount");
			describeBindersResponse.DynamicCode = _ctx.StringValue("DescribeBinders.DynamicCode");

			List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo> describeBindersResponse_eslItemBindInfos = new List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo>();
			for (int i = 0; i < _ctx.Length("DescribeBinders.EslItemBindInfos.Length"); i++) {
				DescribeBindersResponse.DescribeBinders_EslItemBindInfo eslItemBindInfo = new DescribeBindersResponse.DescribeBinders_EslItemBindInfo();
				eslItemBindInfo.EslBarCode = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslBarCode");
				eslItemBindInfo.TemplateSceneId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateSceneId");
				eslItemBindInfo.ActionPrice = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ActionPrice");
				eslItemBindInfo.ItemTitle = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemTitle");
				eslItemBindInfo.PromotionStart = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionStart");
				eslItemBindInfo.PriceUnit = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PriceUnit");
				eslItemBindInfo.OriginalPrice = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].OriginalPrice");
				eslItemBindInfo.ItemId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemId");
				eslItemBindInfo.GmtModified = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].GmtModified");
				eslItemBindInfo.EslPic = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslPic");
				eslItemBindInfo.StoreId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].StoreId");
				eslItemBindInfo.ItemShortTitle = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemShortTitle");
				eslItemBindInfo.BindId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].BindId");
				eslItemBindInfo.PromotionText = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionText");
				eslItemBindInfo.EslModel = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslModel");
				eslItemBindInfo.BePromotion = _ctx.BooleanValue("DescribeBinders.EslItemBindInfos["+ i +"].BePromotion");
				eslItemBindInfo.SkuId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].SkuId");
				eslItemBindInfo.EslConnectAp = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslConnectAp");
				eslItemBindInfo.EslStatus = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslStatus");
				eslItemBindInfo.TemplateId = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateId");
				eslItemBindInfo.PromotionEnd = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionEnd");
				eslItemBindInfo.ItemBarCode = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemBarCode");
				eslItemBindInfo.ContainerName = _ctx.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ContainerName");

				describeBindersResponse_eslItemBindInfos.Add(eslItemBindInfo);
			}
			describeBindersResponse.EslItemBindInfos = describeBindersResponse_eslItemBindInfos;
        
			return describeBindersResponse;
        }
    }
}
