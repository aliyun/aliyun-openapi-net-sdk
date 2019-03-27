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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeTrainResultResponseUnmarshaller
    {
        public static DescribeTrainResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrainResultResponse describeTrainResultResponse = new DescribeTrainResultResponse();

			describeTrainResultResponse.HttpResponse = context.HttpResponse;
			describeTrainResultResponse.RequestId = context.StringValue("DescribeTrainResult.RequestId");

			DescribeTrainResultResponse.DescribeTrainResult_TrainResult trainResult = new DescribeTrainResultResponse.DescribeTrainResult_TrainResult();
			trainResult.ProjectId = context.StringValue("DescribeTrainResult.TrainResult.ProjectId");
			trainResult.IterationId = context.StringValue("DescribeTrainResult.TrainResult.IterationId");
			trainResult.IterationName = context.StringValue("DescribeTrainResult.TrainResult.IterationName");
			trainResult.Precision = context.StringValue("DescribeTrainResult.TrainResult.Precision");
			trainResult.Recall = context.StringValue("DescribeTrainResult.TrainResult.Recall");
			trainResult.MAP = context.StringValue("DescribeTrainResult.TrainResult.MAP");
			trainResult.Threshold = context.StringValue("DescribeTrainResult.TrainResult.Threshold");
			trainResult.Status = context.StringValue("DescribeTrainResult.TrainResult.Status");
			trainResult.StartTime = context.StringValue("DescribeTrainResult.TrainResult.StartTime");
			trainResult.EndTime = context.StringValue("DescribeTrainResult.TrainResult.EndTime");
			trainResult.ErrorCode = context.StringValue("DescribeTrainResult.TrainResult.ErrorCode");
			trainResult.ErrorMessage = context.StringValue("DescribeTrainResult.TrainResult.ErrorMessage");

			List<DescribeTrainResultResponse.DescribeTrainResult_TrainResult.DescribeTrainResult_TagResult> trainResult_tagResults = new List<DescribeTrainResultResponse.DescribeTrainResult_TrainResult.DescribeTrainResult_TagResult>();
			for (int i = 0; i < context.Length("DescribeTrainResult.TrainResult.TagResults.Length"); i++) {
				DescribeTrainResultResponse.DescribeTrainResult_TrainResult.DescribeTrainResult_TagResult tagResult = new DescribeTrainResultResponse.DescribeTrainResult_TrainResult.DescribeTrainResult_TagResult();
				tagResult.TagId = context.StringValue("DescribeTrainResult.TrainResult.TagResults["+ i +"].TagId");
				tagResult.TagName = context.StringValue("DescribeTrainResult.TrainResult.TagResults["+ i +"].TagName");
				tagResult.Precision = context.StringValue("DescribeTrainResult.TrainResult.TagResults["+ i +"].Precision");
				tagResult.Recall = context.StringValue("DescribeTrainResult.TrainResult.TagResults["+ i +"].Recall");
				tagResult.AP = context.StringValue("DescribeTrainResult.TrainResult.TagResults["+ i +"].AP");

				trainResult_tagResults.Add(tagResult);
			}
			trainResult.TagResults = trainResult_tagResults;
			describeTrainResultResponse.TrainResult = trainResult;
        
			return describeTrainResultResponse;
        }
    }
}
