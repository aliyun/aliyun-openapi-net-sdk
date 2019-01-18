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
    public class OnsPublishGetResponseUnmarshaller
    {
        public static OnsPublishGetResponse Unmarshall(UnmarshallerContext context)
        {
			OnsPublishGetResponse onsPublishGetResponse = new OnsPublishGetResponse();

			onsPublishGetResponse.HttpResponse = context.HttpResponse;
			onsPublishGetResponse.RequestId = context.StringValue("OnsPublishGet.RequestId");
			onsPublishGetResponse.HelpUrl = context.StringValue("OnsPublishGet.HelpUrl");

			List<OnsPublishGetResponse.OnsPublishGet_PublishInfoDo> onsPublishGetResponse_data = new List<OnsPublishGetResponse.OnsPublishGet_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsPublishGet.Data.Length"); i++) {
				OnsPublishGetResponse.OnsPublishGet_PublishInfoDo publishInfoDo = new OnsPublishGetResponse.OnsPublishGet_PublishInfoDo();
				publishInfoDo.Id = context.LongValue("OnsPublishGet.Data["+ i +"].Id");
				publishInfoDo.ChannelId = context.IntegerValue("OnsPublishGet.Data["+ i +"].ChannelId");
				publishInfoDo.ChannelName = context.StringValue("OnsPublishGet.Data["+ i +"].ChannelName");
				publishInfoDo.OnsRegionId = context.StringValue("OnsPublishGet.Data["+ i +"].OnsRegionId");
				publishInfoDo.RegionName = context.StringValue("OnsPublishGet.Data["+ i +"].RegionName");
				publishInfoDo.Owner = context.StringValue("OnsPublishGet.Data["+ i +"].Owner");
				publishInfoDo.ProducerId = context.StringValue("OnsPublishGet.Data["+ i +"].ProducerId");
				publishInfoDo.Topic = context.StringValue("OnsPublishGet.Data["+ i +"].Topic");
				publishInfoDo.Status = context.IntegerValue("OnsPublishGet.Data["+ i +"].Status");
				publishInfoDo.StatusName = context.StringValue("OnsPublishGet.Data["+ i +"].StatusName");
				publishInfoDo.CreateTime = context.LongValue("OnsPublishGet.Data["+ i +"].CreateTime");
				publishInfoDo.UpdateTime = context.LongValue("OnsPublishGet.Data["+ i +"].UpdateTime");

				onsPublishGetResponse_data.Add(publishInfoDo);
			}
			onsPublishGetResponse.Data = onsPublishGetResponse_data;
        
			return onsPublishGetResponse;
        }
    }
}