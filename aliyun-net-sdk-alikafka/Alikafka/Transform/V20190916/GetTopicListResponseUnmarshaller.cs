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
    public class GetTopicListResponseUnmarshaller
    {
        public static GetTopicListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTopicListResponse getTopicListResponse = new GetTopicListResponse();

			getTopicListResponse.HttpResponse = _ctx.HttpResponse;
			getTopicListResponse.CurrentPage = _ctx.IntegerValue("GetTopicList.CurrentPage");
			getTopicListResponse.RequestId = _ctx.StringValue("GetTopicList.RequestId");
			getTopicListResponse.Success = _ctx.BooleanValue("GetTopicList.Success");
			getTopicListResponse.Code = _ctx.IntegerValue("GetTopicList.Code");
			getTopicListResponse.Message = _ctx.StringValue("GetTopicList.Message");
			getTopicListResponse.PageSize = _ctx.IntegerValue("GetTopicList.PageSize");
			getTopicListResponse.Total = _ctx.IntegerValue("GetTopicList.Total");

			List<GetTopicListResponse.GetTopicList_TopicVO> getTopicListResponse_topicList = new List<GetTopicListResponse.GetTopicList_TopicVO>();
			for (int i = 0; i < _ctx.Length("GetTopicList.TopicList.Length"); i++) {
				GetTopicListResponse.GetTopicList_TopicVO topicVO = new GetTopicListResponse.GetTopicList_TopicVO();
				topicVO.Status = _ctx.IntegerValue("GetTopicList.TopicList["+ i +"].Status");
				topicVO.PartitionNum = _ctx.IntegerValue("GetTopicList.TopicList["+ i +"].PartitionNum");
				topicVO.Remark = _ctx.StringValue("GetTopicList.TopicList["+ i +"].Remark");
				topicVO.CreateTime = _ctx.LongValue("GetTopicList.TopicList["+ i +"].CreateTime");
				topicVO.Topic = _ctx.StringValue("GetTopicList.TopicList["+ i +"].Topic");
				topicVO.StatusName = _ctx.StringValue("GetTopicList.TopicList["+ i +"].StatusName");
				topicVO.CompactTopic = _ctx.BooleanValue("GetTopicList.TopicList["+ i +"].CompactTopic");
				topicVO.InstanceId = _ctx.StringValue("GetTopicList.TopicList["+ i +"].InstanceId");
				topicVO.LocalTopic = _ctx.BooleanValue("GetTopicList.TopicList["+ i +"].LocalTopic");
				topicVO.RegionId = _ctx.StringValue("GetTopicList.TopicList["+ i +"].RegionId");

				List<GetTopicListResponse.GetTopicList_TopicVO.GetTopicList_TagVO> topicVO_tags = new List<GetTopicListResponse.GetTopicList_TopicVO.GetTopicList_TagVO>();
				for (int j = 0; j < _ctx.Length("GetTopicList.TopicList["+ i +"].Tags.Length"); j++) {
					GetTopicListResponse.GetTopicList_TopicVO.GetTopicList_TagVO tagVO = new GetTopicListResponse.GetTopicList_TopicVO.GetTopicList_TagVO();
					tagVO.Key = _ctx.StringValue("GetTopicList.TopicList["+ i +"].Tags["+ j +"].Key");
					tagVO._Value = _ctx.StringValue("GetTopicList.TopicList["+ i +"].Tags["+ j +"].Value");

					topicVO_tags.Add(tagVO);
				}
				topicVO.Tags = topicVO_tags;

				getTopicListResponse_topicList.Add(topicVO);
			}
			getTopicListResponse.TopicList = getTopicListResponse_topicList;
        
			return getTopicListResponse;
        }
    }
}
