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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryGuideItemGroupResponseUnmarshaller
    {
        public static QueryGuideItemGroupResponse Unmarshall(UnmarshallerContext context)
        {
			QueryGuideItemGroupResponse queryGuideItemGroupResponse = new QueryGuideItemGroupResponse();

			queryGuideItemGroupResponse.HttpResponse = context.HttpResponse;
			queryGuideItemGroupResponse.RequestId = context.StringValue("QueryGuideItemGroup.RequestId");
			queryGuideItemGroupResponse.Code = context.StringValue("QueryGuideItemGroup.Code");
			queryGuideItemGroupResponse.Message = context.StringValue("QueryGuideItemGroup.Message");
			queryGuideItemGroupResponse.SubCode = context.StringValue("QueryGuideItemGroup.SubCode");
			queryGuideItemGroupResponse.SubMessage = context.StringValue("QueryGuideItemGroup.SubMessage");
			queryGuideItemGroupResponse.Success = context.BooleanValue("QueryGuideItemGroup.Success");

			List<QueryGuideItemGroupResponse.QueryGuideItemGroup_ItemInfo> queryGuideItemGroupResponse_guideItemGroup = new List<QueryGuideItemGroupResponse.QueryGuideItemGroup_ItemInfo>();
			for (int i = 0; i < context.Length("QueryGuideItemGroup.GuideItemGroup.Length"); i++) {
				QueryGuideItemGroupResponse.QueryGuideItemGroup_ItemInfo itemInfo = new QueryGuideItemGroupResponse.QueryGuideItemGroup_ItemInfo();
				itemInfo.ItemId = context.LongValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].ItemId");
				itemInfo.ItemTitle = context.StringValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].ItemTitle");
				itemInfo.MainPicUrl = context.StringValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].MainPicUrl");
				itemInfo.ItemUrl = context.StringValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].ItemUrl");
				itemInfo.PriceCent = context.LongValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].PriceCent");
				itemInfo.Points = context.LongValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].Points");
				itemInfo.ReservePrice = context.StringValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].ReservePrice");
				itemInfo.PointsAmount = context.LongValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].PointsAmount");
				itemInfo.PointPrice = context.LongValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].PointPrice");
				itemInfo.LmItemId = context.StringValue("QueryGuideItemGroup.GuideItemGroup["+ i +"].LmItemId");

				queryGuideItemGroupResponse_guideItemGroup.Add(itemInfo);
			}
			queryGuideItemGroupResponse.GuideItemGroup = queryGuideItemGroupResponse_guideItemGroup;
        
			return queryGuideItemGroupResponse;
        }
    }
}
