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
    public class OnsDLQMessagePageQueryByGroupIdResponseUnmarshaller
    {
        public static OnsDLQMessagePageQueryByGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsDLQMessagePageQueryByGroupIdResponse onsDLQMessagePageQueryByGroupIdResponse = new OnsDLQMessagePageQueryByGroupIdResponse();

			onsDLQMessagePageQueryByGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			onsDLQMessagePageQueryByGroupIdResponse.RequestId = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.RequestId");
			onsDLQMessagePageQueryByGroupIdResponse.HelpUrl = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.HelpUrl");

			OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo msgFoundDo = new OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo();
			msgFoundDo.TaskId = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.TaskId");
			msgFoundDo.MaxPageCount = _ctx.LongValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MaxPageCount");
			msgFoundDo.CurrentPage = _ctx.LongValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.CurrentPage");

			List<OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo> msgFoundDo_msgFoundList = new List<OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo>();
			for (int i = 0; i < _ctx.Length("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList.Length"); i++) {
				OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo onsRestMessageDo = new OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo();
				onsRestMessageDo.Topic = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].Topic");
				onsRestMessageDo.Flag = _ctx.IntegerValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].Flag");
				onsRestMessageDo.Body = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].Body");
				onsRestMessageDo.StoreSize = _ctx.IntegerValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].StoreSize");
				onsRestMessageDo.BornTimestamp = _ctx.LongValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].BornTimestamp");
				onsRestMessageDo.BornHost = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].BornHost");
				onsRestMessageDo.StoreTimestamp = _ctx.LongValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].StoreTimestamp");
				onsRestMessageDo.StoreHost = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].StoreHost");
				onsRestMessageDo.MsgId = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].MsgId");
				onsRestMessageDo.OffsetId = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].OffsetId");
				onsRestMessageDo.BodyCRC = _ctx.IntegerValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].BodyCRC");
				onsRestMessageDo.ReconsumeTimes = _ctx.IntegerValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].ReconsumeTimes");
				onsRestMessageDo.InstanceId = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].InstanceId");

				List<OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo.OnsDLQMessagePageQueryByGroupId_MessageProperty> onsRestMessageDo_propertyList = new List<OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo.OnsDLQMessagePageQueryByGroupId_MessageProperty>();
				for (int j = 0; j < _ctx.Length("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].PropertyList.Length"); j++) {
					OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo.OnsDLQMessagePageQueryByGroupId_MessageProperty messageProperty = new OnsDLQMessagePageQueryByGroupIdResponse.OnsDLQMessagePageQueryByGroupId_MsgFoundDo.OnsDLQMessagePageQueryByGroupId_OnsRestMessageDo.OnsDLQMessagePageQueryByGroupId_MessageProperty();
					messageProperty.Name = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Name");
					messageProperty._Value = _ctx.StringValue("OnsDLQMessagePageQueryByGroupId.MsgFoundDo.MsgFoundList["+ i +"].PropertyList["+ j +"].Value");

					onsRestMessageDo_propertyList.Add(messageProperty);
				}
				onsRestMessageDo.PropertyList = onsRestMessageDo_propertyList;

				msgFoundDo_msgFoundList.Add(onsRestMessageDo);
			}
			msgFoundDo.MsgFoundList = msgFoundDo_msgFoundList;
			onsDLQMessagePageQueryByGroupIdResponse.MsgFoundDo = msgFoundDo;
        
			return onsDLQMessagePageQueryByGroupIdResponse;
        }
    }
}
