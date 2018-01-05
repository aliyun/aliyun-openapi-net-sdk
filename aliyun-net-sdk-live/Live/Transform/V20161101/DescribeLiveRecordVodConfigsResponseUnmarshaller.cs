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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveRecordVodConfigsResponseUnmarshaller
    {
        public static DescribeLiveRecordVodConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveRecordVodConfigsResponse describeLiveRecordVodConfigsResponse = new DescribeLiveRecordVodConfigsResponse();

			describeLiveRecordVodConfigsResponse.HttpResponse = context.HttpResponse;
			describeLiveRecordVodConfigsResponse.RequestId = context.StringValue("DescribeLiveRecordVodConfigs.RequestId");
			describeLiveRecordVodConfigsResponse.PageNum = context.IntegerValue("DescribeLiveRecordVodConfigs.PageNum");
			describeLiveRecordVodConfigsResponse.PageSize = context.IntegerValue("DescribeLiveRecordVodConfigs.PageSize");
			describeLiveRecordVodConfigsResponse.Total = context.StringValue("DescribeLiveRecordVodConfigs.Total");

			List<DescribeLiveRecordVodConfigsResponse.DescribeLiveRecordVodConfigs_LiveRecordVodConfig> describeLiveRecordVodConfigsResponse_liveRecordVodConfigs = new List<DescribeLiveRecordVodConfigsResponse.DescribeLiveRecordVodConfigs_LiveRecordVodConfig>();
			for (int i = 0; i < context.Length("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs.Length"); i++) {
				DescribeLiveRecordVodConfigsResponse.DescribeLiveRecordVodConfigs_LiveRecordVodConfig liveRecordVodConfig = new DescribeLiveRecordVodConfigsResponse.DescribeLiveRecordVodConfigs_LiveRecordVodConfig();
				liveRecordVodConfig.CreateTime = context.StringValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].CreateTime");
				liveRecordVodConfig.DomainName = context.StringValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].DomainName");
				liveRecordVodConfig.AppName = context.StringValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].AppName");
				liveRecordVodConfig.StreamName = context.StringValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].StreamName");
				liveRecordVodConfig.VodTranscodeGroupId = context.StringValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].VodTranscodeGroupId");
				liveRecordVodConfig.CycleDuration = context.IntegerValue("DescribeLiveRecordVodConfigs.LiveRecordVodConfigs["+ i +"].CycleDuration");

				describeLiveRecordVodConfigsResponse_liveRecordVodConfigs.Add(liveRecordVodConfig);
			}
			describeLiveRecordVodConfigsResponse.LiveRecordVodConfigs = describeLiveRecordVodConfigsResponse_liveRecordVodConfigs;
        
			return describeLiveRecordVodConfigsResponse;
        }
    }
}