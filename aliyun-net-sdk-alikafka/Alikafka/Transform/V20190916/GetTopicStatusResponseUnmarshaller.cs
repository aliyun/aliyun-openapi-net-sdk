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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetTopicStatusResponseUnmarshaller
    {
        public static GetTopicStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTopicStatusResponse getTopicStatusResponse = new GetTopicStatusResponse();

			getTopicStatusResponse.HttpResponse = _ctx.HttpResponse;
			getTopicStatusResponse.Code = _ctx.IntegerValue("GetTopicStatus.Code");
			getTopicStatusResponse.Message = _ctx.StringValue("GetTopicStatus.Message");
			getTopicStatusResponse.RequestId = _ctx.StringValue("GetTopicStatus.RequestId");
			getTopicStatusResponse.Success = _ctx.BooleanValue("GetTopicStatus.Success");

			GetTopicStatusResponse.GetTopicStatus_TopicStatus topicStatus = new GetTopicStatusResponse.GetTopicStatus_TopicStatus();
			topicStatus.TotalCount = _ctx.LongValue("GetTopicStatus.TopicStatus.TotalCount");
			topicStatus.LastTimeStamp = _ctx.LongValue("GetTopicStatus.TopicStatus.LastTimeStamp");

			List<GetTopicStatusResponse.GetTopicStatus_TopicStatus.GetTopicStatus_OffsetTableItem> topicStatus_offsetTable = new List<GetTopicStatusResponse.GetTopicStatus_TopicStatus.GetTopicStatus_OffsetTableItem>();
			for (int i = 0; i < _ctx.Length("GetTopicStatus.TopicStatus.OffsetTable.Length"); i++) {
				GetTopicStatusResponse.GetTopicStatus_TopicStatus.GetTopicStatus_OffsetTableItem offsetTableItem = new GetTopicStatusResponse.GetTopicStatus_TopicStatus.GetTopicStatus_OffsetTableItem();
				offsetTableItem.Partition = _ctx.IntegerValue("GetTopicStatus.TopicStatus.OffsetTable["+ i +"].Partition");
				offsetTableItem.MinOffset = _ctx.LongValue("GetTopicStatus.TopicStatus.OffsetTable["+ i +"].MinOffset");
				offsetTableItem.LastUpdateTimestamp = _ctx.LongValue("GetTopicStatus.TopicStatus.OffsetTable["+ i +"].LastUpdateTimestamp");
				offsetTableItem.MaxOffset = _ctx.LongValue("GetTopicStatus.TopicStatus.OffsetTable["+ i +"].MaxOffset");
				offsetTableItem.Topic = _ctx.StringValue("GetTopicStatus.TopicStatus.OffsetTable["+ i +"].Topic");

				topicStatus_offsetTable.Add(offsetTableItem);
			}
			topicStatus.OffsetTable = topicStatus_offsetTable;
			getTopicStatusResponse.TopicStatus = topicStatus;
        
			return getTopicStatusResponse;
        }
    }
}
