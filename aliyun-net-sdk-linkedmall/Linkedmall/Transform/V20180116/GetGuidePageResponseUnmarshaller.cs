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
    public class GetGuidePageResponseUnmarshaller
    {
        public static GetGuidePageResponse Unmarshall(UnmarshallerContext context)
        {
			GetGuidePageResponse getGuidePageResponse = new GetGuidePageResponse();

			getGuidePageResponse.HttpResponse = context.HttpResponse;
			getGuidePageResponse.RequestId = context.StringValue("GetGuidePage.RequestId");
			getGuidePageResponse.Code = context.StringValue("GetGuidePage.Code");
			getGuidePageResponse.Message = context.StringValue("GetGuidePage.Message");

			List<GetGuidePageResponse.GetGuidePage_MiniShopInfoItem> getGuidePageResponse_miniShopInfo = new List<GetGuidePageResponse.GetGuidePage_MiniShopInfoItem>();
			for (int i = 0; i < context.Length("GetGuidePage.MiniShopInfo.Length"); i++) {
				GetGuidePageResponse.GetGuidePage_MiniShopInfoItem miniShopInfoItem = new GetGuidePageResponse.GetGuidePage_MiniShopInfoItem();
				miniShopInfoItem.BizId = context.StringValue("GetGuidePage.MiniShopInfo["+ i +"].BizId");
				miniShopInfoItem.Name = context.StringValue("GetGuidePage.MiniShopInfo["+ i +"].Name");
				miniShopInfoItem.Src = context.StringValue("GetGuidePage.MiniShopInfo["+ i +"].Src");

				getGuidePageResponse_miniShopInfo.Add(miniShopInfoItem);
			}
			getGuidePageResponse.MiniShopInfo = getGuidePageResponse_miniShopInfo;
        
			return getGuidePageResponse;
        }
    }
}
