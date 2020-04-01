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
        public static DescribeBindersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBindersResponse describeBindersResponse = new DescribeBindersResponse();

			describeBindersResponse.HttpResponse = context.HttpResponse;
			describeBindersResponse.ErrorMessage = context.StringValue("DescribeBinders.ErrorMessage");
			describeBindersResponse.ErrorCode = context.StringValue("DescribeBinders.ErrorCode");
			describeBindersResponse.TotalCount = context.IntegerValue("DescribeBinders.TotalCount");
			describeBindersResponse.Message = context.StringValue("DescribeBinders.Message");
			describeBindersResponse.PageSize = context.IntegerValue("DescribeBinders.PageSize");
			describeBindersResponse.DynamicCode = context.StringValue("DescribeBinders.DynamicCode");
			describeBindersResponse.Code = context.StringValue("DescribeBinders.Code");
			describeBindersResponse.DynamicMessage = context.StringValue("DescribeBinders.DynamicMessage");
			describeBindersResponse.PageNumber = context.IntegerValue("DescribeBinders.PageNumber");
			describeBindersResponse.RequestId = context.StringValue("DescribeBinders.RequestId");
			describeBindersResponse.Success = context.BooleanValue("DescribeBinders.Success");

			List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo> describeBindersResponse_eslItemBindInfos = new List<DescribeBindersResponse.DescribeBinders_EslItemBindInfo>();
			for (int i = 0; i < context.Length("DescribeBinders.EslItemBindInfos.Length"); i++) {
				DescribeBindersResponse.DescribeBinders_EslItemBindInfo eslItemBindInfo = new DescribeBindersResponse.DescribeBinders_EslItemBindInfo();
				eslItemBindInfo.PromotionText = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionText");
				eslItemBindInfo.BindId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].BindId");
				eslItemBindInfo.StoreId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].StoreId");
				eslItemBindInfo.TemplateId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateId");
				eslItemBindInfo.EslPic = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslPic");
				eslItemBindInfo.EslStatus = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslStatus");
				eslItemBindInfo.ItemTitle = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemTitle");
				eslItemBindInfo.OriginalPrice = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].OriginalPrice");
				eslItemBindInfo.TemplateSceneId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].TemplateSceneId");
				eslItemBindInfo.GmtModified = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].GmtModified");
				eslItemBindInfo.ActionPrice = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ActionPrice");
				eslItemBindInfo.PriceUnit = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PriceUnit");
				eslItemBindInfo.EslConnectAp = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslConnectAp");
				eslItemBindInfo.SkuId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].SkuId");
				eslItemBindInfo.EslBarCode = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslBarCode");
				eslItemBindInfo.ItemShortTitle = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemShortTitle");
				eslItemBindInfo.BePromotion = context.BooleanValue("DescribeBinders.EslItemBindInfos["+ i +"].BePromotion");
				eslItemBindInfo.EslModel = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].EslModel");
				eslItemBindInfo.ItemBarCode = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemBarCode");
				eslItemBindInfo.ItemId = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].ItemId");
				eslItemBindInfo.PromotionStart = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionStart");
				eslItemBindInfo.PromotionEnd = context.StringValue("DescribeBinders.EslItemBindInfos["+ i +"].PromotionEnd");

				describeBindersResponse_eslItemBindInfos.Add(eslItemBindInfo);
			}
			describeBindersResponse.EslItemBindInfos = describeBindersResponse_eslItemBindInfos;
        
			return describeBindersResponse;
        }
    }
}
