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
    public class OnsMessageGetByKeyResponseUnmarshaller
    {
        public static OnsMessageGetByKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMessageGetByKeyResponse onsMessageGetByKeyResponse = new OnsMessageGetByKeyResponse();

			onsMessageGetByKeyResponse.HttpResponse = _ctx.HttpResponse;
			onsMessageGetByKeyResponse.RequestId = _ctx.StringValue("OnsMessageGetByKey.RequestId");
			onsMessageGetByKeyResponse.HelpUrl = _ctx.StringValue("OnsMessageGetByKey.HelpUrl");

			List<OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo> onsMessageGetByKeyResponse_data = new List<OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo>();
			for (int i = 0; i < _ctx.Length("OnsMessageGetByKey.Data.Length"); i++) {
				OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo onsRestMessageDo = new OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo();
				onsRestMessageDo.OffsetId = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].OffsetId");
				onsRestMessageDo.StoreSize = _ctx.IntegerValue("OnsMessageGetByKey.Data["+ i +"].StoreSize");
				onsRestMessageDo.ReconsumeTimes = _ctx.IntegerValue("OnsMessageGetByKey.Data["+ i +"].ReconsumeTimes");
				onsRestMessageDo.StoreTimestamp = _ctx.LongValue("OnsMessageGetByKey.Data["+ i +"].StoreTimestamp");
				onsRestMessageDo.Body = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].Body");
				onsRestMessageDo.InstanceId = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].InstanceId");
				onsRestMessageDo.MsgId = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].MsgId");
				onsRestMessageDo.Flag = _ctx.IntegerValue("OnsMessageGetByKey.Data["+ i +"].Flag");
				onsRestMessageDo.StoreHost = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].StoreHost");
				onsRestMessageDo.Topic = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].Topic");
				onsRestMessageDo.BornTimestamp = _ctx.LongValue("OnsMessageGetByKey.Data["+ i +"].BornTimestamp");
				onsRestMessageDo.BodyCRC = _ctx.IntegerValue("OnsMessageGetByKey.Data["+ i +"].BodyCRC");
				onsRestMessageDo.BornHost = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].BornHost");

				List<OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo.OnsMessageGetByKey_MessageProperty> onsRestMessageDo_propertyList = new List<OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo.OnsMessageGetByKey_MessageProperty>();
				for (int j = 0; j < _ctx.Length("OnsMessageGetByKey.Data["+ i +"].PropertyList.Length"); j++) {
					OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo.OnsMessageGetByKey_MessageProperty messageProperty = new OnsMessageGetByKeyResponse.OnsMessageGetByKey_OnsRestMessageDo.OnsMessageGetByKey_MessageProperty();
					messageProperty._Value = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].PropertyList["+ j +"].Value");
					messageProperty.Name = _ctx.StringValue("OnsMessageGetByKey.Data["+ i +"].PropertyList["+ j +"].Name");

					onsRestMessageDo_propertyList.Add(messageProperty);
				}
				onsRestMessageDo.PropertyList = onsRestMessageDo_propertyList;

				onsMessageGetByKeyResponse_data.Add(onsRestMessageDo);
			}
			onsMessageGetByKeyResponse.Data = onsMessageGetByKeyResponse_data;
        
			return onsMessageGetByKeyResponse;
        }
    }
}
