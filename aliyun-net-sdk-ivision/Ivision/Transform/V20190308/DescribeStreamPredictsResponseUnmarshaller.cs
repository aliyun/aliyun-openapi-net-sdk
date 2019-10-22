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
    public class DescribeStreamPredictsResponseUnmarshaller
    {
        public static DescribeStreamPredictsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamPredictsResponse describeStreamPredictsResponse = new DescribeStreamPredictsResponse();

			describeStreamPredictsResponse.HttpResponse = context.HttpResponse;
			describeStreamPredictsResponse.RequestId = context.StringValue("DescribeStreamPredicts.RequestId");
			describeStreamPredictsResponse.TotalNum = context.LongValue("DescribeStreamPredicts.TotalNum");
			describeStreamPredictsResponse.CurrentPage = context.LongValue("DescribeStreamPredicts.CurrentPage");
			describeStreamPredictsResponse.PageSize = context.LongValue("DescribeStreamPredicts.PageSize");
			describeStreamPredictsResponse.NextPageToken = context.StringValue("DescribeStreamPredicts.NextPageToken");

			List<DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict> describeStreamPredictsResponse_streamPredicts = new List<DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict>();
			for (int i = 0; i < context.Length("DescribeStreamPredicts.StreamPredicts.Length"); i++) {
				DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict streamPredict = new DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict();
				streamPredict.PredictId = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].PredictId");
				streamPredict.StreamType = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].StreamType");
				streamPredict.StreamId = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].StreamId");
				streamPredict.ModelIds = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].ModelIds");
				streamPredict.ProbabilityThresholds = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].ProbabilityThresholds");
				streamPredict.DetectIntervals = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].DetectIntervals");
				streamPredict.Output = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Output");
				streamPredict.Notify = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Notify");
				streamPredict.UserData = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].UserData");
				streamPredict.CreationTime = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].CreationTime");
				streamPredict.Status = context.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Status");

				describeStreamPredictsResponse_streamPredicts.Add(streamPredict);
			}
			describeStreamPredictsResponse.StreamPredicts = describeStreamPredictsResponse_streamPredicts;
        
			return describeStreamPredictsResponse;
        }
    }
}
