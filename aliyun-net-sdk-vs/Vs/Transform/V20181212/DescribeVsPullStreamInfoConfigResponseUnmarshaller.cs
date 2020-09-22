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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsPullStreamInfoConfigResponseUnmarshaller
    {
        public static DescribeVsPullStreamInfoConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsPullStreamInfoConfigResponse describeVsPullStreamInfoConfigResponse = new DescribeVsPullStreamInfoConfigResponse();

			describeVsPullStreamInfoConfigResponse.HttpResponse = context.HttpResponse;
			describeVsPullStreamInfoConfigResponse.RequestId = context.StringValue("DescribeVsPullStreamInfoConfig.RequestId");

			List<DescribeVsPullStreamInfoConfigResponse.DescribeVsPullStreamInfoConfig_LiveAppRecord> describeVsPullStreamInfoConfigResponse_liveAppRecordList = new List<DescribeVsPullStreamInfoConfigResponse.DescribeVsPullStreamInfoConfig_LiveAppRecord>();
			for (int i = 0; i < context.Length("DescribeVsPullStreamInfoConfig.LiveAppRecordList.Length"); i++) {
				DescribeVsPullStreamInfoConfigResponse.DescribeVsPullStreamInfoConfig_LiveAppRecord liveAppRecord = new DescribeVsPullStreamInfoConfigResponse.DescribeVsPullStreamInfoConfig_LiveAppRecord();
				liveAppRecord.DomainName = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].DomainName");
				liveAppRecord.AppName = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].AppName");
				liveAppRecord.StreamName = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].StreamName");
				liveAppRecord.SourceUrl = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].SourceUrl");
				liveAppRecord.StartTime = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].StartTime");
				liveAppRecord.EndTime = context.StringValue("DescribeVsPullStreamInfoConfig.LiveAppRecordList["+ i +"].EndTime");

				describeVsPullStreamInfoConfigResponse_liveAppRecordList.Add(liveAppRecord);
			}
			describeVsPullStreamInfoConfigResponse.LiveAppRecordList = describeVsPullStreamInfoConfigResponse_liveAppRecordList;
        
			return describeVsPullStreamInfoConfigResponse;
        }
    }
}
