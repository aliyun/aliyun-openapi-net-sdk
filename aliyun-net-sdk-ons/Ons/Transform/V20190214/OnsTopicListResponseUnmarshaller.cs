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
        public static OnsTopicListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTopicListResponse onsTopicListResponse = new OnsTopicListResponse();

			onsTopicListResponse.HttpResponse = context.HttpResponse;
			onsTopicListResponse.RequestId = context.StringValue("OnsTopicList.RequestId");
			onsTopicListResponse.HelpUrl = context.StringValue("OnsTopicList.HelpUrl");

			List<OnsTopicListResponse.OnsTopicList_PublishInfoDo> onsTopicListResponse_data = new List<OnsTopicListResponse.OnsTopicList_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsTopicList.Data.Length"); i++) {
				OnsTopicListResponse.OnsTopicList_PublishInfoDo publishInfoDo = new OnsTopicListResponse.OnsTopicList_PublishInfoDo();
				publishInfoDo.Topic = context.StringValue("OnsTopicList.Data["+ i +"].Topic");
				publishInfoDo.Owner = context.StringValue("OnsTopicList.Data["+ i +"].Owner");
				publishInfoDo.Relation = context.IntegerValue("OnsTopicList.Data["+ i +"].Relation");
				publishInfoDo.RelationName = context.StringValue("OnsTopicList.Data["+ i +"].RelationName");
				publishInfoDo.CreateTime = context.LongValue("OnsTopicList.Data["+ i +"].CreateTime");
				publishInfoDo.Remark = context.StringValue("OnsTopicList.Data["+ i +"].Remark");
				publishInfoDo.MessageType = context.IntegerValue("OnsTopicList.Data["+ i +"].MessageType");
				publishInfoDo.InstanceId = context.StringValue("OnsTopicList.Data["+ i +"].InstanceId");
				publishInfoDo.IndependentNaming = context.BooleanValue("OnsTopicList.Data["+ i +"].IndependentNaming");

				List<OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag> publishInfoDo_tags = new List<OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag>();
				for (int j = 0; j < context.Length("OnsTopicList.Data["+ i +"].Tags.Length"); j++) {
					OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag tag = new OnsTopicListResponse.OnsTopicList_PublishInfoDo.OnsTopicList_Tag();
					tag.Key = context.StringValue("OnsTopicList.Data["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("OnsTopicList.Data["+ i +"].Tags["+ j +"].Value");

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
