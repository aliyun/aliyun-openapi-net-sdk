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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetCloudMetricProfilingResponseUnmarshaller
    {
        public static GetCloudMetricProfilingResponse Unmarshall(UnmarshallerContext context)
        {
			GetCloudMetricProfilingResponse getCloudMetricProfilingResponse = new GetCloudMetricProfilingResponse();

			getCloudMetricProfilingResponse.HttpResponse = context.HttpResponse;
			getCloudMetricProfilingResponse.RequestId = context.StringValue("GetCloudMetricProfiling.RequestId");

			List<GetCloudMetricProfilingResponse.GetCloudMetricProfiling_SvgInfo> getCloudMetricProfilingResponse_svgUrls = new List<GetCloudMetricProfilingResponse.GetCloudMetricProfiling_SvgInfo>();
			for (int i = 0; i < context.Length("GetCloudMetricProfiling.SvgUrls.Length"); i++) {
				GetCloudMetricProfilingResponse.GetCloudMetricProfiling_SvgInfo svgInfo = new GetCloudMetricProfilingResponse.GetCloudMetricProfiling_SvgInfo();
				svgInfo.Name = context.StringValue("GetCloudMetricProfiling.SvgUrls["+ i +"].Name");
				svgInfo.Type = context.StringValue("GetCloudMetricProfiling.SvgUrls["+ i +"].Type");
				svgInfo.Url = context.StringValue("GetCloudMetricProfiling.SvgUrls["+ i +"].Url");
				svgInfo.Size = context.IntegerValue("GetCloudMetricProfiling.SvgUrls["+ i +"].Size");

				getCloudMetricProfilingResponse_svgUrls.Add(svgInfo);
			}
			getCloudMetricProfilingResponse.SvgUrls = getCloudMetricProfilingResponse_svgUrls;
        
			return getCloudMetricProfilingResponse;
        }
    }
}