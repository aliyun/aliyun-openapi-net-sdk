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
        public static DescribeChangeOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeChangeOrderResponse describeChangeOrderResponse = new DescribeChangeOrderResponse();

			describeChangeOrderResponse.HttpResponse = _ctx.HttpResponse;
			describeChangeOrderResponse.Message = _ctx.StringValue("DescribeChangeOrder.Message");
			describeChangeOrderResponse.RequestId = _ctx.StringValue("DescribeChangeOrder.RequestId");
			describeChangeOrderResponse.TraceId = _ctx.StringValue("DescribeChangeOrder.TraceId");
			describeChangeOrderResponse.ErrorCode = _ctx.StringValue("DescribeChangeOrder.ErrorCode");
			describeChangeOrderResponse.Code = _ctx.StringValue("DescribeChangeOrder.Code");
			describeChangeOrderResponse.Success = _ctx.BooleanValue("DescribeChangeOrder.Success");

			DescribeChangeOrderResponse.DescribeChangeOrder_Data data = new DescribeChangeOrderResponse.DescribeChangeOrder_Data();
			data.Status = _ctx.IntegerValue("DescribeChangeOrder.Data.Status");
			data.Description = _ctx.StringValue("DescribeChangeOrder.Data.Description");
			data.SupportAbortFreeze = _ctx.BooleanValue("DescribeChangeOrder.Data.SupportAbortFreeze");
			data.CreateTime = _ctx.StringValue("DescribeChangeOrder.Data.CreateTime");
			data.ChangeOrderId = _ctx.StringValue("DescribeChangeOrder.Data.ChangeOrderId");
			data.BatchType = _ctx.StringValue("DescribeChangeOrder.Data.BatchType");
			data.AppName = _ctx.StringValue("DescribeChangeOrder.Data.AppName");
			data.Auto = _ctx.BooleanValue("DescribeChangeOrder.Data.Auto");
			data.CurrentPipelineId = _ctx.StringValue("DescribeChangeOrder.Data.CurrentPipelineId");
			data.CoTypeCode = _ctx.StringValue("DescribeChangeOrder.Data.CoTypeCode");
			data.SupportRollback = _ctx.BooleanValue("DescribeChangeOrder.Data.SupportRollback");
			data.BatchWaitTime = _ctx.IntegerValue("DescribeChangeOrder.Data.BatchWaitTime");
			data.ErrorMessage = _ctx.StringValue("DescribeChangeOrder.Data.ErrorMessage");
			data.CoType = _ctx.StringValue("DescribeChangeOrder.Data.CoType");
			data.BatchCount = _ctx.IntegerValue("DescribeChangeOrder.Data.BatchCount");

			List<string> data_coTargets = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeChangeOrder.Data.CoTargets.Length"); i++) {
				data_coTargets.Add(_ctx.StringValue("DescribeChangeOrder.Data.CoTargets["+ i +"]"));
			}
			data.CoTargets = data_coTargets;

			List<DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline> data_pipelines = new List<DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline>();
			for (int i = 0; i < _ctx.Length("DescribeChangeOrder.Data.Pipelines.Length"); i++) {
				DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline pipeline = new DescribeChangeOrderResponse.DescribeChangeOrder_Data.DescribeChangeOrder_Pipeline();
				pipeline.Status = _ctx.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].Status");
				pipeline.PipelineName = _ctx.StringValue("DescribeChangeOrder.Data.Pipelines["+ i +"].PipelineName");
				pipeline.ParallelCount = _ctx.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].ParallelCount");
				pipeline.UpdateTime = _ctx.LongValue("DescribeChangeOrder.Data.Pipelines["+ i +"].UpdateTime");
				pipeline.StartTime = _ctx.LongValue("DescribeChangeOrder.Data.Pipelines["+ i +"].StartTime");
				pipeline.PipelineId = _ctx.StringValue("DescribeChangeOrder.Data.Pipelines["+ i +"].PipelineId");
				pipeline.BatchType = _ctx.IntegerValue("DescribeChangeOrder.Data.Pipelines["+ i +"].BatchType");

				data_pipelines.Add(pipeline);
			}
			data.Pipelines = data_pipelines;
			describeChangeOrderResponse.Data = data;
        
			return describeChangeOrderResponse;
        }
    }
}
