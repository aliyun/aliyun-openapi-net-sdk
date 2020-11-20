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
        public static DescribeWebsiteScanResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebsiteScanResultResponse describeWebsiteScanResultResponse = new DescribeWebsiteScanResultResponse();

			describeWebsiteScanResultResponse.HttpResponse = _ctx.HttpResponse;
			describeWebsiteScanResultResponse.RequestId = _ctx.StringValue("DescribeWebsiteScanResult.RequestId");
			describeWebsiteScanResultResponse.PageSize = _ctx.IntegerValue("DescribeWebsiteScanResult.PageSize");
			describeWebsiteScanResultResponse.CurrentPage = _ctx.IntegerValue("DescribeWebsiteScanResult.CurrentPage");
			describeWebsiteScanResultResponse.TotalCount = _ctx.IntegerValue("DescribeWebsiteScanResult.TotalCount");

			List<DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult> describeWebsiteScanResultResponse_websiteScanResultList = new List<DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult>();
			for (int i = 0; i < _ctx.Length("DescribeWebsiteScanResult.WebsiteScanResultList.Length"); i++) {
				DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult websiteScanResult = new DescribeWebsiteScanResultResponse.DescribeWebsiteScanResult_WebsiteScanResult();
				websiteScanResult.InstanceId = _ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].InstanceId");
				websiteScanResult.ScanTime = _ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].ScanTime");
				websiteScanResult.Domain = _ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Domain");
				websiteScanResult.SourceRiskCount = _ctx.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].SourceRiskCount");
				websiteScanResult.ImageRiskCount = _ctx.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].ImageRiskCount");
				websiteScanResult.HandleStatus = _ctx.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].HandleStatus");
				websiteScanResult.Id = _ctx.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Id");
				websiteScanResult.TextRiskCount = _ctx.IntegerValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].TextRiskCount");
				websiteScanResult.TaskId = _ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].TaskId");
				websiteScanResult.Url = _ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Url");

				List<string> websiteScanResult_labels = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Labels.Length"); j++) {
					websiteScanResult_labels.Add(_ctx.StringValue("DescribeWebsiteScanResult.WebsiteScanResultList["+ i +"].Labels["+ j +"]"));
				}
				websiteScanResult.Labels = websiteScanResult_labels;

				describeWebsiteScanResultResponse_websiteScanResultList.Add(websiteScanResult);
			}
			describeWebsiteScanResultResponse.WebsiteScanResultList = describeWebsiteScanResultResponse_websiteScanResultList;
        
			return describeWebsiteScanResultResponse;
        }
    }
}
