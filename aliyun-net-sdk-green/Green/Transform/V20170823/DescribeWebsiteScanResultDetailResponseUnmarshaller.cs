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
    public class DescribeWebsiteScanResultDetailResponseUnmarshaller
    {
        public static DescribeWebsiteScanResultDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebsiteScanResultDetailResponse describeWebsiteScanResultDetailResponse = new DescribeWebsiteScanResultDetailResponse();

			describeWebsiteScanResultDetailResponse.HttpResponse = context.HttpResponse;
			describeWebsiteScanResultDetailResponse.RequestId = context.StringValue("DescribeWebsiteScanResultDetail.RequestId");
			describeWebsiteScanResultDetailResponse.Baseline = context.StringValue("DescribeWebsiteScanResultDetail.Baseline");
			describeWebsiteScanResultDetailResponse.Content = context.StringValue("DescribeWebsiteScanResultDetail.Content");
			describeWebsiteScanResultDetailResponse.TamperedSource = context.StringValue("DescribeWebsiteScanResultDetail.TamperedSource");
			describeWebsiteScanResultDetailResponse.ResourceType = context.StringValue("DescribeWebsiteScanResultDetail.ResourceType");

			List<string> describeWebsiteScanResultDetailResponse_hitKeywords = new List<string>();
			for (int i = 0; i < context.Length("DescribeWebsiteScanResultDetail.HitKeywords.Length"); i++) {
				describeWebsiteScanResultDetailResponse_hitKeywords.Add(context.StringValue("DescribeWebsiteScanResultDetail.HitKeywords["+ i +"]"));
			}
			describeWebsiteScanResultDetailResponse.HitKeywords = describeWebsiteScanResultDetailResponse_hitKeywords;

			List<DescribeWebsiteScanResultDetailResponse.DescribeWebsiteScanResultDetail_ImageScanResult> describeWebsiteScanResultDetailResponse_imageScanResults = new List<DescribeWebsiteScanResultDetailResponse.DescribeWebsiteScanResultDetail_ImageScanResult>();
			for (int i = 0; i < context.Length("DescribeWebsiteScanResultDetail.ImageScanResults.Length"); i++) {
				DescribeWebsiteScanResultDetailResponse.DescribeWebsiteScanResultDetail_ImageScanResult imageScanResult = new DescribeWebsiteScanResultDetailResponse.DescribeWebsiteScanResultDetail_ImageScanResult();
				imageScanResult.Url = context.StringValue("DescribeWebsiteScanResultDetail.ImageScanResults["+ i +"].Url");

				List<string> imageScanResult_labels = new List<string>();
				for (int j = 0; j < context.Length("DescribeWebsiteScanResultDetail.ImageScanResults["+ i +"].Labels.Length"); j++) {
					imageScanResult_labels.Add(context.StringValue("DescribeWebsiteScanResultDetail.ImageScanResults["+ i +"].Labels["+ j +"]"));
				}
				imageScanResult.Labels = imageScanResult_labels;

				describeWebsiteScanResultDetailResponse_imageScanResults.Add(imageScanResult);
			}
			describeWebsiteScanResultDetailResponse.ImageScanResults = describeWebsiteScanResultDetailResponse_imageScanResults;
        
			return describeWebsiteScanResultDetailResponse;
        }
    }
}
