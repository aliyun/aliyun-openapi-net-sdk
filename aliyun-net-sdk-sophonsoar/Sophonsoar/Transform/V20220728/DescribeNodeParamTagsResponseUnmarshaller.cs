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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeNodeParamTagsResponseUnmarshaller
    {
        public static DescribeNodeParamTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNodeParamTagsResponse describeNodeParamTagsResponse = new DescribeNodeParamTagsResponse();

			describeNodeParamTagsResponse.HttpResponse = _ctx.HttpResponse;
			describeNodeParamTagsResponse.RequestId = _ctx.StringValue("DescribeNodeParamTags.RequestId");

			List<DescribeNodeParamTagsResponse.DescribeNodeParamTags_Data> describeNodeParamTagsResponse_paramReferredPaths = new List<DescribeNodeParamTagsResponse.DescribeNodeParamTags_Data>();
			for (int i = 0; i < _ctx.Length("DescribeNodeParamTags.ParamReferredPaths.Length"); i++) {
				DescribeNodeParamTagsResponse.DescribeNodeParamTags_Data data = new DescribeNodeParamTagsResponse.DescribeNodeParamTags_Data();
				data.ParamName = _ctx.StringValue("DescribeNodeParamTags.ParamReferredPaths["+ i +"].ParamName");

				List<string> data_referredPath = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNodeParamTags.ParamReferredPaths["+ i +"].ReferredPath.Length"); j++) {
					data_referredPath.Add(_ctx.StringValue("DescribeNodeParamTags.ParamReferredPaths["+ i +"].ReferredPath["+ j +"]"));
				}
				data.ReferredPath = data_referredPath;

				describeNodeParamTagsResponse_paramReferredPaths.Add(data);
			}
			describeNodeParamTagsResponse.ParamReferredPaths = describeNodeParamTagsResponse_paramReferredPaths;
        
			return describeNodeParamTagsResponse;
        }
    }
}
