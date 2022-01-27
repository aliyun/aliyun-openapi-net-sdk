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
			describeShardTaskInfoResponse.RequestId = _ctx.StringValue("DescribeShardTaskInfo.RequestId");
			describeShardTaskInfoResponse.Success = _ctx.BooleanValue("DescribeShardTaskInfo.Success");

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data data = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data();
			data.SourceTableName = _ctx.StringValue("DescribeShardTaskInfo.Data.SourceTableName");
			data.TargetTableName = _ctx.StringValue("DescribeShardTaskInfo.Data.TargetTableName");
			data.Status = _ctx.StringValue("DescribeShardTaskInfo.Data.Status");
			data.Stage = _ctx.StringValue("DescribeShardTaskInfo.Data.Stage");
			data.Progress = _ctx.StringValue("DescribeShardTaskInfo.Data.Progress");
			data.Expired = _ctx.StringValue("DescribeShardTaskInfo.Data.Expired");

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Full full = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Full();
			full.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Expired");
			full.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Progress");
			full.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Total");
			full.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Full.Tps");
			full.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Full.StartTime");
			data.Full = full;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullCheck fullCheck = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullCheck();
			fullCheck.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Expired");
			fullCheck.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Progress");
			fullCheck.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Total");
			fullCheck.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullCheck.Tps");
			fullCheck.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.FullCheck.StartTime");
			data.FullCheck = fullCheck;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullRevise fullRevise = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_FullRevise();
			fullRevise.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Expired");
			fullRevise.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Progress");
			fullRevise.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Total");
			fullRevise.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.FullRevise.Tps");
			fullRevise.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.FullRevise.StartTime");
			data.FullRevise = fullRevise;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Review review = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Review();
			review.Expired = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Expired");
			review.Progress = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Progress");
			review.Total = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Total");
			review.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Review.Tps");
			review.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Review.StartTime");
			data.Review = review;

			DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Increment increment = new DescribeShardTaskInfoResponse.DescribeShardTaskInfo_Data.DescribeShardTaskInfo_Increment();
			increment.Delay = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Increment.Delay");
			increment.Tps = _ctx.IntegerValue("DescribeShardTaskInfo.Data.Increment.Tps");
			increment.StartTime = _ctx.StringValue("DescribeShardTaskInfo.Data.Increment.StartTime");
			data.Increment = increment;
			describeShardTaskInfoResponse.Data = data;
        
			return describeShardTaskInfoResponse;
        }
    }
}
