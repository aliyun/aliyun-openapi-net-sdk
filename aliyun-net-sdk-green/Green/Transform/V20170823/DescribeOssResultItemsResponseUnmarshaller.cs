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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssResultItemsResponseUnmarshaller
    {
        public static DescribeOssResultItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssResultItemsResponse describeOssResultItemsResponse = new DescribeOssResultItemsResponse();

			describeOssResultItemsResponse.HttpResponse = _ctx.HttpResponse;
			describeOssResultItemsResponse.RequestId = _ctx.StringValue("DescribeOssResultItems.RequestId");
			describeOssResultItemsResponse.PageSize = _ctx.IntegerValue("DescribeOssResultItems.PageSize");
			describeOssResultItemsResponse.CurrentPage = _ctx.IntegerValue("DescribeOssResultItems.CurrentPage");
			describeOssResultItemsResponse.TotalCount = _ctx.IntegerValue("DescribeOssResultItems.TotalCount");
			describeOssResultItemsResponse.QueryId = _ctx.StringValue("DescribeOssResultItems.QueryId");

			List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult> describeOssResultItemsResponse_scanResultList = new List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult>();
			for (int i = 0; i < _ctx.Length("DescribeOssResultItems.ScanResultList.Length"); i++) {
				DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult scanResult = new DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult();
				scanResult.TaskId = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].TaskId");
				scanResult.DataId = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].DataId");
				scanResult.NewUrl = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].NewUrl");
				scanResult.Thumbnail = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Thumbnail");
				scanResult.RequestTime = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].RequestTime");
				scanResult.ScanFinishedTime = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].ScanFinishedTime");
				scanResult.CreateTime = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].CreateTime");
				scanResult.Suggestion = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Suggestion");
				scanResult.Id = _ctx.LongValue("DescribeOssResultItems.ScanResultList["+ i +"].Id");
				scanResult.Bucket = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Bucket");
				scanResult._Object = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Object");
				scanResult.Score = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Score");
				scanResult.HandleStatus = _ctx.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].HandleStatus");
				scanResult.ResourceStatus = _ctx.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].ResourceStatus");
				scanResult.Content = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Content");

				List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult> scanResult_frameResults = new List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult>();
				for (int j = 0; j < _ctx.Length("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults.Length"); j++) {
					DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult frameResult = new DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult();
					frameResult.Thumbnail = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Thumbnail");
					frameResult.Offset = _ctx.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Offset");
					frameResult.Url = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Url");

					scanResult_frameResults.Add(frameResult);
				}
				scanResult.FrameResults = scanResult_frameResults;

				List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_VoiceSegmentAntispamResult> scanResult_voiceSegmentAntispamResults = new List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_VoiceSegmentAntispamResult>();
				for (int j = 0; j < _ctx.Length("DescribeOssResultItems.ScanResultList["+ i +"].VoiceSegmentAntispamResults.Length"); j++) {
					DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_VoiceSegmentAntispamResult voiceSegmentAntispamResult = new DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_VoiceSegmentAntispamResult();
					voiceSegmentAntispamResult.Text = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].VoiceSegmentAntispamResults["+ j +"].Text");
					voiceSegmentAntispamResult.EndTime = _ctx.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].VoiceSegmentAntispamResults["+ j +"].EndTime");
					voiceSegmentAntispamResult.StartTime = _ctx.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].VoiceSegmentAntispamResults["+ j +"].StartTime");
					voiceSegmentAntispamResult.Label = _ctx.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].VoiceSegmentAntispamResults["+ j +"].Label");

					scanResult_voiceSegmentAntispamResults.Add(voiceSegmentAntispamResult);
				}
				scanResult.VoiceSegmentAntispamResults = scanResult_voiceSegmentAntispamResults;

				describeOssResultItemsResponse_scanResultList.Add(scanResult);
			}
			describeOssResultItemsResponse.ScanResultList = describeOssResultItemsResponse_scanResultList;
        
			return describeOssResultItemsResponse;
        }
    }
}
