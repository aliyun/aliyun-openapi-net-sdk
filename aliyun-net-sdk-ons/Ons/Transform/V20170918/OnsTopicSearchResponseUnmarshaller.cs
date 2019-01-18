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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ons.Model.V20170918;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20170918
{
    public class OnsTopicSearchResponseUnmarshaller
    {
        public static OnsTopicSearchResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTopicSearchResponse onsTopicSearchResponse = new OnsTopicSearchResponse();

			onsTopicSearchResponse.HttpResponse = context.HttpResponse;
			onsTopicSearchResponse.RequestId = context.StringValue("OnsTopicSearch.RequestId");
			onsTopicSearchResponse.HelpUrl = context.StringValue("OnsTopicSearch.HelpUrl");

			List<OnsTopicSearchResponse.OnsTopicSearch_PublishInfoDo> onsTopicSearchResponse_data = new List<OnsTopicSearchResponse.OnsTopicSearch_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsTopicSearch.Data.Length"); i++) {
				OnsTopicSearchResponse.OnsTopicSearch_PublishInfoDo publishInfoDo = new OnsTopicSearchResponse.OnsTopicSearch_PublishInfoDo();
				publishInfoDo.Id = context.LongValue("OnsTopicSearch.Data["+ i +"].Id");
				publishInfoDo.ChannelId = context.IntegerValue("OnsTopicSearch.Data["+ i +"].ChannelId");
				publishInfoDo.ChannelName = context.StringValue("OnsTopicSearch.Data["+ i +"].ChannelName");
				publishInfoDo.OnsRegionId = context.StringValue("OnsTopicSearch.Data["+ i +"].OnsRegionId");
				publishInfoDo.RegionName = context.StringValue("OnsTopicSearch.Data["+ i +"].RegionName");
				publishInfoDo.Topic = context.StringValue("OnsTopicSearch.Data["+ i +"].Topic");
				publishInfoDo.Owner = context.StringValue("OnsTopicSearch.Data["+ i +"].Owner");
				publishInfoDo.Relation = context.IntegerValue("OnsTopicSearch.Data["+ i +"].Relation");
				publishInfoDo.RelationName = context.StringValue("OnsTopicSearch.Data["+ i +"].RelationName");
				publishInfoDo.Status = context.IntegerValue("OnsTopicSearch.Data["+ i +"].Status");
				publishInfoDo.StatusName = context.StringValue("OnsTopicSearch.Data["+ i +"].StatusName");
				publishInfoDo.Appkey = context.StringValue("OnsTopicSearch.Data["+ i +"].Appkey");
				publishInfoDo.CreateTime = context.LongValue("OnsTopicSearch.Data["+ i +"].CreateTime");
				publishInfoDo.UpdateTime = context.LongValue("OnsTopicSearch.Data["+ i +"].UpdateTime");
				publishInfoDo.Remark = context.StringValue("OnsTopicSearch.Data["+ i +"].Remark");

				onsTopicSearchResponse_data.Add(publishInfoDo);
			}
			onsTopicSearchResponse.Data = onsTopicSearchResponse_data;
        
			return onsTopicSearchResponse;
        }
    }
}