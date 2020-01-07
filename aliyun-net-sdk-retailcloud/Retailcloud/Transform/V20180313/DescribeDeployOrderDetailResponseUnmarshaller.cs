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
        public static DescribeDeployOrderDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeployOrderDetailResponse describeDeployOrderDetailResponse = new DescribeDeployOrderDetailResponse();

			describeDeployOrderDetailResponse.HttpResponse = context.HttpResponse;
			describeDeployOrderDetailResponse.Code = context.IntegerValue("DescribeDeployOrderDetail.Code");
			describeDeployOrderDetailResponse.ErrMsg = context.StringValue("DescribeDeployOrderDetail.ErrMsg");
			describeDeployOrderDetailResponse.RequestId = context.StringValue("DescribeDeployOrderDetail.RequestId");
			describeDeployOrderDetailResponse.Success = context.BooleanValue("DescribeDeployOrderDetail.Success");

			DescribeDeployOrderDetailResponse.DescribeDeployOrderDetail_Result result = new DescribeDeployOrderDetailResponse.DescribeDeployOrderDetail_Result();
			result.AppInstanceType = context.StringValue("DescribeDeployOrderDetail.Result.AppInstanceType");
			result.CurrentPartitionNum = context.IntegerValue("DescribeDeployOrderDetail.Result.CurrentPartitionNum");
			result.DeployOrderId = context.LongValue("DescribeDeployOrderDetail.Result.DeployOrderId");
			result.DeployPauseType = context.StringValue("DescribeDeployOrderDetail.Result.DeployPauseType");
			result.DeployPauseTypeName = context.StringValue("DescribeDeployOrderDetail.Result.DeployPauseTypeName");
			result.DeployType = context.StringValue("DescribeDeployOrderDetail.Result.DeployType");
			result.DeployTypeName = context.StringValue("DescribeDeployOrderDetail.Result.DeployTypeName");
			result.Description = context.StringValue("DescribeDeployOrderDetail.Result.Description");
			result.ElapsedTime = context.IntegerValue("DescribeDeployOrderDetail.Result.ElapsedTime");
			result.EndTime = context.StringValue("DescribeDeployOrderDetail.Result.EndTime");
			result.EnvId = context.LongValue("DescribeDeployOrderDetail.Result.EnvId");
			result.EnvType = context.StringValue("DescribeDeployOrderDetail.Result.EnvType");
			result.FailureRate = context.StringValue("DescribeDeployOrderDetail.Result.FailureRate");
			result.FinishAppInstanceCt = context.IntegerValue("DescribeDeployOrderDetail.Result.FinishAppInstanceCt");
			result.Name = context.StringValue("DescribeDeployOrderDetail.Result.Name");
			result.PartitionType = context.StringValue("DescribeDeployOrderDetail.Result.PartitionType");
			result.PartitionTypeName = context.StringValue("DescribeDeployOrderDetail.Result.PartitionTypeName");
			result.Result = context.IntegerValue("DescribeDeployOrderDetail.Result.Result");
			result.ResultName = context.StringValue("DescribeDeployOrderDetail.Result.ResultName");
			result.SchemaId = context.LongValue("DescribeDeployOrderDetail.Result.SchemaId");
			result.StartTime = context.StringValue("DescribeDeployOrderDetail.Result.StartTime");
			result.Status = context.IntegerValue("DescribeDeployOrderDetail.Result.Status");
			result.StatusName = context.StringValue("DescribeDeployOrderDetail.Result.StatusName");
			result.TotalAppInstanceCt = context.IntegerValue("DescribeDeployOrderDetail.Result.TotalAppInstanceCt");
			result.TotalPartitions = context.IntegerValue("DescribeDeployOrderDetail.Result.TotalPartitions");
			result.UserId = context.StringValue("DescribeDeployOrderDetail.Result.UserId");
			result.UserNick = context.StringValue("DescribeDeployOrderDetail.Result.UserNick");
			describeDeployOrderDetailResponse.Result = result;
        
			return describeDeployOrderDetailResponse;
        }
    }
}
