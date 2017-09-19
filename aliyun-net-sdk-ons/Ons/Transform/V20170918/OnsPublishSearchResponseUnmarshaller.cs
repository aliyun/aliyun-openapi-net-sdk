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
    public class OnsPublishSearchResponseUnmarshaller
    {
        public static OnsPublishSearchResponse Unmarshall(UnmarshallerContext context)
        {
			OnsPublishSearchResponse onsPublishSearchResponse = new OnsPublishSearchResponse();

			onsPublishSearchResponse.HttpResponse = context.HttpResponse;
			onsPublishSearchResponse.RequestId = context.StringValue("OnsPublishSearch.RequestId");
			onsPublishSearchResponse.HelpUrl = context.StringValue("OnsPublishSearch.HelpUrl");

			List<OnsPublishSearchResponse.OnsPublishSearch_PublishInfoDo> onsPublishSearchResponse_data = new List<OnsPublishSearchResponse.OnsPublishSearch_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsPublishSearch.Data.Length"); i++) {
				OnsPublishSearchResponse.OnsPublishSearch_PublishInfoDo publishInfoDo = new OnsPublishSearchResponse.OnsPublishSearch_PublishInfoDo();
				publishInfoDo.Id = context.LongValue("OnsPublishSearch.Data["+ i +"].Id");
				publishInfoDo.ChannelId = context.IntegerValue("OnsPublishSearch.Data["+ i +"].ChannelId");
				publishInfoDo.ChannelName = context.StringValue("OnsPublishSearch.Data["+ i +"].ChannelName");
				publishInfoDo.OnsRegionId = context.StringValue("OnsPublishSearch.Data["+ i +"].OnsRegionId");
				publishInfoDo.RegionName = context.StringValue("OnsPublishSearch.Data["+ i +"].RegionName");
				publishInfoDo.Owner = context.StringValue("OnsPublishSearch.Data["+ i +"].Owner");
				publishInfoDo.ProducerId = context.StringValue("OnsPublishSearch.Data["+ i +"].ProducerId");
				publishInfoDo.Topic = context.StringValue("OnsPublishSearch.Data["+ i +"].Topic");
				publishInfoDo.Status = context.IntegerValue("OnsPublishSearch.Data["+ i +"].Status");
				publishInfoDo.StatusName = context.StringValue("OnsPublishSearch.Data["+ i +"].StatusName");
				publishInfoDo.CreateTime = context.LongValue("OnsPublishSearch.Data["+ i +"].CreateTime");
				publishInfoDo.UpdateTime = context.LongValue("OnsPublishSearch.Data["+ i +"].UpdateTime");

				onsPublishSearchResponse_data.Add(publishInfoDo);
			}
			onsPublishSearchResponse.Data = onsPublishSearchResponse_data;
        
			return onsPublishSearchResponse;
        }
    }
}