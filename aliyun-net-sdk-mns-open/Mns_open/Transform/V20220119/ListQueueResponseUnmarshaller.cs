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
    public class ListQueueResponseUnmarshaller
    {
        public static ListQueueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueueResponse listQueueResponse = new ListQueueResponse();

			listQueueResponse.HttpResponse = _ctx.HttpResponse;
			listQueueResponse.RequestId = _ctx.StringValue("ListQueue.RequestId");
			listQueueResponse.Code = _ctx.LongValue("ListQueue.Code");
			listQueueResponse.Status = _ctx.StringValue("ListQueue.Status");
			listQueueResponse.Message = _ctx.StringValue("ListQueue.Message");
			listQueueResponse.Success = _ctx.BooleanValue("ListQueue.Success");

			ListQueueResponse.ListQueue_Data data = new ListQueueResponse.ListQueue_Data();
			data.PageNum = _ctx.LongValue("ListQueue.Data.PageNum");
			data.PageSize = _ctx.LongValue("ListQueue.Data.PageSize");
			data.Size = _ctx.LongValue("ListQueue.Data.Size");
			data.Pages = _ctx.LongValue("ListQueue.Data.Pages");
			data.Total = _ctx.LongValue("ListQueue.Data.Total");

			List<ListQueueResponse.ListQueue_Data.ListQueue_PageDataItem> data_pageData = new List<ListQueueResponse.ListQueue_Data.ListQueue_PageDataItem>();
			for (int i = 0; i < _ctx.Length("ListQueue.Data.PageData.Length"); i++) {
				ListQueueResponse.ListQueue_Data.ListQueue_PageDataItem pageDataItem = new ListQueueResponse.ListQueue_Data.ListQueue_PageDataItem();
				pageDataItem.QueueUrl = _ctx.StringValue("ListQueue.Data.PageData["+ i +"].QueueUrl");
				pageDataItem.QueueInternalUrl = _ctx.StringValue("ListQueue.Data.PageData["+ i +"].QueueInternalUrl");
				pageDataItem.QueueName = _ctx.StringValue("ListQueue.Data.PageData["+ i +"].QueueName");
				pageDataItem.CreateTime = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].CreateTime");
				pageDataItem.LastModifyTime = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].LastModifyTime");
				pageDataItem.DelaySeconds = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].DelaySeconds");
				pageDataItem.MaximumMessageSize = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].MaximumMessageSize");
				pageDataItem.MessageRetentionPeriod = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].MessageRetentionPeriod");
				pageDataItem.VisibilityTimeout = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].VisibilityTimeout");
				pageDataItem.PollingWaitSeconds = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].PollingWaitSeconds");
				pageDataItem.ActiveMessages = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].ActiveMessages");
				pageDataItem.InactiveMessages = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].InactiveMessages");
				pageDataItem.DelayMessages = _ctx.LongValue("ListQueue.Data.PageData["+ i +"].DelayMessages");
				pageDataItem.LoggingEnabled = _ctx.BooleanValue("ListQueue.Data.PageData["+ i +"].LoggingEnabled");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			listQueueResponse.Data = data;
        
			return listQueueResponse;
        }
    }
}
