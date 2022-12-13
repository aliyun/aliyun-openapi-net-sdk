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
    public class GetConsumerProgressResponseUnmarshaller
    {
        public static GetConsumerProgressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetConsumerProgressResponse getConsumerProgressResponse = new GetConsumerProgressResponse();

			getConsumerProgressResponse.HttpResponse = _ctx.HttpResponse;
			getConsumerProgressResponse.Code = _ctx.IntegerValue("GetConsumerProgress.Code");
			getConsumerProgressResponse.Message = _ctx.StringValue("GetConsumerProgress.Message");
			getConsumerProgressResponse.RequestId = _ctx.StringValue("GetConsumerProgress.RequestId");
			getConsumerProgressResponse.Success = _ctx.BooleanValue("GetConsumerProgress.Success");

			GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress consumerProgress = new GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress();
			consumerProgress.LastTimestamp = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.LastTimestamp");
			consumerProgress.TotalDiff = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TotalDiff");

			List<GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem> consumerProgress_topicList = new List<GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem>();
			for (int i = 0; i < _ctx.Length("GetConsumerProgress.ConsumerProgress.TopicList.Length"); i++) {
				GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem topicListItem = new GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem();
				topicListItem.TotalDiff = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].TotalDiff");
				topicListItem.LastTimestamp = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].LastTimestamp");
				topicListItem.Topic = _ctx.StringValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].Topic");

				List<GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem.GetConsumerProgress_OffsetListItem> topicListItem_offsetList = new List<GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem.GetConsumerProgress_OffsetListItem>();
				for (int j = 0; j < _ctx.Length("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].OffsetList.Length"); j++) {
					GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem.GetConsumerProgress_OffsetListItem offsetListItem = new GetConsumerProgressResponse.GetConsumerProgress_ConsumerProgress.GetConsumerProgress_TopicListItem.GetConsumerProgress_OffsetListItem();
					offsetListItem.Partition = _ctx.IntegerValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].OffsetList["+ j +"].Partition");
					offsetListItem.BrokerOffset = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].OffsetList["+ j +"].BrokerOffset");
					offsetListItem.ConsumerOffset = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].OffsetList["+ j +"].ConsumerOffset");
					offsetListItem.LastTimestamp = _ctx.LongValue("GetConsumerProgress.ConsumerProgress.TopicList["+ i +"].OffsetList["+ j +"].LastTimestamp");

					topicListItem_offsetList.Add(offsetListItem);
				}
				topicListItem.OffsetList = topicListItem_offsetList;

				consumerProgress_topicList.Add(topicListItem);
			}
			consumerProgress.TopicList = consumerProgress_topicList;
			getConsumerProgressResponse.ConsumerProgress = consumerProgress;
        
			return getConsumerProgressResponse;
        }
    }
}
