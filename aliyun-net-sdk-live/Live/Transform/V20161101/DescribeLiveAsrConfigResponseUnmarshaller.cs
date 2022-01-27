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
    public class DescribeLiveAsrConfigResponseUnmarshaller
    {
        public static DescribeLiveAsrConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveAsrConfigResponse describeLiveAsrConfigResponse = new DescribeLiveAsrConfigResponse();

			describeLiveAsrConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveAsrConfigResponse.RequestId = _ctx.StringValue("DescribeLiveAsrConfig.RequestId");

			List<DescribeLiveAsrConfigResponse.DescribeLiveAsrConfig_LiveAsrConfigList> describeLiveAsrConfigResponse_liveAsrConfig = new List<DescribeLiveAsrConfigResponse.DescribeLiveAsrConfig_LiveAsrConfigList>();
			for (int i = 0; i < _ctx.Length("DescribeLiveAsrConfig.LiveAsrConfig.Length"); i++) {
				DescribeLiveAsrConfigResponse.DescribeLiveAsrConfig_LiveAsrConfigList liveAsrConfigList = new DescribeLiveAsrConfigResponse.DescribeLiveAsrConfig_LiveAsrConfigList();
				liveAsrConfigList.DomainName = _ctx.IntegerValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].DomainName");
				liveAsrConfigList.AppName = _ctx.StringValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].AppName");
				liveAsrConfigList.StreamName = _ctx.StringValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].StreamName");
				liveAsrConfigList.Period = _ctx.IntegerValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].Period");
				liveAsrConfigList.MnsTopic = _ctx.StringValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].MnsTopic");
				liveAsrConfigList.MnsRegion = _ctx.StringValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].MnsRegion");
				liveAsrConfigList.HttpCallbackURL = _ctx.StringValue("DescribeLiveAsrConfig.LiveAsrConfig["+ i +"].HttpCallbackURL");

				describeLiveAsrConfigResponse_liveAsrConfig.Add(liveAsrConfigList);
			}
			describeLiveAsrConfigResponse.LiveAsrConfig = describeLiveAsrConfigResponse_liveAsrConfig;
        
			return describeLiveAsrConfigResponse;
        }
    }
}
