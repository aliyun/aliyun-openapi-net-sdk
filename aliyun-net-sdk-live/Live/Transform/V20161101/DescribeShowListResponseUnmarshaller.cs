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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeShowListResponseUnmarshaller
    {
        public static DescribeShowListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeShowListResponse describeShowListResponse = new DescribeShowListResponse();

			describeShowListResponse.HttpResponse = _ctx.HttpResponse;
			describeShowListResponse.RequestId = _ctx.StringValue("DescribeShowList.RequestId");
			describeShowListResponse.ShowList = _ctx.StringValue("DescribeShowList.ShowList");

			DescribeShowListResponse.DescribeShowList_ShowListInfo showListInfo = new DescribeShowListResponse.DescribeShowList_ShowListInfo();
			showListInfo.CurrentShowId = _ctx.StringValue("DescribeShowList.ShowListInfo.CurrentShowId");
			showListInfo.Background = _ctx.StringValue("DescribeShowList.ShowListInfo.Background");
			showListInfo.Watermark = _ctx.StringValue("DescribeShowList.ShowListInfo.Watermark");
			showListInfo.HighPriorityShowId = _ctx.StringValue("DescribeShowList.ShowListInfo.HighPriorityShowId");
			showListInfo.HighPriorityShowStartTime = _ctx.StringValue("DescribeShowList.ShowListInfo.HighPriorityShowStartTime");
			showListInfo.ShowListRepeatTimes = _ctx.IntegerValue("DescribeShowList.ShowListInfo.ShowListRepeatTimes");
			showListInfo.TotalShowListRepeatTimes = _ctx.IntegerValue("DescribeShowList.ShowListInfo.TotalShowListRepeatTimes");

			List<DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show> showListInfo_showList = new List<DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show>();
			for (int i = 0; i < _ctx.Length("DescribeShowList.ShowListInfo.ShowList.Length"); i++) {
				DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show show = new DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show();
				show.Duration = _ctx.LongValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].Duration");
				show.RepeatTimes = _ctx.IntegerValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].RepeatTimes");
				show.ShowId = _ctx.StringValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ShowId");
				show.ShowName = _ctx.StringValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ShowName");

				DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show.DescribeShowList_ResourceInfo resourceInfo = new DescribeShowListResponse.DescribeShowList_ShowListInfo.DescribeShowList_Show.DescribeShowList_ResourceInfo();
				resourceInfo.LiveInputType = _ctx.IntegerValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ResourceInfo.LiveInputType");
				resourceInfo.ResourceId = _ctx.StringValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ResourceInfo.ResourceId");
				resourceInfo.ResourceType = _ctx.StringValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ResourceInfo.ResourceType");
				resourceInfo.ResourceUrl = _ctx.StringValue("DescribeShowList.ShowListInfo.ShowList["+ i +"].ResourceInfo.ResourceUrl");
				show.ResourceInfo = resourceInfo;

				showListInfo_showList.Add(show);
			}
			showListInfo.ShowList = showListInfo_showList;
			describeShowListResponse.ShowListInfo = showListInfo;
        
			return describeShowListResponse;
        }
    }
}
