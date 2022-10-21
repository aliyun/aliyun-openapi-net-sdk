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
    public class ListTopicResponseUnmarshaller
    {
        public static ListTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTopicResponse listTopicResponse = new ListTopicResponse();

			listTopicResponse.HttpResponse = _ctx.HttpResponse;
			listTopicResponse.RequestId = _ctx.StringValue("ListTopic.RequestId");
			listTopicResponse.Code = _ctx.LongValue("ListTopic.Code");
			listTopicResponse.Status = _ctx.StringValue("ListTopic.Status");
			listTopicResponse.Message = _ctx.StringValue("ListTopic.Message");
			listTopicResponse.Success = _ctx.BooleanValue("ListTopic.Success");

			ListTopicResponse.ListTopic_Data data = new ListTopicResponse.ListTopic_Data();
			data.PageNum = _ctx.LongValue("ListTopic.Data.PageNum");
			data.PageSize = _ctx.LongValue("ListTopic.Data.PageSize");
			data.Total = _ctx.LongValue("ListTopic.Data.Total");

			List<ListTopicResponse.ListTopic_Data.ListTopic_PageDataItem> data_pageData = new List<ListTopicResponse.ListTopic_Data.ListTopic_PageDataItem>();
			for (int i = 0; i < _ctx.Length("ListTopic.Data.PageData.Length"); i++) {
				ListTopicResponse.ListTopic_Data.ListTopic_PageDataItem pageDataItem = new ListTopicResponse.ListTopic_Data.ListTopic_PageDataItem();
				pageDataItem.TopicName = _ctx.StringValue("ListTopic.Data.PageData["+ i +"].TopicName");
				pageDataItem.MessageCount = _ctx.LongValue("ListTopic.Data.PageData["+ i +"].MessageCount");
				pageDataItem.MaxMessageSize = _ctx.LongValue("ListTopic.Data.PageData["+ i +"].MaxMessageSize");
				pageDataItem.MessageRetentionPeriod = _ctx.LongValue("ListTopic.Data.PageData["+ i +"].MessageRetentionPeriod");
				pageDataItem.CreateTime = _ctx.LongValue("ListTopic.Data.PageData["+ i +"].CreateTime");
				pageDataItem.LastModifyTime = _ctx.LongValue("ListTopic.Data.PageData["+ i +"].LastModifyTime");
				pageDataItem.TopicUrl = _ctx.StringValue("ListTopic.Data.PageData["+ i +"].TopicUrl");
				pageDataItem.TopicInnerUrl = _ctx.StringValue("ListTopic.Data.PageData["+ i +"].TopicInnerUrl");
				pageDataItem.LoggingEnabled = _ctx.BooleanValue("ListTopic.Data.PageData["+ i +"].LoggingEnabled");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			listTopicResponse.Data = data;
        
			return listTopicResponse;
        }
    }
}
