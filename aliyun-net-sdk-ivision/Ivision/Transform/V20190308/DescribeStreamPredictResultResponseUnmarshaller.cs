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
    public class DescribeStreamPredictResultResponseUnmarshaller
    {
        public static DescribeStreamPredictResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStreamPredictResultResponse describeStreamPredictResultResponse = new DescribeStreamPredictResultResponse();

			describeStreamPredictResultResponse.HttpResponse = context.HttpResponse;
			describeStreamPredictResultResponse.RequestId = context.StringValue("DescribeStreamPredictResult.RequestId");
			describeStreamPredictResultResponse.TotalNum = context.LongValue("DescribeStreamPredictResult.TotalNum");
			describeStreamPredictResultResponse.CurrentPage = context.LongValue("DescribeStreamPredictResult.CurrentPage");
			describeStreamPredictResultResponse.PageSize = context.LongValue("DescribeStreamPredictResult.PageSize");
			describeStreamPredictResultResponse.NextPageToken = context.StringValue("DescribeStreamPredictResult.NextPageToken");

			List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData> describeStreamPredictResultResponse_streamPredictDatas = new List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData>();
			for (int i = 0; i < context.Length("DescribeStreamPredictResult.StreamPredictDatas.Length"); i++) {
				DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData streamPredictData = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData();
				streamPredictData.PredictId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictId");
				streamPredictData.ModelId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ModelId");
				streamPredictData.DataUrl = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].DataUrl");
				streamPredictData.StreamTimestamp = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].StreamTimestamp");
				streamPredictData.PredictTime = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictTime");
				streamPredictData.Status = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].Status");

				List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_ResultStatisticsItem> streamPredictData_resultStatistics = new List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_ResultStatisticsItem>();
				for (int j = 0; j < context.Length("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ResultStatistics.Length"); j++) {
					DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_ResultStatisticsItem resultStatisticsItem = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_ResultStatisticsItem();
					resultStatisticsItem.TagId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ResultStatistics["+ j +"].TagId");
					resultStatisticsItem.TagName = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ResultStatistics["+ j +"].TagName");
					resultStatisticsItem.Count = context.LongValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].ResultStatistics["+ j +"].Count");

					streamPredictData_resultStatistics.Add(resultStatisticsItem);
				}
				streamPredictData.ResultStatistics = streamPredictData_resultStatistics;

				List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult> streamPredictData_predictionResults = new List<DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult>();
				for (int j = 0; j < context.Length("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults.Length"); j++) {
					DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult predictionResult = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult();
					predictionResult.TagId = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].TagId");
					predictionResult.TagName = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].TagName");
					predictionResult.Probability = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Probability");
					predictionResult.Overlap = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Overlap");
					predictionResult.RegionType = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].RegionType");

					DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult.DescribeStreamPredictResult_Region region = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult.DescribeStreamPredictResult_Region();
					region.Left = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Region.Left");
					region.Top = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Region.Top");
					region.Width = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Region.Width");
					region.Height = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Region.Height");
					predictionResult.Region = region;

					DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult.DescribeStreamPredictResult_Properties properties = new DescribeStreamPredictResultResponse.DescribeStreamPredictResult_StreamPredictData.DescribeStreamPredictResult_PredictionResult.DescribeStreamPredictResult_Properties();
					properties.WithGloves = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Properties.WithGloves");
					properties.WithGlovesProbability = context.StringValue("DescribeStreamPredictResult.StreamPredictDatas["+ i +"].PredictionResults["+ j +"].Properties.WithGlovesProbability");
					predictionResult.Properties = properties;

					streamPredictData_predictionResults.Add(predictionResult);
				}
				streamPredictData.PredictionResults = streamPredictData_predictionResults;

				describeStreamPredictResultResponse_streamPredictDatas.Add(streamPredictData);
			}
			describeStreamPredictResultResponse.StreamPredictDatas = describeStreamPredictResultResponse_streamPredictDatas;
        
			return describeStreamPredictResultResponse;
        }
    }
}
