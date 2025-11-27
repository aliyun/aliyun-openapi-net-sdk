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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodEditingUsageDataResponseUnmarshaller
    {
        public static DescribeVodEditingUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodEditingUsageDataResponse describeVodEditingUsageDataResponse = new DescribeVodEditingUsageDataResponse();

			describeVodEditingUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodEditingUsageDataResponse.RequestId = _ctx.StringValue("DescribeVodEditingUsageData.RequestId");
			describeVodEditingUsageDataResponse.StartTime = _ctx.StringValue("DescribeVodEditingUsageData.StartTime");
			describeVodEditingUsageDataResponse.EndTime = _ctx.StringValue("DescribeVodEditingUsageData.EndTime");

			List<DescribeVodEditingUsageDataResponse.DescribeVodEditingUsageData_DataModule> describeVodEditingUsageDataResponse_editingData = new List<DescribeVodEditingUsageDataResponse.DescribeVodEditingUsageData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVodEditingUsageData.EditingData.Length"); i++) {
				DescribeVodEditingUsageDataResponse.DescribeVodEditingUsageData_DataModule dataModule = new DescribeVodEditingUsageDataResponse.DescribeVodEditingUsageData_DataModule();
				dataModule.Specification = _ctx.StringValue("DescribeVodEditingUsageData.EditingData["+ i +"].Specification");
				dataModule.Region = _ctx.StringValue("DescribeVodEditingUsageData.EditingData["+ i +"].Region");
				dataModule.TimeStamp = _ctx.StringValue("DescribeVodEditingUsageData.EditingData["+ i +"].TimeStamp");
				dataModule.Duration = _ctx.LongValue("DescribeVodEditingUsageData.EditingData["+ i +"].Duration");

				describeVodEditingUsageDataResponse_editingData.Add(dataModule);
			}
			describeVodEditingUsageDataResponse.EditingData = describeVodEditingUsageDataResponse_editingData;
        
			return describeVodEditingUsageDataResponse;
        }
    }
}
