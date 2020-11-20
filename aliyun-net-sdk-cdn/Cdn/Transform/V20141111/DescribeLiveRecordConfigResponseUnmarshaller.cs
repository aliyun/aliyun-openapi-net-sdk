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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveRecordConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveRecordConfigResponse describeLiveRecordConfigResponse = new DescribeLiveRecordConfigResponse();

			describeLiveRecordConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveRecordConfigResponse.RequestId = _ctx.StringValue("DescribeLiveRecordConfig.RequestId");

			List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord> describeLiveRecordConfigResponse_liveAppRecordList = new List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord>();
			for (int i = 0; i < _ctx.Length("DescribeLiveRecordConfig.LiveAppRecordList.Length"); i++) {
				DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord liveAppRecord = new DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord();
				liveAppRecord.DomainName = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].DomainName");
				liveAppRecord.AppName = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].AppName");
				liveAppRecord.OssEndpoint = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssEndpoint");
				liveAppRecord.OssBucket = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssBucket");
				liveAppRecord.OssObjectPrefix = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssObjectPrefix");
				liveAppRecord.CreateTime = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].CreateTime");

				describeLiveRecordConfigResponse_liveAppRecordList.Add(liveAppRecord);
			}
			describeLiveRecordConfigResponse.LiveAppRecordList = describeLiveRecordConfigResponse_liveAppRecordList;
        
			return describeLiveRecordConfigResponse;
        }
    }
}
