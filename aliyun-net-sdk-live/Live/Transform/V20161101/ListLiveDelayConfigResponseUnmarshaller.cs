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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ListLiveDelayConfigResponseUnmarshaller
    {
        public static ListLiveDelayConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveDelayConfigResponse listLiveDelayConfigResponse = new ListLiveDelayConfigResponse();

			listLiveDelayConfigResponse.HttpResponse = _ctx.HttpResponse;
			listLiveDelayConfigResponse.RequestId = _ctx.StringValue("ListLiveDelayConfig.RequestId");
			listLiveDelayConfigResponse.Total = _ctx.IntegerValue("ListLiveDelayConfig.Total");

			List<ListLiveDelayConfigResponse.ListLiveDelayConfig_DelayConfig> listLiveDelayConfigResponse_delayConfigList = new List<ListLiveDelayConfigResponse.ListLiveDelayConfig_DelayConfig>();
			for (int i = 0; i < _ctx.Length("ListLiveDelayConfig.DelayConfigList.Length"); i++) {
				ListLiveDelayConfigResponse.ListLiveDelayConfig_DelayConfig delayConfig = new ListLiveDelayConfigResponse.ListLiveDelayConfig_DelayConfig();
				delayConfig.App = _ctx.StringValue("ListLiveDelayConfig.DelayConfigList["+ i +"].App");
				delayConfig.DelayTime = _ctx.StringValue("ListLiveDelayConfig.DelayConfigList["+ i +"].DelayTime");
				delayConfig.Domain = _ctx.StringValue("ListLiveDelayConfig.DelayConfigList["+ i +"].Domain");
				delayConfig.Stream = _ctx.StringValue("ListLiveDelayConfig.DelayConfigList["+ i +"].Stream");
				delayConfig.TaskTriggerMode = _ctx.StringValue("ListLiveDelayConfig.DelayConfigList["+ i +"].TaskTriggerMode");

				listLiveDelayConfigResponse_delayConfigList.Add(delayConfig);
			}
			listLiveDelayConfigResponse.DelayConfigList = listLiveDelayConfigResponse_delayConfigList;
        
			return listLiveDelayConfigResponse;
        }
    }
}
