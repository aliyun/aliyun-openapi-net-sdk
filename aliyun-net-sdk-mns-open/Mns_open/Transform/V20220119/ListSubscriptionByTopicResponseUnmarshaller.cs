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
using Aliyun.Acs.Mns_open.Model.V20220119;

namespace Aliyun.Acs.Mns_open.Transform.V20220119
{
    public class ListSubscriptionByTopicResponseUnmarshaller
    {
        public static ListSubscriptionByTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSubscriptionByTopicResponse listSubscriptionByTopicResponse = new ListSubscriptionByTopicResponse();

			listSubscriptionByTopicResponse.HttpResponse = _ctx.HttpResponse;
			listSubscriptionByTopicResponse.RequestId = _ctx.StringValue("ListSubscriptionByTopic.RequestId");
			listSubscriptionByTopicResponse.Code = _ctx.LongValue("ListSubscriptionByTopic.Code");
			listSubscriptionByTopicResponse.Status = _ctx.StringValue("ListSubscriptionByTopic.Status");
			listSubscriptionByTopicResponse.Message = _ctx.StringValue("ListSubscriptionByTopic.Message");
			listSubscriptionByTopicResponse.Success = _ctx.BooleanValue("ListSubscriptionByTopic.Success");

			ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data data = new ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data();
			data.PageNum = _ctx.LongValue("ListSubscriptionByTopic.Data.PageNum");
			data.PageSize = _ctx.LongValue("ListSubscriptionByTopic.Data.PageSize");
			data.Size = _ctx.LongValue("ListSubscriptionByTopic.Data.Size");
			data.Pages = _ctx.LongValue("ListSubscriptionByTopic.Data.Pages");
			data.Total = _ctx.LongValue("ListSubscriptionByTopic.Data.Total");

			List<ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data.ListSubscriptionByTopic_PageDataItem> data_pageData = new List<ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data.ListSubscriptionByTopic_PageDataItem>();
			for (int i = 0; i < _ctx.Length("ListSubscriptionByTopic.Data.PageData.Length"); i++) {
				ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data.ListSubscriptionByTopic_PageDataItem pageDataItem = new ListSubscriptionByTopicResponse.ListSubscriptionByTopic_Data.ListSubscriptionByTopic_PageDataItem();
				pageDataItem.SubscriptionName = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].SubscriptionName");
				pageDataItem.TopicOwner = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].TopicOwner");
				pageDataItem.TopicName = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].TopicName");
				pageDataItem.Endpoint = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].Endpoint");
				pageDataItem.FilterTag = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].FilterTag");
				pageDataItem.CreateTime = _ctx.LongValue("ListSubscriptionByTopic.Data.PageData["+ i +"].CreateTime");
				pageDataItem.LastModifyTime = _ctx.LongValue("ListSubscriptionByTopic.Data.PageData["+ i +"].LastModifyTime");
				pageDataItem.NotifyStrategy = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].NotifyStrategy");
				pageDataItem.NotifyContentFormat = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].NotifyContentFormat");
				pageDataItem.SubscriptionURL = _ctx.StringValue("ListSubscriptionByTopic.Data.PageData["+ i +"].SubscriptionURL");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			listSubscriptionByTopicResponse.Data = data;
        
			return listSubscriptionByTopicResponse;
        }
    }
}
