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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsTopicListResponseUnmarshaller
    {
        public static OnsTopicListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsTopicListResponse onsTopicListResponse = new OnsTopicListResponse();

			onsTopicListResponse.HttpResponse = _ctx.HttpResponse;
			onsTopicListResponse.RequestId = _ctx.StringValue("OnsTopicList.RequestId");
			onsTopicListResponse.HelpUrl = _ctx.StringValue("OnsTopicList.HelpUrl");

			List<OnsTopicListResponse.OnsTopicList_PublishInfoDo> onsTopicListResponse_data = new List<OnsTopicListResponse.OnsTopicList_PublishInfoDo>();
			for (int i = 0; i < _ctx.Length("OnsTopicList.Data.Length"); i++) {
				OnsTopicListResponse.OnsTopicList_PublishInfoDo publishInfoDo = new OnsTopicListResponse.OnsTopicList_PublishInfoDo();
				publishInfoDo.Topic = _ctx.StringValue("OnsTopicList.Data["+ i +"].Topic");
				publishInfoDo.Owner = _ctx.StringValue("OnsTopicList.Data["+ i +"].Owner");
				publishInfoDo.Relation = _ctx.IntegerValue("OnsTopicList.Data["+ i +"].Relation");
				publishInfoDo.RelationName = _ctx.StringValue("OnsTopicList.Data["+ i +"].RelationName");
				publishInfoDo.CreateTime = _ctx.LongValue("OnsTopicList.Data["+ i +"].CreateTime");
				publishInfoDo.Remark = _ctx.StringValue("OnsTopicList.Data["+ i +"].Remark");
				publishInfoDo.MessageType = _ctx.IntegerValue("OnsTopicList.Data["+ i +"].MessageType");
				publishInfoDo.InstanceId = _ctx.StringValue("OnsTopicList.Data["+ i +"].InstanceId");
				publishInfoDo.IndependentNaming = _ctx.BooleanValue("OnsTopicList.Data["+ i +"].IndependentNaming");

				List<OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag> publishInfoDo_tags = new List<OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag>();
				for (int j = 0; j < _ctx.Length("OnsTopicList.Data["+ i +"].Tags.Length"); j++) {
					OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag tag = new OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag();
					tag.Key = _ctx.StringValue("OnsTopicList.Data["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("OnsTopicList.Data["+ i +"].Tags["+ j +"].Value");

					publishInfoDo_tags.Add(tag);
				}
				publishInfoDo.Tags = publishInfoDo_tags;

				onsTopicListResponse_data.Add(publishInfoDo);
			}
			onsTopicListResponse.Data = onsTopicListResponse_data;
        
			return onsTopicListResponse;
        }
    }
}
