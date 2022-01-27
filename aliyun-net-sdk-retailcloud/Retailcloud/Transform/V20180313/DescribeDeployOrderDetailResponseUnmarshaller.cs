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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeDeployOrderDetailResponseUnmarshaller
    {
        public static DescribeDeployOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeployOrderDetailResponse describeDeployOrderDetailResponse = new DescribeDeployOrderDetailResponse();

			describeDeployOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDeployOrderDetailResponse.Code = _ctx.IntegerValue("DescribeDeployOrderDetail.Code");
			describeDeployOrderDetailResponse.ErrMsg = _ctx.StringValue("DescribeDeployOrderDetail.ErrMsg");
			describeDeployOrderDetailResponse.RequestId = _ctx.StringValue("DescribeDeployOrderDetail.RequestId");
			describeDeployOrderDetailResponse.Success = _ctx.BooleanValue("DescribeDeployOrderDetail.Success");

			DescribeDeployOrderDetailResponse.DescribeDeployOrderDetail_Result result = new DescribeDeployOrderDetailResponse.DescribeDeployOrderDetail_Result();
			result.Status = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.Status");
			result.AppInstanceType = _ctx.StringValue("DescribeDeployOrderDetail.Result.AppInstanceType");
			result.DeployType = _ctx.StringValue("DescribeDeployOrderDetail.Result.DeployType");
			result.UserId = _ctx.StringValue("DescribeDeployOrderDetail.Result.UserId");
			result.PartitionTypeName = _ctx.StringValue("DescribeDeployOrderDetail.Result.PartitionTypeName");
			result.StatusName = _ctx.StringValue("DescribeDeployOrderDetail.Result.StatusName");
			result.EnvType = _ctx.StringValue("DescribeDeployOrderDetail.Result.EnvType");
			result.TotalAppInstanceCt = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.TotalAppInstanceCt");
			result.ElapsedTime = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.ElapsedTime");
			result.Description = _ctx.StringValue("DescribeDeployOrderDetail.Result.Description");
			result.Name = _ctx.StringValue("DescribeDeployOrderDetail.Result.Name");
			result.DeployTypeName = _ctx.StringValue("DescribeDeployOrderDetail.Result.DeployTypeName");
			result.FinishAppInstanceCt = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.FinishAppInstanceCt");
			result.SchemaId = _ctx.LongValue("DescribeDeployOrderDetail.Result.SchemaId");
			result.DeployPauseType = _ctx.StringValue("DescribeDeployOrderDetail.Result.DeployPauseType");
			result.Result = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.Result");
			result.FailureRate = _ctx.StringValue("DescribeDeployOrderDetail.Result.FailureRate");
			result.TotalPartitions = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.TotalPartitions");
			result.UserNick = _ctx.StringValue("DescribeDeployOrderDetail.Result.UserNick");
			result.EndTime = _ctx.StringValue("DescribeDeployOrderDetail.Result.EndTime");
			result.StartTime = _ctx.StringValue("DescribeDeployOrderDetail.Result.StartTime");
			result.DeployOrderId = _ctx.LongValue("DescribeDeployOrderDetail.Result.DeployOrderId");
			result.DeployPauseTypeName = _ctx.StringValue("DescribeDeployOrderDetail.Result.DeployPauseTypeName");
			result.ResultName = _ctx.StringValue("DescribeDeployOrderDetail.Result.ResultName");
			result.CurrentPartitionNum = _ctx.IntegerValue("DescribeDeployOrderDetail.Result.CurrentPartitionNum");
			result.PartitionType = _ctx.StringValue("DescribeDeployOrderDetail.Result.PartitionType");
			result.EnvId = _ctx.LongValue("DescribeDeployOrderDetail.Result.EnvId");
			describeDeployOrderDetailResponse.Result = result;
        
			return describeDeployOrderDetailResponse;
        }
    }
}
