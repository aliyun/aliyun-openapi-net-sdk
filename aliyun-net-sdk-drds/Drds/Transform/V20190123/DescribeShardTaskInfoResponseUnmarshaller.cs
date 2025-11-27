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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeShardTaskInfoResponseUnmarshaller
    {
        public static DescribeShardTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeShardTaskInfoResponse describeShardTaskInfoResponse = new DescribeShardTaskInfoResponse();

			describeShardTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeShardTaskInfoResponse.Success = _ctx.BooleanValue("DescribeShardTaskInfo.Success");
			describeShardTaskInfoResponse.RequestId = _ctx.StringValue("DescribeShardTaskInfo.RequestId");

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data data = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data();
			data.Status = _ctx.StringValue("DescribeShardTaskInfo.Data.Status");
			data.Stage = _ctx.StringValue("DescribeShardTaskInfo.Data.Stage");
			data.Progress = _ctx.StringValue("DescribeShardTaskInfo.Data.Progress");
			data.Expired = _ctx.StringValue("DescribeShardTaskInfo.Data.Expired");
			data.TargetTableName = _ctx.StringValue("DescribeShardTaskInfo.Data.TargetTableName");
			data.SourceTableName = _ctx.StringValue("DescribeShardTaskInfo.Data.SourceTableName");

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Full full = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Full();
			full.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Full.StartTime");
			full.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Progress");
			full.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Tps");
			full.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Total");
			full.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Expired");
			data.Full = full;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullCheck fullCheck = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullCheck();
			fullCheck.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.FullCheck.StartTime");
			fullCheck.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Progress");
			fullCheck.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Tps");
			fullCheck.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Total");
			fullCheck.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Expired");
			data.FullCheck = fullCheck;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullRevise fullRevise = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullRevise();
			fullRevise.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.FullRevise.StartTime");
			fullRevise.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Progress");
			fullRevise.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Tps");
			fullRevise.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Total");
			fullRevise.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Expired");
			data.FullRevise = fullRevise;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Review review = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Review();
			review.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Review.StartTime");
			review.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Progress");
			review.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Tps");
			review.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Total");
			review.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Expired");
			data.Review = review;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Increment increment = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Increment();
			increment.Delay = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Increment.Delay");
			increment.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Increment.StartTime");
			increment.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Increment.Tps");
			data.Increment = increment;
			describeShardTaskInfoResponse.Data = data;
        
			return describeShardTaskInfoResponse;
        }
    }
}
