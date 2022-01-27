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
    public class DescribeLivePullStreamConfigResponseUnmarshaller
    {
        public static DescribeLivePullStreamConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePullStreamConfigResponse describeLivePullStreamConfigResponse = new DescribeLivePullStreamConfigResponse();

			describeLivePullStreamConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePullStreamConfigResponse.RequestId = _ctx.StringValue("DescribeLivePullStreamConfig.RequestId");

			List<DescribeLivePullStreamConfigResponse.DescribeLivePullStreamConfig_LiveAppRecord> describeLivePullStreamConfigResponse_liveAppRecordList = new List<DescribeLivePullStreamConfigResponse.DescribeLivePullStreamConfig_LiveAppRecord>();
			for (int i = 0; i < _ctx.Length("DescribeLivePullStreamConfig.LiveAppRecordList.Length"); i++) {
				DescribeLivePullStreamConfigResponse.DescribeLivePullStreamConfig_LiveAppRecord liveAppRecord = new DescribeLivePullStreamConfigResponse.DescribeLivePullStreamConfig_LiveAppRecord();
				liveAppRecord.DomainName = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].DomainName");
				liveAppRecord.AppName = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].AppName");
				liveAppRecord.StreamName = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].StreamName");
				liveAppRecord.SourceUrl = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].SourceUrl");
				liveAppRecord.SourceUsing = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].SourceUsing");
				liveAppRecord.StartTime = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].StartTime");
				liveAppRecord.EndTime = _ctx.StringValue("DescribeLivePullStreamConfig.LiveAppRecordList["+ i +"].EndTime");

				describeLivePullStreamConfigResponse_liveAppRecordList.Add(liveAppRecord);
			}
			describeLivePullStreamConfigResponse.LiveAppRecordList = describeLivePullStreamConfigResponse_liveAppRecordList;
        
			return describeLivePullStreamConfigResponse;
        }
    }
}
