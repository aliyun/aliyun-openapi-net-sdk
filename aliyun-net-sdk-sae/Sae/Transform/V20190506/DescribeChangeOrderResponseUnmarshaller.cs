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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeChangeOrderResponseUnmarshaller
    {
        public static DescribeChangeOrderResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeChangeOrderResponse describeChangeOrderResponse = new DescribeChangeOrderResponse();

			describeChangeOrderResponse.HttpResponse = context.HttpResponse;
			describeChangeOrderResponse.Code = context.StringValue("DescribeChangeOrder.Code");
			describeChangeOrderResponse.ErrorCode = context.StringValue("DescribeChangeOrder.ErrorCode");
			describeChangeOrderResponse.Message = context.StringValue("DescribeChangeOrder.Message");
			describeChangeOrderResponse.Success = context.BooleanValue("DescribeChangeOrder.Success");
			describeChangeOrderResponse.TraceId = context.StringValue("DescribeChangeOrder.TraceId");
			describeChangeOrderResponse.RequestId = context.StringValue("DescribeChangeOrder.RequestId");

			DescribeChangeOrderResponse.DescribeChangeOrder_Data data = new DescribeChangeOrderResponse.DescribeChangeOrder_Data();
			data.AppName = context.StringValue("DescribeChangeOrder.Data.AppName");
			data.Auto = context.BooleanValue("DescribeChangeOrder.Data.Auto");
			data.BatchCount = context.IntegerValue("DescribeChangeOrder.Data.BatchCount");
			data.BatchType = context.StringValue("DescribeChangeOrder.Data.BatchType");
			data.BatchWaitTime = context.IntegerValue("DescribeChangeOrder.Data.BatchWaitTime");
			data.ChangeOrderId = context.StringValue("DescribeChangeOrder.Data.ChangeOrderId");
			data.CoType = context.StringValue("DescribeChangeOrder.Data.CoType");
			data.CoTypeCode = context.StringValue("DescribeChangeOrder.Data.CoTypeCode");
			data.CreateTime = context.StringValue("DescribeChangeOrder.Data.CreateTime");
			data.CurrentPipelineId = context.StringValue("DescribeChangeOrder.Data.CurrentPipelineId");
			data.Description = context.StringValue("DescribeChangeOrder.Data.Description");
			data.Status = context.IntegerValue("DescribeChangeOrder.Data.Status");
			data.SupportAbortFreeze = context.BooleanValue("DescribeChangeOrder.Data.SupportAbortFreeze");
			data.SupportRollback = context.BooleanValue("DescribeChangeOrder.Data.SupportRollback");
			data.ErrorMessage = context.StringValue("DescribeChangeOrder.Data.ErrorMessage");

			List<string> data_coTargets = new List<string>();
			for (int i = 0; i < context.Length("DescribeChangeOrder.Data.CoTargets.Length"); i++) {
				data_coTargets.Add(context.StringValue("DescribeChangeOrder.Data.CoTargets["+ i +"]"));
			}
			data.CoTargets = data_coTargets;

			List<DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline> data_pipelines = new List<DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline>();
			for (int i = 0; i < context.Length("DescribeChangeOrder.Data.Pipelines.Length"); i++) {
				DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline pipeline = new DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline();
				pipeline.BatchType = context.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].BatchType");
				pipeline.ParallelCount = context.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].ParallelCount");
				pipeline.PipelineId = context.StringValue("DescribeChangeOrder.Data.Pipelines["+ i +"].PipelineId");
				pipeline.PipelineName = context.StringValue("DescribeChangeOrder.Data.Pipelines["+ i +"].PipelineName");
				pipeline.StartTime = context.LongValue("DescribeChangeOrder.Data.Pipelines["+ i +"].StartTime");
				pipeline.Status = context.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].Status");
				pipeline.UpdateTime = context.LongValue("DescribeChangeOrder.Data.Pipelines["+ i +"].UpdateTime");

				data_pipelines.Add(pipeline);
			}
			data.Pipelines = data_pipelines;
			describeChangeOrderResponse.Data = data;
        
			return describeChangeOrderResponse;
        }
    }
}
