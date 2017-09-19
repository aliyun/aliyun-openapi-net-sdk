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
    public class OnsTopicGetResponseUnmarshaller
    {
        public static OnsTopicGetResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTopicGetResponse onsTopicGetResponse = new OnsTopicGetResponse();

			onsTopicGetResponse.HttpResponse = context.HttpResponse;
			onsTopicGetResponse.RequestId = context.StringValue("OnsTopicGet.RequestId");
			onsTopicGetResponse.HelpUrl = context.StringValue("OnsTopicGet.HelpUrl");

			List<OnsTopicGetResponse.OnsTopicGet_PublishInfoDo> onsTopicGetResponse_data = new List<OnsTopicGetResponse.OnsTopicGet_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsTopicGet.Data.Length"); i++) {
				OnsTopicGetResponse.OnsTopicGet_PublishInfoDo publishInfoDo = new OnsTopicGetResponse.OnsTopicGet_PublishInfoDo();
				publishInfoDo.Id = context.LongValue("OnsTopicGet.Data["+ i +"].Id");
				publishInfoDo.ChannelId = context.IntegerValue("OnsTopicGet.Data["+ i +"].ChannelId");
				publishInfoDo.ChannelName = context.StringValue("OnsTopicGet.Data["+ i +"].ChannelName");
				publishInfoDo.OnsRegionId = context.StringValue("OnsTopicGet.Data["+ i +"].OnsRegionId");
				publishInfoDo.RegionName = context.StringValue("OnsTopicGet.Data["+ i +"].RegionName");
				publishInfoDo.Topic = context.StringValue("OnsTopicGet.Data["+ i +"].Topic");
				publishInfoDo.Owner = context.StringValue("OnsTopicGet.Data["+ i +"].Owner");
				publishInfoDo.Relation = context.IntegerValue("OnsTopicGet.Data["+ i +"].Relation");
				publishInfoDo.RelationName = context.StringValue("OnsTopicGet.Data["+ i +"].RelationName");
				publishInfoDo.Status = context.IntegerValue("OnsTopicGet.Data["+ i +"].Status");
				publishInfoDo.StatusName = context.StringValue("OnsTopicGet.Data["+ i +"].StatusName");
				publishInfoDo.Appkey = context.StringValue("OnsTopicGet.Data["+ i +"].Appkey");
				publishInfoDo.CreateTime = context.LongValue("OnsTopicGet.Data["+ i +"].CreateTime");
				publishInfoDo.UpdateTime = context.LongValue("OnsTopicGet.Data["+ i +"].UpdateTime");
				publishInfoDo.Remark = context.StringValue("OnsTopicGet.Data["+ i +"].Remark");

				onsTopicGetResponse_data.Add(publishInfoDo);
			}
			onsTopicGetResponse.Data = onsTopicGetResponse_data;
        
			return onsTopicGetResponse;
        }
    }
}