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
using Aliyun.Acs.Ons.Model.V20190214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMessagePageQueryByTopicResponseUnmarshaller
    {
        public static OnsMessagePageQueryByTopicResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMessagePageQueryByTopicResponse onsMessagePageQueryByTopicResponse = new OnsMessagePageQueryByTopicResponse();

			onsMessagePageQueryByTopicResponse.HttpResponse = context.HttpResponse;
			onsMessagePageQueryByTopicResponse.RequestId = context.StringValue("OnsMessagePageQueryByTopic.RequestId");
			onsMessagePageQueryByTopicResponse.HelpUrl = context.StringValue("OnsMessagePageQueryByTopic.HelpUrl");

			OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo msgFoundDo = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo();
			msgFoundDo.TaskId = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.TaskId");
			msgFoundDo.MaxPageCount = context.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MaxPageCount");
			msgFoundDo.CurrentPage = context.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.CurrentPage");

			List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo> msgFoundDo_msgFoundList = new List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo>();
			for (int i = 0; i < context.Length("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList.Length"); i++) {
				OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo onsRestMessageDo = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo();
				onsRestMessageDo.Topic = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Topic");
				onsRestMessageDo.Flag = context.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Flag");
				onsRestMessageDo.Body = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].Body");
				onsRestMessageDo.StoreSize = context.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreSize");
				onsRestMessageDo.BornTimestamp = context.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BornTimestamp");
				onsRestMessageDo.BornHost = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BornHost");
				onsRestMessageDo.StoreTimestamp = context.LongValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreTimestamp");
				onsRestMessageDo.StoreHost = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].StoreHost");
				onsRestMessageDo.MsgId = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].MsgId");
				onsRestMessageDo.OffsetId = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].OffsetId");
				onsRestMessageDo.BodyCRC = context.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].BodyCRC");
				onsRestMessageDo.ReconsumeTimes = context.IntegerValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].ReconsumeTimes");
				onsRestMessageDo.InstanceId = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].InstanceId");

				List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty> onsRestMessageDo_propertyList = new List<OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty>();
				for (int j = 0; j < context.Length("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList.Length"); j++) {
					OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty messageProperty = new OnsMessagePageQueryByTopicResponse.OnsMessagePageQueryByTopic_MsgFoundDo.OnsMessagePageQueryByTopic_OnsRestMessageDo.OnsMessagePageQueryByTopic_MessageProperty();
					messageProperty.Name = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Name");
					messageProperty._Value = context.StringValue("OnsMessagePageQueryByTopic.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Value");

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