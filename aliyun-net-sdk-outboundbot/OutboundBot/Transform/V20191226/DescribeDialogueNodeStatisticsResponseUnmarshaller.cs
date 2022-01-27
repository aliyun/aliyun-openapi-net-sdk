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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeDialogueNodeStatisticsResponseUnmarshaller
    {
        public static DescribeDialogueNodeStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDialogueNodeStatisticsResponse describeDialogueNodeStatisticsResponse = new DescribeDialogueNodeStatisticsResponse();

			describeDialogueNodeStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeDialogueNodeStatisticsResponse.RequestId = _ctx.StringValue("DescribeDialogueNodeStatistics.RequestId");
			describeDialogueNodeStatisticsResponse.Success = _ctx.BooleanValue("DescribeDialogueNodeStatistics.Success");
			describeDialogueNodeStatisticsResponse.Code = _ctx.StringValue("DescribeDialogueNodeStatistics.Code");
			describeDialogueNodeStatisticsResponse.Message = _ctx.StringValue("DescribeDialogueNodeStatistics.Message");
			describeDialogueNodeStatisticsResponse.HttpStatusCode = _ctx.IntegerValue("DescribeDialogueNodeStatistics.HttpStatusCode");
			describeDialogueNodeStatisticsResponse.GroupId = _ctx.StringValue("DescribeDialogueNodeStatistics.GroupId");
			describeDialogueNodeStatisticsResponse.InstanceId = _ctx.StringValue("DescribeDialogueNodeStatistics.InstanceId");
			describeDialogueNodeStatisticsResponse.TotalCompleted = _ctx.IntegerValue("DescribeDialogueNodeStatistics.TotalCompleted");

			List<DescribeDialogueNodeStatisticsResponse.DescribeDialogueNodeStatistics_NoAnswerDialogueNode> describeDialogueNodeStatisticsResponse_noAnswerDialogueNodes = new List<DescribeDialogueNodeStatisticsResponse.DescribeDialogueNodeStatistics_NoAnswerDialogueNode>();
			for (int i = 0; i < _ctx.Length("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes.Length"); i++) {
				DescribeDialogueNodeStatisticsResponse.DescribeDialogueNodeStatistics_NoAnswerDialogueNode noAnswerDialogueNode = new DescribeDialogueNodeStatisticsResponse.DescribeDialogueNodeStatistics_NoAnswerDialogueNode();
				noAnswerDialogueNode.Id = _ctx.StringValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].Id");
				noAnswerDialogueNode.InstanceId = _ctx.StringValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].InstanceId");
				noAnswerDialogueNode.GroupId = _ctx.StringValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].GroupId");
				noAnswerDialogueNode.NodeId = _ctx.StringValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].NodeId");
				noAnswerDialogueNode.NodeName = _ctx.StringValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].NodeName");
				noAnswerDialogueNode.HitNum = _ctx.IntegerValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].HitNum");
				noAnswerDialogueNode.HangUpNum = _ctx.IntegerValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].HangUpNum");
				noAnswerDialogueNode.NoAnswerNum = _ctx.IntegerValue("DescribeDialogueNodeStatistics.NoAnswerDialogueNodes["+ i +"].NoAnswerNum");

				describeDialogueNodeStatisticsResponse_noAnswerDialogueNodes.Add(noAnswerDialogueNode);
			}
			describeDialogueNodeStatisticsResponse.NoAnswerDialogueNodes = describeDialogueNodeStatisticsResponse_noAnswerDialogueNodes;
        
			return describeDialogueNodeStatisticsResponse;
        }
    }
}
