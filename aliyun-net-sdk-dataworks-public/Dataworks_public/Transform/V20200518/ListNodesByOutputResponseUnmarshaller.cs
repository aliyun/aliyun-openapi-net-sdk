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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListNodesByOutputResponseUnmarshaller
    {
        public static ListNodesByOutputResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesByOutputResponse listNodesByOutputResponse = new ListNodesByOutputResponse();

			listNodesByOutputResponse.HttpResponse = _ctx.HttpResponse;
			listNodesByOutputResponse.Success = _ctx.BooleanValue("ListNodesByOutput.Success");
			listNodesByOutputResponse.HttpStatusCode = _ctx.IntegerValue("ListNodesByOutput.HttpStatusCode");
			listNodesByOutputResponse.ErrorCode = _ctx.StringValue("ListNodesByOutput.ErrorCode");
			listNodesByOutputResponse.ErrorMessage = _ctx.StringValue("ListNodesByOutput.ErrorMessage");
			listNodesByOutputResponse.RequestId = _ctx.StringValue("ListNodesByOutput.RequestId");

			List<ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair> listNodesByOutputResponse_data = new List<ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair>();
			for (int i = 0; i < _ctx.Length("ListNodesByOutput.Data.Length"); i++) {
				ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair outputNodePair = new ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair();
				outputNodePair.Output = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].Output");

				List<ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair.ListNodesByOutput_Node> outputNodePair_nodeList = new List<ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair.ListNodesByOutput_Node>();
				for (int j = 0; j < _ctx.Length("ListNodesByOutput.Data["+ i +"].NodeList.Length"); j++) {
					ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair.ListNodesByOutput_Node node = new ListNodesByOutputResponse.ListNodesByOutput_OutputNodePair.ListNodesByOutput_Node();
					node.NodeId = _ctx.LongValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].NodeId");
					node.NodeName = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].NodeName");
					node.OwnerId = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].OwnerId");
					node.Description = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].Description");
					node.ResGroupName = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].ResGroupName");
					node.CronExpress = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].CronExpress");
					node.Repeatability = _ctx.BooleanValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].Repeatability");
					node.ProgramType = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].ProgramType");
					node.ProjectId = _ctx.LongValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].ProjectId");
					node.SchedulerType = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].SchedulerType");
					node.ParamValues = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].ParamValues");
					node.Priority = _ctx.IntegerValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].Priority");
					node.BaselineId = _ctx.LongValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].BaselineId");
					node.RepeatInterval = _ctx.IntegerValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].RepeatInterval");
					node.Connection = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].Connection");
					node.DqcType = _ctx.IntegerValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].DqcType");
					node.DqcDescription = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].DqcDescription");
					node.RelatedFlowId = _ctx.LongValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].RelatedFlowId");
					node.FileType = _ctx.StringValue("ListNodesByOutput.Data["+ i +"].NodeList["+ j +"].FileType");

					outputNodePair_nodeList.Add(node);
				}
				outputNodePair.NodeList = outputNodePair_nodeList;

				listNodesByOutputResponse_data.Add(outputNodePair);
			}
			listNodesByOutputResponse.Data = listNodesByOutputResponse_data;
        
			return listNodesByOutputResponse;
        }
    }
}
