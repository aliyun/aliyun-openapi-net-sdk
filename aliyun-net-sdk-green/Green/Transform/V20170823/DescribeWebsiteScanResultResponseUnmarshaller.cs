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
    public class DescribeWebsiteScanResultResponseUnmarshaller
    {
        public static DescribeWebsiteScanResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebsiteScanResultResponse describeWebsiteScanResultResponse = new DescribeWebsiteScanResultResponse();

			describeWebsiteScanResultResponse.HttpResponse = context.HttpResponse;
			describeWebsiteScanResultResponse.RequestId = context.StringValue("DescribeWebsiteScanResult.RequestId");
			describeWebsiteScanResultResponse.PageSize = context.IntegerValue("DescribeWebsiteScanResult.PageSize");
			describeWebsiteScanResultResponse.CurrentPage = context.IntegerValue("DescribeWebsiteScanResult.CurrentPage");
			describeWebsiteScanResultResponse.TotalCount = context.IntegerValue("DescribeWebsiteScanResult.TotalCount");

			List<DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult> describeWebsiteScanResultResponse_websiteScanResultList = new List<DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult>();
			for (int i = 0; i < context.Length("DescribeWebsiteScanResult.WebsiteScanResultList.Length"); i++) {
				DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult websiteScanResult = new DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult();
				websiteScanResult.InstanceId = context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].InstanceId");
				websiteScanResult.ScanTime = context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].ScanTime");
				websiteScanResult.Domain = context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Domain");
				websiteScanResult.SourceRiskCount = context.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].SourceRiskCount");
				websiteScanResult.ImageRiskCount = context.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].ImageRiskCount");
				websiteScanResult.HandleStatus = context.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].HandleStatus");
				websiteScanResult.Id = context.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Id");
				websiteScanResult.TextRiskCount = context.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].TextRiskCount");
				websiteScanResult.TaskId = context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].TaskId");
				websiteScanResult.Url = context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Url");

				List<string> websiteScanResult_labels = new List<string>();
				for (int j = 0; j < context.Length("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Labels.Length"); j++) {
					websiteScanResult_labels.Add(context.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Labels["+ j +"]"));
				}
				websiteScanResult.Labels = websiteScanResult_labels;

				describeWebsiteScanResultResponse_websiteScanResultList.Add(websiteScanResult);
			}
			describeWebsiteScanResultResponse.WebsiteScanResultList = describeWebsiteScanResultResponse_websiteScanResultList;
        
			return describeWebsiteScanResultResponse;
        }
    }
}
