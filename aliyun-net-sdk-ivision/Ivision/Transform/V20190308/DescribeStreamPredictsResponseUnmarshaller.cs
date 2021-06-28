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
        public static DescribeStreamPredictsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStreamPredictsResponse describeStreamPredictsResponse = new DescribeStreamPredictsResponse();

			describeStreamPredictsResponse.HttpResponse = _ctx.HttpResponse;
			describeStreamPredictsResponse.TotalNum = _ctx.LongValue("DescribeStreamPredicts.TotalNum");
			describeStreamPredictsResponse.PageSize = _ctx.LongValue("DescribeStreamPredicts.PageSize");
			describeStreamPredictsResponse.RequestId = _ctx.StringValue("DescribeStreamPredicts.RequestId");
			describeStreamPredictsResponse.CurrentPage = _ctx.LongValue("DescribeStreamPredicts.CurrentPage");
			describeStreamPredictsResponse.NextPageToken = _ctx.StringValue("DescribeStreamPredicts.NextPageToken");

			List<DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict> describeStreamPredictsResponse_streamPredicts = new List<DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict>();
			for (int i = 0; i < _ctx.Length("DescribeStreamPredicts.StreamPredicts.Length"); i++) {
				DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict streamPredict = new DescribeStreamPredictsResponse.DescribeStreamPredicts_StreamPredict();
				streamPredict.CreationTime = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].CreationTime");
				streamPredict.Status = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Status");
				streamPredict.Notify = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Notify");
				streamPredict.PredictId = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].PredictId");
				streamPredict.ModelUserData = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].ModelUserData");
				streamPredict.Output = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].Output");
				streamPredict.PredictTemplateId = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].PredictTemplateId");
				streamPredict.StreamId = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].StreamId");
				streamPredict.AutoStart = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].AutoStart");
				streamPredict.ProbabilityThresholds = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].ProbabilityThresholds");
				streamPredict.DetectIntervals = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].DetectIntervals");
				streamPredict.StreamType = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].StreamType");
				streamPredict.UserData = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].UserData");
				streamPredict.ModelIds = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].ModelIds");
				streamPredict.FaceGroupId = _ctx.StringValue("DescribeStreamPredicts.StreamPredicts["+ i +"].FaceGroupId");

				describeStreamPredictsResponse_streamPredicts.Add(streamPredict);
			}
			describeStreamPredictsResponse.StreamPredicts = describeStreamPredictsResponse_streamPredicts;
        
			return describeStreamPredictsResponse;
        }
    }
}
