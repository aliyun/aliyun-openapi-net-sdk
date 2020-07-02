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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetTopicInfluenceResponseUnmarshaller
    {
        public static GetTopicInfluenceResponse Unmarshall(UnmarshallerContext context)
        {
			GetTopicInfluenceResponse getTopicInfluenceResponse = new GetTopicInfluenceResponse();

			getTopicInfluenceResponse.HttpResponse = context.HttpResponse;
			getTopicInfluenceResponse.Success = context.BooleanValue("GetTopicInfluence.Success");
			getTopicInfluenceResponse.ErrorCode = context.StringValue("GetTopicInfluence.ErrorCode");
			getTopicInfluenceResponse.ErrorMessage = context.StringValue("GetTopicInfluence.ErrorMessage");
			getTopicInfluenceResponse.HttpStatusCode = context.IntegerValue("GetTopicInfluence.HttpStatusCode");
			getTopicInfluenceResponse.RequestId = context.StringValue("GetTopicInfluence.RequestId");

			GetTopicInfluenceResponse.GetTopicInfluence_Data data = new GetTopicInfluenceResponse.GetTopicInfluence_Data();
			data.TopicId = context.LongValue("GetTopicInfluence.Data.TopicId");

			List<GetTopicInfluenceResponse.GetTopicInfluence_Data.GetTopicInfluence_InfluencesItem> data_influences = new List<GetTopicInfluenceResponse.GetTopicInfluence_Data.GetTopicInfluence_InfluencesItem>();
			for (int i = 0; i < context.Length("GetTopicInfluence.Data.Influences.Length"); i++) {
				GetTopicInfluenceResponse.GetTopicInfluence_Data.GetTopicInfluence_InfluencesItem influencesItem = new GetTopicInfluenceResponse.GetTopicInfluence_Data.GetTopicInfluence_InfluencesItem();
				influencesItem.BaselineId = context.LongValue("GetTopicInfluence.Data.Influences["+ i +"].BaselineId");
				influencesItem.Bizdate = context.LongValue("GetTopicInfluence.Data.Influences["+ i +"].Bizdate");
				influencesItem.InGroupId = context.IntegerValue("GetTopicInfluence.Data.Influences["+ i +"].InGroupId");
				influencesItem.BaselineName = context.StringValue("GetTopicInfluence.Data.Influences["+ i +"].BaselineName");
				influencesItem.Owner = context.StringValue("GetTopicInfluence.Data.Influences["+ i +"].Owner");
				influencesItem.Status = context.StringValue("GetTopicInfluence.Data.Influences["+ i +"].Status");
				influencesItem.ProjectId = context.LongValue("GetTopicInfluence.Data.Influences["+ i +"].ProjectId");
				influencesItem.Priority = context.IntegerValue("GetTopicInfluence.Data.Influences["+ i +"].Priority");
				influencesItem.Buffer = context.LongValue("GetTopicInfluence.Data.Influences["+ i +"].Buffer");

				data_influences.Add(influencesItem);
			}
			data.Influences = data_influences;
			getTopicInfluenceResponse.Data = data;
        
			return getTopicInfluenceResponse;
        }
    }
}
