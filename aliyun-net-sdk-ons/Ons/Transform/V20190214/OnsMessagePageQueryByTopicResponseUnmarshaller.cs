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
    public class OnsMessagePageQueryByTopicResponseUnmarshaller
    {
        public static OnsMessagePageQueryByTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMessagePageQueryByTopicResponse onsMessagePageQueryByTopicResponse = new OnsMessagePageQueryByTopicResponse();

			onsMessagePageQueryByTopicResponse.HttpResponse = _ctx.HttpResponse;
			onsMessagePageQueryByTopicResponse.RequestId = _ctx.StringValue("OnsMessagePageQueryByTopic.RequestId");
			onsMessagePageQueryByTopicResponse.HelpUrl = _ctx.StringValue("OnsMessagePageQueryByTopic.HelpUrl");

			OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo msgFoundDo = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo();
			msgFoundDo.CurrentPage = _ctx.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.CurrentPage");
			msgFoundDo.MaxPageCount = _ctx.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MaxPageCount");
			msgFoundDo.TaskId = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.TaskId");

			List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo> msgFoundDo_msgFoundList = new List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo>();
			for (int i = 0; i < _ctx.Length("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList.Length"); i++) {
				OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo onsRestMessageDo = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo();
				onsRestMessageDo.OffsetId = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].OffsetId");
				onsRestMessageDo.StoreSize = _ctx.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreSize");
				onsRestMessageDo.ReconsumeTimes = _ctx.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].ReconsumeTimes");
				onsRestMessageDo.StoreTimestamp = _ctx.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreTimestamp");
				onsRestMessageDo.Body = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Body");
				onsRestMessageDo.InstanceId = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].InstanceId");
				onsRestMessageDo.MsgId = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].MsgId");
				onsRestMessageDo.Flag = _ctx.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Flag");
				onsRestMessageDo.StoreHost = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreHost");
				onsRestMessageDo.Topic = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Topic");
				onsRestMessageDo.BornTimestamp = _ctx.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BornTimestamp");
				onsRestMessageDo.BodyCRC = _ctx.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BodyCRC");
				onsRestMessageDo.BornHost = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BornHost");

				List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty> onsRestMessageDo_propertyList = new List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty>();
				for (int j = 0; j < _ctx.Length("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList.Length"); j++) {
					OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty messageProperty = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty();
					messageProperty._Value = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Value");
					messageProperty.Name = _ctx.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Name");

					onsRestMessageDo_propertyList.Add(messageProperty);
				}
				onsRestMessageDo.PropertyList = onsRestMessageDo_propertyList;

				msgFoundDo_msgFoundList.Add(onsRestMessageDo);
			}
			msgFoundDo.MsgFoundList = msgFoundDo_msgFoundList;
			onsMessagePageQueryByTopicResponse.MsgFoundDo = msgFoundDo;
        
			return onsMessagePageQueryByTopicResponse;
        }
    }
}
